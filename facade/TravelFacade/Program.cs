namespace TravelFacade;

public class Program
{
    public static void Main()
    {
        TravelFacade travel = new TravelFacade();

        TripDetails trip = new TripDetails(
            TravelerName: "Anvar Karimov",
            FromCity: "Toshkent",
            ToCity: "Dubay",
            FlightNumber: "HY-333",
            HotelName: "Burj Al Arab",
            RoomType: "Deluxe Suite",
            Amount: 1500);

        travel.BookTrip(trip);
        travel.CancelTrip(trip.TravelerName);

        TripDetails badTrip = trip with { TravelerName = "Bobur Aliyev", Amount = 0 };
        travel.BookTrip(badTrip);
    }
}
