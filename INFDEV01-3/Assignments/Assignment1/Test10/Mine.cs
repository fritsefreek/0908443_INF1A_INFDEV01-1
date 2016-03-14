using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AssignmentComplete
{
	public class Mine : IFactory 
	{
		private Vector2 _posisiton;
		private Texture2D _truck, _mine, _mineCard, _oreContainer;
		private List<IContainer> _products;


		#region IFactory implementation
		public Texture2D TruckTexture {
			get {
				return this._truck;
			}
		}

		public Texture2D ContainerTexture {
			get {
				return this._oreContainer;
			}
		}
			
		public ITruck GetReadyTruck ()
		{
			throw new NotImplementedException ();
		}

		public Microsoft.Xna.Framework.Vector2 Position {
			get {
				return this._posisiton;
			}
		}

		public System.Collections.Generic.List<IContainer> ProductsToShip {
			get {
				return this._products;
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
			spriteBatch.Draw (this._mine, this._posisiton, null, Color.White, 0f, Vector2.Zero, new Vector2(0.5f, 0.5f), SpriteEffects.None, 0f);
			spriteBatch.Draw (this._mineCard, new Vector2(5, 60), null, Color.White, 0f, Vector2.Zero, new Vector2(0.2f, 0.2f), SpriteEffects.None, 0f);
			spriteBatch.Draw (this._mineCard, new Vector2(5, 100), null, Color.White, 0f, Vector2.Zero, new Vector2(0.2f, 0.2f), SpriteEffects.None, 0f);
			spriteBatch.Draw (this._truck, new Vector2(150, 50), null, Color.White, 0f, Vector2.Zero, new Vector2(0.3f, 0.3f), SpriteEffects.None, 0f);
			spriteBatch.Draw (this._oreContainer, new Vector2(170, 50), null, Color.White, 0f, Vector2.Zero, new Vector2(0.2f, 0.2f), SpriteEffects.None, 0f);
		}

		#endregion

		public Mine (Vector2 posisiton, Texture2D truck, Texture2D mine, Texture2D mineCard, Texture2D oreContainer)
		{
			this._posisiton = posisiton;
			this._truck = truck;
			this._mine = mine;
			this._mineCard = mineCard;
			this._oreContainer = oreContainer;
		}
	}
}

