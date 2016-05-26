using System;

namespace INFDEV014
{
	public class exercise113
	{
		interface IOption<T>
		{
			U Visit<U>(IOptionVisitor<T, U> visitor);
		}

		interface IOptionVisitor<T, U>
		{
			U onSome(T value);
			U onNone();
		};

		class Some<T>: IOption<T>
		{
			public T value;

			public Some(T value)
			{
				this.value = value;
			}

			#region IOption implementation

			public U Visit<U> (IOptionVisitor<T, U> visitor)
			{
				return visitor.onSome (this.value);
			}

			#endregion
		
		}

		class OnNone<T>: IOption<T>
		{
			#region IOption implementation
			public U Visit<U> (IOptionVisitor<T, U> visitor)
			{
				return visitor.onNone ();
			}
			#endregion
		}

		class IntPrettyPrinterIOptionVisitor: IOptionVisitor<int, string>
		{
			#region IOptionVisitor implementation

			public string onSome(int value)
			{
				return value.ToString();
			}

			public string onNone()
			{
				return "I  am nothing ...";
			}

			#endregion


		}


		public exercise113 ()
		{
			IOptionVisitor <int , string > opt_visitor = new IntPrettyPrinterIOptionVisitor ();
			IOption<int> number = new Some<int>(5); 
			number.Visit(opt_visitor);
		}
	}
}

