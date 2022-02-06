using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<CarDetailDto>> GetCarsByBrandName(string brandName);
        IDataResult<List<CarDetailDto>> GetCarsByColorName(string colorName);
        IDataResult<List<CarDetailDto>> GetCarsByDailyPrice(decimal min,decimal max);
        IDataResult<List<CarDetailDto>> GetCarList();
        IDataResult<List<CarDetailDto>> GetCarDetailById(int carId);
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);

        IResult TransactionalOperation(Car car);

    }
}
