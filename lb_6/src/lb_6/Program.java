package lb_6;

public class Program {
	
	 public static void main(String[] args) {
         
		 	Stock<String> acc1 = new Stock<String>("Sklad", "Moscow");
		 	acc1.getInfo();
		 	Stock<Integer> acc2 = new Stock<Integer>(12, "St. Petersburg");
		 	acc2.getInfo();
		 	Goods goods = new Goods(5);
		 	goods.<String>print(goods.getArray());
	         
	  }

}
