package lb_7;

import java.util.Enumeration;
import java.util.Scanner;
import java.util.Vector;

public class workingWithVector {
	
	public Vector<String>  Add(int numbers)
	{
		Vector<String>  builders = new Vector<String> ();
		for(int i =0; i<numbers;i++)
		{
			Builders build = new Builders();
			builders.add(build.GetnameBuilding());
		}
		return builders; 
	}
	public void removeVector (Vector<String> vector)
	{
		System.out.printf("Which of the %s brigades do you want to remove? \n",vector.size());
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		String rem_ele = vector.remove(n-1);
	}
	public void GetVector (Vector<String> builders)
	{
		Enumeration<String> enm = builders.elements();
		int i=1;
	    while(enm.hasMoreElements()){
	      System.out.printf("%s team works at a construction site: \n",i);
	      System.out.println(enm.nextElement());
	      i++;
	    }
	}
	    
	    public void Search (Vector<String> builders)
		{
	    	Scanner in = new Scanner(System.in);
		      System.out.printf("Which brigade do you want to find?\n"
		      		+ " (Search is carried out by the brigade number) \n");
		      int n = in.nextInt();
		      System.out.println(builders.get(n-1));
		    }
	

}
