package lb_2;

import java.util.Scanner;

public class StartRobot extends Robot {
	
	public String Start()
    {
		Scanner in = new Scanner(System.in);
		System.out.print("Enter the password:");
        String enterPassword = in.nextLine();;
        return enterPassword.equals(password) ? "Robot launched" : "Wrong password";
    }

}
