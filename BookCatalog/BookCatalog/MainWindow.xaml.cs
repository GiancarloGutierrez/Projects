using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataAccess;

namespace BookCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region "Global Selection"
        Book selectedBook;
        bool editing = false;
        #endregion
        #region "Start Up"
        public MainWindow()
        {
            InitializeComponent();
            btnAddNew.Visibility = Visibility.Hidden;
            btnDelete.Visibility = Visibility.Hidden;
            var CategoriesList = Utility.getCategories();
            cmbCategory.ItemsSource = CategoriesList;
            cmbCategory.SelectedItem = "Fiction";
            
            var BookList = Utility.getBooks();
            dgBooks.ItemsSource = BookList;
            dgBooks.SelectionUnit = DataGridSelectionUnit.Cell;
            dgBooks.IsReadOnly = true;
        }
        #endregion
        #region "Buttons"
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(txtTitle.Text == string.Empty)
            {
                MessageBox.Show("Title Cannot be Empty");
                return;
            }
            if(txtAuthor.Text == string.Empty)
            {
                MessageBox.Show("Author Cannot Be Empty");
                return;
            }
            if(!int.TryParse(txtEdition.Text, out int n))
            {
                MessageBox.Show("Edition Must be An Integer");
                return;
            }
            if(!double.TryParse(txtISBN.Text, out double y))
            {
                MessageBox.Show("ISBN Must be an Integer");
                return;
            }

            double isbn = double.Parse(txtISBN.Text.ToString());
            int edition = int.Parse(txtEdition.Text.ToString());
            if (editing)
            {
                Utility.updateBook(selectedBook.BookID,txtTitle.Text.ToString(), edition, isbn, txtAuthor.Text.ToString(), cmbCategory.SelectedItem.ToString());
                
            }
            else
            {
                Utility.createBook(txtTitle.Text.ToString(), edition, isbn, txtAuthor.Text.ToString(), cmbCategory.SelectedItem.ToString());
                
            }
            reset();
        }
        private void dgBooks_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {   
            if(editing)
            {
                return;
            }
            if (GetSelectedRowIndex() < 0) return;
            else if (GetSelectedRowIndex() > dgBooks.Items.Count - 1) return;
            else
            {
                editing = true;
                SelectBookFromCellSelected();
                LoadBookSelectionFields();
                btnSubmit.Content = "Update";
                btnAddNew.Visibility = Visibility.Visible;
                btnDelete.Visibility = Visibility.Visible;
                MessageBox.Show("Edit Book Mode");
            }
        }
        private void btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            reset();
            MessageBox.Show("Add Book Mode");
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Utility.deleteBook(selectedBook.BookID);
            reset();
            MessageBox.Show("Book Deleted");
        }
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            reset();
        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            if(txtSearch.Text == string.Empty)
            {
                reset();
                return;
            }
            var BookList = Utility.searchBooks(txtSearch.Text);
            dgBooks.ItemsSource = BookList;
            dgBooks.SelectionUnit = DataGridSelectionUnit.Cell;
            dgBooks.IsReadOnly = true;
        }
        #endregion
        #region "Functions"
        private void reset()
        {
            btnSubmit.Content = "Submit";
            editing = false;
            btnDelete.Visibility = Visibility.Hidden;
            btnAddNew.Visibility = Visibility.Hidden;
            txtSearch.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtEdition.Text = string.Empty;
            txtISBN.Text = string.Empty;
            cmbCategory.SelectedItem = "Fiction";
            reloadBooks();
        }
        private void reloadBooks()
        {
            var BookList = Utility.getBooks();
            dgBooks.ItemsSource = BookList;
            dgBooks.SelectionUnit = DataGridSelectionUnit.Cell;
            dgBooks.IsReadOnly = true;
        }
        private string GetSelectedCellValue()
        {
            DataGridCellInfo cellInfo = dgBooks.SelectedCells[0];
            if (cellInfo == null) return null;

            DataGridBoundColumn column = cellInfo.Column as DataGridBoundColumn;
            if (column == null) return null;

            FrameworkElement element = new FrameworkElement() { DataContext = cellInfo.Item };
            BindingOperations.SetBinding(element, TagProperty, column.Binding);

            return element.Tag.ToString();
        }
        private int GetSelectedRowIndex()
        {
            int rowIndex = dgBooks.Items.IndexOf(dgBooks.CurrentItem);
            return rowIndex;
        }
        private void SelectBookFromCellSelected()
        {
            int rowIndex = GetSelectedRowIndex();
            DataGridRow row = (DataGridRow)dgBooks.ItemContainerGenerator.ContainerFromIndex(rowIndex);
            selectedBook = (Book)row.Item;
        }
        private void LoadBookSelectionFields()
        {
            if (!editing) return;
            txtTitle.Text = selectedBook.Title;
            txtAuthor.Text = selectedBook.Author;
            txtEdition.Text = selectedBook.Edition.ToString();
            txtISBN.Text = selectedBook.ISBN.ToString();
            cmbCategory.SelectedItem = selectedBook.Category;
        }
        #endregion
    }
}
