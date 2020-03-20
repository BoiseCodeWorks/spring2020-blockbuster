using System;
using System.Collections.Generic;
using blockbuster.Models;

namespace blockbuster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Video jp = new Video("Jurassic Park", "PG-13");
            Store boise = new Store("123 Main st");
            boise.AddVideo(jp);
            boise.AddVideo(new Video("Titanic", "PG-13"));
            boise.AddVideo(new Video("Dude Where's My Car", "R"));

            Video sw4 = new Video("Star Wars: A New Hope", "PG");
            Video sw5 = new Video("Star Wars: Empire Strikes Back", "PG");
            Video sw6 = new Video("Star Wars: Return of the Jedi", "PG");

            List<Video> swSaga = new List<Video>(){
                sw4,
                sw5,
                sw6
            };

            Video[] lotr = new Video[]{
                new Video("Fellowship of the Ring", "PG-13")
            };

            boise.AddVideo(swSaga);
            boise.AddVideo(lotr);

            boise.Merchandise.Add("swag", new List<string>() { "Blockbuster Hoodie", "keychain" });
            boise.Merchandise.Add("Food", new List<string>() { "PopCorn", "Soda" });

            if (boise.Merchandise.ContainsKey("pizza"))
            {
                System.Console.WriteLine("we Have Pizza");
            }

            ///make your choice
            Dictionary<string, string> WinCondition = new Dictionary<string, string>();
            WinCondition.Add("rock", "scissors");


            string choice = Console.ReadLine();
            string compChoice = "scissors";

            if (WinCondition.ContainsKey(choice) && WinCondition[choice] == compChoice)
            {
                System.Console.WriteLine("win");
            }


            System.Console.WriteLine(boise.VideoList());

        }
    }
}
