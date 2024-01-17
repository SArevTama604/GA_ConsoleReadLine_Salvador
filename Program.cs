namespace GA_ConsoleReadLine_Salvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");
            Console.WriteLine("What is your favorite color?");
            string favoriteColor = Console.ReadLine();
            Console.WriteLine("Ah, " + favoriteColor + " is a great color!");
            Console.WriteLine(userName + ", who likes " + favoriteColor + ", Welcome to the Program!");

        }
    }
}
