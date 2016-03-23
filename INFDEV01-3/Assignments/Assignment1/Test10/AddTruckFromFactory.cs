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
			if (this._factory.ProductsToShip.Count == 3) {
				if (this._factory.IsTruckReady == true) {
					this._factory.ProductsToShip = new List<IContainer>();
					ITruck _truck = _factory.GetReadyTruck ();
					this._truck.Add (_truck);
				}
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