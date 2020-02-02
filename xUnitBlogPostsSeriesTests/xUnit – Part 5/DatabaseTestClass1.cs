using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_5
{
    [CollectionDefinition("Context collection")]
    public class InMemoryDbContextFixtureCollection : ICollectionFixture<InMemoryDbContextFixture>
    {
        // This class has no code, and is never created. Its purpose is simply
        // to be the place to apply [CollectionDefinition] and all the
        // ICollectionFixture<> interfaces.
    }
}
