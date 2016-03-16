using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace AssignmentComplete
{
	public class AddTruckFromFactory : IAction
	{
		#region IAction implementation
		private IFactory _factory;
		private List<ITruck> _truck;


		public void Run ()
		{
			IContainer _container;
			ITruck _truck;

			if (this._factory.ProductsToShip.Count >= 100) {
				this._factory.ProductsToShip = new List<IContainer>();

				if (this._factory.GetType () == typeof(Mine)) {
					_truck = new Truck (new Vector2 (200, 50), new Vector2 (50, 0), this._factory.TruckTexture);
					_container = new Container (100, 200, new Vector2 (200, 40), this._factory.ContainerTexture);
				} else {
					_truck = new Truck (new Vector2 (420, 320), new Vector2 (-50, 0), this._factory.TruckTexture);
					_container = new Container (100, 200, new Vector2 (480, 310), this._factory.ContainerTexture);
				}

				_truck.AddContainer (_container);
				this._truck.Add (_truck);
			}
		}

		#endregion

		public AddTruckFromFactory (IFactory factory, List<ITruck> truck)
		{
			this._factory = factory;
			this._truck = truck;
		}

	}
}