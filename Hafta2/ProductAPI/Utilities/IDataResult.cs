﻿namespace ProductAPI.Utilities
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
