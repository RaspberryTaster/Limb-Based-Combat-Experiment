using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Stats
{
	public struct Stat_Changes
	{
		public int Increased_Value_Total;
		public int Decrease_Value_Total;

		public int Increased_Value_Recent;
		public int Decrease_Value_Recent;

		public int Value_Change_Total;
		public int Value_Change_Recent;
		public Stat_Changes(int increased_Value_Total, int decrease_Value_Total, int increased_Value_Recent, int decrease_Value_Recent, int value_Change_Total, int value_Change_Recent)
		{
			Increased_Value_Total = increased_Value_Total;
			Decrease_Value_Total = decrease_Value_Total;
			Increased_Value_Recent = increased_Value_Recent;
			Decrease_Value_Recent = decrease_Value_Recent;
			Value_Change_Total = value_Change_Total;
			Value_Change_Recent = value_Change_Recent;
		}
	}
}
