using System;
using Xunit;
using Core;

namespace CoreTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Core.Delegate dlg = new Core.Delegate();
            //Assert.Equal(dlg.TestDelegate("ABC"), $"Xin chao ABC");
        }
    }
}
