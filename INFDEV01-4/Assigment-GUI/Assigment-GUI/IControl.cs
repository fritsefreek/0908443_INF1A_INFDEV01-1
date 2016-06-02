using System;
using Microsoft.Xna.Framework;

namespace AssigmentGUI
{
	interface IControl {
		Vector2 Position { get; set;}
		Vector2 Size { get; set; }

		void Update();
		void Draw();
	}
}