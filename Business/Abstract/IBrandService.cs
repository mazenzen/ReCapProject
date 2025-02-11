﻿using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();

        IResult Add(Brand brand);
        IResult Delete(Brand brand);
        IResult Update(Brand brand);


        IDataResult<List<Brand>> GetById(int brandId);

        IDataResult<List<Brand>> GetAllByBrandId(int id);




    }
}
