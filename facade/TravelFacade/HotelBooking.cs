namespace TravelFacade;

public class HotelBooking
{
    private readonly HashSet<string> _bookings = new HashSet<string>();

    public bool BookRoom(string guestName, string hotelName, string roomType)
    {
        _bookings.Add($"{guestName}:{hotelName}");
        Console.WriteLine($"  Mehmonxona bron qilindi: {hotelName} ({roomType})");
        return true;
    }

    public bool CancelRoom(string guestName, string hotelName)
    {
        if (_bookings.Remove($"{guestName}:{hotelName}"))
        {
            Console.WriteLine($"  Mehmonxona bekor qilindi: {hotelName}");
            return true;
        }
        Console.WriteLine($"  Mehmonxona topilmadi: {hotelName}");
        return false;
    }
}
