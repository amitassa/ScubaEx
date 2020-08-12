using System;
using System.Collections.Generic;
using System.Text;

namespace ScubaEx
{
    public class ScubaException : Exception
    {
        public int studentNumber { get; }
        public ScubaException(string exceptionMessage, int studentNumber) : base(exceptionMessage)
        { }
    }
}
