using System;

namespace MathLibrary
{
    public class CalculateExceptionStringIsEmpty : InvalidOperationException
    {
        public CalculateExceptionStringIsEmpty(string message) : base(message)
        {

        }
    }
}