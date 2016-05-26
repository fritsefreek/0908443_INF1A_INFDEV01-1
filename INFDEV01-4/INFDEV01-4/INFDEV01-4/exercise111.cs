using System;

namespace INFDEV014
{
	public class exercise111
	{
		interface INumber
		{
			void visit(INumberVisitor INumberVisitor);
		}

		class MyInt : INumber
		{
			public void visit(INumberVisitor INumberVisitor)
			{
				INumberVisitor.onMyInt(this);
			}
		}

		class MyFloat : INumber
		{
			public void visit(INumberVisitor INumberVisitor)
			{
				INumberVisitor.onMyFloat(this);
			}
		}

		interface INumberVisitor
		{
			void onMyInt(MyInt MyInt);
			void onMyFloat(MyFloat MyFloat);
		}

		class NumberVisitor : INumberVisitor
		{
			public void onMyFloat(MyFloat MyFloat)
			{
				Console.WriteLine("Found float!");
			}

			public void onMyInt(MyInt MyInt)
			{
				Console.WriteLine("Found int!");
			}
		}

		public exercise111 ()
		{
			NumberVisitor numberVistor = new NumberVisitor();
			numberVistor.onMyFloat(new MyFloat());
			numberVistor.onMyInt(new MyInt());
			Console.Read();
		}
	}
}