using System;
using System.Collections.Generic;

namespace AssigmentGUI
{
	public class ListIterator<T>: Iterator<T> 
	{
		private List<T> list;
		private int index = 0;

		public ListIterator(List<T> list) {
			this.list = list;
		}

		public IOption<T> GetNext() {
			if (index > list.Count) {
				return new None<T> ();
			} else {
				this.index += 1;
				return new Some<T> (this.list[this.index]);
			}
		}
	}
}

