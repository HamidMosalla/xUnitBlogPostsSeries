using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace xUnitBlogPostsSeriesTests.xUnit___Part_3
{
    public class Buggy
    {
        public void ThrowsInvalidCastException()
        {
            throw new InvalidCastException();
        }

        public void ThrowsCustomInvalidOperationException()
        {
            throw new CustomInvalidOperationException();
        }

        public Task ThrowsExceptionAsync()
        {
            throw new InvalidCastException();
        }
    }


    public class CustomInvalidOperationException : InvalidOperationException
    {

    }
}
