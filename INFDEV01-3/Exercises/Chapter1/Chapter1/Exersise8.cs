using System;

namespace Chapter1
{
	public class Exersise8
	{
		public Exersise8 ()
		{
			Console.WriteLine ("Execute Exersise8");

			UserStory userStory1 = new UserStory ();
			userStory1.hours = 10;
			userStory1.description = "Dit is een test1";
			Console.WriteLine(userStory1.ToString());

			UserStory userStory2 = new UserStory ();
			userStory2.hours = 20;
			userStory2.description = "Dit is een test2";

			UserStory userStory3 = new UserStory ();
			userStory3.hours = 30;
			userStory3.description = "Dit is een test3";

				
			Sprint sprint1 = new Sprint ();
			sprint1.userStories = new UserStory[]{ userStory1, userStory2, userStory3 };


			Console.WriteLine (sprint1.ToString());
		}
	}


	public class UserStory
	{
		public int hours { get; set; }
		public string description { get; set; }


		public override string ToString()
		{
			return "Description: " + this.description;
		}

	}


	public class Sprint
	{
		public UserStory[] userStories;

		public int totalHours()
		{
			int sum = 0;
			foreach (UserStory userStory in userStories) {
				sum += userStory.hours;
			}
			return sum;
		}

		public override string ToString()
		{
			return "Aantal uur:  " + this.totalHours();
		}

	}

}