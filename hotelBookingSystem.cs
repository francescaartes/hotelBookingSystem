class Booking
{
    public string? Name { get; set; }
    public DateOnly CheckInDate { get; set; }
    public DateOnly CheckOutDate { get; set; }
    public string? RoomType { get; set; }
    public int RoomNumber { get; set; }
    public int TotalPrice { get; set; }
}
class hotelBookingSystem 
{
    public static List<Booking> bookings = new List<Booking>();
    static void Main()
    {
        Console.WriteLine("THE SYNTAX HOTEL");

        int standard = 5;
        int deluxe = 3;
        int suite = 2;
        string? roomType = "";

        int standardPrice = 1500;
        int deluxePrice = 3000;
        int suitePrice = 5000;
        int roomPrice = 0;

        bool run = true;

        while (run)
        {
            string menu = HotelMenu();

            switch (menu)
            {
                case "1":
                    System.Console.Write("\nEnter your name: ");
                    string? userName = Console.ReadLine();

                    DisplayRooms(standardPrice, deluxePrice, suitePrice);

                    bool selectRoom = true;
                    while (selectRoom)
                    {
                        System.Console.Write("\nEnter the type of room (1-3): ");
                        roomType = Console.ReadLine();

                        if (roomType != "1" && roomType != "2" && roomType != "3")
                        {
                            System.Console.WriteLine("\nInvalid room type! Please try again.");
                            continue;
                        }
                        else if (standard == 0 || deluxe == 0 || suite == 0)
                        {
                            if (standard == 0 && roomType == "1")
                            {
                                System.Console.WriteLine("\nSorry, there are no more standard rooms available.");
                                continue;
                            }
                            else if (deluxe == 0 && roomType == "2")
                            {
                                System.Console.WriteLine("\nSorry, there are no more deluxe rooms available.");
                                continue;
                            }
                            else if (suite == 0 && roomType == "3")
                            {
                                System.Console.WriteLine("\nSorry, there are no more suites available.");
                                continue;
                            }
                        }
                        else selectRoom = false;
                    }
                    System.Console.Write("Enter the date of check-in (MM/DD/YYYY): ");
                    DateTime checkIn = CheckDateFormat();
                    System.Console.Write("Enter the date of check-out (MM/DD/YYYY): ");
                    DateTime checkOut = CheckDateFormat();

                    TimeSpan duration = checkOut.Date.Subtract(checkIn.Date);
                    int roomDays = Convert.ToInt16(duration.TotalDays);

                    DateOnly checkInDate = DateOnly.FromDateTime(checkIn);
                    DateOnly checkOutDate = DateOnly.FromDateTime(checkOut);

                    Random random = new Random();
                    int roomNum = random.Next();

                    switch (roomType)
                    {
                        case "1":
                            standard = standard - 1;
                            roomType = "Standard";
                            roomNum = random.Next(100, 200);
                            roomPrice = standardPrice * roomDays;
                            break;

                        case "2":
                            deluxe = deluxe - 1;
                            roomType = "Deluxe";
                            roomNum = random.Next(200, 300);
                            roomPrice = deluxePrice * roomDays;
                            break;

                        case "3":
                            suite = suite - 1;
                            roomType = "Suite";
                            roomNum = random.Next(300, 400);
                            roomPrice = suitePrice * roomDays;
                            break;

                        default:
                            System.Console.WriteLine("\nInvalid booking! Please try again.");
                            break;
                    }
                    System.Console.WriteLine("\nBook Confirmed! Thank you!\n");
                    System.Console.WriteLine("\t                  THE SYNTAX HOTEL                ");
                    System.Console.WriteLine("\t+================================================+");
                    System.Console.WriteLine("\t    Name          :  " + userName);
                    System.Console.WriteLine("\t    Date          :  " + checkInDate + " - " + checkOutDate);
                    System.Console.WriteLine("\t    Room Type     :  " + roomType);
                    System.Console.WriteLine("\t    Room No.      :  " + roomNum);
                    System.Console.WriteLine("\t    Total Price   :  P" + roomPrice + ".00");
                    System.Console.WriteLine("\t+================================================+");

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
                    break;

                case "2":
                    DisplayRooms(standardPrice, deluxePrice, suitePrice);
                    break;

                case "3":
                    DisplayBookings();
                    break;

                case "0":
                    System.Console.WriteLine("\nThank you for coming to THE SYNTAX HOTEL!");
                    run = false;
                    break;

                default:
                    System.Console.WriteLine("\n Invalid choice! Please try again.");
                    break;
            }
        }
    }
    private static string HotelMenu()
    {
        string userChoice;
        Console.WriteLine();
        Console.WriteLine("Menu: ");
        Console.WriteLine("1. Book a hotel room");
        Console.WriteLine("2. View hotel rooms and prices");
        Console.WriteLine("3. View bookings");
        Console.WriteLine("0. Exit");
        System.Console.Write("Enter the number: ");
        return userChoice = Console.ReadLine();
    }
    private static void DisplayRooms(int standardPrice, int deluxePrice, int suitePrice)
    {
        System.Console.WriteLine("\n\t+============================+");
        System.Console.WriteLine("\t|      THE SYNTAX HOTEL      |");
        System.Console.WriteLine("\t+==============+=============+");
        System.Console.WriteLine("\t|  Room Types  |    Price    |");
        System.Console.WriteLine("\t+==============+=============+");
        System.Console.WriteLine("\t| 1. Standard  |    P" + standardPrice + "    |");
        System.Console.WriteLine("\t+==============+=============+");
        System.Console.WriteLine("\t| 2. Deluxe    |    P" + deluxePrice + "    |");
        System.Console.WriteLine("\t+==============+=============+");
        System.Console.WriteLine("\t| 3. Suite     |    P" + suitePrice + "    |");
        System.Console.WriteLine("\t+==============+=============+");
    }
    private static DateTime CheckDateFormat()
    {
        while (true)
        {
            try
            {
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null);
                return date;
            }
            catch (FormatException)
            {
                System.Console.Write("\nInvalid date format. \n\nPlease enter a date in MM/DD/YYYY format: ");
            }
        }
    }
    private static void DisplayBookings()
    {
        foreach (Booking booking in bookings)
        {
            System.Console.WriteLine();
            System.Console.WriteLine($"Name: {booking.Name}");
            System.Console.WriteLine($"Check-in Date: {booking.CheckInDate}");
            System.Console.WriteLine($"Check-out Date: {booking.CheckOutDate}");
            System.Console.WriteLine($"Room Type: {booking.RoomType}");
            System.Console.WriteLine($"Room Number: {booking.RoomNumber}");
            System.Console.WriteLine($"Total Price: P{booking.TotalPrice}");
        }
    }
}