using blockbuster.Interfaces;

namespace blockbuster.Models
{
    class CD : IRentable
    {
        public string Artist { get; set; }
        public string UPC { get; set; }
        public bool CheckedOut { get; set; }

        public void CheckOut()
        {
            System.Console.WriteLine("Enjoy your tunes");
        }
    }
}