using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentService
    {
        IResult Add(Rent rent);

        IResult Update(Rent rent);

        IResult Delete(Rent rent);

        IDataResult<List<Rent>> GetAll();

        IDataResult<Rent> GetById(int id);
    }
}