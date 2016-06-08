using System;


namespace AssigmentGUI
{
	public interface Iterator<T> {
		IOption<T> GetNext();
	}
}

