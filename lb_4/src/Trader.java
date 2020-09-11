
public class Trader extends NPC 
{
	
	public Trader(String name, int health){
		super (name, health);
		activity = "Trader";
		lvlFriendly = 100;
		System.out.printf("\nTrader speak:"+Speak("Trader")+"\n");
	}
	
	@Override
	public void GetInfo()
	{
		if (lvlFriendly>80) System.out.printf("%s speak: Hi i'm %s. Would you like to see my products?\n", activity, name);
		else System.out.printf("%s speak: Hi i'm %s.", activity, name);
	}
}
