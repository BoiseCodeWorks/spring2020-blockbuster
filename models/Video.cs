namespace blockbuster.Models
{
    class Video
    {
        // NOTE Fields are built automatically for us with auto props below
        // private string _title;
        // public string Title
        // {
        //     get
        //     {
        //         return _title;
        //     }
        //     set
        //     {
        //         _title = value.ToUpper();
        //     }
        // }


        public string Title { get; }
        public string Rating { get; private set; }
        public bool CheckedOut { get; private set; }


        public Video(string title, string rating)
        {
            Title = title;
            Rating = rating;
            CheckedOut = false;
        }
    }
}