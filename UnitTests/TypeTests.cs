using CSharpFundamentals;

namespace UnitTests
{
    public class TypeTests
    {
        [Fact]
        public void Test()
        {
            Book bookOne = GetBook("BookOne");
            Book bookTwo = GetBook("BookTwo");

            Assert.Equal("BookOne", bookOne.Name);
            Assert.Equal("BookTwo", bookTwo.Name);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
