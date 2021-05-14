using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TopicManager : ITopicService
    {
        ITopicDal _topicDal;

        public TopicManager(ITopicDal topicDal)
        {
            _topicDal = topicDal;
        }

        [ValidationAspect(typeof(TopicValidator))]
        [SecuredOperation("admin")]
        public IResult Add(Topic topic)
        {
            _topicDal.Add(topic);
            return new SuccessResult(Messages.TopicAdded);
        }

        public IResult Delete(Topic topic)
        {
            _topicDal.Delete(topic);
            return new SuccessResult();
        }

        public IDataResult<List<Topic>> GetAll()
        {
            
            return new SuccessDataResult<List<Topic>>(_topicDal.GetAll());
        }

        public IDataResult<Topic> GetById(int topictId)
        {
            return new SuccessDataResult<Topic>(_topicDal.Get(u => u.Id == topictId));
        }
    }
}
