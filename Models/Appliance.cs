namespace gregslist.Models
{
    public class Appliance : Manufactured
    {
        public Appliance(string make, string model, int year, string desc, double price, string condition, string imgurl, string subcat) : base(make, model, year, desc, price, condition, imgurl, subcat)
        {
        }
    }
}