using System;
using Microsoft.Xna.Framework;

namespace AssigmentGUI
{
	public class ControlFactory
	{
		public IControl Create(string controlType)
		{
			if (controlType == "") {
				return null;
			}

			if (controlType == "label-left") {
				return new Label {position = new Vector2 (200, 20), size = new Vector2 (2, 2)};
			}

			if (controlType == "label-right") {
				return new Label {position = new Vector2 (500, 20), size = new Vector2 (2, 2)};
			}

			if (controlType == "button-normal") {
				return new Button {position = new Vector2 (200, 200), size = new Vector2(1, 1), texture = "normal" };
			}
			return null;
		}
	}
}