using System;
using Blct.Concretes;
using Blct.Interfaces;
using Xunit;

namespace Blct.Tests.Concretes
{
    public class ArrayOperationsComponentTests
    {
        private IArrayOperations arrayOperations { get; set; }
        
        public ArrayOperationsComponentTests()
        {
            this.arrayOperations = new ArrayOperationsComponent();
        }

        [Fact]
        public void TestReverseMethodReverseArrayCorrectly()
        {
            // Prepare
            var given = new int[] { 1, 2, 3, 4, 5 };
            var expected = new int[] { 5, 4, 3, 2, 1 };
            
            // Perform
            var output = this.arrayOperations.Reverse(given);

            // Assert
            Assert.NotEqual(given, expected);
            Assert.Equal(output, expected);
        }

        [Fact]
        public void TestReverseMethodWithEmptyInputReturnsEmptyArray()
        {
            // Prepare
            var given = new int[] { };
            
            // Perform
            var output = this.arrayOperations.Reverse(given);

            // Assert
            Assert.Equal(output, given);
        }

        [Fact]
        public void TestReverseMethodWithNullInputThrowsException()
        {
            // Assert
            Assert.Throws<NullReferenceException>(() => this.arrayOperations.Reverse(null));
        }

        [Fact]
        public void TestDeletePartDeletesPartCorrectly()
        {
            // Prepare
            var given = new int[] { 1, 2, 3, 4, 5 };
            var position = 2;

            var expected = new int[] { 1, 3, 4, 5 };
            
            // Perform
            var output = this.arrayOperations.DeletePart(given, position);

            // Assert
            Assert.NotEqual(given, expected);
            Assert.Equal(output, expected);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(6)]
        public void TestDeletePartDeletesNothingForOutOfRangePosition(int position)
        {
            // Prepare
            var given = new int[] { 1, 2, 3, 4, 5 };

            // Perform
            var output = this.arrayOperations.DeletePart(given, position);

            // Assert
            Assert.Equal(output, given);
        }

        [Fact]
        public void TestDeleteParthMethodWithNullInputThrowsException()
        {
            // Assert
            Assert.Throws<NullReferenceException>(() => this.arrayOperations.DeletePart(null, 3));
        }
    }
}
