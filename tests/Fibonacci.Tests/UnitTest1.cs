using Xunit;

namespace Fibonacci.Tests
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var results = await Compute.ExecuteAsync(new[] {"9", "2"});
            Assert.Equal(34, results[0]);
            Assert.Equal(2, results.Count);
        }
    }
}