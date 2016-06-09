using System;
using Microsoft.Xna.Framework;

namespace AssigmentGUI
{
	public class FancyButton : MakeFancyDecorator
	{
		public FancyButton(IControl baseComponent): base(baseComponent)
		{
			baseComponent.Texture = "hover";
			baseComponent.Position = new Vector2(100, 300);
		}
	}
}