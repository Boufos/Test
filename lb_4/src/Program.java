import java.util.Vector;

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
			Ñompanion companion = new Ñompanion("Fredi",100);
			companion.GetInfo();
			
			Vector<ISpeak> speak = new Vector<ISpeak>();
			speak.add((ISpeak) terraEnemy);
			speak.add((ISpeak) trader);
			speak.add((ISpeak) inhabitant);
			
			for (int i =0; i<speak.size();i++)
			{
				speak.get(i).Speak();
			}
	   }
}
