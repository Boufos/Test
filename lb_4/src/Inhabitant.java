
public class Inhabitant extends NPC 
{
	
	public Inhabitant(String name, int health){
		super (name, health);
		activity = "Inhabitant";
		lvlFriendly = 100;
		System.out.printf("\nInhabitant speak:"+Speak("Inhabitant")+"\n");
	}
	
	@Override
	public void GetInfo()
	{
		if (lvlFriendly>80) System.out.printf("%s speak: Hi i'm %s. How are you?\n", activity, name);
		else System.out.printf("%s speak: Hi i'm %s.", activity, name);
	}
}
