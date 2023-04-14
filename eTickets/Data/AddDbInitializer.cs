using eTickets.Models;

namespace eTickets.Data
{
    public class AddDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder) 
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "Descroption"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "Descroption"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "Descroption"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "Descroption"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "Descroption"
                        },
                    });   
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg",
                            Bio = "Biography"
                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg",
                            Bio = "Biography"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg",
                            Bio = "Biography"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg",
                            Bio = "Biography"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg",
                            Bio = "Biography"
                        },
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg",
                            Bio = "Biography"
                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg",
                            Bio = "Biography"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg",
                            Bio = "Biography"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg",
                            Bio = "Biography"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg",
                            Bio = "Biography"
                        },
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Film 1",
                            Description ="Description",
                            Price = 1,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(30),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Film 2",
                            Description ="Description",
                            Price = 1654,
                            ImageURL = "http://dotnethow.net/images/movies/movie-2.jpeg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(30),
                            CinemaId = 2,
                            ProducerId = 2,
                            MovieCategory = Enums.MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            Name = "Film 3",
                            Description ="Description",
                            Price = 145,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(30),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = Enums.MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Film 4",
                            Description ="Description",
                            Price = 781,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(30),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = Enums.MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Film 5",
                            Description ="Description",
                            Price = 561,
                            ImageURL = "http://dotnethow.net/images/movies/movie-5.jpeg",
                            StartDate = DateTime.Now,
                            EndDate= DateTime.Now.AddDays(30),
                            CinemaId = 5,
                            ProducerId = 5,
                            MovieCategory = Enums.MovieCategory.Documentary
                        },
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    Random random = new Random();
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                        new Actor_Movie()
                        {
                            ActorId = random.Next(1,5),
                            MovieId = random.Next(1,5),
                        },
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
