using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyzerProblems
{
    public class MoodAnalyseFactory
    {
        public static object CreateMoodAnalysis(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzeType = executing.GetType(className);
                    return Activator.CreateInstance(MoodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "No Constructor is Found");
            }
        }
        ///<sumary>
        ///create moodAnalyse Method Method to create Object of ModdAnalyze Class
        ///</sumary>
        ///<param name="className"></param>
        ///<param name="constructoreName"></param>
        ///<param name="message"></param>
        ///<returns></returns>
        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className, string constructorName, string message)
        { 
        Type type= typeof(MoodAnalyzer);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructor = type.GetConstructor(new[] { typeof(string) });
                    object instance = constructor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "Class not Found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
        public static string InvokeAnalyzerMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzerProblems.MoodAnalyzer");
                object moodAnalyzeObject = MoodAnalyseFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerProblems.MoodAnalyzer", "MoodAnalyzer", message);
                MethodInfo methodInfo = type.GetMethod(methodName);
                object mood = methodInfo.Invoke(moodAnalyzeObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException)
            {
               throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not Found");
            }
        }
        ///<summary>
        ///Method to Set The Field Dynamically using Reflection
        ///</summary>
        ///<param name="moodAnalyzeObject"></param>
        ///<param name="message"></param>
        public static string SetField(string message, string fieldName)
        {
            try
            {
                MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
                Type type = typeof(MoodAnalyzer);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (message == null)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_FIELD, "Message Should not be null");
                }
                field.SetValue(moodAnalyzer, message);
                return moodAnalyzer.message;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_FIELD, "Field is  not Found");
            }
        }
    }
}
