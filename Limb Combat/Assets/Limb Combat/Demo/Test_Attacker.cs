using Assets.Attacks;
using Assets.Damage_Types;
using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_Attacker : MonoBehaviour
{
    public Body Target;

    [Button("Attack", EButtonEnableMode.Always)]
    public void Attack()
	{
        Body_Part selected = Target.Vitals.Body_Parts[0];
        IDamage[] damge_Types = new IDamage[] { new Slash_Damage(), new Blunt_Damage(), new Pierce_Damage()};
        Target.Attack(selected, new Damaging_Attack(10, damge_Types));
        Debug.Log("Current Barrier Value: " + Target.Body_Combat.Barrier.Value);
        Debug.Log(selected.To_String() + " Current Health Value: " + selected.Health.Value);
        Debug.Log("Current Endurance Value: " + Target.Body_Combat.Endurance.Value);
	}
   
    [Button("Heal", EButtonEnableMode.Always)]
    public void Heal()
	{
        Target.Heal(20);
        Debug.Log("Current Endurance Value: " + Target.Body_Combat.Endurance.Value);
    }

    [Button("Barrier", EButtonEnableMode.Always)]
    public void Barrier()
    {
        Target.Add_Barrier(20);
        Debug.Log("Current Barrier Value: " + Target.Body_Combat.Barrier.Value);
    }
}
