using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssigmentGUI
{
	public class Label : Microsoft.Xna.Framework.Game, IControl
	{
		public Vector2 position;
		public Vector2 size;

		SpriteFont Font1;
		Vector2 FontPos;
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;


		public Label()
		{
			spriteBatch = new SpriteBatch(GraphicsDevice);
			Font1 = Content.Load<SpriteFont>("Courier New");           
			FontPos = new Vector2(graphics.GraphicsDevice.Viewport.Width / 2, graphics.GraphicsDevice.Viewport.Height / 2);
		}
			

		#region IControl implementation

		public void Update ()
		{
			throw new NotImplementedException ();
		}

		public void Draw ()
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			spriteBatch.Begin();

			// Draw Hello World
			string output = "Hello World";

			// Find the center of the string
			Vector2 FontOrigin = Font1.MeasureString(output) / 2;
			// Draw the string
			spriteBatch.DrawString(Font1, output, FontPos, Color.LightGreen, 0, FontOrigin, 1.0f, SpriteEffects.None, 0.5f);

			spriteBatch.End();
		
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

		#endregion
	}
}

