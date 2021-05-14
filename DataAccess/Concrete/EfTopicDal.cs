﻿using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfTopicDal : EfEntityRepositoryBase<Topic, DbAbooContext>, ITopicDal
    {
    }
}
