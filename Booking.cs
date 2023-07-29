class Booking
{
    public string? Name { get; private set; }
    public DateOnly CheckInDate { get; private set; }
    public DateOnly CheckOutDate { get; private set; }
    public string? RoomType { get; private set; }
    public int RoomNumber { get; private set; }
    public int TotalPrice { get; private set; }
    public static List<Booking> bookings = new List<Booking>();

    public void AddBooking(string? userName, string? roomType, DateOnly checkInDate, DateOnly checkOutDate, int roomNum, int roomPrice)
    {
        Booking booking = new Booking
        {
            Name = userName,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate,
            RoomType = roomType,
            RoomNumber = roomNum,
            TotalPrice = roomPrice,
        };
        bookings.Add(booking);
    }

    public bool CancelBooking(string bookingName)
    {
        foreach (Booking booking in bookings)
        {
            if (bookingName == booking.Name)
            {
                bookings.Remove(booking);
                if (booking.RoomType == "Standard")
                {
                    StandardRoom.availableStandard++;
                }
                else if (booking.RoomType == "Deluxe")
                {
                    DeluxeRoom.availableDeluxe++;
                }
                else if (booking.RoomType == "Suite")
                {
                    SuiteRoom.availableSuite++;
                }
                return true;
            }
        }
        return false;
    }
}