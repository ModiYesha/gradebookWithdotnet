using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book();
            book.AddGrade(20.69);
            book.AddGrade(30.65);

            //act 
            //var result = book.Statistic;

            //assert 
            //Assert.Equal(low,'');
        }
    }
}
