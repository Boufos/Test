package lb_1;
import java.util.Scanner;

public class lb_1Static {

	 public static void main(String[] args)
     {
         System.out.print("Enter the length of the array:\n ");
         Scanner in = new Scanner(System.in);
         double[] array = new double[in.nextInt()];

         SumCubeStatic.sumCube(array);
         
         System.out.print("\nEnter the length of the array: ");
         double[] array1 = new double[in.nextInt()];
         SumCubeNoStatic sumarray = new SumCubeNoStatic();
         sumarray.sumCube(array1);
     }

 }


