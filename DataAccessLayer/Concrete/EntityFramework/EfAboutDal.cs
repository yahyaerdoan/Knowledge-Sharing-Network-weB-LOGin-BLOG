﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using DataAccessLayer.Repositories.Concrete;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfAboutDal : GenericRepository<About>, IAboutDal
    {
    }
}
