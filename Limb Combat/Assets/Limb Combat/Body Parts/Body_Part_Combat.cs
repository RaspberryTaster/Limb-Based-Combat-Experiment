using Assets.Attacks;
using Assets.Damage_Types;
using Assets.Stats;
using UnityEngine;

namespace Assets.Body_Parts
{
	public class Body_Part_Combat
	{
		public Body_Part Body_Part;

		public Body_Part_Combat(Body_Part body_Part)
		{
			Body_Part = body_Part;
		}

		public int Damage(Damaging_Attack damaging_Attack)
		{
			int value = Defence(damaging_Attack, Body_Part.Barrier);

			Damage(value);
			
			return value;
		}

		public void Damage(int damage)
		{
			if (damage > 0)
			{
				Body_Part.Health.Decrease_Value(damage);
			}
		}
		
		public int Defence(Damaging_Attack damaging_Attack, Barrier barrier)
		{
			IDefence Null_Defence =new Null_Defence();
			IDefence targeted_Defence = new Null_Defence();
			IDamage damage_Type = new Null_Damage();

			int Damage_Types = damaging_Attack.damage_Types.Length;
			for (int x = 0; x < Damage_Types; x++)
			{
				int count = Body_Part.Defences.Count;
				for (int i = 0; i < count; i++)
				{

					IDamage current_Damage = damaging_Attack.damage_Types[x];
					if (Body_Part.Defences[i].Is_Valid(current_Damage))
					{
						if(!Is_More_Vulnerable(targeted_Defence, Body_Part.Defences[i]))
						{
							targeted_Defence = Body_Part.Defences[i];
							damage_Type = current_Damage;
						}
					}
					else
					{
						if (!Is_More_Vulnerable(targeted_Defence, Null_Defence))
						{
							targeted_Defence = Null_Defence;
							damage_Type = current_Damage;

						}
					}
				}


			}
			
			//Debug.Log(targeted_Defence + " " + damage_Type);
			Debug.Log($"Targeted defence: {targeted_Defence}, targeted defence value: {targeted_Defence.Defence_Value}, Damage type: {damage_Type}");
			return targeted_Defence.Defence(damage_Type, damaging_Attack, this, barrier);
		}

		private bool Is_More_Vulnerable(IDefence one, IDefence two)
		{
			return ((int)one.Defence_Value < (int)two.Defence_Value);
		}
		public int Armor_Mitigaton(int armor_Value, int damage, int flat_Armor_Penetration, int extra_Armor_Damage, int minimum_Damage)
		{
			int post_Flat_Armor_Pen = armor_Value - flat_Armor_Penetration;
			if (armor_Value > 0)
			{
				damage += extra_Armor_Damage;
			}
			int Value = damage - post_Flat_Armor_Pen;
			return Mathf.Clamp(Value, minimum_Damage, int.MaxValue); ;
		}
		
		public int Barrier_Mitigation(Barrier barrier,int damage, int extraBarrierDamage)
		{
			int barrier_Value = barrier.Value;
			if (barrier_Value == 0) return damage;
			int post_Barrier_Damage;

			damage += extraBarrierDamage;

			if (damage > barrier_Value)
			{
				barrier.Decrease_Value(damage);
				post_Barrier_Damage = barrier.tracker.Get_Stat_Changes().Decrease_Value_Recent - barrier_Value;
			}
			else
			{

				barrier.Decrease_Value(damage);
				post_Barrier_Damage = 0;
			}


			return post_Barrier_Damage;
		}
	}
}
