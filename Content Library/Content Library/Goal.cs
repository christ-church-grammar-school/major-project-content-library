using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content_Library
{
	public class Goal
	{
		public string title;
		public List<Activity> activites;
		public bool completed;

		//public static List<Goal>;

		public Goal(string t)
		{
			title = t;
			activites = new List<Activity>();
			completed = false;
		}
	}
}
