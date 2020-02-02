using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_5
{
    public class InMemoryDbContextTests : IDisposable
    {
        InMemoryDbContext  inMemoryDbContext;

        public InMemoryDbContextTests()
        {
            inMemoryDbContext = new InMemoryDbContext();
        }

        public void Dispose()
        {
            inMemoryDbContext.Dispose();
        }

        [Fact]
        public void WithNoItems_CountShouldReturnZero()
        {
            var count = inMemoryDbContext.Users.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void AfterAddingItem_CountShouldReturnOne()
        {
            inMemoryDbContext.Users.Add(new User());

            var count = inMemoryDbContext.Users.Count;

            Assert.Equal(1, count);
        }
    }
}
