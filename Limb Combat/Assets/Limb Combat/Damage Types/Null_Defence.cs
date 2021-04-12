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
	public class Null_Defence : IDefence
	{
		public Defence_Value Defence_Value { get => Defence_Value.STANDARD; }

		public bool Is_Valid(IDamage damage)
		{
			return true;
		}

		public int Defence(IDamage Damage_Type,Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			return Damage_Type.Standard(damaging_Attack, body_Part_Combat, barrier);
		}
	}
}
