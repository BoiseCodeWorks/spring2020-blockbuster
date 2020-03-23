namespace blockbuster.Models
{
    class DVD : Video
    {
        public bool Extras { get; set; }
        public bool Scratched { get; set; }
        public DVD(string title, Rating rating, bool extras) : base(title, rating)
        {
            Extras = extras;
            Scratched = false;
        }
    }
}