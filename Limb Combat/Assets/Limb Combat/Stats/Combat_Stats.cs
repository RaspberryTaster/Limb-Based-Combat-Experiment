using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Combat_Stats
{
    //only here for debug purposes
    [SerializeField] private int current;
    public int Current
    {
        get => current > Maximum ? Maximum : current;
        set
        {
            if (value > Maximum)
            {
                current = Maximum;
            }
            else
            {
                current = value;
            }

            //current = value;
        }
    }
    public int Maximum;

    public Combat_Stats(int current, int maximum)
    {
        Set_Current(current);
        Set_Maximum(maximum);
    }
    public Combat_Stats(int maximum)
    {
        Set_Maximum(maximum);
        Set_Current_To_Maximum();
    }
    public void Set_Current_To_Maximum()
    {
        Set_Current(Maximum);
    }
    public void Reduce(int value)
	{
        Current -= value;
	}


    public void Reduce(int value, int minimum_Clamp)
	{
        Current -= value;
        Clamp(minimum_Clamp);
	}
    public void Increase(int value)
	{
        Current += value;
	}

    public void Increase(int value, int minimum_Clamp)
    {
        Current += value;
        Clamp(minimum_Clamp);
    }
    public void Set_Current(int number)
    {
        Current = number;
    }
    public void Set_Maximum(int number)
    {
        Maximum = number;
    }

    public void Clamp(int minimum)
    {
        Current = Mathf.Clamp(Current, minimum, Maximum);
    }
}