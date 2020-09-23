using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
    class TerraEnemy: Enemy
    {
		public TerraEnemy(String name, int health)
			:base(name, health)
		{
			damage = 20;
			SeeCharacter();
			Speak();
		}

		public void Speak()
		{
			String str =

					"```````_`````````````_,-\"~^\"-.\"-.`\n" +
					"`````_//`)``````_,-\"~`````````````.\n" +
					"```.\"`(`/`\"-,-\"`````````````````````;\n" +
					"``/`6`````````````````````````````;\n" +
					"`/```````````,`````````````,-\"`````;\n" +
					"(,__.--.``````\\```````````/````````;\n" +
					"`//'```/`-.\\```|``````````|`````````.________\n" +
					"```_.-'_/```)``)--...,,,___\\`````\\––––––––––––––,)\n" +
					"`(((\"~``_.-'.-'```````````__`-.```)```````````//\n" +
					"```````(((\"``````````````(((---~\"```````````//\n" +
					"'````````````````````````````````````````((________________\n" +
					"``````````````````````````````````````````----\"\"\"\"~~~~^^^\n";
			Console.Write($"\n {name}: *Aggressively hisses*\n\n");
			Console.Write(str);
		}
		
	public override void GetInfo()
		{
			Console.Write($"\n{name} attacks the character for {damage} health\n");
		}
	}
}
