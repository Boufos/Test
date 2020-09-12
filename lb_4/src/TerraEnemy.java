public class TerraEnemy extends Enemy implements ISpeak
{
	public TerraEnemy(String name, int health){
		super (name, health);
		damage = 20;
		SeeCharacter();
	}
	
	public void Speak()
	{
		String str = 
				
				"```````_`````````````_,-\"~^\"-.\"-.`\n" +
				"`````_//`)``````_,-\"~`````````````.\n" +
				"```.\"`(`/`\"-,-\"`````````````````````;\n" +
				"``/`6`````````````````````````````;\n"+
				"`/```````````,`````````````,-\"`````;\n" +
				"(,__.--.``````\\```````````/````````;\n" +
				"`//'```/`-.\\```|``````````|`````````.________\n" +
				"```_.-'_/```)``)--...,,,___\\`````\\––––––––––––––,)\n" +
				"`(((\"~``_.-'.-'```````````__`-.```)```````````//\n" +
				"```````(((\"``````````````(((---~\"```````````//\n" +
				"'````````````````````````````````````````((________________\n" +
				"``````````````````````````````````````````----\"\"\"\"~~~~^^^\n";
				System.out.printf("\n %s: *Aggressively hisses*\n\n",name);
				System.out.printf(str);
	}
	@Override
	public void GetInfo()
	{
		System.out.printf("\n%s attacks the character for %d health\n" ,name, damage);
	}

}