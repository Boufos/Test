using System;
using System.Collections.Generic;
using System.Text;

namespace lb8_A
{
    class NPC: Character
    {
		protected int lvlFriendly;
		protected String activity;

		public NPC (string name, int health)
			: base(name, health)
		{
			
		}
	}
}
