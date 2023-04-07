using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    public class Validator
    {
        
        public static void AssertOnPositiveValue(int value)
        {
            StackTrace stacktrace = new StackTrace();
            if (value <= 0)
                throw new ArgumentException($"the value in class " +
                    $"{stacktrace.GetFrame(1).GetMethod().DeclaringType.Name} " +
                    $"method {stacktrace.GetFrame(1).GetMethod().Name} " +
                    $"is not supposed to be negative");
        }
        public static void AssertOnPositiveValue(double value)
        {
            StackTrace stacktrace = new StackTrace();
            if (value <= 0)
                throw new ArgumentException($"the value in class " +
                    $"{stacktrace.GetFrame(1).GetMethod().DeclaringType.Name} " +
                    $"method {stacktrace.GetFrame(1).GetMethod().Name} " +
                    $"is not supposed to be negative");
        }
        public static void AssertValueInRange(int value, int min, int max)
        {
            StackTrace stacktrace = new StackTrace();
            if (value < min || value > max)
                throw new ArgumentException($"the value in class " +
                    $"{stacktrace.GetFrame(1).GetMethod().DeclaringType.Name} " +
                    $"method {stacktrace.GetFrame(1).GetMethod().Name} " +
                    $"is suposed to be between {min} and {max}");
        }
        public static void AssertValueInRange(double value, int min, int max)
        {
            StackTrace stacktrace = new StackTrace();
            if (value < min || value > max)
                throw new ArgumentException($"the value in class " +
                    $"{stacktrace.GetFrame(1).GetMethod().DeclaringType.Name} " +
                    $"method {stacktrace.GetFrame(1).GetMethod().Name} " +
                    $"is suposed to be between {min} and {max}");
        }
    }
}
