using UnityEngine;
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
		if(counter > 500f){
			recruitment();
		} else {
			counter += Time.deltaTime;
		}
	}

	public void initialize(int maxUnits){
		foreach (Dood a in activeDoods){
			foreach (Dood b in activeDoods){
				if(a==b){
					a.setFriendship(b, 1f);
				} else {
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
		//float[] draw = new float[UnitBuilder.activeTeams.Count];
	}
}
