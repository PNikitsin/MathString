using System;

namespace MathLibrary
{
    public class CalculateExceptionInvalidExpression : Exception
    {
        public CalculateExceptionInvalidExpression(string message) : base(message)
        {

        }
    }
}