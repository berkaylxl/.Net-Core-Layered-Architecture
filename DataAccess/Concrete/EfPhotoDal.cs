﻿using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfPhotoDal :EfEntityRepositoryBase<UserPhoto,DbAbooContext>,IUserPhotoDal
    {

    } 
}
