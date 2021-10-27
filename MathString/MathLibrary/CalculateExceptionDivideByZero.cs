using System;

namespace MathLibrary
{
    public class CalculateExceptionDivideByZero : DivideByZeroException
    {
        public CalculateExceptionDivideByZero(string message) : base(message)
        {

        }
    }
}