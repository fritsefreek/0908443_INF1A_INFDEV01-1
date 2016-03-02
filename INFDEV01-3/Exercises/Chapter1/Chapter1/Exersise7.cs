using System;

namespace Chapter1
{
	public class Exersise7
	{
		public Exersise7 ()
		{
			Console.WriteLine ("Execute Exersise7");

			RemcoCounter c1 = new RemcoCounter ();
			RemcoCounter c2 = new RemcoCounter ();

			c1.SetOnTarget(4, counter => c1.Reset());

			for(int i=0;i<100;i++){
				c1.Tick ();
				Console.WriteLine(c1);
			}

			c1.Tick ();
			c1.Tick ();
			c1.Tick ();
			c1.Tick ();
			c2.Tick ();
			c2.Reset ();
			c2.Tick ();	

			RemcoCounter sumCounter = c1 + c2;
			Console.Write (sumCounter);
		}
	}

	public class RemcoCounter
	{
		int counter = 0;
		int target = int.MaxValue;
		Action<int> onTarget;
		public RemcoCounter() {

		}

		RemcoCounter(int ticks) {
			counter = ticks;

		}

		public void Reset() {
			this.counter = 0;
		}

		public void Tick() {
			this.counter++;
			if (counter >= target && onTarget != null) {
				this.onTarget (counter);
			}
		}

		public static RemcoCounter operator +(RemcoCounter c1, RemcoCounter c2) {
			return new RemcoCounter (c1.counter + c2.counter);
		}

		public void SetOnTarget(int target, Action<int> onTarget) {
			this.onTarget = onTarget;
			this.target = target;


		}

		public override string ToString () => counter.ToString();
	}
}