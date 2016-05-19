using System;

namespace INFDEV014
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			NumberVisitor num = new NumberVisitor();
			num.onMyFloat(new MyFloat());
			num.onMyInt(new MyInt());
			Console.Read();
		}
	}
}
