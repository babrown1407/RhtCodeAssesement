using System;
using Xunit;
using RhtCodeAssesement;

namespace XUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void PassAWord()
        {
            var myPhrase = "Hello GoodBye";

            var hello = Program.ReverseString(myPhrase);

            Assert.Equal("GoodBye Hello", hello);
        }
    }
}
