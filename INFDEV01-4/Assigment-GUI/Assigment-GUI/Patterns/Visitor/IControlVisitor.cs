using System;

namespace AssigmentGUI
{
	public interface IControlVisitor
	{
		bool OnIControl(IControl Control);
	}
}

