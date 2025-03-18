namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> VideoGames = new List<string>();
            VideoGames.Add("* Rainbow Six Siege,");
            VideoGames.Add("* For Honor,");
            VideoGames.Add("* Apex Legends,");
            VideoGames.Add("* Fall Guys.");

            var OrderedGameNames = VideoGames.OrderByDescending(name => name.Length);

            Console.WriteLine("Video Game Names Listed By Length!");
            Console.WriteLine("----------------------------------");
            foreach(var VideoGame in OrderedGameNames)
            {
                Console.WriteLine(VideoGame);
            }


                
        }
    }
}
