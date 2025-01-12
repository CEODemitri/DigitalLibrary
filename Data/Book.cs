namespace BlazorApp.Models
{
    public class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public int Year { get; set; }
        public required string Url { get; set; }
    }
}
