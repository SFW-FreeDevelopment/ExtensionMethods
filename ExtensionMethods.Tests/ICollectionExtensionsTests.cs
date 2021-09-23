using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace ExtensionMethods.Tests
{
    public class ICollectionExtensionsTests
    {
        [Fact]
        public void IsNullOrEmpty_True_WhenValueIsNull()
        {
            ICollection value = null;
            var result = value.IsNullOrEmpty();
            
            Assert.True(result);
        }
        
        [Fact]
        public void IsNullOrEmpty_True_WhenValueIsEmpty()
        {
            ICollection value = new List<object>();
            var result = value.IsNullOrEmpty();
            
            Assert.True(result);
        }
        
        [Fact]
        public void IsNullOrEmpty_Value_WhenValueIsNotNullOrEmpty()
        {
            ICollection value = new List<object>() { new object() };
            var result = value.IsNullOrEmpty();
            
            Assert.False(result);
        }
    }
}