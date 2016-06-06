using System;

namespace AssigmentGUI
{
	public class ControlFactory
	{
		public IControl Create(string controlType)
		{
			if (controlType == "") {
				return null;
			}

			if (controlType == "label") {
				return new Label ();
			}
			return null;
		
			
		}
	}
}

