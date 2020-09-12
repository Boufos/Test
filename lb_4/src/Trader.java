
public class Trader extends NPC implements ISpeak
{
	
	public Trader(String name, int health){
		super (name, health);
		activity = "Trader";
		lvlFriendly = 100;
		
	}
	
	@Override
	public void GetInfo()
	{
		System.out.printf("%s speak: Hi i'm %s.", activity, name);
	}
	public void Speak()
	{
		String str = 
				
				"...___..\n" +
				".._| |_\n" +
				" §(•,• )§\n" +
				"../|_|\\\n" +
				".. ||| ..\n" +
				". _?.?_ .\n" ;
		System.out.printf("\n%s speak: Hi i'm %s. Would you like to see my products?\n", activity, name);
				System.out.print(str);
	}
}
