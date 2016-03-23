using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
	class Ikea : IFactory
	{

		class AddOreBoxToMine : IAction
		{
			Ikea ikea;
			public AddOreBoxToMine(Ikea ikea)
			{
				this.ikea = ikea;
			}
			public void Run()
			{
				ikea.ProductsToShip.Add(CreateOreBox(ikea.Position + new Vector2(+150, 40 + -30 * ikea.ProductsToShip.Count)));
			}
			Ore CreateOreBox(Vector2 position)
			{
				var box = new Ore(100, ikea.product_box);
				box.Position = position;
				return box;
			}
		} 


		Texture2D ikea, oreContainer, product_box, truckTexture;
		List<IStateMachine> processes;
		ITruck waitingTruck;
		bool isTruckReady = true;
		Vector2 position;
		List<IContainer> productsToShip;

		public Ikea(Vector2 position, Texture2D truck_texture, Texture2D ikea, Texture2D product_box, Texture2D ore_container)
		{
			processes = new List<IStateMachine>();
			ProductsToShip = new List<IContainer>();
			this.ikea = ikea;
			this.truckTexture = truck_texture;
			this.oreContainer = ore_container;
			this.product_box = product_box;
			this.position = position;


			ITruck newTruck = new Truck (new Vector2(position.X -150, position.Y + 15), new Vector2(-50, 0), truckTexture);
			this.waitingTruck = newTruck;

			processes.Add(
				new Repeat(new Seq(new Timer(1.0f),
					new Call(new AddOreBoxToMine(this)))));
		}


		public ITruck GetReadyTruck()
		{
			IContainer _container = new Container (100, 200, new Vector2(position.X - 80, position.Y + 15), oreContainer);
			ITruck readyTruck = this.waitingTruck;
			waitingTruck.AddContainer (_container);

			ITruck newTruck = new Truck (new Vector2(position.X -150, position.Y + 15), new Vector2(-50, 0), truckTexture);
			waitingTruck = newTruck;

			return readyTruck;
		}


		public Boolean IsTruckReady {
			get {
				return isTruckReady;
			}
		}
		public Vector2 Position
		{
			get
			{
				return position;
			}
		}
		public List<IContainer> ProductsToShip
		{
			get
			{
				return productsToShip;
			}
			set
			{
				productsToShip = value;
			}
		}
		public void Draw(SpriteBatch spriteBatch)
		{
			foreach (var cart in ProductsToShip)
			{
				cart.Draw(spriteBatch);
			}
			spriteBatch.Draw (ikea, position, null, Color.White, 0f, Vector2.Zero, new Vector2(0.5f, 0.5f), SpriteEffects.None, 0f);
			waitingTruck.Draw (spriteBatch);
		}
		public void Update(float dt)
		{
			foreach (var process in processes)
			{
				process.Update(dt);
			}
		}

	}
}