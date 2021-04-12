using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Body_Part_Handler
{
	public bool Vital;
	public Body Body;
    public List<Body_Part> body_Parts = new List<Body_Part>();

	public Body_Part_Handler(bool vital, Body body)
	{
		Vital = vital;
		Body = body;
	}

	public Body_Part_Handler(bool vital, Body body, List<Body_Part> body_Parts)
	{
		Vital = vital;
		Body = body;
		this.body_Parts = body_Parts;
	}

	public void On_Body_Part_Destroyed()
	{
		if (Vital)
		{
			Body.Die();
		}
	}
}
