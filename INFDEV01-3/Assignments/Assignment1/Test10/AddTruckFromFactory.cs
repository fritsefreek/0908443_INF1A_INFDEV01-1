using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace AssignmentComplete
{
	public class AddTruckFromFactory : IAction
	{
		#region IAction implementation

		public void Run ()
		{
			System.Console.Write ("test");
		}

		#endregion

		public AddTruckFromFactory (IFactory factory, List<ITruck> truck)
		{
			ITruck _truck;
			if (factory.GetType() == typeof(Mine)) {
				_truck = new Truck (new Vector2 (400, 50), new Vector2 (10, 10), factory.TruckTexture);
			} else {
			 	_truck = new Truck (new Vector2 (200, 360), new Vector2 (-10, 10), factory.TruckTexture);
			}

			IContainer _container = new Container (100, 200, _truck.Position, factory.ContainerTexture);
			_truck.AddContainer (_container);
			truck.Add (_truck);
		}


	}
}

