namespace blockbuster.Models
{
    class VHS : Video
    {
        public bool Rewound { get; set; }
        public VHS(string title, Rating rating) : base(title, rating)
        {
            Rewound = true;
        }
    }
}