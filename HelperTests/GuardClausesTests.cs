using System;
using Helper;
using NUnit.Framework;

namespace HelperTests
{
    public class GuardClausesTests
    {
        [Test]
        public void TestIsNotNullThrowExceptionIfArgumentIsNull()
        {
            Assert.Throws<ArgumentNullException>(
                () => MethodGuardingArgumentIsNotNull(null),
                "GuardClauses.IsNotNull did not throw ArgumentNullException");
        }

        [Test]
        public void TestIsNotNullDoesNotThrowExceptionIfArgumentIsNotNull()
        {
            MethodGuardingArgumentIsNotNull(new object());
        }

        private static void MethodGuardingArgumentIsNotNull(object theArgument)
        {
            GuardClauses.IsNotNull(theArgument, nameof(theArgument));
        }
    }
}