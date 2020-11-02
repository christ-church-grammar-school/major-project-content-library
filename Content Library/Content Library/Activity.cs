using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Library
{
	public class Activity
	{
		public string name;
		public bool completed;

		public Activity(string n)
		{
			name = n;
			completed = false;
		}
	}
}
