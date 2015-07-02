using UnityEngine;
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class UnitBuilder : MonoBehaviour {
	public int startingClanCount = 10;
	public static string[] names = {"Acornsquash","Adobo","Airfreshener","Ale","Allspice","Almondbutter","Amaretto","Applesauce","Appletree","Apricot","Aquavit","Artichoke","Arugula","Asparagus","Avocado","Bag","Bagel","Baguette","Bakingsoda","Ball","Balloon","Balsamic","Banana","Barbecue","Barley","Basil","Bathmat","Bathtub","Bayleaf","Bed","Beet","Belt","Bike","Blackberry","Blackolive","Blanket","Blender","Blind","Blouse","Blueberry","Boat","Bokchoy","Book","Bookmark","Boombox","Bottle","Bottlecap","Bouillon","Bourbon","Bow","Bowl","Box","Bracelet","Brandy","Bread","Breadcrumb","Breadfruit","Broccoliraab","Brocolli","Bruschetta","Brush","Brusselssprout","Bucket","Buckwheat","Bus","Button","Cabbage","Cactus","Calendar","Camera","Candle","Candywrapper","Canolaoil","Cantaloupe","Canvas","Cape","Car","Cardboard","Carpet","Carrot","Case","Cat","Cauliflower","Ceiling","Celery","Cellphone","Cerealbowl","Chai","Chainlinkfence","Chair","Chalk","Chambord","Champagne","Chapterbook","Chard","Charger","Checkbook","Cherry","Chestnut","Chickpea","Chicory","Chilisauce","Chipotle","Chive","Chocolate","Chutney","Cider","Ciggarette","Cilantro","Cinderblock","Cinnamon","Clamp","Claypot","Clock","Clothing","Cloud","Clove","Coaster","Coathanger","Coconutoil","Coffee","Comb","Compactdisc","Computer","Conditioner","Controller","Cookie","Cookiejar","Coriander","Cork","Corncob","Cornstarch","Cornsyrup","Cotton","Couch","Couscous","Cranberry","Crayon","Creamoftartar","Creditcard","Crochethook","Crouton","Cucumber","Cumin","Cup","Currypaste","Date","Deck","Dentalfloss","Deodorant","Desk","Dill","Dinnerplate","Disc","Doghouse","Doll","Door","Doorframe","Drawer","Dress","Drillpress","Drum","Dumpling","Duster","Eggplant","Envelope","Eraser","Eyeglasses","Eyeliner","Facewash","Fan","Fennel","Fig","Flag","Floor","Flour","Flower","Folder","Food","Fork","Fountain","Fridge","Gardenhose","Garlic","Gasoline","Ginger","Gingerale","Glass","Glasses","Glowstick","Gojiberry","Grahamcracker","Granola","Grape","Greetingcard","Gridpaper","Grits","Guava","Guitar","Gum","Hairbrush","Hairnet","Hairtie","Hanger","Hashbrown","Hat","Hazelnut","Headphone","Hearth","Helmet","Honeydew","Horseradish","House","Huckleberry","Ice","Icecubetray","Induction","Jar","Jellybean","Jewelry","Jicama","Kale","Ketchup","Key","Keyboard","Keychain","Kiwi","Knife","Kumquat","Lace","Ladder","Lager","Lamp","Lampshade","Laundry","Leaf","Leeks","Legwarmer","Lemon","Lemongrass","Lemonjuice","Lemonpeel","Lentil","Letter","Lettuce","Light","Lightbulb","Lighter","Lime","Linen","Lipgloss","Lock","Lollypop","Lotion","Magnet","Mailbox","Mantle","Maplesyrup","Marble","Margarine","Marmalade","Mesclungreen","Mint","Mirror","Mobilephone","Modelcar","Molasses","Money","Monitor","Mop","Mousepad","Mushroom","Mustard","Mustardseed","Nailclipper","Nailfile","Necklace","Nectarine","Needle","Newspaper","Notebook","Notepad","Oatmeal","Okra","Oliveoil","Onion","Orange","Oregano","Outlet","Oven","Packingpeanut","Paintbrush","Painting","Pan","Pants","Papaya","Paper","Paperclip","Paprika","Parsley","Parsnip","Passionfruit","Pasta","Patio","Peach","Peanut","Peanutbutter","Pear","Pecan","Pen","Pencil","Pepper","Perfume","Pesto","Phenylalanine","Phone","Photoalbum","Piano","Pickle","Picodegallo","Picture","Pictureframe","Pillow","Pin","Pineapple","Pintobean","Pistachio","Plane","Plantain","Plaque","Plasticbag","Plasticfork","Plasticware","Plate","Playingcard","Plum","Pneumonia","Pomegranate","Pool","Poolstick","Poppyseed","Popsicle","Portabello","Potatochip","Pots","Printer","Prune","Puddle","Pumpkin","Purse","Radio","Radish","Railing","Raisin","Raspberry","Redcabbage","Refrigerator","Remote","Remotecontrol","Remoulade","Rhubarb","Rice","Ricepaper","Ricewine","Ring","Roadsign","Rock","Romaine","Rosemary","Rosewater","Rubberband","Rubberduck","Rug","Rum","Rustynail","Sage","Sailboat","Salsa","Salt","Sandal","Sandpaper","Saucer","Sauerkraut","Scissors","Scotchtape","Screw","Seatbelt","Shallot","Shampoo","Sharpie","Shawl","Shelf","Sherry","Shirt","Shoe","Shoelace","Shovel","Showercurtain","Sidewalk","Silverware","Sketchpad","Slipper","Soap","Sock","Sodacan","Sofa","Sorbitol","Soybean","Soymilk","Soysauce","Speaker","Spearmint","Spinach","Sponge","Spoon","Spring","Squash","Stapler","Stereo","Stick","Stickynote","Stocking","Stopsign","Stove","Strawberry","Streetlight","String","Succotash","Sugar","Sundial","Sunflower","Sunglasses","Sunscreen","Sushi","Sweetpepper","Sweetpotato","Tabasco","Table","Tarragon","Tea","Telephone","Television","Thermometer","Thermostat","Thread","Thyme","Tile","Tireswing","Tissuebox","Titration","Toaster","Toenail","Toering","Tofu","Toilet","Tomato","Tonicwater","Toothbrush","Toothpaste","Toothpick","Tortilla","Towel","Train","Tree","Treehouse","Truck","Truffle","Turnip","Tweezers","Twister","Vacuum","Vanilla","Vase","Vermouth","Videogame","Vinegar","Wagon","Wallet","Wallpaper","Walnut","Wasabi","Washingmachine","Watch","Water","Waterbottle","Waterchestnut","Watermelon","Whitebean","Whiteout","Wildrice","Window","Windowframe","Wine","Wire","Wonton","Wristband","Yarn","Zest","Zinfandel","Zipper"};
	public static string[] clans = {"Acts of the Demonic","Affliction of the Right","Angelic Shadow","Angels of the Land","Anguish of Heroes","Anguish of Promises","Aqua Hawks","Aqua Wolves","Aquadeath","Arcane Sacrament","Army of the Corrupted","Army of the Shield","Aspiring Chaos","Atonement of the Serene","Attack of Disease","Avengers of the Vigorous","Bandits of the Heroic","Bannershapers","Battleblades","Bellowdawn","Blackhammers","Blessing of the Shadows","Blood of the Vulture","Blood Rage","Blue Assailant","Boon of the Mighty","Bouldercrawlers","Boulderguard","Brave Knights","Brightblades","Burningwell","Civilians of the Loyal","Civilians of the World","Companions of the Putrid","Concealed Executors","Contract of Desire","Contract of the Infernal","Corruption of the Sick","Crushers of the Joyous","Cry of the Stag","Cunninglaws","Curse of the Extinct","Cutlass Champions","Damnation of Faith","Dashing Rats","Defiant Ancients","Delicate Genesis","Demolition Vikings","Departed End","Desire of the Fearless","Dishonest Nightmare","Dishonest Veterans","Dispensable Supremacy","Doomlaws","Emerald Apocalypse","Enemies of the Sincere","Eternal Assault","Eternal Paradox","Ethereal Assassins","Fallencrawlers","Fallensmiths","Famous Gang","Fellight","Feltalons","Fight of the Crow","Fighters of the Deluded","Fighters of the Sacred","Firetips","Flames of the Obscene","Forgesong","Forsaken Supremacy","Forsakenmanes","Funny Vultures","Furious Predators","Golden Intent","Goldendeath","Grace of the Universe","Gray Oath","Grieve of the Talon","Grim Gunslingers","Grim Illusions","Guards of the Jaguar","Hallowbeards","Hammers of Loyalty","Harmonious Plague","Harvesters of the Owl","Hell Rats","Hellcrushers","Hellflayers","Hellforce","Hellshields","Honest Death","Host of the Valiant","Humble Assassins","Humble Squad","Hummingswords","Hummingwell","Ill Hooligans","Ill Shadows","Immoral Vigorous","Independent Dynasty","Infernal Maggots","Ironcrawlers","Ivoryhammers","Jumpy Butchers","Large Vitality","Last of the Sacred","Legion of the Bear","Lightningbane","Magicbrawlers","Magicscars","Memories of Forests","Messengers of the Deserted","Metalfists","Misery of the Raven","Misery of the Sophisticated","Misery of the Woods","Monsters of the Seduced","Mystery of the Living","Mystical Punished","Nameless Warfare","Nefarious Assault","Nefarious Vengeance","Nightstriders","Oath of the Mysterious","Omega Ashes","Omega Vikings","Order of the Boar","Outlaws of the Dove","Pain of the Fallen","Passion of the Devoted","Patience of the Fierce","Peace of Fury","Perished Gunslingers","Poison Dragons","Poison Oath","Power Harvesters","Profane Punished","Punishment of Devotion","Punishment of the Cheeky","Pursuit of the Discarded","Rainshapers","Rangers of the Jungle","Ravendawn","Raventalons","Rebels of the Tame","Redguard","Refugees of the Ram","Relics of the Cougar","Retribution of the Crow","Revenant Primeval","Riddles of the Ended","Rise of the Talon","Roaring Enemy","Roaring Privilege","Robust Fall","Robust Shadow","Rogue Domination","Rumours of the Spider","Sacrifice of Shadows","Scouts of the Discarded","Screech of Darkness","Searing Harvesters","Sedated Supremacy","Shades of the Valiant","Shame of the Moon","Sightless Vanguards","Silence of the Boar","Society of Serenity","Society of the Hawk","Solarscars","Solarwell","Steelcrawlers","Stewards from the People","Stewards of the Lost Age","Stoneflags","Stonehammers","Storm of the Stars","Swiftflayers","Tasty Titans","Thundercrawlers","Tradition of Forests","Tremblestriders","Twin Eagles","Unknown Veterans","Valiant Rebels","Vanquished Gangsters","Vendetta from the Woods","Venom of Fury","Weak Vengeance","White Hawks","Whiteflags","Whitesong","Widows of the Strong","Wind Lust","Windcloaks","Workers of Virtue","Wraiths of the Vigorous","Wrecking Hawks","Wrong Veterans"};

	// Create a role object rather than using a string. Abilities will go there.
	public static List<string> roles = new List<string>() {"Valiant Palisade","Dawn Ritualist","Zephyr Minstrel","Ruin Bringer","Crescent Stalker"};

	public static List<int> openIDs = new List<int>();
	public static List<int> openClans = new List<int>();

	void Start(){
		openIDs = Enumerable.Range(0,names.Length).OrderBy(x => UnityEngine.Random.value).ToList();
		openClans = Enumerable.Range(0,clans.Length).OrderBy(x => UnityEngine.Random.value).ToList();
		for(int i=0; i<startingClanCount; i++){
			RelationsTracker.activeClans.Add(new Clan(clans[popClan()]));
		}

		transform.gameObject.GetComponent<RelationsTracker>().initialize();
	}

	void Update(){
	}

	static int popID(){
		int ret = openIDs.ElementAt(openIDs.Count-1);
		openIDs.RemoveAt(openIDs.Count-1);
		return ret;
	}

	static int popClan(){
		int ret = openClans.ElementAt(openClans.Count-1);
		openClans.RemoveAt(openClans.Count-1);
		return ret;
	}

	public static Dood getDoodByRandom(Clan clan = null){
		return new Dood(popID (), clan);
	}

	public static Dood getDoodByRole(int role, Clan clan = null){
		int id, i=openIDs.Count-1;
		do{
			id = openIDs[i--];
		} while(id%roles.Count != role);
		openIDs.RemoveAt(i+1);
		return new Dood(id, clan);
	}
}

