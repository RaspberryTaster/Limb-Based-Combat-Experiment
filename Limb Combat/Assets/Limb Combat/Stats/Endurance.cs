using Kryz.CharacterStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Stats
{
	public class Endurance : Raspberry_Stat
	{
		public Endurance(int value)
		{
			Max_Value = value;
			Initalize(Max_Value);
		}

		public void Set_Max(int value)
		{
			Max_Value = value;
		}
	}
}
