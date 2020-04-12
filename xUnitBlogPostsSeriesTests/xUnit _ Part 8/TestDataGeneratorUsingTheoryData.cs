using Xunit;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_8
{
    public class TestDataGeneratorUsingTheoryData : TheoryData<int, int, int, int>
    {
        public TestDataGeneratorUsingTheoryData()
        {
            Add(5, 1, 3, 9);
            Add(7, 1, 5, 3);
        }
    }

    public class ParameterizedTestsWithTheory
    {
        public bool IsOddNumber(int number)
        {
            return number % 2 != 0;
        }

        [Theory]
        [ClassData(typeof(TestDataGeneratorUsingTheoryData))]
        public void AllNumbers_AreOdd_WithTheoryData(int a, int b, int c, int d)
        {
            Assert.True(IsOddNumber(a));
            Assert.True(IsOddNumber(b));
            Assert.True(IsOddNumber(c));
            Assert.True(IsOddNumber(d));
        }
    }
}