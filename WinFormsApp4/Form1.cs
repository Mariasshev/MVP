namespace WinFormsApp4
{
    public partial class Form1 : Form, IBookInfo
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveAttempted?.Invoke(this, EventArgs.Empty);
        }
        private void Del_Click(object sender, EventArgs e)
        {
            DeleteAttempted?.Invoke(this, EventArgs.Empty);
        }

        string IBookInfo.Name { get => this.name.Text; set => this.name.Text = value; }
        string IBookInfo.Author { get => this.author.Text; set => this.author.Text = value; }
        string IBookInfo.Genre { get => this.genre.Text; set => this.genre.Text = value; }
        string IBookInfo.Year { get => this.year.Text; set => this.year.Text = value; }
        string IBookInfo.ShowInfo { get => this.ShowInfo.Text; set => this.ShowInfo.Text = value; }
        void UpdateBookList(IEnumerable<string> books);

        private void ShowInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string IBookInfo.ShowInfo
        {
            get => ShowInfo.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    ShowInfo.Items.Add(value);
                }
            }
        }

        public event EventHandler? SaveAttempted;
        public event EventHandler? DeleteAttempted;
    }
}
