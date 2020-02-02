using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_5
{
    public class SharedInMemoryDbContextTests : IClassFixture<InMemoryDbContextFixture>
    {
        InMemoryDbContextFixture fixture;

        public SharedInMemoryDbContextTests(InMemoryDbContextFixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void WithNoItems_CountShouldReturnZero()
        {
            var count = fixture.Context.Users.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void AfterAddingItem_CountShouldReturnOne()
        {
            fixture.Context.Users.Add(new User());

            var count = fixture.Context.Users.Count;

            Assert.Equal(1, count);
        }
    }
}
