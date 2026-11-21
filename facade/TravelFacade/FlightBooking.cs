namespace TravelFacade;

public class FlightBooking
{
    private readonly HashSet<string> _bookings = new HashSet<string>();

    public bool BookFlight(string passengerName, string flightNumber, string fromCity, string toCity)
    {
        _bookings.Add($"{passengerName}:{flightNumber}");
        Console.WriteLine($"  Aviachipta bron qilindi: {flightNumber} ({fromCity} -> {toCity})");
        return true;
    }

    public bool CancelFlight(string passengerName, string flightNumber)
    {
        if (_bookings.Remove($"{passengerName}:{flightNumber}"))
        {
            Console.WriteLine($"  Aviachipta bekor qilindi: {flightNumber}");
            return true;
        }
        Console.WriteLine($"  Aviachipta topilmadi: {flightNumber}");
        return false;
    }
}
