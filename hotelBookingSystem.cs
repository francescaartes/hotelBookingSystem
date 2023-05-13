Console.WriteLine("Welcome to Hotel Booking System!" );

bool hotelBookingSystem = true;

    int singleRooms = 15;
    int doubleRooms = 10;
    int familyRooms = 5; 

while(hotelBookingSystem) {
    Console.WriteLine();
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Book a hotel room");
    Console.WriteLine("2. View hotel rooms");
    Console.WriteLine("3. Exit");

    System.Console.Write("Enter the number (1-3): ");
    string? selectedMenu = Console.ReadLine();

    switch(selectedMenu) {
        case "1":
            System.Console.WriteLine("\nHotel Rooms: ");

            System.Console.WriteLine("\tType of Rooms:      No. of Available rooms:");
            System.Console.WriteLine("\t1. Single           " + singleRooms);
            System.Console.WriteLine("\t2. Double           " + doubleRooms);
            System.Console.WriteLine("\t3. Family           " + familyRooms);

            System.Console.Write("\nEnter the type of room (1-3): ");
            string? roomType = Console.ReadLine();
            
            System.Console.Write("Enter the date (MM/DD/YYYY): ");
            string? dateBooked = Console.ReadLine();

            if (roomType == "1") {
                singleRooms = singleRooms - 1;
                roomType = "Single Room";
                }
            else if (roomType == "2") {
                doubleRooms = doubleRooms - 1;
                roomType = "Double Room";
                }
            else if(roomType == "3") {
                familyRooms = familyRooms - 1;
                roomType = "Family Room";
                }

            System.Console.WriteLine("\nYou have successfully booked a " + roomType + " on " + dateBooked);
        break;
    
        case "2":
            System.Console.WriteLine("\nHotel Rooms: ");

            System.Console.WriteLine("\tType of Rooms:      No. of Available rooms:");
            System.Console.WriteLine("\t1. Single           " + singleRooms);
            System.Console.WriteLine("\t2. Double           " + doubleRooms);
            System.Console.WriteLine("\t3. Family           " + familyRooms);
        break;

        case "3":
            System.Console.WriteLine("\nThank you for using Hotel Booking System!");
            hotelBookingSystem = false;
        break;

        default:
            System.Console.WriteLine("\n Invalid number! Please try again.");
        break;
    }
}