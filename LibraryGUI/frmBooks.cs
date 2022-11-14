using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFCodeFirst;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace LibraryGUI
{
    public partial class frmBooks : Form
    {
        LibraryContext _context;
        Author _author;
        public frmBooks(LibraryContext context, Author author)
        {
            InitializeComponent();
            _context = context;
            _author = author;
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            lblAuthor.Text = _author.Name;
            ReadBooks();
        }

        private void ReadBooks()
        {
            lstBooks.Items.Clear();
            foreach (Book b in _author.Books)
                lstBooks.Items.Add(b);
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null)
            {
                Book b = lstBooks.SelectedItem as Book;
                txtID.Text = b.Id.ToString();
                txtTitle.Text = b.Title;
                nudPublishingYear.Value = b.PublishingYear;

                lstContents.Items.Clear();
                foreach(Novel n in b.Novels)
                {
                    lstContents.Items.Add(n);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.PublishingYear = (int)nudPublishingYear.Value;

            book.Author = _author;

            _context.Books.Add(book);
            _context.SaveChanges();
            ReadBooks();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null)
            {
                Book book = lstBooks.SelectedItem as Book;
                book.Title = txtTitle.Text;
                book.PublishingYear = (int)nudPublishingYear.Value;

                _context.SaveChanges();

                ReadBooks();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem != null)
            {
                Book book = lstBooks.SelectedItem as Book;

                _context.Books.Remove(book);
                _context.SaveChanges();
                ReadBooks();
            }
        }

        private void lstContents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstContents.SelectedItem != null)
            {
                Novel n = lstContents.SelectedItem as Novel;
                lstOtherBooks.Items.Clear();
                foreach(Book b in n.Books)
                {
                    lstOtherBooks.Items.Add(b);
                }
            }
            
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            
            List<Book> books = _context.Books.ToList();

            var selBooks = books.Where(b => b.PublishingYear <= nudPublishingYear.Value).Select(b => new {Title = b.Title, Year = b.PublishingYear});
            lstOtherBooks.Items.Clear();
            foreach (var b in selBooks)
            {
                lstOtherBooks.Items.Add(b);
            }
                              
            return;
            
            /*
            var novels = from book in _context.Books
                         from novel in book.Novels
                         where book.PublishingYear <= nudPublishingYear.Value
                         select novel;
            lstOtherBooks.Items.Clear();
            foreach(var n in novels)
            {
                lstOtherBooks.Items.Add(n);
            }
            return;
            var books = from book in _context.Books
                        join author in _context.Authors on book.Author.Id equals author.Id
                        where book.PublishingYear <= nudPublishingYear.Value
                        select new { Book = book.Title, Author = author.Name, Year = book.PublishingYear };

            lstOtherBooks.Items.Clear();
            foreach(var b in books)
            {                
                lstOtherBooks.Items.Add(b);
            }
            
            */


        }

        private void btnAddContents_Click(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
                return;
            Book book = lstBooks.SelectedItem as Book;

            book.NovelsChanged += this.ContentListRefresh;
            
            var contents = _context.Novels.ToList();
            /*
            ProcessSelection func = new ProcessSelection(this.ProcessSelectedNovel);
            func += this.TestMethod;
            var lst = func.GetInvocationList();

            foreach (var d in lst)
                MessageBox.Show($"Target : {d.Target}, Method: {d.Method}");

            Action<object> action = new Action<object>(this.ProcessSelectedNovel);

            frmSelect frm = new frmSelect("Выберите произведение", contents, this.ProcessSelectedNovel);
            */
            /*
            Action<object> action = delegate (object selected)
            {
                Novel novel = selected as Novel;
                if (book.Novels.Contains(novel))
                {
                    MessageBox.Show("Произведение уже есть в книге");
                    return;
                }
                book.Novels.Add(novel);
                _context.SaveChanges();
            }
            */

            frmSelect frm = new frmSelect("Выберите произведение", contents, (object selected) =>
            {
                Novel novel = selected as Novel;
                if (book.Novels.Contains(novel))
                {
                    MessageBox.Show("Произведение уже есть в книге");
                    return;
                }
                book.Novels.Add(novel);
                book.InvokeChange();
                
                _context.SaveChanges();
            });

            frm.Show();
        }

        private void ProcessSelectedNovel(object selected)
        {
            
            if (lstBooks.SelectedItem == null)
                return;
            Book book = lstBooks.SelectedItem as Book;

            Novel novel = selected as Novel;
            var existing = book.Novels.FirstOrDefault(n => n.Id == novel.Id);
            //if (book.Novels.Contains(novel))
            if (existing != null)
            {
                MessageBox.Show("Произведение уже есть в книге");
                return;
            }
            book.Novels.Add(novel);
            
            _context.SaveChanges();
        }

        private void TestMethod(object obj)
        {
            MessageBox.Show("Test method: " + obj.ToString());
        }

        private void ContentListRefresh(object sender, EventArgs e)
        {
            if (lstBooks.SelectedItem == null)
                return;
            if (sender != lstBooks.SelectedItem)
                return;

            Book b = sender as Book;
            lstContents.Items.Clear();
            foreach(var novel in b.Novels)
                lstContents.Items.Add(novel);
        }

    }

    public delegate void ProcessSelection(object selected);

}
