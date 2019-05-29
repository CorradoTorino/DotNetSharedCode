using System;
using System.Collections.Generic;
using System.Linq;

namespace Helper
{
    public static class GuardClauses
    {
        public static void IsNotNull(object argumentValue, string argumentName)
        {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);
        }

        public static void IsNotEmpty<T>(IList<T> argumentValue, string argumentName)
        {
            if (argumentValue == null)
                throw new ArgumentNullException(argumentName);

            if(!argumentValue.Any())
                throw new ArgumentException(argumentName);
        }
    }
}