using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class RelationsTracker : MonoBehaviour {
	
	public static List<Clan> activeClans = new List<Clan>();
	public static List<Dood> activeDoods = new List<Dood>();

	private float counter;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(counter > 3f){
			wandering();
			// TODO: Add clan recruitment if they're short on a role.
			if(activeClans.Count < activeDoods.Count / 10f){
				forkLargestClan();
				outputClanSummary();
			}
		} else {
			counter += Time.deltaTime;
		}
	}

	public void initialize(){
		foreach (Dood a in activeDoods){
			foreach (Dood b in activeDoods){
				if(a!=b){
					float weight = (Random.value);
					if(!a.isClannie(b)){ weight*=0.75f; } // Fix to make less friends overall. Better friends with their own team. Remove to return to socialite behavior.
					if(weight < 0.50f){ weight = 0f; continue; }
					else if(weight > 0.9f){ weight = 0.9f; b.setFriendship(a,weight); }
					if(weight > 0) a.setFriendship(b,weight);
				}
			}
		}
	}

	private void wandering(){
		bool rosterChanged = false;
		foreach (Dood dood in activeDoods){
			// Stay put if sufficiently happy.
			if(dood.happy > 0.7f) continue;
			
			// Assess perception towards each clan.
			Dictionary<Clan, float> draw = new Dictionary<Clan, float> ();
			foreach (Clan clan in activeClans){ draw.Add(clan, 0f); }

			int[] friendsInClanCnt = new int[activeClans.Count];

			draw[dood.clan]+=dood.happy;
			friendsInClanCnt[activeClans.IndexOf(dood.clan)]++;

			foreach (Dood friend in dood.friendship.Keys){
				draw[friend.clan]+=(friend.happy*dood.friendship[friend]);
				friendsInClanCnt[activeClans.IndexOf(friend.clan)]++;
			}

			foreach (Clan clan in activeClans){
				draw[clan] /= friendsInClanCnt[activeClans.IndexOf(clan)]; // Make it an average draw.
				float gearLust = (1f * clan.avgScore) / dood.equipLevel;
				if(draw[clan] < 1f){
					draw[clan] = 1f * gearLust;
				} else {
					draw[clan] *= gearLust;
				}
			}		

			// Apply to more desirable clans.
			foreach(KeyValuePair<Clan, float> pair in draw.OrderByDescending(key => key.Value)){
				if(pair.Key == dood.clan) break; // Don't leave for anything beneath the current clan.
				if(pair.Key.Recruit(dood)){ // Apply to clan
					rosterChanged = true;
					dood.swapClans(pair.Key); // You're in! Time to gquit!
					break;
				} else {
					dood.modifyHappy (-0.1f);
					// TODO: They should probably grow more distant from the friends they can't join.
					// Loop and keep applying until accepted to a better clan.
					//Debug.Log (dood.name+"("+dood.role+") rejected by "+pair.Key.name);
				}
			}
		}
		if(rosterChanged){
			outputClanSummary();
		}
	}

	private void outputClanSummary(){
		foreach (Clan clan in activeClans){
			clan.outputDebug();
		}
		Debug.Log ("++++++++++++++++++");
	}

	// TODO: This new clan should probably become friends if they all left together...
	private void forkLargestClan(){
		Clan target = activeClans[0];
		foreach(Clan clan in activeClans){
			if(clan.roster.Count > target.roster.Count){
				target = clan;
			}
		}

		int numToLeave = target.roster.Count / 5;

		Dood[] leaving =   (from d in target.roster
		                  	orderby d.happy ascending
		                   	select d).Take(numToLeave).ToArray();
		UnitBuilder.createNewClan(leaving);

		foreach (Dood dood in target.roster){
			dood.modifyHappy(-0.1f); // They're sad about the split. :(
		}
	}

	public void debugWin(int position){
		if(position < activeClans.Count){
			foreach(Dood dood in activeClans[position].roster){
				if(UnityEngine.Random.value > 0.3f){
					// This is debug crap. Get rid of it later~!
					dood.Equip(new Lewt("test",30));
				} else {
					dood.modifyHappy (0.05f);
				}
			}
			activeClans[position].recalcStats();
		}

	}

	public void debugWipe(int position){
		if(position < activeClans.Count){
			foreach(Dood dood in activeClans[position].roster){
				dood.modifyHappy (-0.1f);
			}
			activeClans[position].recalcStats();
		}
	}
}
