using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public class ControlVisitor: IControlVisitor
	{
		#region IControlVisitor implementation

		public bool OnIControl (IControl Control)
		{
			return true;
		}


		#endregion


	}
}

