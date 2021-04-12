using Assets.Attacks;
using Assets.Body_Parts;
using Assets.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Damage_Types
{
	public class Pierce_Damage : IDamage
	{
		int flat_Armor_Penetration;
		int extra_Armor_Damage;
		int minimum_Damage;
		int barrier_Damage;

		public int Immmunity()
		{
			Debug.Log("Pierce Immune");
			return 0;
		}

		public int Resistance(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			int damage = damaging_Attack.Value / 2;

			damage = body_Part_Combat.Armor_Mitigaton(body_Part_Combat.Body_Part.Armor.Value, damage, flat_Armor_Penetration, extra_Armor_Damage, minimum_Damage);
			damage = body_Part_Combat.Barrier_Mitigation(barrier, damage, barrier_Damage);

			return damage;
		}

		public int Standard(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			int damage = damaging_Attack.Value;

			damage = body_Part_Combat.Armor_Mitigaton(body_Part_Combat.Body_Part.Armor.Value, damage, flat_Armor_Penetration, extra_Armor_Damage, minimum_Damage);
			damage = body_Part_Combat.Barrier_Mitigation(barrier, damage, barrier_Damage);

			return damage;
		}

		public int Weakness(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier)
		{
			int damage = damaging_Attack.Value * 2;

			damage = body_Part_Combat.Armor_Mitigaton(body_Part_Combat.Body_Part.Armor.Value, damage, flat_Armor_Penetration, extra_Armor_Damage, minimum_Damage);
			damage = body_Part_Combat.Barrier_Mitigation(barrier, damage, barrier_Damage);

			return damage;
		}
	}
}
