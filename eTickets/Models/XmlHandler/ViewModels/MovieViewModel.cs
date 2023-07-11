namespace eTickets.Models.XmlHandler.ViewModels
{
    public class MovieViewModel
    {
        public MovieViewModel()
        {
            MovieGenre = new List<MovieGenre>();
        }
        public List<MovieGenre> MovieGenre { get; set;}

        public int SumOfFailure { get; set;}  
    }
}
