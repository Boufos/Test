package lb_1;

import java.util.Scanner;

public class SumCubeNoStatic {
	
	public void sumCube(double[] array)
    {
		Scanner in = new Scanner(System.in);
		for (int i=0;i<array.length;i++)
        {
       	 System.out.print("Enter array element: ");
            array[i] = in.nextInt();
        }
        array[0] = Math.pow(array[0], 3);
        for (int i = 1; i < array.length; i++)
        {
            array[i] = Math.pow(array[i], 3) + array[i - 1];
        }
        System.out.print("Cubic sum array:");

        for(int i=0;i<array.length;i++)
    {
       	 System.out.print(array[i]+" ");
    }
        
    }

}