public class Clan{
	public string name;
	public int score = 0;
	public int avgScore = 0;
	public int[] roleCount = new int[UnitBuilder.roles.Count];
	public List<Dood> roster = new List<Dood>();
	
	public Clan(string name){
		this.name = name;
		for(int i=0; i<5; i++){
			Dood dood = UnitBuilder.getDoodByRole(i, this);
			roster.Add(dood);
			score+=dood.equipLevel;
			roleCount[i]++;
		}
		for(int i=UnityEngine.Random.Range (2,4); i>0; i--){
			Dood dood = UnitBuilder.getDoodByRandom(this);
			roster.Add(dood);
			score+=dood.equipLevel;
			roleCount[UnitBuilder.roles.IndexOf(dood.role)]++;
		}
		avgScore = score / roster.Count;
		outputDebug();
	}

	public void outputDebug(){
		Debug.Log (name+"("+roster.Count+") Score: "+score+" Avg: "+avgScore);
	}
	
	private void recalcStats(){
		Array.Clear(roleCount, 0, roleCount.Length);
		score = 0;
		foreach (Dood dood in roster){
			score+=dood.equipLevel;
			roleCount[UnitBuilder.roles.IndexOf(dood.role)]++;	
		}
		avgScore = score / roster.Count;
	}

	public void rosterRemove(Dood dood){
		roster.Remove (dood);
		if(roster.Count == 0){
			Debug.Log (name+" has disbanded!");
			RelationsTracker.activeClans.Remove(this);
		} else {
			recalcStats();
		}
	}

