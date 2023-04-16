using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]//need to show this data into Index.cshtml
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Full Name")]//need to show this data into Index.cshtml
        public string FullName { get; set; }

        [Display(Name = "Biography")]//need to show this data into Index.cshtml
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set;}
    }
}
