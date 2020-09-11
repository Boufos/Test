
public class TerraEnemy extends Enemy
{
	public TerraEnemy(String name, int health){
		super (name, health);
		damage = 20;
		SeeCharacter();
	}
	
	@Override
	public void GetInfo()
	{
		System.out.printf("\n%s attacks the character for %d health\n" ,name, damage);
	}

}