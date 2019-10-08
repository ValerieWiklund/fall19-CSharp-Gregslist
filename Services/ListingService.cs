using System;
using System.Collections.Generic;
using gregslist.Models;

namespace gregslist.Services
{
  public class CarService
  {
    public List<Listing> Listings { get; private set; }
    public List<string> Messages { get; set; }

    public void Setup()
    {
      Car ford = new Car("Ford", "F350", 2019, "leather seats and all the bells and whistles", 50000.89, "New", "whatever", "truck", "gas");
      Car honda = new Car("Honda", "Civic", 1989, "how dare you", 1000, "Sorta New", "whatever", "car", "gas");
      Car toyota = new Car("Toyota", "Tacoma", 2011, "full of trash", 12000, "old", "whatever", "truck", "gas");
      Car tracker = new Car("Darryl", "Frankenstein", 1989, "mostly a tracker", 1000000, "New Parts....", "whatever", "truck", "gas");

      Furniture couch = new Furniture(2011, "its a brown leather couch", 100, "Its very cracked and warn", "n______n", "Couch");

      Listings.AddRange(new Listing[] { ford, honda, toyota, tracker, couch });
    }

    internal void GetCars(int index)
    {
      if (index < Listings.Count && index > -1)
      {
        Listing listing = Listings[index];
        Messages.Add(listing.GetTemplate());
        if (listing is Car)
        {
          Car carListing = (Car)listing;
          Messages.Add($"car was checked by mechanic: {carListing.HaveMechanicChecked()}");
        }
      }
      else
      {
        Messages.Add("Invalid Choice... Dummy!");

      }
    }

    public void GetCars()
    {
      Messages.Add("Available Cars");
      for (int i = 0; i < Listings.Count; i++)
      {
        Listing c = Listings[i];
        Messages.Add($"{i + 1}: {c.ImgUrl} - {c.Price}");
      }
      Messages.Add("Type a number to see details or Q to quit");
    }

    public CarService()
    {
      Messages = new List<string>();
      Listings = new List<Listing>();
      Setup();
    }
  }
}