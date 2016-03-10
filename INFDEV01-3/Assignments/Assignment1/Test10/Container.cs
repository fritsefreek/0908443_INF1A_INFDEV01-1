using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace AssignmentComplete
{
	class Container : IContainer
	{
		private int _currentAmount;
		private int _maxCapacity;
		private Vector2 _position;

		public Container(int currentAmount, int maxCapacity, Vector2 position)
		{
			_currentAmount = currentAmount;
			_maxCapacity = maxCapacity;
			_position = position;
		}

		public int CurrentAmount { get; }
		public int MaxCapacity { get; }
		public Vector2 Position { get; set;}

		public bool AddContent(int amount) {
			return true;
		}

		public void Draw(SpriteBatch sprite)
		{
		 	Draw(sprite);
		}

	}
}
