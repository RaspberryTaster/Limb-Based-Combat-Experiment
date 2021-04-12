using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Stats
{
	public class Stat_Tracker
	{
		private int Increased_Value_Total;
		private int Decrease_Value_Total;

		private int Increased_Value_Recent;
		private int Decrease_Value_Recent;

		private int Value_Change_Total;
		private int Value_Change_Recent;
		public void Reset_All()
		{
			Increased_Value_Total = 0;
			Decrease_Value_Total = 0;
			Value_Change_Total = 0;
			Reset_Recent();
		}

		private void Reset_Recent()
		{
			Value_Change_Recent = 0;
			Increased_Value_Recent = 0;
			Decrease_Value_Recent = 0;
		}

		public void Increase(int amount)
		{
			Value_Change_Total += amount;
			Increased_Value_Total += amount;
			Increased_Value_Recent = amount;
			Value_Change_Recent = amount;
		}

		public void Decrease(int amount)
		{
			Value_Change_Total += amount;
			Decrease_Value_Recent = amount;
			Decrease_Value_Total += amount;
			Value_Change_Recent = amount;
		}

		public Stat_Changes Get_Stat_Changes()
		{
			return new Stat_Changes(Increased_Value_Total, Decrease_Value_Total, Increased_Value_Recent, Decrease_Value_Recent, Value_Change_Total, Value_Change_Recent);
		}
	}
}
