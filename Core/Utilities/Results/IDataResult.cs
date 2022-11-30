using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        //success ve result IResulttan geliyor ve ek olarak Data var
        T Data { get; }
    }
}