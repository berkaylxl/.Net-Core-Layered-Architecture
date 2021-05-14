using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITopicService
    {
        IResult Add(Topic topic);
        IResult Delete(Topic topic);
        IDataResult<List<Topic>> GetAll();
        IDataResult<Topic> GetById(int topictId);
    }
}
