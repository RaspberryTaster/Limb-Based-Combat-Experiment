using Assets.Damage_Types;

namespace Assets.Attacks
{
	public class Damaging_Attack
	{
		public int Value;
		public IDamage[] damage_Types;

		public Damaging_Attack(int value, IDamage[] damage_Types)
		{
			Value = value;
			this.damage_Types = damage_Types;
		}

		public void Attack(Body_Part body_Part)
		{
			body_Part.Body_Part_Combat.Damage(this);
		}
	}
}
