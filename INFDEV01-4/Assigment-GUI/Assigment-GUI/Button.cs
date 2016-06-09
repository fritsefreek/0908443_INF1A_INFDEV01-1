using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public class Button: IControl
	{
		public Vector2 position;
		public Vector2 size;
		public string texture;
	

		#region IControl implementation

		public void Update ()
		{
			throw new NotImplementedException ();
		}

		public void Draw (SpriteBatch spritebatch, SpriteFont font, Dictionary<string, Texture2D> buttonStates)
		{
			spritebatch.Draw (buttonStates[this.texture], position, null, Color.White, 0f, Vector2.Zero, size, SpriteEffects.None, 0f);
		}

		public void Visit(IControlVisitor IControlVisitor)
		{
			IControlVisitor.OnButton (this);
		}

		public Vector2 Position {
			get {
				return this.position;
			}
			set {
				this.position = value;
			}
		}

		public Vector2 Size {
			get {
				return this.size;
			}
			set {
				this.size = value;
			}
		}

		public string Texture
		{
			get
			{
				return this.texture;
			}
			set
			{
				this.texture = value;
			}

		}

		#endregion


	}
}

