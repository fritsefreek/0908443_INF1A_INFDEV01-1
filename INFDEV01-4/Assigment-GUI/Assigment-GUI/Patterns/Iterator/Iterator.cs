using System;
using System.Collections.Generic;

namespace AssigmentGUI
{
	public interface Iterator<T>
	{
		IOption<T> GetNext();
	}
}

