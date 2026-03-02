// Custom exceptions
namespace HotelBookingManager;
public class DoubleBookingException : Exception
{
	public DoubleBookingException() : base("There is already a booking for that room at that time.") {}

	public DoubleBookingException(string message) : base(message) {}
}
