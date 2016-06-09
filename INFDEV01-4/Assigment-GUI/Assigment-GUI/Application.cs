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
			this.IsMouseVisible = true;

			ControlFactory someControl = new ControlFactory ();
			this.controlList.Add (someControl.Create("label-left"));
			this.controlList.Add (someControl.Create("label-right"));
			this.controlList.Add (someControl.Create ("button-normal"));

			IControl fancybutton = new FancyButton(someControl.Create("button-normal"));
			this.controlList.Add(fancybutton);
		}

		protected override void LoadContent()
		{
			spriteBatch = new SpriteBatch(graphics.GraphicsDevice);
			this.font = Content.Load<SpriteFont>("Arial");
			this.buttonStates.Add ("normal", Content.Load<Texture2D>("ButtonNormal.png"));
			this.buttonStates.Add("hover", Content.Load<Texture2D>("ButtonHover.png"));
		}

		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState (PlayerIndex.One).Buttons.Back == ButtonState.Pressed) {
				this.Exit ();
			}
		
			MouseState state = Mouse.GetState();
			System.Console.WriteLine (state.X );

			base.Update(gameTime);
		}

		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);
			spriteBatch.Begin();

			Iterator<IControl> IteratorList = new ListIterator<IControl>(this.controlList);
			IOption<IControl> ListItem = IteratorList.GetNext();
			ControlVisitor controlVisitor = new ControlVisitor();

			while (ListItem is Some<IControl>) {
				IControl control = ListItem.getValue();
				control.Draw(spriteBatch, this.font, this.buttonStates);
				ListItem = IteratorList.GetNext();
			}

			spriteBatch.End();
			base.Draw(gameTime);
		}
	}
}