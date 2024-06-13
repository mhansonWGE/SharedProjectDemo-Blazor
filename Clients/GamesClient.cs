using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;



public class GamesClient
{
    private List<GameSummary> inventory =
    [
        new()
        {
            ID = 1,
            Name = "Lord of the Rings Online",
            Price = 14.99M,
            Genre = "Fantasy",
            ReleaseDate = new DateOnly(2013, 5, 26)
        },
        new()
        {
            ID = 2,
            Name = "Destiny2",
            Price = 8.99M,
            Genre = "Sci-Fi Looter-Shooter",
            ReleaseDate = new DateOnly(2015, 1, 24)
        },
        new GameSummary()
        {
            Genre = "Sci-Fi FPS",
            ID = 3,
            Name="Half-Life 2",
            Price = 4.99M,
            ReleaseDate = new DateOnly(2004,11,16)
        }
    
    
    ];


    private readonly Genre[] genres = new GenresClient().GetGenresList();

    public GameSummary[] GetGamesList() => inventory.ToArray();
    
    
    
    public void AddGame(GameDetails game)
    {
        if(game == null)
            Console.WriteLine("Game param turned up null");
        if(game.GenreID == null)
            Console.WriteLine("Game genre ID param turned up null");
        
        // ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreID); //if game.genreid is null throw an exception
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreID));
        
        var newGameSummary = new GameSummary()
        {
            ID = inventory.Count+1,
            Name = game.Name,
            Genre = genre.genreName,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
        
        inventory.Add(newGameSummary);
    }
}