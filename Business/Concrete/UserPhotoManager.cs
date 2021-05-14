using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserPhotoManager : IUserPhotoService
    {
        IUserPhotoDal _userPhotoDal;

        public UserPhotoManager(IUserPhotoDal userPhotoDal)
        {
            _userPhotoDal = userPhotoDal;
        }

        public IResult Add(IFormFile file, UserPhoto photo)
        {
            IResult result = BusinessRules.Run(CheckIfImageLimitExceedded(photo.UserId));
            if (result!=null)
            {
                return result;
            }
            photo.ImagePath = FileHelpers.Add(file);
            _userPhotoDal.Add(photo);
            return new SuccessResult(Messages.PhotoAdded);
        }

        public IResult Delete(IFormFile file, UserPhoto photo)
        {
            FileHelpers.Delete(photo.ImagePath);
            _userPhotoDal.Delete(photo);
            return new SuccessResult();
        }

        public IDataResult<UserPhoto> Get(int id)
        {
            return new SuccessDataResult<UserPhoto>(_userPhotoDal.Get(p=>p.Id==id));

        }

        private IResult CheckIfImageLimitExceedded(int id)
        {
            var imageCount = _userPhotoDal.GetAll(p => p.UserId == id).Count;
            if (imageCount>=1)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }
            return new SuccessResult();
        }
    }
}
