using System;

namespace Chapter1
{
	public class Exersise1
	{
		public Exersise1 ()
		{
			Console.WriteLine ("Execute Exersise1");

			string result = "";

			for (int i = 0; i <= 9; i++) {
				for (int j = 0; j <= i; j++) {
					result += "*";
				}
				result += "\n";
			}
			Console.WriteLine (result);
		}
	}
}

