
public class NPC extends Character
{
	protected int lvlFriendly;
	protected String activity;
	
	public NPC(String name, int health){
		super (name, health);
	}
	
	protected String Speak(String activityNPC)
	{
		return activityNPC=="Inhabitant" ? "Hi. Do you want to speak?" : "Hi. Do you want to trade?";
	}

}
