using Kryz.CharacterStats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Stats
{
	[Serializable]
	public class Barrier
	{
		public Barrier(CharacterStat barrier)
		{
			Initalize((int)barrier.Value);
		}
		public Barrier(int value)
		{
			Initalize(value);
		}

		public Stat_Tracker tracker = new Stat_Tracker();

		protected CharacterStat _value;
		public int Value
		{
			get
			{
				return _value == null ? 0 : (int)Mathf.Clamp((float)_value.Value, 0, int.MaxValue);
			}
		}


		public virtual void Initalize(int attribute)
		{
			tracker.Reset_All();
			_value = new CharacterStat(attribute);
		}
		public virtual int Decrease_Value(int amount)
		{
			int negative_Amount = amount * -1;
			_value.AddModifier(new StatModifier(negative_Amount, StatModType.Flat, this));
			tracker.Decrease(Mathf.Abs(negative_Amount));
			if(_value.Value < 0)
			{
				int value = Mathf.Abs(0 - (int)_value.Value);
				_value.AddModifier(new StatModifier(value, StatModType.Flat));
			}
			return Get_Value();
		}
		public virtual int Increase_Value(int amount)
		{
			_value.AddModifier(new StatModifier(amount, StatModType.Flat, this));
			tracker.Increase(Mathf.Abs(amount));
			return Get_Value();
		}

		public int Get_Value()
		{
			return Value;
		}
	}
}
