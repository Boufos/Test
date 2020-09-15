package lb_2;

public class Robot {

	 private String model;
     protected String password = "123";
     public Robot (String model)
     {
         this.model = model;
         System.out.printf("%s is ready to work\n",model);
     }
     public Robot()
     {

     }

}
