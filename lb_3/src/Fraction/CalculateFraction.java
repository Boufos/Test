package Fraction;

public class CalculateFraction {
		
	private int dividend;
	private int divider;
	
	public CalculateFraction(int dividend, int divider)
	{
		this.dividend = dividend;
		this.divider = divider;
	}
	
	public void GetFraction ()
	{
		System.out.printf("Your answer: %f",(double)dividend/divider);
	}
	
}
