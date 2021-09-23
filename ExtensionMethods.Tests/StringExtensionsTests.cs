using Xunit;

namespace ExtensionMethods.Tests
{
    public class StringExtensionsTests
    {
        [Fact]
        public void IsNotNullOrEmpty_False_WhenValueIsNull()
        {
            string value = null;
            var result = value.IsNotNullOrEmpty();
            
            Assert.False(result);
        }
        
        [Fact]
        public void IsNotNullOrEmpty_False_WhenValueIsEmpty()
        {
            string value = "";
            var result = value.IsNotNullOrEmpty();
            
            Assert.False(result);
        }
        
        [Fact]
        public void IsNotNullOrEmpty_True_WhenValueIsNotNullOrEmpty()
        {
            string value = "some value";
            var result = value.IsNotNullOrEmpty();
            
            Assert.True(result);
        }
    }
}