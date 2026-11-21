namespace TravelFacade;

public class TravelFacade
{
    private readonly FlightBooking _flightBooking;
    private readonly HotelBooking _hotelBooking;
    private readonly Payment _payment;
    private readonly Dictionary<string, TripDetails> _activeBookings = new Dictionary<string, TripDetails>();

    public TravelFacade()
        : this(new FlightBooking(), new HotelBooking(), new Payment())
    {
    }

    public TravelFacade(FlightBooking flightBooking, HotelBooking hotelBooking, Payment payment)
    {
        _flightBooking = flightBooking;
        _hotelBooking = hotelBooking;
        _payment = payment;
    }

    public bool BookTrip(TripDetails trip)
    {
        Console.WriteLine($"Sayohat bron qilish ({trip.TravelerName}):");

        _flightBooking.BookFlight(trip.TravelerName, trip.FlightNumber, trip.FromCity, trip.ToCity);
        _hotelBooking.BookRoom(trip.TravelerName, trip.HotelName, trip.RoomType);

        if (!_payment.MakePayment(trip.TravelerName, trip.Amount, trip.Currency))
        {
            _flightBooking.CancelFlight(trip.TravelerName, trip.FlightNumber);
            _hotelBooking.CancelRoom(trip.TravelerName, trip.HotelName);
            Console.WriteLine("Xatolik: Sayohat bron qilinmadi.");
            Console.WriteLine();
            return false;
        }

        _activeBookings[trip.TravelerName] = trip;
        Console.WriteLine("Sayohat muvaffaqiyatli bron qilindi.");
        Console.WriteLine();
        return true;
    }

    public bool CancelTrip(string travelerName)
    {
        if (!_activeBookings.Remove(travelerName, out TripDetails? trip))
        {
            Console.WriteLine($"Sayohat topilmadi: {travelerName}");
            Console.WriteLine();
            return false;
        }

        Console.WriteLine($"Sayohatni bekor qilish ({trip.TravelerName}):");
        _flightBooking.CancelFlight(trip.TravelerName, trip.FlightNumber);
        _hotelBooking.CancelRoom(trip.TravelerName, trip.HotelName);
        _payment.RefundPayment(trip.TravelerName, trip.Currency);
        Console.WriteLine("Sayohat bekor qilindi.");
        Console.WriteLine();
        return true;
    }
}
