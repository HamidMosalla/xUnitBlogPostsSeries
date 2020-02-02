using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_5
{
    [Collection("Context collection")]
    public class ContextTestClass1
    {
        InMemoryDbContextFixture fixture;

        public ContextTestClass1(InMemoryDbContextFixture fixture)
        {
            this.fixture = fixture;
        }
    }

    [Collection("Context collection")]
    public class ContextTestClass2
    {
        // ...
    }
}
