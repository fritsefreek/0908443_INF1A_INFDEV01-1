using System;

namespace Chapter1
{
	public class Exersise6
	{
		public Exersise6 ()
		{
			Console.WriteLine ("Execute Exersise6");

			int start = Int32.Parse(Console.ReadLine());
			int end = Int32.Parse(Console.ReadLine());

			Interval inv = new Interval (start, end);
			Console.WriteLine (inv.Sum());
			Console.WriteLine (inv.Product());
		}
	}

	public class Interval
	{
		int start, end;

		public Interval(int start, int end) {
			this.start = start;
			this.end = end;
		}


		public int Sum() {
			return this.Sum (this.start, this.end);
		}

		private int Sum(int start, int end){
			if (start <= end) {
				return this.Sum(start+1, end) + start;
			} else {
				return 0;
			}
		}


		public int Product() {
			return this.Product (this.start, this.end);
		}

		private int Product(int start, int end) {
			if (start <= end) {
				return this.Product (start + 1, end) * start;
			} else {
				return 1;
			}
		}

	}
}