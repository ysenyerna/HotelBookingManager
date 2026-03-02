namespace HotelBookingManager
{
	public partial class MainForm : Form
	{
		private BookingManager bookingManager;
		public MainForm()
		{
			InitializeComponent();

			CreateEventHandlers();
			ConfigureInitialValues();

			// Create the booking manager
			bookingManager = new();
		}


		// SETUP 
		void CreateEventHandlers()
		{
			// Buttons
			btnBook.Click += Book;
			btnCancel.Click += CancelBooking;
			btnViewBookings.Click += ViewBookings;
			btnExit.Click += Exit;

			// Resize
			listAllBookings.Resize += ResizeBookingsListColumns;
		}

		void ConfigureInitialValues()
		{
			// Set minimum dates for date time boxes
			dateCheckIn.MinDate = DateTime.Today;
			dateCheckOut.MinDate = DateTime.Today.AddDays(1);

			// Hide the list by default
			groupListView.Visible = false;
			
			// Initialize columns for the list of all bookings
			listAllBookings.Columns.Add("Room #", 0);
			listAllBookings.Columns.Add("Name", 0);
			listAllBookings.Columns.Add("Check In", 0);
			listAllBookings.Columns.Add("Check Out", 0);
			listAllBookings.View = View.Details;
			ResizeBookingsListColumns();
		}



		// BUTTON EVENTS

		// Attempts to book a room
		void Book(object? sender, EventArgs e)
		{
			string name = textGuestName.Text;
			string roomNum = textRoomNumber.Text;
			DateTime checkIn = dateCheckIn.Value;
			DateTime checkOut = dateCheckOut.Value;

			// Validate name
			if (string.IsNullOrWhiteSpace(name))
			{
				Logger.Warn("Attempted to book a room without a guest name");
				UpdateStatus("Guest name cannot be empty!", Color.Red);
				return;
			}
			// Validate room number
			if (string.IsNullOrWhiteSpace(roomNum))
			{
				Logger.Warn("Attempted to book a room without a room number");
				UpdateStatus("Room number cannot be empty!", Color.Red);
				return;
			}
			// Validate check in and check out
			if (checkIn >= checkOut)
			{
				Logger.Warn($"Attempted to book room {roomNum} for {name} from {checkIn:MM-dd-yyyy hh:mm} to {checkOut:MM-dd-yyyy hh:mm}. Check in date is before check out date");
				UpdateStatus("Check in date cannot be after check out date!", Color.Red);
				return;
			}
			// Check for double bookings
			if (!bookingManager.CheckAvailability(roomNum, checkIn, checkOut))
			{
				Logger.Warn($"Attempted to double book room {roomNum} for {name} from {checkIn:MM-dd-yyyy hh:mm} to {checkOut:MM-dd-yyyy hh:mm}");
				UpdateStatus("There is already a booking for that room at that time!", Color.Red);
				return;
			}
			// Ask for confirmation
			string msg = $"You are about to create a booking. Are you sure you wish to proceed?";
			bool confirmed = MessageBox.Show(msg, "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK;
			if (!confirmed) {
				Logger.Info($"Stopped booking operation on room {roomNum} for {name} from {checkIn:MM-dd-yyyy hh:mm} to {checkOut:MM-dd-yyyy hh:mm}");
				return;
			}
			// Create the booking
			Booking b = new(name, roomNum, checkIn, checkOut);
			bookingManager.AddBooking(b);
			UpdateStatus("Booking successfully created!", Color.Green);
			RefreshList();
			Logger.Info($"Booked room {roomNum} for {name} from {checkIn:MM-dd-yyyy hh:mm} to {checkOut:MM-dd-yyyy hh:mm}");
		}

		// Attempts to cancel bookings
		void CancelBooking(object? sender, EventArgs e)
		{
			string guestName = textGuestName.Text;
			string roomNum = textRoomNumber.Text;

			int bookingCount = bookingManager.GetBookingCount(guestName, roomNum);
			// Return if no bookings are found
			if (bookingCount == 0)
			{
				Logger.Warn($"Attempted to cancel bookings for {guestName} in room {roomNum} but no bookings were found");
				UpdateStatus($"No bookings found for {guestName} in room {roomNum}!", Color.Red);
				return;
			}
			// Ask the user to confirm
			string msg = $"You are about to cancel {bookingCount} booking(s). Are you sure you wish to proceed?";
			bool confirmed = MessageBox.Show(msg, "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK;

			if (!confirmed) {
				Logger.Info($"Stopped booking cancelation operation for {guestName} in room {roomNum}");
				return;
			}


			// Cancel bookings
			int cancelCount = bookingManager.CancelBooking(guestName, roomNum);
			RefreshList();
			Logger.Info($"Canceled {cancelCount} booking(s) for {guestName} in room {roomNum}");

			// Show confirmation message
			if (cancelCount == 1)
				UpdateStatus("Booking successfully canceled!", Color.Green);
			else
				UpdateStatus($"{cancelCount} bookings were successfully canceled!", Color.Green);

				
		}

		// Toggles the visibility of the bookings list
		void ViewBookings(object? sender, EventArgs e)
		{
			bool enable = !groupListView.Visible;
			if (enable)
			{
				groupListView.Visible = true;
				btnViewBookings.Text = "Hide Bookings";
				Height = 400;
				RefreshList();
			}
			else
			{
				groupListView.Visible = false;
				btnViewBookings.Text = "View All Bookings";
				Height = 219;
			}
		}

		// Closes the form
		void Exit(object? sender, EventArgs e) {
			Close();
		}





		// Updates the status line with a new message
		void UpdateStatus(string message, Color color)
		{
			labelStatus.Text = "Status: " + message;
			labelStatus.ForeColor = color;
		}

		// Updates the bookings list
		void RefreshList()
		{
			// Clear previous items
			listAllBookings.Items.Clear();
	
			// Create a list item for each bookings
			var bookings = bookingManager.ListAll();
			foreach (Booking b in bookings)
			{
				var item = new ListViewItem(b.RoomNumber);
				item.SubItems.Add(b.GuestName);
				item.SubItems.Add(b.CheckIn.ToString("MM-dd-yyyy HH:mm"));
				item.SubItems.Add(b.CheckOut.ToString("MM-dd-yyyy HH:mm"));
				listAllBookings.Items.Add(item);
			}
		}

		// Auto resizes the bookings list columns
		void ResizeBookingsListColumns(object? sender = null, EventArgs? e = null)
		{
			int totalWidth = listAllBookings.Width;

			// Assign size percentages for each column in the list
			double[] SizePercentages = [0.15, 0.35, 0.25, 0.25];
			for (int i = 0; i < 4; i++)
				listAllBookings.Columns[i].Width = (int)Math.Floor(totalWidth * SizePercentages[i]);
		}
	}
}
