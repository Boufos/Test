using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
    class Character
    {
		protected String name;
		protected String activities;
		protected int health;

		public Character(String name, int health)
		{
			this.name = name;
			this.health = health;
			this.activities = "has been created";
		}

		public virtual void GetInfo()
		{
			Console.Write($"{name} {activities}, his health is {health}\n");
		}
	}
}
