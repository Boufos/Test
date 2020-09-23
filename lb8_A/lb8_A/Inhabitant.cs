using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
	class Inhabitant : NPC
	{
		public Inhabitant(String name, int health)
			: base(name, health)
		{
			activity = "Inhabitant";
			lvlFriendly = 100;
			Speak();
		}

		public override void GetInfo()
		{
			if (lvlFriendly > 80) Console.Write($" {activity} speak: Hi i'm {name}. How are you?\n");
			else Console.Write($"{activity} speak: Hi i'm {name}.");
		}
		public void Speak()
		{
			String str =

					"...___...\n" +
					"..(*,*)...\n" +
					" .(|_|\\..\n" +
					".. ||| ..\n" +
					". _?.?_ .\n";

			Console.Write($"\n {activity} speak: Hi i'm {name}. Do you want to speak with me?\n");
			Console.Write(str);
		}
	}
}
