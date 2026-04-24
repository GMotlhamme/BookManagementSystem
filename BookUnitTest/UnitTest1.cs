using BookManagementSystem.Models;

namespace BookUnitTest
{
    public class UnitTest1
    {
        
        [Fact]
        public void IsAvailable_shouldReturnTrue()
        {   
            var book = new Book();
            bool result = book.IsAvailable(5);

            Assert.True(result);
        }

        [Fact]
        public void IsAvailable_shouldReturnFalse()
        {
            //Arrange
            var book = new Book();
            //Act
            bool result = book.IsAvailable(0);
            //Assert
            Assert.False(result, "Test that a book is NOT available");
        }


        [Fact]
        public void IsAvailable_checkIfDataTypesAreCorrect()
        {
            //Arrange

            var book = new Book();
            string expetedTitle = "Database Systems";
            string expectedAuthor = "John Smith";
            string expectedCategory = "IT";


            //Act 
            book.Title = "Database Systems";
            book.Author = "John Smith";
            book.Category = "IT";

            Assert.Equal(expetedTitle, book.Title);
            Assert.Equal(expectedAuthor, book.Author);
            Assert.Equal(expectedCategory, book.Category);
        }



    }
}
