using Entities.Concrete;
using System.Collections.Generic;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IResult Add(Brand brand);

        IResult Update(Brand brand);

        IResult Delete(Brand brand);

        IDataResult<List<Brand>> GetAll();

        IDataResult<Brand> GetById(int id);
    }
}