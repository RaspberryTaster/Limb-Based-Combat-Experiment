using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Body_Parts
{
	public interface IBody_Part_Handler
	{
		List<Body_Part> Body_Parts { get; set; }
		void On_Body_Part_Destroyed();
		void Set_Body_Parts(List<Body_Part> body_Parts);
	}
}
