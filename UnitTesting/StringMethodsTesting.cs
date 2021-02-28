using Testing_Assignment_2.StringMethods;
using Xunit;

namespace UnitTesting
{
    public class StringMethodsTesting
    {
        [Theory]
        [InlineData("teststring", "TESTSTRING")]
        [InlineData("TESTSTRING", "teststring")]
        [InlineData("test123", "TEST123")]
        [InlineData("", null)]
        [InlineData(null, null)]
        public void UpperLower(string str, string expected)
        {
            //Arrange

            //Act
            var result = StringMethods.UpperLower(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("TEST", "TEST")]
        [InlineData("TEST123", "TEST123")]
        [InlineData("", "")]
        [InlineData(null, null)]
        public void TitleCase(string str, string expected)
        {
            //Arrange

            //Act
            var result = StringMethods.TitleCase(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("test", true)]
        [InlineData("test lower case", false)] //Space is not a LowerCase Character
        [InlineData("TEST", false)]
        [InlineData("TEST123", false)]
        [InlineData("test123", false)] //Not all characters are LowerCase
        [InlineData("123", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void FindLower(string str, bool expected)
        {
            //Arrange

            //Act
            var result = StringMethods.FindLower(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("TEST", true)]
        [InlineData("TEST TITLE CASE", false)] //Space is not an UpperCase Character
        [InlineData("test", false)]
        [InlineData("test123", false)]
        [InlineData("TEST123", false)] //Not all characters are UpperCase
        [InlineData("123", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void FindUpper(string str, bool expected)
        {
            //Arrange

            //Act
            var result = StringMethods.FindUpper(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("test", "Test")]
        [InlineData("TEST", "TEST")]
        [InlineData("test test test", "Test test test")]
        [InlineData("tEST", "TEST")]
        [InlineData("test123", "Test123")]
        [InlineData("123", "123")]
        [InlineData("", null)]
        [InlineData(null, null)]
        public void FirstUpper(string str, string expected)
        {
            //Arrange

            //Act
            var result = StringMethods.FirstUpper(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("test", "tes")]
        [InlineData("TEST", "TES")]
        [InlineData("1234", "123")]
        [InlineData("", null)]
        [InlineData("t", "")]
        [InlineData(null, null)]
        public void RemoveLast(string str, string expected)
        {
            //Arrange

            //Act
            var result = StringMethods.RemoveLast(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("test", 1)]
        [InlineData("test words", 2)]
        [InlineData("", 0)]
        [InlineData(" ", 0)]
        [InlineData("  ", 0)]
        [InlineData("Test words  ", 2)]
        [InlineData(null, 0)]
        public void WordCount(string str, int expected)
        {
            //Arrange

            //Act
            var result = StringMethods.WordCount(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1", true)]
        [InlineData("0", true)]
        [InlineData("-1", true)]
        [InlineData("00", true)]
        [InlineData("", false)]
        [InlineData("a", false)]
        [InlineData("0a", false)]
        [InlineData(null, false)]
        public void FindNumber(string str, bool expected)
        {
            //Arrange

            //Act
            var result = StringMethods.FindNumber(str);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("1", 1)]
        [InlineData("0", 0)]
        [InlineData("-1", -1)]
        [InlineData("00", 00)]
        [InlineData("", null)]
        [InlineData("a", null)]
        [InlineData("0a", null)]
        [InlineData(null, null)]
        public void ConvertToInt(string str, double? expected)
        {
            //Arrange

            //Act
            var result = StringMethods.ConvertToInt(str);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
