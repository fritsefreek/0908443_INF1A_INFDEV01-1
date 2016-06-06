using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public interface IControl {
		Vector2 Position { get; set;}
		Vector2 Size { get; set; }

		void Update();
		void Draw(SpriteBatch spritebatch, SpriteFont font);
		void Visit(IControlVisitor IControlVisitor);
	}
}