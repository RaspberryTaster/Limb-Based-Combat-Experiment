using Assets.Attacks;
using Assets.Body_Parts;
using Assets.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Damage_Types
{
	public class Slash_Defence : IDefence
	{
		private Defence_Value defence_Value;

		public Slash_Defence(Defence_Value defence_Value)
		{
			this.defence_Value = defence_Value;
		}

		public Defence_Value Defence_Value { get => defence_Value;}

		public bool Is_Valid(IDamage damage)
		{
			return damage is Slash_Damage;
		}

		public int Defence(IDamage Damage_Type,Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			int value;
			if (Defence_Value == Defence_Value.STANDARD)
			{
				value = Damage_Type.Standard(damaging_Attack, body_Part_Combat, barrier);
			}
			else if (Defence_Value == Defence_Value.WEAKNESS)
			{
				value = Damage_Type.Weakness(damaging_Attack, body_Part_Combat, barrier);
			}
			else if (Defence_Value == Defence_Value.RESISTANCE)
			{
				value = Damage_Type.Resistance(damaging_Attack, body_Part_Combat, barrier);
			}
			else
			{
				value = Damage_Type.Immmunity();
			}

			return value;
		}
	}
}
