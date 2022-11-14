namespace EFCodeFirst
{
    public class Book
    {
        public Book()
        {
            this.Novels = new List<Novel>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishingYear { get; set; }

        public Author Author { get; set; }
        public ICollection<Novel> Novels { get; set; }

        public override string ToString()
        {
            return this.Title;
        }

        public void InvokeChange()
        {
            this.NovelsChanged?.Invoke(this, new EventArgs());
        }

        public event EventHandler NovelsChanged;
    }
}