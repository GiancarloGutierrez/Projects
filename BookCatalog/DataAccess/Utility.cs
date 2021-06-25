using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public static class Utility
    {
       #region "Book CRUD and Search"
        public static List<Book> getBooks()
        {
            LibraryEntities dtBooks = new LibraryEntities();
            return dtBooks.Books.ToList();
        }
        public static void updateBook(int id, string title, int edition, double isbn, string author, string category)
        {
            LibraryEntities dtBooks = new LibraryEntities();
            var alter = dtBooks.Books.Where(x => x.BookID == id).Single();
            alter.Title = title;
            alter.Edition = edition;
            alter.ISBN = isbn;
            alter.Author = author;
            alter.Category = category;

            dtBooks.SaveChanges();
        }
        public static void createBook(string title, int edition, double isbn, string author, string category)
        {
            LibraryEntities dtBooks = new LibraryEntities();
            Book newBook = new Book();
            newBook.Title = title;
            newBook.Author = author;
            newBook.Edition = edition;
            newBook.ISBN = isbn;
            newBook.Category = category;
            dtBooks.Books.Add(newBook);
            dtBooks.SaveChanges();
        }
        public static void deleteBook(int id)
        {
            LibraryEntities dtBooks = new LibraryEntities();
            dtBooks.Books.Remove(dtBooks.Books.Where(x => x.BookID == id).Single());
            dtBooks.SaveChanges();

        }
        public static List<Book> searchBooks(string param)
        {
            LibraryEntities dtBooks = new LibraryEntities();
            List<Book> bookList;
            if (Double.TryParse(param, out double z))
            {
                List<Book> bookListFull = getBooks();
                if (int.TryParse(param, out int v))
                {
                    bookList = bookListFull.Where(x => (x.Edition.ToString()+x.ISBN.ToString()).Contains(param)).ToList();
                }
                else
                {
                    bookList = bookListFull.Where(x => x.ISBN.ToString().Contains(param)).ToList();
                }
            }
            else
            {
                bookList = dtBooks.Books.Where(x => (x.Title.ToUpper() + x.Author.ToUpper() + x.Category.ToUpper() +x.Edition.ToString()).Contains(param.ToUpper())).ToList();
            }
            return bookList;
        }
        #endregion
       #region "Category CRUD and Search"
        public static List<string> getCategories()
        {
            LibraryEntities dtCategories = new LibraryEntities();
            List<string> listR = new List<string>();
            foreach (Category  c in dtCategories.Categories.ToList()) {
                listR.Add(c.CategoryName);
            }
            return listR;
        }
        public static void updateCategory()
        {

        } // No Current Implementation 
        public static void createCategory()
        {

        } // No Current Implementation
        public static void deleteCategory()
        {

        } // No Current Implementation
        #endregion
    }
}
