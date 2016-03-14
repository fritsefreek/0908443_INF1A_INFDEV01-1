using System;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace AssignmentComplete
{
	public class Ore : IContainer
	{
		private Texture2D _texture;
		private Vector2 _position;
		private int _currentAmount, _maxCapacity;


		#region IContainer implementation

		public bool AddContent (int amount)
		{
			if (this._currentAmount + amount > this._maxCapacity) {
				return false;
			} else {
				return true;
			}
		}

		public int CurrentAmount {
			get {
				return this._currentAmount;
			}
		}

		public int MaxCapacity {
			get {
				return this._maxCapacity;
			}
		}

		public Microsoft.Xna.Framework.Vector2 Position {
			get {
				return this._position;
			}
			set {
				this._position = value;
			}
		}

		#endregion

		#region IDrawable implementation

		public void Draw (SpriteBatch spriteBatch)
		{
			throw new NotImplementedException ();
		}

		#endregion

	

		public Ore (Texture2D texture, Vector2 position, int currentAmount, int maxCapacity)
		{
			this._texture = texture;
			this._position = position;
			this._currentAmount = currentAmount;
			this._maxCapacity = maxCapacity;
		}

	
	}
}
