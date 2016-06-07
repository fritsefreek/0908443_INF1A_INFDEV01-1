using System;
using System.Collections.Generic;
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
		SpriteFont font;
		Dictionary<string, Texture2D> buttonStates = new Dictionary<string, Texture2D>();
		List<IControl> controlList = new List<IControl>();


		public Application()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";

			ControlFactory someControl = new ControlFactory ();
			this.controlList.Add (someControl.Create("label-left"));
			this.controlList.Add (someControl.Create("label-right"));

		}
			

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
			this.font = Content.Load<SpriteFont>("Arial");
			this.buttonStates.Add ("normal", Content.Load<Texture2D>("ButtonNormal.png"));
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

			foreach(IControl control in this.controlList) {
				control.Draw(spriteBatch, this.font, this.buttonStates);
			}

			//ControlVisitor controlVisitor = new ControlVisitor();
			//controlVisitor.onLabel(this.testlabel, spriteBatch, this.font);

			spriteBatch.End();

			base.Draw(gameTime);
		}
	}
}