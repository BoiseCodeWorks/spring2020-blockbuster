using System.Collections;
using System.Collections.Generic;

namespace blockbuster.Models
{
    class Store
    {
        public string Address { get; set; }
        private List<Video> Videos { get; set; }

        public Dictionary<string, List<string>> Merchandise { get; set; }


        public void AddVideo(Video newVid)
        {
            // perform some logic for your app
            System.Console.WriteLine("add one");
            Videos.Add(newVid);
        }

        public void AddVideo(IEnumerable<Video> videos)
        {
            System.Console.WriteLine("add many");
            Videos.AddRange(videos);
        }

        public string VideoList()
        {
            string template = "";
            for (int i = 0; i < Videos.Count; i++)
            {
                Video current = Videos[i];
                template += $"{i + 1}. {current.Title} -  {current.Rating} \n";
            }

            return template;
        }

        public Store(string address)
        {
            Address = address;
            Videos = new List<Video>();

            // Merchandise = {
            //     swag: ["Blockbuster Hoodie", "keychain"],
            //     food: []
            // }
            Merchandise = new Dictionary<string, List<string>>();
        }



        public int FPV(int price, int time)
        {
            return 9;
        }


        public int FPV(float price, int time)
        {
            return 9;
        }

        private float FPV(int price, int time, float interest)
        {
            return 10;
        }









    }
}