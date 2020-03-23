namespace blockbuster.Interfaces
{
    interface IRentable
    {
        string UPC { get; set; }
        bool CheckedOut { get; set; }

        public void CheckOut();
    }
}