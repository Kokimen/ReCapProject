using System.Collections.Generic;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImage);

        IResult Update(CarImage carImage);

        IResult Delete(CarImage carImage);

        IDataResult<List<CarImage>> GetAll();

        IDataResult<CarImage> GetById(int carImageId);
    }
}