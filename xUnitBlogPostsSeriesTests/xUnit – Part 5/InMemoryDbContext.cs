using System;
using System.Collections.Generic;
using System.Text;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_5
{
    public class User
    {

    }

    public class InMemoryDbContext : IDisposable
    {
        public List<User> Users { get; internal set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
