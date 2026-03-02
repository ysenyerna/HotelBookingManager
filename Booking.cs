// Class for individual room bookings
namespace HotelBookingManager;
class Booking
{
	// Guest name
	string _guestName = null!;
	public string GuestName { 
		get { return _guestName; }
		private set { 
			ArgumentException.ThrowIfNullOrWhiteSpace(value);
			_guestName = value.Trim();
		}
	}
	// Room number
	string _roomNumber = null!;
	public string RoomNumber { 
		get { return _roomNumber; }
		private set { 
			ArgumentException.ThrowIfNullOrWhiteSpace(value);
			_roomNumber = value.Trim();
		}
	}
	// Dates
	public DateTime CheckIn;
	DateTime _checkOut;
	public DateTime CheckOut
	{
		get { return _checkOut; }
		private set
		{
			if (CheckIn > value)
				throw new ArgumentException("Check out cannot be before check in");
			_checkOut = value;
		}
	}

	// Constructor
	public Booking(string guestName, string roomNumber, DateTime checkIn, DateTime checkOut)
	{
		GuestName = guestName;
		RoomNumber = roomNumber;
		CheckIn = checkIn;
		CheckOut = checkOut;
	}


	public override string ToString()
	{
		return $"[ BOOKING INFORMATION ] Guest: {GuestName}, Room Number: {RoomNumber}, Check In Date: {CheckIn:MM-dd-yyyy HH\\:mm}, Check Out Date: {CheckOut:MM-dd-yyyy HH\\:mm}";
	}


}