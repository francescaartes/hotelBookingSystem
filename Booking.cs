class Booking
{
    public string? Name { get; set; }
    public DateOnly CheckInDate { get; set; }
    public DateOnly CheckOutDate { get; set; }
    public string? RoomType { get; set; }
    public int RoomNumber { get; set; }
    public int TotalPrice { get; set; }
    public static List<Booking> bookings = new List<Booking>();

    public void AddBooking(string? userName, string? roomType, DateOnly checkInDate, DateOnly checkOutDate, int roomNum, int roomPrice)
    {
        Booking boooking = new Booking
        {
            Name = userName,
            CheckInDate = checkInDate,
            CheckOutDate = checkOutDate,
            RoomType = roomType,
            RoomNumber = roomNum,
            TotalPrice = roomPrice
        };
        bookings.Add(boooking);
    }
}