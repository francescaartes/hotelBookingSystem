class HotelBookingSystem
{
    static void Main()
    {
        Console.WriteLine("Hotel Booking System");

        bool run = true;

        while (run)
        {
            string? menu = HotelMenu();
            
            switch (menu)
            {
                case "1":
                    System.Console.Write("\nEnter your name: ");
                    string? userName = Console.ReadLine();
                           
                    DisplayRooms(Room.standardPrice, Room.deluxePrice, Room.suitePrice);

                    bool selectRoom = true;
                    while (selectRoom)
                    {
                        System.Console.Write("\nEnter the type of room (1-3): ");
                        string? roomType = Console.ReadLine();

                        if (roomType != "1" && roomType != "2" && roomType != "3")
                        {
                            System.Console.WriteLine("\nInvalid room type! Please try again.");
                            continue;
                        }

                        bool roomAvailable = Room.CheckRoomAvailability(roomType);

                        if (roomAvailable)
                        {
                            System.Console.WriteLine("\n\tSorry, your desired room type is not available");
                            continue;
                        }
                        else
                        {
                            selectRoom = false;
                            
                            System.Console.Write("Enter the date of check-in (MM/DD/YYYY): ");
                            DateTime checkIn = CheckDateFormat();
                            System.Console.Write("Enter the date of check-out (MM/DD/YYYY): ");
                            DateTime checkOut = CheckDateFormat();

                            TimeSpan duration = checkOut.Date.Subtract(checkIn.Date);
                            int roomDays = Convert.ToInt16(duration.TotalDays);

                            DateOnly checkInDate = DateOnly.FromDateTime(checkIn);
                            DateOnly checkOutDate = DateOnly.FromDateTime(checkOut);
                            
                            Room room = new Room(roomType, roomDays);

                            System.Console.Write("\nDo you want to confirm your booking? (Y/N) - ");
                            string? confrm = Console.ReadLine().ToUpper();
                            
                            if (confrm == "Y") 
                            {
                                System.Console.WriteLine("\n\t                  THE SYNTAX HOTEL                ");
                                System.Console.WriteLine("\t+================================================+");
                                System.Console.WriteLine($"\t    Name          :  {userName}");
                                System.Console.WriteLine($"\t    Date          :  {checkInDate:MM/dd/yyyy} - {checkOutDate:MM/dd/yyyy}");
                                System.Console.WriteLine($"\t    Room Type     :  {room.Type}");
                                System.Console.WriteLine($"\t    Room No.      :  {room.Number}");
                                System.Console.WriteLine($"\t    Total Price   :  P{room.Price}");
                                System.Console.WriteLine("\t+================================================+");
                                System.Console.WriteLine("\nBooking confirmed! Thank you!\n");
                                
                                Booking booking = new Booking(userName, room.Type, checkInDate, checkOutDate, room.Number, room.Price);
                                booking.AddBooking();
                            }
                            else break;
                        }
                    }
                    break;

                case "2":
                    DisplayRooms(Room.standardPrice, Room.deluxePrice, Room.suitePrice);
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
    private static string? HotelMenu()
    {
        string? userChoice;
        Console.WriteLine();
        Console.WriteLine("+++ THE SYNTAX HOTEL +++");
        Console.WriteLine("1. Book a hotel room");
        Console.WriteLine("2. View hotel room prices");
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
        System.Console.WriteLine($"\t| 1. Standard  |    P{standardPrice}    |");
        System.Console.WriteLine("\t+==============+=============+");
        System.Console.WriteLine($"\t| 2. Deluxe    |    P{deluxePrice}    |");
        System.Console.WriteLine("\t+==============+=============+");
        System.Console.WriteLine($"\t| 3. Suite     |    P{suitePrice}    |");
        System.Console.WriteLine("\t+==============+=============+");
    }
    private static DateTime CheckDateFormat()
    {
        while (true)
        {
            try
            {
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", null );
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
        System.Console.WriteLine();
        if (Booking.bookings.Count == 0) System.Console.WriteLine("\tThere are no bookings yet!");
        foreach (Booking booking in Booking.bookings)
        {
            System.Console.WriteLine("\t+-------------------------------+");
            System.Console.WriteLine($"\t   Name: {booking.Name}");
            System.Console.WriteLine($"\t   Check-in Date: {booking.CheckInDate:MM/dd/yyyy}");
            System.Console.WriteLine($"\t   Check-out Date: {booking.CheckOutDate:MM/dd/yyyy}");
            System.Console.WriteLine($"\t   Room Type: {booking.RoomType}");
            System.Console.WriteLine($"\t   Room Number: {booking.RoomNumber}");
            System.Console.WriteLine($"\t   Total Price: P{booking.TotalPrice}");
        }
    }
}