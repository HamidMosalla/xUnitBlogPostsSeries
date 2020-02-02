using System;
using System.Collections.Generic;
using System.Text;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_5
{
    public class InMemoryDbContextFixture : IDisposable
    {
        public InMemoryDbContextFixture()
        {
            Context = new InMemoryDbContext();

            // ... initialize data in the test database ...
        }

        public void Dispose()
        {
            // ... clean up test data from the database ...
        }

        public InMemoryDbContext Context { get; private set; }
    }
}
