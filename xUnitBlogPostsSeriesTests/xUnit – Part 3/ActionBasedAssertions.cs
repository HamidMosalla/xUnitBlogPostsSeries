using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using xUnitBlogPostsSeriesTests.xUnit___Part_3;

namespace XUnitPartTwoTests
{
    public class ActionBasedAssertions
    {
        [Fact]
        public async Task RaiseEventAssertions()
        {
            var messageSender = new Message();

            var receivedEvent = Assert.Raises<MessageEventArgs>(
             a => messageSender.SendMessageEvent += a,
             a => messageSender.SendMessageEvent -= a,
             () => messageSender.SendMessageToUser("This is an event message"));
            Assert.NotNull(receivedEvent);
            Assert.Equal("This is an event message", receivedEvent.Arguments.Message);


            var receivedEvent2 = Assert.RaisesAny<MessageEventArgs>(
            a => messageSender.SendMessageEvent += a,
            a => messageSender.SendMessageEvent -= a,
            () => messageSender.SendMessageToUser("This is an event message"));
            Assert.NotNull(receivedEvent2);
            Assert.Equal("This is an event message", receivedEvent2.Arguments.Message);


            var receivedEventTask = Assert.RaisesAsync<MessageEventArgs>(
            a => messageSender.SendMessageEvent += a,
            a => messageSender.SendMessageEvent -= a,
            async () => messageSender.SendMessageToUser("This is an event message"));
            var receivedEventAsync = await receivedEventTask;
            Assert.NotNull(receivedEventAsync);
            Assert.Equal("This is an event message", receivedEventAsync.Arguments.Message);
        }

        [Fact]
        public void ThrowsExceptionAssertions()
        {
            //Assert.Throws
            //Assert.ThrowsAny
            //Assert.ThrowsAnyAsync
            //Assert.ThrowsAsync

            // Exception ex = Record.Exception(() => someCode());
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

        [Fact]
        public void ShouldClearWithEvents()
        {
            // arrange
            var target = new ObservableStack<string>();

            target.Push("1");

            // act
            Assert.PropertyChanged(target, "Count", () => target.Clear());

            // assert
            Assert.True(target.Count == 0);
        }
    }
}
