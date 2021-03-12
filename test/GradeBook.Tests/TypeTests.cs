using System;
using Xunit;

namespace GradeBook.Tests
{
    public class TypeTests
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            //Given
            string name = "Henry";
            //When
            string upper = MakeUpperCase(name);
            //Then
            Assert.Equal("HENRY", upper);
            Assert.Equal("Henry", name);
        }

        private string MakeUpperCase(string name)
        {
            return name.ToUpper();
        }

        [Fact]
        public void ReturnInt()
        {
            //Given
            var x = GetInt();
            //When
            SetInt(ref x);
            //Then
            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByValue()
        {
            var book1 = GetBook("Atlas Shrugged");
            GetBookSetName(ref book1, "Atlas did NOT shrug");

            Assert.Equal("Atlas did NOT shrug", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        } 
 
        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Atlas Shrugged");
            GetBookSetName(book1, "Atlas did NOT shrug");

            Assert.Equal("Atlas Shrugged", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Atlas Shrugged");
            Setname(book1, "Atlas did NOT shrug");

            Assert.Equal("Atlas did NOT shrug", book1.Name);
        } 

        private void Setname(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void BookReturns()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");


            //assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }
        [Fact]
        public void SameObjectPointerReturn()
        {
            //arrange
            var book1 = GetBook("Book 1");
            var book2 = book1;


            //assert
            Assert.Same(book2, book1);
            Assert.True(Object.ReferenceEquals(book2, book1));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
