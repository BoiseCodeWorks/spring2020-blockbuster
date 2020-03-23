using blockbuster.Interfaces;

namespace blockbuster.Models
{
    class DVD : Video, IRentable
    {
        public bool Extras { get; set; }
        public bool Scratched { get; set; }
        public string UPC { get; set; }

        public DVD(string title, Rating rating, bool extras) : base(title, rating)
        {
            Extras = extras;
            Scratched = false;
        }


        // POLYMORPHISM
        public void CheckOut()
        {
            if (Scratched)
            {
                System.Console.WriteLine("En o You  Flick");
                return;
            }
            System.Console.WriteLine("Enjoy!");
        }
    }
}