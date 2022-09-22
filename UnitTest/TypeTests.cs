
using CSharpFundamentals;

namespace UnitTest
{
    public class TypeTests
    {
        [Fact]
        public void Test()
        {
            Book bookOne = GetBook("BookOne");
            Book bookTwo = GetBook("BookTwo");

            Assert.Equal("BookOne", bookOne._name);
            Assert.Equal("BookTwo", bookTwo._name);
        }

        private Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
