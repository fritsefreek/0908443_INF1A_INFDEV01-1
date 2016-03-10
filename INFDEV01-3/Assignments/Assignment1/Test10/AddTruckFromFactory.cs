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
			IContainer _container = new Container (400, 1000, new Vector2(400, 50), factory.ContainerTexture);
			ITruck _truck = new Truck(new Vector2(400, 50), new Vector2(10, 10), factory.TruckTexture);
			_truck.AddContainer (_container);
			truck.Add (_truck);
		}


	}
}

