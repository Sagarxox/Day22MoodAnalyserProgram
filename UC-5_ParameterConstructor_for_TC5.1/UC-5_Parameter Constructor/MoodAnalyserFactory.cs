using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace UC_5_Parameter_Constructor
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if(type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] {typeof(string)});
                    object instance = ctor.Invoke(new object[] {"HAPPY"});
                    return instance;
                }
                else
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_METHOD, "Constructor is not found");

                }
            }
            else
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.ExceptionType.NO_SUCH_CLASS, "Class is not found");
                

            }
        }
    }
}
