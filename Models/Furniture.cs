namespace gregslist.Models
{
    public class Furniture : Listing
    {

        public Furniture(int year, string desc, double price, string condition, string imgurl, string subcat) : base(year, desc, price, condition, imgurl, subcat)
        {
        }
    }
}