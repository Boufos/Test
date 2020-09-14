package lb_7;
import java.util.*;

public class Program {
	
	public static void main (String[] args)
	{
		Scanner in = new Scanner(System.in);
		System.out.print("Enter how many brigades to add:\n");
		workingWithVector work = new workingWithVector();
		Vector<String> builders= new Vector<String>();
		builders=work.Add(in.nextInt());
	    work.GetVector(builders);
	    work.removeVector(builders);
	    work.GetVector(builders);
	    work.Search(builders);
	}

}
