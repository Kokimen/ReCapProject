using System;
using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentManager:IRentService
    {
        private readonly IRentDal _rentDal;

        public RentManager(IRentDal rentDal)
        {
            _rentDal = rentDal;
        }

        public IResult Add(Rent rent) //sıkıntı var
        {
            var rentCar = _rentDal.GetAll(r => r.CarId == rent.CarId && r.ReturnDate==null);
            if (rentCar.Count>0)
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }

            _rentDal.Add(rent);
            return new SuccessResult(Messages.Added);
        }

        public IResult Update(Rent rent)
        {
            _rentDal.Update(rent);
            return new SuccessResult(Messages.Updated);
        }

        public IResult Delete(Rent rent)
        {
            _rentDal.Delete(rent);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Rent>> GetAll()
        {
            return new SuccessDataResult<List<Rent>>(Messages.Listed, _rentDal.GetAll());
        }

        public IDataResult<Rent> GetById(int id)
        {
            return new SuccessDataResult<Rent>(Messages.Listed, _rentDal.Get(r=>r.RentId==id));
        }
    }
}