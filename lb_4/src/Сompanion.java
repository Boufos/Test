
public class Ñompanion extends Character
{
	private double distance;
	public Ñompanion(String name, int health){
		super (name, health);
		distance=10;
	}
	@Override
	public void GetInfo()
	{
		if(distance>=10) System.out.printf("\n%s accompanies the character \n" ,name);
		else if(distance>=10) System.out.printf("\n%s  does not accompany the character \n" ,name);
		
	}
}
