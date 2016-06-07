using System;


namespace AssigmentGUI
{
	public interface Iterator {
		bool hasNext();
		IControl next();
	}
}

