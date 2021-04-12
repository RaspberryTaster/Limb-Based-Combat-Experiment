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
	public enum Defence_Value
	{
		WEAKNESS = 0, STANDARD = 1, RESISTANCE = 2, IMMMUNE = 3 
	}

	public interface IDefence
	{
		Defence_Value Defence_Value { get;}
		bool Is_Valid(IDamage damage);
		int Defence(IDamage Damage_Type, Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier);
	}
}
