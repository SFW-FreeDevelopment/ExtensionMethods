using System.Collections.Generic;
using Xunit;

namespace ExtensionMethods.Tests
{
    public class IEnumerableExtensionsTests
    {
       
        [Fact]
        public void IsNullOrEmpty_True_WhenValueIsNull()
        {
            IEnumerable<object> value = null;
            var result = value.IsNullOrEmpty();
            
            Assert.True(result);
        }
        
        [Fact]
        public void IsNullOrEmpty_True_WhenValueIsEmpty()
        {
            IEnumerable<object> value = new object[] { };
            var result = value.IsNullOrEmpty();
            
            Assert.True(result);
        }
        
        [Fact]
        public void IsNullOrEmpty_Value_WhenValueIsNotNullOrEmpty()
        {
            IEnumerable<object> value = new object[] { new object() };
            var result = value.IsNullOrEmpty();
            
            Assert.False(result);
        }
    }
}