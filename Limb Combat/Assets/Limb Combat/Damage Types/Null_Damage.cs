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
	public class Null_Damage : IDamage
	{
		public int Immmunity()
		{
			return 0;
		}

		public int Resistance(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			return 0;
		}

		public int Standard(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			return 0;
		}

		public int Weakness(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			return 0;
		}
	}
}
