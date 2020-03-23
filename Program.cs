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

            Video jp = new VHS("Jurassic Park", Rating.PG13);
            Store boise = new Store("123 Main st");
            boise.AddVideo(jp);
            boise.AddVideo(new VHS("Titanic", Rating.PG13));
            boise.AddVideo(new DVD("Dude Where's My Car", Rating.R, false));

            VHS sw4 = new VHS("Star Wars: A New Hope", Rating.PG);
            VHS sw5 = new VHS("Star Wars: Empire Strikes Back", Rating.PG);
            Video sw6 = new VHS("Star Wars: Return of the Jedi", Rating.PG);

            List<Video> swSaga = new List<Video>(){
                sw4,
                sw5,
                sw6
            };

            Video[] lotr = new Video[]{
                new DVD("Fellowship of the Ring", Rating.PG13, true)
            };

            boise.AddVideo(swSaga);
            boise.AddVideo(lotr);

            boise.Merchandise.Add("swag", new List<string>() { "Blockbuster Hoodie", "keychain" });
            boise.Merchandise.Add("Food", new List<string>() { "PopCorn", "Soda" });


            System.Console.WriteLine(boise.VideoList());

        }
    }
}
