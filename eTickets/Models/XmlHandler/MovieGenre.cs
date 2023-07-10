namespace eTickets.Models.XmlHandler
{
    public class MovieGenre
    {
        public MovieGenre()
        {
            Movie = new List<Movie>();
        }

        public string Title { get; set; }//name of Genre
        public List<Movie> Movie { get; set; }
    }
}
