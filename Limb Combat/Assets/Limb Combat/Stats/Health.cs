using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Stats
{
	[Serializable]
	public class Health : Raspberry_Stat
	{
		public Health(int value)
		{
			Max_Value = value;
			Initalize(Max_Value);
		}
	}
}
