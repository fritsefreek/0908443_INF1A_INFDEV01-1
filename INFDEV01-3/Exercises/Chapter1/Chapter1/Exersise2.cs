using System;

namespace Chapter1
{
	public class Exersise2
	{
		public Exersise2 ()
		{
			Console.WriteLine ("Execute Exersise2");

			int input = Int32.Parse(Console.ReadLine());
			int radius = input / 2;
			string result = "";

			for (int y = 0; y <= input; y++) {
				double x1y1 = (y - (radius)) * (y - (radius));
				
				for (int x = 0; x <= input; x++) {
					double x2y2 = (x - (radius)) * (x - (radius));
					if (Math.Sqrt(x1y1 + x2y2) < radius) {
						result += "*";
					} else {
						result += " ";
					}
				}
				result += "\n";
			}
			Console.WriteLine (result);
		}
	}
}