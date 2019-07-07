using System;
using Xunit;
using SimpleAPI.Controllers;


namespace SimpleAPI.TEST
{
    public class UnitTest1
    {
        ValuesController vc = new ValuesController();

        [Fact]
        public void Test1()
        {
            var valueFromControler = vc.Get(1);

            Assert.Equal("Michal Dudek", valueFromControler.Value);    
        }

        [Fact]
        public void Test2()
        {
            var valueFromControler = vc.Get(2);

            Assert.Equal("Justyna Dudek", valueFromControler.Value);    
        }
    }
}
