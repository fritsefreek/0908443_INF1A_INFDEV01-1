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
		private Texture2D _texture;

		#region IContainer implementation

		public bool AddContent (int amount)
		{
			if (this._currentAmount + amount > this._maxCapacity) {
				return false;
			} else {
				this._currentAmount += amount;
				return true;
			}
		}

		public int CurrentAmount {
			get {
				return _currentAmount;
			}
		}

		public int MaxCapacity {
			get {
				return _maxCapacity;
			}
		}

		public Vector2 Position {
			get {
				return _position;
			}
			set {
				this._position = value;
			}
		}

		#endregion

		#region IDrawable implementation

		public void Draw (SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (this._texture, this._position, null, Color.White, 0f, Vector2.Zero, new Vector2(0.3f, 0.3f), SpriteEffects.None, 0f);
		}

		#endregion

		public Container(int currentAmount, int maxCapacity, Vector2 position, Texture2D texture)
		{
			_currentAmount = currentAmount;
			_maxCapacity = maxCapacity;
			_position = position;
			_texture = texture;
		}

	}
}
