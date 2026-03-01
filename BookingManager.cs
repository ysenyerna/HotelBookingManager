// Class for creating and managing bookings
class BookingManager
{
	private readonly List<Booking> _bookings = [];


	// Attempts to add a booking, throws an exception if booking is invalid
	public void AddBooking(Booking b)
	{
		// Check if the booking is available
		if (!CheckAvailability(b.RoomNumber, b.CheckIn, b.CheckOut))
			throw new DoubleBookingException();

		// Add the booking
		_bookings.Add(b);
	}

	// Attempts to cancel bookings, returns false if no bookings are found
	public bool CancelBooking(string guestName, string roomNumber)
	{
		// Find all bookings that match criteria
		List<Booking> bookingsToCancel = [.. _bookings.Where(b => b.RoomNumber == roomNumber && b.GuestName == guestName)];

		// Remove the bookings
		bookingsToCancel.ForEach(b => _bookings.Remove(b));

		return bookingsToCancel.Count != 0;

	}

	// Returns a list with information for all bookings
	public List<string> ListAll()
	{
		return [.. _bookings.Select(b => b.ToString())];
	}

	// Check if a room is available during a period of time
	public bool CheckAvailability(string roomNumber, DateTime checkIn, DateTime checkOut)
	{
		foreach (Booking booking in _bookings)
		{
			// Check if the datetimes overlap
			if (checkIn < booking.CheckOut 
				&& booking.CheckIn < checkOut)
			{
				return false;
			}
		}
		return true;
	}

}