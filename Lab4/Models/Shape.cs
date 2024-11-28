﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;


namespace Lab4.Models
{ 
	internal class Shape
	{
		public double X { get; set; }
		public double Y { get; set; }
		public double Height { get; set; }
		public double Width { get; set; }



        public virtual void Draw()
		{
			Console.WriteLine(nameof(Shape));
		}
	}	
}