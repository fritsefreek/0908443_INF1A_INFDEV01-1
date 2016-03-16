using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace AssignmentComplete
{
	public class Ikea : IFactory 
	{
		private Vector2 _posisiton;
		private Texture2D _truck, _ikea, _productBox, _productContainer;
		private List<IContainer> _products = new List<IContainer>();

		public void CreateProduct()
		{
			Random random = new Random();
			OreContainer ore = new OreContainer (this._productBox, new Vector2(this._posisiton.X + random.Next(-50, 100), this._posisiton.Y + random.Next(-50, 100)), 0, 200);
			this._products.Add (ore);
		}

		#region IFactory implementation
		public Texture2D TruckTexture {
			get {
				return this._truck;
			}
		}

		public Texture2D ContainerTexture {
			get {
				return this._productContainer;
			}
		}

		public ITruck GetReadyTruck ()
		{
			return new Truck (this._posisiton, new Vector2(10, 0), this._truck);
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
			set {
				this._products = value;
			}
		}

		#endregion

		#region IUpdateable implementation

		public void Update (float dt)
		{
			foreach (var product in this._products) {
				if (product.CurrentAmount < product.MaxCapacity) {
					product.AddContent (50);
				} else if(this._products[this._products.Count - 1] == product) {
					this.CreateProduct ();
					break;
				}
			}
			if (this._products.Count == 0) {
				this.CreateProduct ();
			}
		}

		#endregion

		#region IDrawable implementation

		public void Draw (Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (this._ikea, this._posisiton, null, Color.White, 0f, Vector2.Zero, new Vector2(0.5f, 0.5f), SpriteEffects.None, 0f);
			spriteBatch.Draw (this._truck, new Vector2(420, 320), null, Color.White, 0f, Vector2.Zero, new Vector2(0.3f, 0.3f), SpriteEffects.FlipHorizontally, 0f);
			spriteBatch.Draw (this._productBox, new Vector2(750, 350), null, Color.White, 0f, Vector2.Zero, new Vector2(0.2f, 0.2f), SpriteEffects.FlipHorizontally, 0f);

			if (this._products.Count > 0) {
				foreach (var product in this._products) {
					if (product.CurrentAmount == product.MaxCapacity) {
						product.Draw (spriteBatch);
					}
				}
			}
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