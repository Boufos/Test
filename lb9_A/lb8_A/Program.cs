﻿using System;
using System.Collections.Generic;

namespace lb9_A
{
    class Program
    {
        static void Main(string[] args)
        {
			Character character = new Character("Bill", 100);
			character.GetInfo();
			NPC inhabitant = new Inhabitant("Emy", 100);
			inhabitant.GetInfo();
			NPC trader = new Trader("Sam", 100);
			trader.GetInfo();
			Enemy terraEnemy = new TerraEnemy("Rat", 100);
			terraEnemy.GetInfo();
			Enemy watcher = new Watcher("Observe", 100);
			watcher.GetInfo();
			Companion companion = new Companion("Fredi", 100);
			companion.GetInfo();

			List<ISpeak> speak = new List<ISpeak>();
			speak.Add((ISpeak)terraEnemy);
			speak.Add((ISpeak)trader);
			speak.Add((ISpeak)inhabitant);

			for (int i = 0; i < speak.Count; i++)
			{
				speak[i].Speak();
			}

		}
    }
}
