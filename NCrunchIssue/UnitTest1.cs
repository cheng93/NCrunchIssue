using Xunit;

namespace NCrunchIssue
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(true);
        }

        [CustomFact]
        public void Test2()
        {
            Assert.True(true);
        }
    }
}
