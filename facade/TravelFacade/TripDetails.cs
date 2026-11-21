namespace TravelFacade;

public record TripDetails(
    string TravelerName,
    string FromCity,
    string ToCity,
    string FlightNumber,
    string HotelName,
    string RoomType,
    decimal Amount,
    string Currency = "USD");
