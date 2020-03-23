namespace blockbuster.Models
{
    abstract class Video
    {
        public string Title { get; }
        public Rating Rating { get; private set; }
        public bool CheckedOut { get; private set; }

        public Video(string title, Rating rating)
        {
            Title = title;
            Rating = rating;
            CheckedOut = false;
        }
    }


    enum Rating
    {
        G,
        PG,
        PG13,
        R,
        NR
    }

}