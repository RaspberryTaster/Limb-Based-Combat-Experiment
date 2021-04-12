using Assets.Attacks;
using Assets.Stats;

namespace Assets.Body_Parts
{
	public class Body_Combat
	{
		public Endurance Endurance;
		public Barrier Barrier;
		public Body_Combat(int endurance, int barrier)
		{
			Endurance = new Endurance(endurance);
			Barrier = new Barrier(barrier);
		}

		public Body_Combat(Endurance endurance, Barrier barrier)
		{
			Endurance = endurance;
			Barrier = barrier;
		}

		public void On_Evade(Damaging_Attack damaging_Attack)
		{
			Damage(damaging_Attack.Value);
		}
		public void On_Hit(Body_Part body_Part, Damaging_Attack damaging_Attack)
		{
			int value = Defence(damaging_Attack, body_Part);
			if (value > 0)
			{
				Damage(value);
			}
		}

		public int Defence(Damaging_Attack damaging_Attack, Body_Part body_Part)
		{
			return body_Part.Body_Part_Combat.Damage(damaging_Attack);
		}

		public void Add_Barrier(int value)
		{
			Barrier.Increase_Value(value);
		}

		public void Heal(int value)
		{
			Endurance.Increase_Value(value);
		}
		public void Damage(int damage)
		{
			Endurance.Decrease_Value(damage);
		}

		public int Barrier_Mitigation(int damage, int extraBarrierDamage)
		{
			int barrier_Value = Barrier.Value;
			if (barrier_Value == 0) return damage;
			int post_Barrier_Damage;

			damage += extraBarrierDamage;

			if (damage > barrier_Value)
			{
				Barrier.Decrease_Value(damage);
				post_Barrier_Damage = Barrier.tracker.Get_Stat_Changes().Decrease_Value_Recent - barrier_Value;
			}
			else
			{

				Barrier.Decrease_Value(damage);
				post_Barrier_Damage = 0;
			}


			return post_Barrier_Damage;
		}
	}
}
