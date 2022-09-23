using System;
namespace Lab4
{
	// this class exists to get the project directory
	public class FileRoot
	{
        public static string fileRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
	}
}

