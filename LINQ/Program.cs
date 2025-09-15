using System.ComponentModel.DataAnnotations;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string> { "Hollow Knight", "Stardew Valley", "Terraria", "Risk of Rain 2", "Street Fighter 6", "Dark Souls" };
            var gamesSorted = games.OrderBy(game => game.Length );
            gamesSorted.ToList().ForEach(Console.WriteLine);
        }
    }
}
