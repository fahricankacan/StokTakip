﻿using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunService
    {
        IResult Add(Urun urun);
        IResult Update(Urun urun);
        IResult Delete(Urun urun);
        IDataResult<List<Urun>> GetAll();

    }
}
