using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
	public class Ikea : IFactory 
	{
		private Vector2 _posisiton;
		private Texture2D _truck, _ikea, _productBox, _productContainer;

		#region IFactory implementation

		public ITruck GetReadyTruck ()
		{
			throw new NotImplementedException ();
		}

		public Microsoft.Xna.Framework.Vector2 Position {
			get {
				throw new NotImplementedException ();
			}
		}

		public System.Collections.Generic.List<IContainer> ProductsToShip {
			get {
				throw new NotImplementedException ();
			}
		}

		#endregion

		#region IUpdateable implementation

		public void Update (float dt)
		{
			//throw new NotImplementedException ();
		}

		#endregion

		#region IDrawable implementation

		public void Draw (Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (this._ikea, this._posisiton, null, Color.White, 0f, Vector2.Zero, new Vector2(0.5f, 0.5f), SpriteEffects.None, 0f);
			spriteBatch.Draw (this._truck, new Vector2(420, 320), null, Color.White, 0f, Vector2.Zero, new Vector2(0.3f, 0.3f), SpriteEffects.FlipHorizontally, 0f);
			spriteBatch.Draw (this._productContainer, new Vector2(500, 320), null, Color.White, 0f, Vector2.Zero, new Vector2(0.2f, 0.2f), SpriteEffects.FlipHorizontally, 0f);
			spriteBatch.Draw (this._productBox, new Vector2(750, 350), null, Color.White, 0f, Vector2.Zero, new Vector2(0.2f, 0.2f), SpriteEffects.FlipHorizontally, 0f);
		}

		#endregion

		public Ikea (Vector2 posisiton, Texture2D truck, Texture2D ikea, Texture2D productBox, Texture2D productContainer)
		{
			this._posisiton = posisiton;
			this._truck = truck;
			this._ikea = ikea;
			this._productBox = productBox;
			this._productContainer = productContainer;
		}
	}
}

