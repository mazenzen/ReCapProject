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
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();

        IDataResult<Color> GetById(int colorId);

        IDataResult<List<Color>> GetAllByColorId(int id);


        IResult Add(Color color);
        IResult Delete(Color color);
        IResult Update(Color color);

    }
}
