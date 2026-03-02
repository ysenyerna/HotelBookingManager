namespace HotelBookingManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textGuestName = new TextBox();
            textRoomNumber = new TextBox();
            dateCheckIn = new DateTimePicker();
            btnBook = new Button();
            btnCancel = new Button();
            btnExit = new Button();
            btnViewBookings = new Button();
            labelStatus = new Label();
            labelRoomNum = new Label();
            labelGuestName = new Label();
            labelCheckIn = new Label();
            labelCheckOut = new Label();
            dateCheckOut = new DateTimePicker();
            groupCreateBooking = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupListView = new GroupBox();
            listAllBookings = new ListView();
            groupCreateBooking.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupListView.SuspendLayout();
            SuspendLayout();
            // 
            // textGuestName
            // 
            textGuestName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textGuestName.Location = new Point(84, 4);
            textGuestName.Name = "textGuestName";
            textGuestName.Size = new Size(255, 23);
            textGuestName.TabIndex = 0;
            // 
            // textRoomNumber
            // 
            textRoomNumber.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textRoomNumber.Location = new Point(443, 4);
            textRoomNumber.Name = "textRoomNumber";
            textRoomNumber.Size = new Size(54, 23);
            textRoomNumber.TabIndex = 1;
            // 
            // dateCheckIn
            // 
            dateCheckIn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateCheckIn.CustomFormat = "yyyy-MM-dd HH:mm";
            dateCheckIn.Format = DateTimePickerFormat.Custom;
            dateCheckIn.Location = new Point(70, 4);
            dateCheckIn.Name = "dateCheckIn";
            dateCheckIn.Size = new Size(172, 23);
            dateCheckIn.TabIndex = 3;
            // 
            // btnBook
            // 
            btnBook.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnBook.Location = new Point(3, 4);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(142, 23);
            btnBook.TabIndex = 4;
            btnBook.Text = "Book Room";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnCancel.Location = new Point(151, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel Bookings";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnExit.Location = new Point(447, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // btnViewBookings
            // 
            btnViewBookings.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnViewBookings.Location = new Point(299, 4);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(142, 23);
            btnViewBookings.TabIndex = 7;
            btnViewBookings.Text = "View All Bookings";
            btnViewBookings.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelStatus.Location = new Point(3, 125);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(500, 15);
            labelStatus.TabIndex = 10;
            labelStatus.Text = "Status: ";
            // 
            // labelRoomNum
            // 
            labelRoomNum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelRoomNum.AutoSize = true;
            labelRoomNum.Location = new Point(345, 8);
            labelRoomNum.Name = "labelRoomNum";
            labelRoomNum.Size = new Size(92, 15);
            labelRoomNum.TabIndex = 11;
            labelRoomNum.Text = "Room Number: ";
            // 
            // labelGuestName
            // 
            labelGuestName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelGuestName.AutoSize = true;
            labelGuestName.Location = new Point(3, 8);
            labelGuestName.Name = "labelGuestName";
            labelGuestName.Size = new Size(75, 15);
            labelGuestName.TabIndex = 12;
            labelGuestName.Text = "Guest Name:";
            // 
            // labelCheckIn
            // 
            labelCheckIn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelCheckIn.AutoSize = true;
            labelCheckIn.Location = new Point(3, 8);
            labelCheckIn.Name = "labelCheckIn";
            labelCheckIn.Size = new Size(61, 15);
            labelCheckIn.TabIndex = 13;
            labelCheckIn.Text = "Check-In: ";
            // 
            // labelCheckOut
            // 
            labelCheckOut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            labelCheckOut.AutoSize = true;
            labelCheckOut.Location = new Point(248, 8);
            labelCheckOut.Name = "labelCheckOut";
            labelCheckOut.Size = new Size(71, 15);
            labelCheckOut.TabIndex = 14;
            labelCheckOut.Text = "Check-Out: ";
            // 
            // dateCheckOut
            // 
            dateCheckOut.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dateCheckOut.CustomFormat = "yyyy-MM-dd HH:mm";
            dateCheckOut.Format = DateTimePickerFormat.Custom;
            dateCheckOut.Location = new Point(325, 4);
            dateCheckOut.Name = "dateCheckOut";
            dateCheckOut.Size = new Size(172, 23);
            dateCheckOut.TabIndex = 15;
            // 
            // groupCreateBooking
            // 
            groupCreateBooking.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupCreateBooking.Controls.Add(tableLayoutPanel1);
            groupCreateBooking.Location = new Point(3, 3);
            groupCreateBooking.Name = "groupCreateBooking";
            groupCreateBooking.Size = new Size(512, 174);
            groupCreateBooking.TabIndex = 18;
            groupCreateBooking.TabStop = false;
            groupCreateBooking.Text = "Create a New Booking";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(labelStatus, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 19);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Size = new Size(506, 152);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.Controls.Add(textRoomNumber, 3, 0);
            tableLayoutPanel3.Controls.Add(labelGuestName, 0, 0);
            tableLayoutPanel3.Controls.Add(textGuestName, 1, 0);
            tableLayoutPanel3.Controls.Add(labelRoomNum, 2, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(500, 32);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 4;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(labelCheckIn, 0, 0);
            tableLayoutPanel4.Controls.Add(dateCheckIn, 1, 0);
            tableLayoutPanel4.Controls.Add(labelCheckOut, 2, 0);
            tableLayoutPanel4.Controls.Add(dateCheckOut, 3, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 41);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(500, 32);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.7619076F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.7619038F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.7619038F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.7142859F));
            tableLayoutPanel5.Controls.Add(btnBook, 0, 0);
            tableLayoutPanel5.Controls.Add(btnExit, 3, 0);
            tableLayoutPanel5.Controls.Add(btnViewBookings, 2, 0);
            tableLayoutPanel5.Controls.Add(btnCancel, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 79);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(500, 32);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(groupCreateBooking, 0, 0);
            tableLayoutPanel2.Controls.Add(groupListView, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 180F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(518, 180);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // groupListView
            // 
            groupListView.Controls.Add(listAllBookings);
            groupListView.Dock = DockStyle.Fill;
            groupListView.Location = new Point(3, 183);
            groupListView.Name = "groupListView";
            groupListView.Size = new Size(512, 1);
            groupListView.TabIndex = 19;
            groupListView.TabStop = false;
            groupListView.Text = "Bookings";
            // 
            // listAllBookings
            // 
            listAllBookings.Dock = DockStyle.Fill;
            listAllBookings.Location = new Point(3, 19);
            listAllBookings.Name = "listAllBookings";
            listAllBookings.Size = new Size(506, 0);
            listAllBookings.TabIndex = 0;
            listAllBookings.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 180);
            Controls.Add(tableLayoutPanel2);
            Name = "MainForm";
            Text = "Hotel Booking Manager";
            groupCreateBooking.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            groupListView.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textGuestName;
        private TextBox textRoomNumber;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateCheckIn;
        private Button btnBook;
        private Button btnCancel;
        private Button btnExit;
        private Button btnViewBookings;
        private Label labelStatus;
        private Label labelRoomNum;
        private Label labelGuestName;
        private Label labelCheckIn;
        private Label labelCheckOut;
        private DateTimePicker dateCheckOut;
        private GroupBox groupBooking;
        private GroupBox groupCreateBooking;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private GroupBox groupListView;
        private ListView listAllBookings;
    }
}
