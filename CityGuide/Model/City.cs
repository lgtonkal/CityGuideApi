﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Model
{
	public class City
	{
		public City()
		{
			Photos = new List<Photo>();
		}

		[Key]
		public int Id { get; set; }
		public int UserId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		public List<Photo> Photos { get; set; }
		public User User { get; set; }

	}
}
