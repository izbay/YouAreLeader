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
		if(counter > 5f){
			recruitment();
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

	private void recruitment(){
		bool rosterChanged = false;
		foreach (Dood dood in activeDoods){
			// Stay put if sufficiently happy.
			if(dood.happy > 0.5f) continue;
			
			// Assess perception towards each clan.
			Dictionary<Clan, float> draw = new Dictionary<Clan, float> ();
			foreach (Clan clan in activeClans){ draw.Add(clan, 0f); }
			
			draw[dood.clan]+=dood.happy;
			foreach (Dood friend in dood.friendship.Keys){
				draw[friend.clan]+=(friend.happy*dood.friendship[friend]);
			}
			
			// Apply to more desirable clans.
			foreach(KeyValuePair<Clan, float> pair in draw.OrderByDescending(key => key.Value)){
				if(pair.Key == dood.clan) break; // Don't leave for anything beneath the current clan.
				if(pair.Key.Recruit(dood)){ // Apply to clan
					rosterChanged = true;
					dood.swapClans(pair.Key); // You're in! Time to gquit!
					break;
				} else {
					dood.happy -= 0.01f;
					// Loop and keep applying until accepted to a better clan.
					Debug.Log (dood.name+"("+dood.role+") rejected by "+pair.Key.name);
				}
			}
		}
		if(rosterChanged){
			foreach (Clan clan in activeClans){
				clan.outputDebug();
			}
		}
	}

	public void debugWin(int position){
		if(position < activeClans.Count){
			foreach(Dood dood in activeClans[position].roster){
				if(UnityEngine.Random.value > 0.3f){
					dood.happy+= 0.2f;
				} else {
					dood.happy+= 0.05f;
				}
				if(dood.happy > 1f){ dood.happy = 1f; }
			}
		}
	}

	public void debugWipe(int position){
		if(position < activeClans.Count){
			foreach(Dood dood in activeClans[position].roster){
				dood.happy-= 0.1f;
				if(dood.happy < 0f){ dood.happy = 0f; }
			}
		}
	}
}
