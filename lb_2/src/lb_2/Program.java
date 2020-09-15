package lb_2;

import java.util.Scanner;

public class Program {

	public static void main(String[] args) {
	      
		Robot robot = new Robot("Model_1");	            
		StartRobot start = new StartRobot();	            
		System.out.println(start.Start());	            
		System.out.println("Enter the line to wrap: ");	
		Scanner in = new Scanner(System.in);
		String workStr = in.nextLine();	           
		System.out.println("Enter the number of characters to wrap: ");	            
		int number = in.nextInt();          
		WorkRobot work = new WorkRobot(workStr, number);	            
		work.workBegin();
	        
	}
		    
}



