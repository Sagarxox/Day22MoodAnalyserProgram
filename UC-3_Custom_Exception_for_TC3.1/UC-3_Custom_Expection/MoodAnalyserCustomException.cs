using System;
using System.Collections.Generic;
using System.Text;

namespace UC_3_Custom_Expection
{
    public class MoodAnalyserCustomException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }
        public readonly ExceptionType type;
        public MoodAnalyserCustomException(ExceptionType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
