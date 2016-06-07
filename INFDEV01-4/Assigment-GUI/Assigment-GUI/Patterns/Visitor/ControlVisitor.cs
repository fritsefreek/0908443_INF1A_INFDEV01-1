using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public class ControlVisitor: IControlVisitor
	{
		#region IControlVisitor implementation

		void IControlVisitor.OnLabel (Label Label)
		{
			Console.Write ("I found a label");
			//Label.Draw (spritebatch, font)
		}

		void IControlVisitor.OnButton(Button Button)
		{
			Console.Write ("I found a button");
		}

		#endregion


	}
}

