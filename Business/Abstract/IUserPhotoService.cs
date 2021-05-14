using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
     public interface IUserPhotoService
    {
        IResult Add(IFormFile file,UserPhoto photo);
        IResult Delete(IFormFile file, UserPhoto photo);
        IDataResult<UserPhoto> Get(int id);
        
    }
}
