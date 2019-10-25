using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Model
{
	public class User
	{
		public User()
		{
			Cities = new List<City>();
		}

		[Key]
		public int Id { get; set; }
		public string UserName { get; set; }
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }

		public List<City> Cities { get; set; }
	}
}
