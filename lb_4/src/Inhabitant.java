
public class Inhabitant extends NPC implements ISpeak
{
	
	public Inhabitant(String name, int health){
		super (name, health);
		activity = "Inhabitant";
		lvlFriendly = 100;
		//System.out.printf("\nInhabitant speak:"+Speak("Inhabitant")+"\n");
	}
	
	@Override
	public void GetInfo()
	{
		if (lvlFriendly>80) System.out.printf("%s speak: Hi i'm %s. How are you?\n", activity, name);
		else System.out.printf("%s speak: Hi i'm %s.", activity, name);
	}
	public void Speak()
	{
		String str = 
				
				"...___...\n" +
				"..(•,•)...\n" +
				" .(|_|\\..\n" +
				".. ||| ..\n" +
				". _?.?_ .\n" ;
	
		System.out.printf("\n%s speak: Hi i'm %s. Do you want to speak with me?\n", activity, name);
				System.out.print(str);
	}
}
