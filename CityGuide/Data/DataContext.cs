﻿using CityGuide.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<City> Cities { get; set; }
		public DbSet<Photo> Photos { get; set; }
		public DbSet<User> Users { get; set; }
	}
}
