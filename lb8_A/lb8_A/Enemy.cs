using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
    class Enemy: Character
    {
		protected int damage;
		public Enemy(String name, int health)
			:base(name, health)
		{
			
		}

		public void SeeCharacter()
		{
			Console.Write("\nThe enemy noticed character");
		}
	}
}
