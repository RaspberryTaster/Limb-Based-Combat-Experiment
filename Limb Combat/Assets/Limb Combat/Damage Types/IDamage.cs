using Assets.Attacks;
using Assets.Body_Parts;
using Assets.Stats;

namespace Assets.Damage_Types
{
	public interface IDamage
	{
		int Standard(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier);
		int Weakness(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier);
		int Resistance(Damaging_Attack damaging_Attack, Body_Part_Combat body_Part_Combat, Barrier barrier);
		int Immmunity();
	}
}
