using System;
using Xunit;
using xUnitPartOne.Controllers;

namespace XUnitPartOneTests
{
    public class HomeControllerTests
    {
        private HomeController _sut;

        public HomeControllerTests()
        {
            _sut = new HomeController();
        }

        [Fact]
        public void HomeController_Index_Always_ReturnTheCorrectType()
        {
            var viewResult = _sut.Index();

            Assert.NotNull(viewResult);
        }
    }
}
