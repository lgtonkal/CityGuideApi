﻿using CityGuide.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityGuide.Data
{
	public interface IAppRepository
	{
		void Add<T>(T entity) where T:class;
		void Delete<T>(T entity) where T:class;
		bool SaveAll();

		List<City> GetCities();
		List<Photo> GetPhotosByCity(int id);
		City GetCityById(int cityId);
		Photo GetPhoto(int id);
	}
}
