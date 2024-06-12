using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GenresClient
{
    private readonly Genre[] _genres =
    [
        new()
        {
            genreName = "Action",
            Id = 1
        },
        new Genre()
        {
            genreName = "Platformer",
            Id = 2
        },
        new Genre()
        {
            genreName = "Fantasy",
            Id = 3
        },
        new Genre()
        {
            genreName = "Sci-Fi",
            Id = 4
        },
        new Genre()
        {
            genreName = "First Person Shooter",
            Id = 5
        },
        new Genre()
        {
            genreName = "Strategy",
            Id = 6
        },
        new Genre()
        {
            genreName = "Third Person Action/Adventure",
            Id = 7
        }
    ];

    public Genre[] GetGenresList() => _genres.ToArray();
}