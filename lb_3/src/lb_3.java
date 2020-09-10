import Fraction.CalculateFraction;
import java.util.Scanner;

public class lb_3 {
	
	public static void main (String[] args)
	{
		Scanner in = new Scanner(System.in);
		System.out.println("Enter the dividend: ");
		int dividend =in.nextInt();
		System.out.println("Enter the divider: ");
		int divider = in.nextInt();
		CalculateFraction fraction1 = new CalculateFraction(dividend, divider);
		fraction1.GetFraction();
	}  

}
