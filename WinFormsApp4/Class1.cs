using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
   public interface IBookInfo
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string Year { get; set; }

        public string ShowInfo { get; set; }

        public event EventHandler? SaveAttempted;
        public event EventHandler? DeleteAttempted;

        void UpdateBookList(IEnumerable<string> books);

    }

    public class BookInfoPresenter
    {
        private readonly IBookInfo _form;
        private const string FilePath = "books.txt";

        public BookInfoPresenter(IBookInfo form)
        {
            _form = form;

            _form.SaveAttempted += OnSaveAttempted;
            _form.DeleteAttempted += OnDeleteAttempted;

            LoadBooksFromFile();
        }

        private void OnSaveAttempted(object? sender, EventArgs e)
        {
            string bookEntry = $"{_form.Name};{_form.Author};{_form.Genre};{_form.Year}";
            File.AppendAllLines(FilePath, new[] { bookEntry });
            LoadBooksFromFile();
        }

        private void OnDeleteAttempted(object? sender, EventArgs e)
        {
            var books = File.ReadAllLines(FilePath).ToList();
            books.Remove(_form.ShowInfo);
            File.WriteAllLines(FilePath, books);
            LoadBooksFromFile();
        }

        private void LoadBooksFromFile()
        {
            if (File.Exists(FilePath))
            {
                var books = File.ReadAllLines(FilePath);
                _form.UpdateBookList(books);
            }
            else
            {

            }
        }
    }
}
