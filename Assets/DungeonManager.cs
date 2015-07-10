using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DungeonManager : MonoBehaviour {
	public static List<Invasion> invasions = new List<Invasion>();
}

public class Invasion {
	public List<Encounter> encounters = new List<Encounter>();
	public string name;
}

public class Encounter : Combatant{
	public List<Lewt> lewtTable = new List<Lewt>();
	public string name;
}

public class Lewt {
	public string name;
	public List<Role> roles = UnitBuilder.roles;
	public int level;

	public Lewt(string name, int level){
		this.name = name;
		this.level = level;
	}
}