using System;

namespace AssigmentGUI
{
	public interface IControlVisitor
	{
		void OnLabel(Label Label);
		void OnButton(Button Button);
	}
}

