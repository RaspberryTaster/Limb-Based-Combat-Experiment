using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit_Stats : MonoBehaviour
{
    public Combat_Stats Endurance_Points;
    [Space]
    public Combat_Stats Barrier_Points;
    [Space]
    public Combat_Stats Action_Points;
    [Space]
    public Combat_Stats Bonus_Action_Points;

    public void Damage(int damage)
	{
        Endurance_Points.Reduce(damage, 0);
    }
}
