using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public class ControlVisitor: IControlVisitor
	{
		#region IControlVisitor implementation

		void IControlVisitor.onLabel (Label Label)
		{
			Console.Write ("test");
			//Label.Draw (spritebatch, font)
		}

		#endregion


	}
}

