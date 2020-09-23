using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
    class Trader: NPC
    {
		public Trader(String name, int health)
			:base(name, health)
		{
			activity = "Trader";
			lvlFriendly = 100;
			Speak();
		}

		
	public override void GetInfo()
		{
			Console.WriteLine($" {activity} speak: Hi i'm {name}.");
		}
		public void Speak()
		{
			String str =

					"...___..\n" +
					".._| |_\n" +
					" §(•,• )§\n" +
					"../|_|\\\n" +
					".. ||| ..\n" +
					". _?.?_ .\n";
			Console.Write($"\n {activity} speak: Hi i'm {name}. Would you like to see my products?\n");
			Console.Write(str);
		}
	}
}
