using System;

namespace AssigmentGUI
{
	public interface OptionVisitor<T, U>
	{
		U onSome(T value);
		U onNone();
	}

	public interface IOption<T> { 
		U Visit<U>(OptionVisitor<T, U> visitor); 
		T getValue();
		Boolean isNone();
	}

	class Some<T> : IOption<T>
	{
		public T value;
		public Some(T value) { this.value = value; }
		public U Visit<U>(OptionVisitor<T, U> visitor)
		{
			return visitor.onSome(this.value);
		}

		public T getValue() {
			return this.value;
		}

		public Boolean isNone() {
			return false;
		}
	}

	class None<T> : IOption<T>
	{
		public U Visit<U>(OptionVisitor<T, U> visitor)
		{
			return visitor.onNone();
		}

		public T getValue(){
			throw new NotImplementedException();
		}

		public Boolean isNone() {
			return true;
		}

	}
}