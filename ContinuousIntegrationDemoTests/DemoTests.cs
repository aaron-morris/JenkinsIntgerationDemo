using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit;

namespace ContinuousIntegrationDemoTests
{
    using ContinousIntegrationDemo;

    using NUnit.Framework;

    [TestFixture]
    public class DemoTests
    {
        [TestCase]
        public void DemoTest_TestPasses()
        {
            Assert.True(new Demo().Test());
        }

        [TestCase]
        public void DemoTest_TestFails()
        {
            Assert.False(new Demo().Test());
        }
    }
}
