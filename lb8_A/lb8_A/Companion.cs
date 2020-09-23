using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
    class Companion: Character
    {
		private double distance;
		public Companion(String name, int health)
			:base(name, health)
		{
			distance = 10;
		}
	public override void GetInfo()
		{
			if (distance >= 10) Console.Write($"\n{name} accompanies the character \n");
		else if (distance >= 10) Console.Write($"\n{name}  does not accompany the character \n");

		}
	}
}
