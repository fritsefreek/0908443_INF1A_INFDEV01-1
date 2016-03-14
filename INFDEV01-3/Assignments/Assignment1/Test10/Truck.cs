using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
	public class Truck : ITruck
	{
		private Vector2 _posisiton, _velocity;
		public Texture2D _texture;
		private IContainer _container;

		#region ITruck implementation

		public void StartEngine ()
		{
			throw new NotImplementedException ();
		}

		public void AddContainer (IContainer container)
		{
			this._container = container;
		}

		public IContainer Container {
			get {
				return this._container;
			}
		}

		public Vector2 Position {
			get {
				return this._posisiton;	
			}
			set {
				this._posisiton = value;
			}
		}

		public Vector2 Velocity {
			get {
				return this._velocity;	
			}
			set {
				this._velocity = value;
			}
		}

		#endregion

		#region IUpdateable implementation

		public void Update (float dt)
		{
			this._posisiton.X = this._posisiton.X + this._velocity.X * dt;
			Vector2 positionContainer = this._container.Position;
			this._container.Position = new Vector2(this._container.Position.X + this._velocity.X * dt, positionContainer.Y);
		}

		#endregion

		#region IDrawable implementation

		public void Draw (SpriteBatch spriteBatch)
		{
			SpriteEffects spriteEffect;
			if (this._velocity.X < 0) {
				spriteEffect = SpriteEffects.FlipHorizontally;
			} else {
				spriteEffect = SpriteEffects.None;
			}

			spriteBatch.Draw (this._texture, this._posisiton, null, Color.White, 0f, Vector2.Zero, new Vector2(0.3f, 0.3f), spriteEffect, 0f);
			this._container.Draw (spriteBatch);
		}

		#endregion

		public Truck(Vector2 position, Vector2 velocity, Texture2D texture)
		{
			this._posisiton = position;
			this._velocity = velocity;
			this._texture = texture;
		}
	}
}
