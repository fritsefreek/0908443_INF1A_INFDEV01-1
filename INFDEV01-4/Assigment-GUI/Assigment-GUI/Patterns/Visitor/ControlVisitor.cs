using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public class ControlVisitor: IControlVisitor
	{
		#region IControlVisitor implementation

		public bool OnButton (Button Button)
		{
			return true;
		}

		public bool OnLabel(Label Label)
		{
			return true;
		}
		#endregion

	}
}

