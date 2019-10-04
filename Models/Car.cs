namespace gregslist.Models
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Car(string make, string model, int year, string desc, double price)
        {
            Make = make;
            Model = model;
            Year = year;
            Description = desc;
            Price = price;
        }
    }
}