	public void rosterAdd(Dood dood){
		roster.Add (dood);
		recalcStats();
	}

	public bool Recruit(Dood dood){
		// Calculate need for role [0, 1]
		float need = (roster.Count - roleCount[UnitBuilder.roles.IndexOf(dood.role)]) / roster.Count;
		// Prioritize tanks/healers
		if(	(need >= 0.2f && dood.role == UnitBuilder.roles[0]) ||
		   (need >= 0.1f && dood.role == UnitBuilder.roles[1]))
		{
			need *= 3f;
		}
		// Compare equipLevel [0, inf)
		float gearcheck = (1f * dood.equipLevel) / avgScore;
		// Check for endorsements [0, 1]
		float endorsement = 0f;
		int numFriends = 0;
		foreach (Dood clannie in roster){
			if(clannie.friendship.ContainsKey(dood)){
				endorsement += clannie.friendship[dood];
				numFriends++;
			}
		}
		// Decision
		return 1f < ((need * gearcheck) + (2f * endorsement / numFriends));
	}
}

public class Dood{
	public Clan clan;
	public int id, equipLevel, personality, gender;
	public string role, name;
	public float happy, smart, brave;
	public Dictionary<Dood, float> friendship = new Dictionary<Dood, float>();

	public Dood(int id, Clan clan){
		this.id = id;
		this.clan = clan;
		equipLevel = (id%10)+11;
		personality = ((id%10)%5)%4; // 0 is normal, 1 is stoic, 2 is aggro, 3 is cutesy
		gender = (id%3)%2; // 0 is male, 1 is female
		role = UnitBuilder.roles[id%UnitBuilder.roles.Count];
		name = UnitBuilder.names[id%UnitBuilder.names.Length];
		happy = (id%17)/17f;
		smart = (id%19)/19f;
		brave = (id%23)/23f;

		RelationsTracker.activeDoods.Add (this);
		//outputDebug();
	}

	public void setFriendship(Dood other, float score){
		if(score <= 0f) return; if(score > 1f) score = 1f;
		if(friendship.ContainsKey(other)){
			friendship[other] = score;
		} else {
			friendship.Add (other, score);
		}
	}

	public bool isClannie(Dood other){
		return clan == other.clan;
	}

	public void swapClans(Clan newClan){
		// Update both clan rosters
		clan.rosterRemove(this);
		newClan.rosterAdd(this);
		// Do a notification.
		Debug.Log (name+"("+role+") has left "+clan.name+" for "+newClan.name+".");
		// Update own clan
		clan = newClan;
		// Be happy about it!
		happy += 0.3f;
		if(happy > 1f) happy = 1f;
	}

	public void outputDebug(){
		Debug.Log (name+"-"+role+"("+equipLevel+")");
	}
}
