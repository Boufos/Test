
public class Enemy extends Character
{
	protected int damage;
	public Enemy(String name, int health){
		super (name, health);
	}
	
	public void SeeCharacter()
	{
		System.out.print("\nThe enemy noticed character");
	}
	

}
