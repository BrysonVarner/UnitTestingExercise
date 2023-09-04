using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(7, 9, 1, 17)]
        [InlineData(0, 6, 3, 9)]
        [InlineData(4, 2, 1, 7)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var addTest = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = addTest.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual); 
        }

        [Theory]
        [InlineData( 5, 4, 1)]//Add test data <-------
        [InlineData( 14, 9, 5)]
        [InlineData( 6, 12, -6)]
        [InlineData( 20, 10, 10)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var subtractTest = new Calculator();
            //Act
            var actual = subtractTest.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData( 5, 5, 25)]//Add test data <-------
        [InlineData( 7, 2, 14)]
        [InlineData( 8, 8, 64)]
        [InlineData( 6, 3, 18)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:
            //Arrange
            var multiplyTest = new Calculator();
            //Act
            var actual = multiplyTest.Multiply(num1,num2);
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData( 10, 2 , 5)]//Add test data <-------
        [InlineData( 100, 5, 20)]
        [InlineData( 63, 9, 7)]
        [InlineData( 18, 6, 3)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var divideTest = new Calculator();
            //Act
            var result = divideTest.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, result);
        }

    }
}
