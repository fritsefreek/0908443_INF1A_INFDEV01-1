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
			IContainer _container;
			if (factory.GetType() == typeof(Mine)) {
				_truck = new Truck (new Vector2 (400, 50), new Vector2 (10, 0), factory.TruckTexture);
				_container = new Container (100, 200, new Vector2(400, 40), factory.ContainerTexture);
			} else {
			 	_truck = new Truck (new Vector2 (200, 360), new Vector2 (-10, 0), factory.TruckTexture);
				_container = new Container (100, 200, new Vector2(260, 340), factory.ContainerTexture);
			}
				
			_truck.AddContainer (_container);
			truck.Add (_truck);
		}

	}
}