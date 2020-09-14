package lb_7;

import java.util.Scanner;

public class Builders {
	
	private String[] nameBuilding;
	
	public Builders()
	{
		Scanner in = new Scanner(System.in);

		System.out.print("Enter the name of the object or objects:\n");	
		nameBuildings(in.nextLine());
	}
	
	public void nameBuildings(String building)
	{
		nameBuilding=building.split("\\s");
	}
	public String GetnameBuilding()
	{
		String name = "";
		for(int i = 0; i < nameBuilding.length; i++) { 
	         name+=nameBuilding[i]+" ";
	      }
		return name; 
	}


}
