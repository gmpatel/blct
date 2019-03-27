using System;
using Blct.Concretes;
using Blct.Interfaces;
using Blct.WebApi.Controllers;
using Blct.WebApi.Objects;
using Xunit;

namespace Blct.Tests.WebApi
{
    /*********************************************************************
    
    As we have tests for the injected dependecy for this controller and 
    the controller has no business loging going on, the tests are not 
    require for controller `ArraycalcController`, but just to illustrate
    how can we test controller if we have business logic in the conroller 
    class...

    **********************************************************************/

    public class ArraycalcControllerTests
    {
        private ArraycalcController arraycalcController { get; set; }
        
        public ArraycalcControllerTests()
        {
            this.arraycalcController = new ArraycalcController(new ArrayOperationsComponent());
        }

        [Fact]
        public void TestReverseMethodReverseArrayCorrectly()
        {
            // Prepare
            var given = new RequestReverseParameters {
                ProductIds = new int[] { 1, 2, 3, 4, 5 }
            };
            var expected = new int[] { 5, 4, 3, 2, 1 };
            
            // Perform
            var output = this.arraycalcController.Reverse(given).Value;

            // Assert
            Assert.NotEqual(given.ProductIds, expected);
            Assert.Equal(output, expected);
        }

        [Fact]
        public void TestReverseMethodWithEmptyInputReturnsEmptyArray()
        {
            // Prepare
            var given =  new RequestReverseParameters {
                ProductIds = new int[] { }
            };

            // Perform
            var output = this.arraycalcController.Reverse(given).Value;

            // Assert
            Assert.Equal(output, given.ProductIds);
        }

        [Fact]
        public void TestDeletePartDeletesPartCorrectly()
        {
            // Prepare
            var given = new RequestDeletePartParameters {
                ProductIds = new int[] { 1, 2, 3, 4, 5 },
                Position = 2
            };

            var expected = new int[] { 1, 3, 4, 5 };
            
            // Perform
            var output = this.arraycalcController.DeletePart(given).Value;

            // Assert
            Assert.NotEqual(given.ProductIds, expected);
            Assert.Equal(output, expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(6)]
        public void TestDeletePartDeletesNothingForOutOfRangePosition(int position)
        {
            // Prepare
            var given = new RequestDeletePartParameters {
                ProductIds = new int[] { 1, 2, 3, 4, 5 },
                Position = position
            };

            // Perform
            var output = this.arraycalcController.DeletePart(given).Value;

            // Assert
            Assert.Equal(output, given.ProductIds);
        }
    }
}
