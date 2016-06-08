using System;
using Microsoft.Xna.Framework;

namespace AssigmentGUI
{
	class FancyButton : Decorator
	{
		public FancyButton(IControl baseComponent): base(baseComponent)
		{
			baseComponent.Position = new Vector2 (100, 100);
		}
	}
}

