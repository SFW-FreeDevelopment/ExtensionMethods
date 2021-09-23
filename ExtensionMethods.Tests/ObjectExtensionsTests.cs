using Xunit;

namespace ExtensionMethods.Tests
{
    public class ObjectExtensionsTests
    {
        #region IsNull
        [Fact]
        public void IsNull_Returns_True_WhenValueIsNull()
        {
            object value = null;
            bool result = value.IsNull();
            
            Assert.True(result);
        }
        
        [Fact]
        public void IsNull_Returns_False_WhenValueIsNotNull()
        {
            object value = new object();
            bool result = value.IsNull();
            
            Assert.False(result);
        }
        #endregion
        
        #region IsNotNull
        [Fact]
        public void IsNotNull_Returns_True_WhenValueIsNotNull()
        {
            object value = new object();
            bool result = value.IsNotNull();
            
            Assert.True(result);
        }
        
        [Fact]
        public void IsNotNull_Returns_False_WhenValueIsNull()
        {
            object value = null;
            bool result = value.IsNotNull();
            
            Assert.False(result);
        }
        #endregion
    }
}