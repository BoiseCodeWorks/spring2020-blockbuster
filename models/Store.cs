using System.Collections;
using System.Collections.Generic;
using blockbuster.Interfaces;

namespace blockbuster.Models
{
    class Store
    {
        public string Address { get; set; }
        private List<IRentable> Rentals { get; set; }

        public Dictionary<string, List<string>> Merchandise { get; set; }


        public void AddVideo(IRentable newVid)
        {
            Rentals.Add(newVid);
        }

        public void AddVideo(IEnumerable<IRentable> videos)
        {
            Rentals.AddRange(videos);
        }

        public string VideoList()
        {
            string template = "";
            for (int i = 0; i < Videos.Count; i++)
            {
                Video video = Videos[i];
                template += $"{i + 1}. {video.Title} - {video.Rating}";
                //NOTE check if video is an instance of VHS
                if (video is VHS)
                {
                    //NOTE convert the video to a vhs and save as a variable
                    VHS vidoVHS = (VHS)video;
                    template += " (VHS), rewound: ";
                }

                //NOTE try to convert to DVD
                DVD videoDVD = video as DVD;
                //NOTE check for success
                if (videoDVD != null)
                {
                    template += " (DVD), extras: " + videoDVD.Extras;
                }

                template += "\n";
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