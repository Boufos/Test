using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
    class Watcher: Enemy
    {
		public Watcher(String name, int health)
			:base(name, health)
		{
			SeeCharacter();
		}

	public override void GetInfo()
		{
			Console.Write($"\n{name} reports on the approach of the character to all enemies\n");
		}
	}
}
