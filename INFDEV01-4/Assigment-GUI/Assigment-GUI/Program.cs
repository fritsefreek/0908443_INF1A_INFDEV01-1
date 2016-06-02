using System;


namespace AssigmentGUI
{
	class MainClass
	{
		public static void Main (string[] args) 
		{
			using (Application app = new Application())
			{
				app.Run();
			}
		}
	}
}
