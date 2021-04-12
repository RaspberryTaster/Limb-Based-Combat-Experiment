using Kryz.CharacterStats;
using UnityEngine;

namespace Assets.Stats
{
	public abstract class Raspberry_Stat
	{
		public Stat_Tracker tracker = new Stat_Tracker();

		protected CharacterStat _value;
		public int Value
		{
			get
			{
				return _value == null ? 0 : (int)_value.Value;
			}
		}
		public int Min_Value = 0;
		public int Max_Value = int.MaxValue;

		public virtual void Initalize(int attribute)
		{
			tracker.Reset_All();
			_value = new CharacterStat(attribute);
		}
		public virtual void Decrease_Value(int amount)
		{
			int negative_Amount = amount * -1;
			int potential = Value + negative_Amount;
			if(potential < Min_Value)
			{
				//9 - 4 = 5;
				amount = Mathf.Abs(Value - Min_Value);
			}
			if (amount == 0) return;
			negative_Amount = amount * -1;
			if(negative_Amount > 1)
			{
				Increase_Value(negative_Amount);
			}

			_value.AddModifier(new StatModifier(negative_Amount, StatModType.Flat, this));
			tracker.Decrease(Mathf.Abs(negative_Amount));
		}
		public virtual void Increase_Value(int amount)
		{
			int potential = Value + amount;
			if(potential > Max_Value)
			{
				//6
				//10 > 8
				amount = Mathf.Abs(Value - Max_Value);
			}
			if (amount == 0) return;

			_value.AddModifier(new StatModifier(amount, StatModType.Flat, this));
			tracker.Increase(Mathf.Abs(amount));
		}

		public int Get_Value()
		{
			return Value;
		}
	}
}
