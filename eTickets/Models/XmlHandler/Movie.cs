namespace eTickets.Models.XmlHandler
{
    public class Movie
    {
        public Movie()
        {
            PricePosition = new List<PricePosition>();
        }

        public string Title { get; set; }
        public List<PricePosition> PricePosition { get; set; }
    }
}
