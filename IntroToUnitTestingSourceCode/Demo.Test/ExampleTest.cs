using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;
using Xunit;
using System.IO;

namespace Demo.Test
{
    public class ExampleTest
    {
        [Fact]
        public void ExampleLoadTestFile_shouldReturnString()
        {
            string expected = Examples.ExampleLoadTextFile("This is my New Project to learn Unit Testin");
            Assert.True(expected.Length > 10);
        }
        //[Fact]
        //public void ExampleLoadTestFile_shouldReturnException()
        //{
        //    Assert.Throws<System.IO.FileNotFoundException>(() => Examples.ExampleLoadTextFile("fdsf"));
        //}

        [Fact]
        public void ExampleLoadTestFile_ShouldReturnArguementException()
        {
            Assert.Throws<ArgumentException>("file", () => Examples.ExampleLoadTextFile("sd"));
        }
    }


}
