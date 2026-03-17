namespace VideoGames
{
    // declare Program class
    public class Program
    {
        // add main method to Program class
        public static void Main(string[] args)
        {
            // create a list for VideoGame objects and add video game objects
            List<VideoGame> games = new List<VideoGame>();
            games.Add(new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5});
            games.Add(new VideoGame { Name = "Marvel's Spider-Man Remastered", Genre = "Action-Adventure", Rating = 4.6});
            games.Add(new VideoGame { Name = "Terraria", Genre = "Action-Adventure", Rating = 4.0});
            games.Add(new VideoGame { Name = "R.E.P.O.", Genre = "Survival Horror", Rating = 3.8});
            games.Add(new VideoGame { Name = "STAR WARS Jedi: Fallen Order", Genre = "Action-Adventure", Rating = 4.2});
            games.Add(new VideoGame { Name = "The Sims 4", Genre = "Life Simulation", Rating = 3.9});
            games.Add(new VideoGame { Name = "Stardew Valley", Genre = "Life Simulation", Rating = 4.5});

            // create a LINQ query to create new list of games with rating 4+
            var topRatedGames = (from game in games where game.Rating >= 4 select game).ToList();
            // create LINQ query with orderby clause to sort topRatedGames by name
            var sortedGames = (from game in topRatedGames orderby game.Name select game).ToList();

            // use a foreach loop to print out names in sortedGames
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }
        }
    }
}