// Class for creating and managing bookings
using System.Collections.ObjectModel;

namespace HotelBookingManager;
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

	// Returns the number of bookings that match criteria
	public int GetBookingCount(string guestName, string roomNumber)
		=> _bookings.Count(
			b => string.Equals(b.RoomNumber, roomNumber, StringComparison.OrdinalIgnoreCase) && 
			string.Equals(b.GuestName, guestName, StringComparison.OrdinalIgnoreCase)
				);
	

	// Attempts to cancel bookings, returns the number of bookings canceled
	public int CancelBooking(string guestName, string roomNumber)
	{
		// Find all bookings that match criteria
		List<Booking> bookingsToCancel = [.. _bookings.Where(
			b => string.Equals(b.RoomNumber, roomNumber, StringComparison.OrdinalIgnoreCase) && 
			string.Equals(b.GuestName, guestName, StringComparison.OrdinalIgnoreCase)
				)];

		// Remove the bookings
		bookingsToCancel.ForEach(b => _bookings.Remove(b));

		return bookingsToCancel.Count;

	}

	// Returns a readonly list of all bookings
	public ReadOnlyCollection<Booking> ListAll()
		=> _bookings.AsReadOnly();
	

	// Check if a room is available during a period of time, returns true if it is available
	public bool CheckAvailability(string roomNumber, DateTime checkIn, DateTime checkOut)
	{
		foreach (Booking booking in _bookings)
		{
			// Continue if room number is different
			if (!string.Equals(booking.RoomNumber, roomNumber, StringComparison.OrdinalIgnoreCase))
				continue;

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