using System.Linq;
using TOTVS.Models;

namespace TOTVS.Data
{
    public class SeedData
    {
        public static class DbInitializer
        {
            public static void Initialize(TOTVSContext context)
            {
                context.Database.EnsureCreated();

                // Look for any students.
                if (context.Genres.Any())
                {
                    return;   // DB has been seeded
                }

                var genres = new Genre[]
                {
                    new Genre{Name="Rock",Description="Rock descricao"},
                    new Genre{Name="Jazz",Description="Jazz descricao"},
                    new Genre{Name="Metal",Description="Heavy Metal descricao"},
                    new Genre{Name="Blues",Description="Blues descricao"},
                    new Genre{Name="Classical",Description="Classica descricao"}
                };
                foreach (Genre p in genres)
                {
                    context.Genres.Add(p);
                }
                context.SaveChanges();

                var artists = new Artist[]
                 {
                    new Artist { Name = "AC/DC" },
                    new Artist { Name = "Accept" },
                    new Artist { Name = "Aisha Duo" },
                    new Artist { Name = "Apocalyptica" },
                    new Artist { Name = "Berliner Philharmoniker & Herbert Von Karajan" },
                    new Artist { Name = "Black Sabbath" },
                    new Artist { Name = "Boston Symphony Orchestra & Seiji Ozawa" },
                    new Artist { Name = "Deep Purple" },
                    new Artist { Name = "U2" },
                    new Artist { Name = "The Cult" },
                    new Artist { Name = "The Doors" },
                    new Artist { Name = "The King's Singers" }
                 };
                foreach (Artist p in artists)
                {
                    context.Artists.Add(p);
                }
                context.SaveChanges();

                var albuns = new Album[]
             {
                    new Album { Title = "For Those About To Rock We Salute You", Genre = genres.Single(g => g.Name == "Rock"), Price = 28.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Let There Be Rock", Genre = genres.Single(g => g.Name == "Rock"), Price = 38.99M, Artist = artists.Single(a => a.Name == "AC/DC"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Balls to the Wall", Genre = genres.Single(g => g.Name == "Rock"), Price = 15.99M, Artist = artists.Single(a => a.Name == "Accept"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Quiet Songs", Genre = genres.Single(g => g.Name == "Jazz"), Price = 8.95M, Artist = artists.Single(a => a.Name == "Aisha Duo"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Plays Metallica By Four Cellos", Genre = genres.Single(g => g.Name == "Metal"), Price = 13.22M, Artist = artists.Single(a => a.Name == "Apocalyptica"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Mozart: Symphonies Nos. 40 & 41", Genre = genres.Single(g => g.Name == "Classical"), Price = 28.95M, Artist = artists.Single(a => a.Name == "Berliner Philharmoniker & Herbert Von Karajan"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Black Sabbath Vol. 4 (Remaster)", Genre = genres.Single(g => g.Name == "Metal"), Price = 28.99M, Artist = artists.Single(a => a.Name == "Black Sabbath"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Black Sabbath", Genre = genres.Single(g => g.Name == "Metal"), Price = 28.99M, Artist = artists.Single(a => a.Name == "Black Sabbath"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Carmina Burana", Genre = genres.Single(g => g.Name == "Classical"), Price = 28.99M, Artist = artists.Single(a => a.Name == "Boston Symphony Orchestra & Seiji Ozawa"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Deep Purple In Rock", Genre = genres.Single(g => g.Name == "Rock"), Price = 28.99M, Artist = artists.Single(a => a.Name == "Deep Purple"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "How To Dismantle An Atomic Bomb", Genre = genres.Single(g => g.Name == "Rock"), Price = 28.99M, Artist = artists.Single(a => a.Name == "U2"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "Beyond Good And Evil", Genre = genres.Single(g => g.Name == "Rock"), Price = 28.99M, Artist = artists.Single(a => a.Name == "The Cult"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "The Doors", Genre = genres.Single(g => g.Name == "Rock"), Price = 28.99M, Artist = artists.Single(a => a.Name == "The Doors"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
                    new Album { Title = "English Renaissance", Genre = genres.Single(g => g.Name == "Classical"), Price = 28.99M, Artist = artists.Single(a => a.Name == "The King's Singers"), AlbumArtUrl = "/Content/Images/placeholder.gif" },
             };
                foreach (Album p in albuns)
                {
                    context.Albums.Add(p);
                }
                context.SaveChanges();

                var users = new User[]
                {
                    new User{Nome="Remo",CPF="22679930827"},
                    new User{Nome="Nome",CPF="65478743455"},
                    new User{Nome="Nome2",CPF="234565756788"}
                };
                foreach (User p in users)
                {
                    context.Users.Add(p);
                }
                context.SaveChanges();
            }
        }
    }
}