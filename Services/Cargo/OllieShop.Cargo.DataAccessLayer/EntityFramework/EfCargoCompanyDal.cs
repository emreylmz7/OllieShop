﻿using OllieShop.Cargo.DataAccessLayer.Abstract;
using OllieShop.Cargo.DataAccessLayer.Concrete;
using OllieShop.Cargo.DataAccessLayer.Repositories;
using OllieShop.Cargo.EntityLayer.Concrete;

namespace OllieShop.Cargo.DataAccessLayer.EntityFramework
{
    public class EfCargoCompanyDal : GenericRepository<CargoCompany>, ICargoCompanyDal
    {
        public EfCargoCompanyDal(CargoContext context) : base(context)
        {
        }
    }
}
