﻿using System;
namespace Lab4
{
	public class FileRoot
	{
        public static string fileRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
	}
}

