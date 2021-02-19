using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        // Bunun set işlemini ctor ile yapıcaz.
        bool Success { get; }
        string Message { get; }
    }
}
