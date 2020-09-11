
public class Character {

	protected String name;
	protected String activities;
	protected int health;
	
	public Character(String name, int health)
	{
		this.name = name;
		this.health = health;
		this.activities = "has been created";
	}
	
	public void GetInfo()
	{
		System.out.printf("%s %s, his health is %d \n", name, activities, health );
	}
}
