using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFDEV014
{
	class Program
	{
		interface INumber
		{
			void visit(INumberVisitor INumberVisitor);
		}

		interface INumberVisitor
		{
			void onMyInt(MyInt MyInt);
			void onMyFloat(MyFloat MyFloat);
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

		static void Main(string[] args)
		{
			NumberVisitor numberVistor = new NumberVisitor();
			numberVistor.onMyFloat(new MyFloat());
			numberVistor.onMyInt(new MyInt());
			Console.Read();
		}
	}
}