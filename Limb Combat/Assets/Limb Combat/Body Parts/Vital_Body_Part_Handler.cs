using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Body_Parts
{

	public class Vital_Body_Part_Handler : IBody_Part_Handler
	{
		public Body Body;
		public List<Body_Part> body_Parts = new List<Body_Part>();
		public List<Body_Part> Body_Parts { get => body_Parts; set => body_Parts = value; }
		
		public Vital_Body_Part_Handler(Body body, List<Body_Part> body_Parts)
		{
			Body = body;
			this.body_Parts = body_Parts;
		}

		public void On_Body_Part_Destroyed()
		{
			Body.Die();
		}

		public void Set_Body_Parts(List<Body_Part> body_Parts)
		{
			Body_Parts = body_Parts;
			int count = Body_Parts.Count;
			for (int i = 0; i < count; i++)
			{
				Body_Parts[i].Body_Part_Handler = this;
			}
		}
	}
}
