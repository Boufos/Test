
public class Program {

	 public static void main(String[] args) {
	   
			Character character = new Character("Bill", 100);
			character.GetInfo();
			NPC inhabitant = new Inhabitant ("Emy",100);
			inhabitant.GetInfo();
			NPC trader = new Trader ("Sam", 100);
			trader.GetInfo();
			Enemy terraEnemy = new TerraEnemy("Rat",100);
			terraEnemy.GetInfo();
			Enemy watcher = new Watcher("Observe",100);
			watcher.GetInfo();
			�ompanion companion = new �ompanion("Fredi",100);
			companion.GetInfo();
	   }
}
