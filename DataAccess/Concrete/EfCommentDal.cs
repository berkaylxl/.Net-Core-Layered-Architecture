using Core.DataAcces.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
   public class EfCommentDal:EfEntityRepositoryBase<Comment,DbAbooContext>,ICommentDal
    {

    }
}
