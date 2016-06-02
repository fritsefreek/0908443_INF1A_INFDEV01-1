using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;

namespace AssigmentGUI
{

	public class Application : Game
	{
		GraphicsDeviceManager graphics;
		SpriteBatch spriteBatch;
		Label testlabel;
		SpriteFont font;

		public Application()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
			Vector2 position = new Vector2 (200, 20);
			this.testlabel = new Label {position = position, size = position};
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
			this.font = Content.Load<SpriteFont>("Arial");
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed) {
				this.Exit ();
			}
		
			base.Update(gameTime);
		}
			
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			spriteBatch.Begin();
			this.testlabel.Draw(spriteBatch, this.font);
			spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}