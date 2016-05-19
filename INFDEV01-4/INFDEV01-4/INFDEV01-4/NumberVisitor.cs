using System;

namespace INFDEV014
{
	class NumberVisitor: INumberVisitor
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
}