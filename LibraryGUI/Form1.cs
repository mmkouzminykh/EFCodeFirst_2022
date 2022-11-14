using EFCodeFirst;
using Microsoft.EntityFrameworkCore;

namespace LibraryGUI
{
    public partial class frmTest : Form
    {
        LibraryContext context;

        public frmTest()
        {
            InitializeComponent();
            context = new LibraryContext();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Author author = new Author();

            author.Name = txtName.Text;
            DateTime d = dtpBirthday.Value;
            author.Birthday = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0, DateTimeKind.Utc);            

            context.Authors.Add(author);
            context.SaveChanges();

            ReadAuthors();
        }

        private void btnReadAuthors_Click(object sender, EventArgs e)
        {
            ReadAuthors();
        }

        private void ReadAuthors()
        {
            lstAuthors.Items.Clear();
            foreach (var author in context.Authors.Include("Books").Include("Books.Novels"))
            {
                lstAuthors.Items.Add(author);
            }            
        }

        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAuthors.SelectedItem != null)
            {
                Author a = lstAuthors.SelectedItem as Author;
                txtID.Text = a.Id.ToString();
                txtName.Text = a.Name;
                dtpBirthday.Value = a.Birthday;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstAuthors.SelectedItem != null)
            {
                Author a = lstAuthors.SelectedItem as Author;
                a.Name = txtName.Text;
                DateTime d = dtpBirthday.Value;
                a.Birthday = new DateTime(d.Year, d.Month, d.Day, 0, 0, 0, DateTimeKind.Utc);

                context.SaveChanges();
                ReadAuthors();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstAuthors.SelectedItem != null)
            {
                Author a = lstAuthors.SelectedItem as Author;
                context.Authors.Remove(a);
                context.SaveChanges();

                ReadAuthors();
            }
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            if (lstAuthors.SelectedItem != null)
            {
                Author a = lstAuthors.SelectedItem as Author;
                frmBooks frm = new frmBooks(context, a);
                frm.ShowDialog();
            }
        }
    }
}