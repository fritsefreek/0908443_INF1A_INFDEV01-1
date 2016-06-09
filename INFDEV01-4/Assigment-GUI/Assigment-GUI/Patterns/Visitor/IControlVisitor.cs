using System;

namespace AssigmentGUI
{
	public interface IControlVisitor
	{
		bool OnButton(Button Button);
		bool OnLabel(Label Label);
	}
}

