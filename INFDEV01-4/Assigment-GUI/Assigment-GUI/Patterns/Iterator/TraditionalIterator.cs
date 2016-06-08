using System;


namespace AssigmentGUI
{
	public interface TraditionalIterator<T> {
		void MoveNext();
		bool HasNext();
		T GetCurrent();
	}
}

