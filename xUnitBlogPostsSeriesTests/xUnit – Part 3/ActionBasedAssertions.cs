using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitPartTwoTests
{
    public class ActionBasedAssertions
    {
        [Fact]
        public void TestingAssertions()
        {
            //https://www.csharpcodi.com/csharp-examples/Xunit.Assert.PropertyChanged(System.ComponentModel.INotifyPropertyChanged,%20string,%20System.Func)/
            //Assert.PropertyChanged
            //Assert.RaisedEvent
            //Assert.Raises
            //Assert.RaisesAny
            //Assert.RaisesAnyAsync
            //Assert.RaisesAsync

            //Assert.Throws
            //Assert.ThrowsAny
            //Assert.ThrowsAnyAsync
            //Assert.ThrowsAsync

            // Rectord.something
        }

        [Fact]
        public void AllNumberIsEven()
        {
            var numbers = new List<int> { 2, 4, 6 };

            Action<int> allAreEven = (a) =>
            {
                Assert.True(a % 2 == 0);
            };

            Assert.All(numbers, allAreEven);
        }

        [Fact]
        public void AllNumberAreEvenAndNotZero()
        {
            var numbers = new List<int> { 2, 4, 6 };

            Assert.Collection(numbers, a => Assert.True(a == 2), a => Assert.True(a == 4), a => Assert.True(a == 6));

            // Assert.All(result, item => Assert.True(a % 2 == 0));
        }
    }
}
