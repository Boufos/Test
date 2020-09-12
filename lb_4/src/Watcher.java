public class Watcher extends Enemy 
{
	public Watcher(String name, int health){
		super (name, health);
		SeeCharacter();
	}
	
	@Override
	public void GetInfo()
	{
		System.out.printf("\n%s reports on the approach of the character to all enemies\n" ,name);
	}

}