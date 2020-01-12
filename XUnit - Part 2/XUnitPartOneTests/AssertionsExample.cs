using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitPartTwoTests
{
    public class AssertionsExample
    {

        [Fact]
        public void TestingAssertions()
        {
            //Assert.Contains("text", "This is a text.");

            //var names = new List<string> { "Picard", "Kirk" };

            //Assert.Contains(names, n => n == "Kirk");

            //Assert.DoesNotContain("sdf", "This is a text.");

            //Assert.True("e".GetType() == typeof(string));
            //Assert.False(11.GetType() == typeof(int));

            //var regEx = @"\A[A-Z0-9+_.-]+@[A-Z0-9.-]+\Z";
            //Assert.DoesNotMatch(regEx, "this is a text");
            //Assert.Matches(regEx, "this is a text");


            //var set1 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
            //var set2 = new HashSet<int> { 3, 4 };
            //var notProperSubset = new HashSet<int> { 1, 2, 3, 4, 5, 6 };

            //Assert.Subset(set1, set2);

            //Assert.ProperSubset(set1, set2);

            //// fails, https://mathinsight.org/definition/proper_subset
            //Assert.ProperSubset(set1, notProperSubset);

            //var set3 = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
            //var set4 = new HashSet<int> { 3, 4 };
            //var notProperSuperSet = new HashSet<int> { 1, 2, 3, 4, 5, 6 };

            //Assert.Superset(set4, set3);
            //Assert.ProperSuperset(set4, notProperSuperSet);

            //// fails
            //Assert.ProperSuperset(set3, notProperSuperSet);

            //Assert.Equal("text", "Text");
            //Assert.NotEqual("text", "Text");

            //Assert.Empty(new List<int> { });
            //Assert.NotEmpty(new List<int> { 1 });

            //Assert.InRange(3, 1, 6);
            //Assert.NotInRange(3, 1, 2);

            //var listWithSingle = new List<int> { 1 };
            //Assert.Single(listWithSingle);



             Assert.IsType<string>("passes");

            Assert.IsNotType<string>(1);
            Assert.IsNotType<string>("fails");

            Assert.IsAssignableFrom<IEnumerable<int>>(new List<int>());
            Assert.IsAssignableFrom<IDictionary<int, string>>(new List<int>());


            Assert.Null(null);
            Assert.NotNull(new List<int>());

            var obj1 = new object();
            var obj2 = obj1;
            var obj3 = new object();

            Assert.Same(obj1, obj2);
            Assert.NotSame(obj1, obj3);

             // It's better to call Assert.Same() instead.
             // Assert.ReferenceEquals(obj1, obj2);

            /* 
            Strictly relies on the built-in behavior of val1.Equals(val2),
            since Assert.Equal attempts to do a lot of reconciliation to get
            the correct answer for collections, etc.
            TODO: find a compelling example for it
             */
            Assert.StrictEqual(1, 1);
            Assert.NotStrictEqual(1, 1);









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
