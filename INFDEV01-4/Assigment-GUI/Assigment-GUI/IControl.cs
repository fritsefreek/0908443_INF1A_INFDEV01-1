using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public interface IControl {
		Vector2 Position { get; set;}
		Vector2 Size { get; set; }
		string Texture { get; set; }

		void Update();
		void Draw(SpriteBatch spritebatch, SpriteFont font, Dictionary<string, Texture2D> buttonStates);
		void Visit(IControlVisitor IControlVisitor);
	}
}