﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, MyDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (MyDatabaseContext context = new MyDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             
                             join co in context.Colors
                             on c.ColorId equals co.ColorId

                            

                             select new CarDetailDto 
                             { 
                                                       CarId = c.CarId,
                                                       CarName = c.CarName, 
                                                       BrandName = b.BrandName,
                                                       ColorName = co.ColorName,
                                                       DailyPrice=c.DailyPrice,
                                                       Desciription=c.Desciription,
                                                       ModelYear = c.ModelYear,
                                                       
    
                             };

                return result.ToList();
            }
        }
    }
}
