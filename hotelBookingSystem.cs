Console.WriteLine("WELCOME TO SYNTAX HOTEL!");

bool hotelBookingSystem = true;

int standard = 1;
int deluxe = 3;
int suite = 2;

int standardPrice = 1500;
int deluxePrice = 3000;
int suitePrice = 5000;
int roomPrice = 0;

while (hotelBookingSystem)
{
    Console.WriteLine();
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Book a hotel room");
    Console.WriteLine("2. View hotel rooms and prices");
    Console.WriteLine("0. Exit");

    System.Console.Write("Enter the number: ");
    string? selectedMenu = Console.ReadLine();

    switch (selectedMenu)
    {
        case "1":
            System.Console.Write("Name: ");
            string? userName = Console.ReadLine();

            System.Console.WriteLine("\t+=============================+");
            System.Console.WriteLine("\t|       THE SYNTAX HOTEL      |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| Type of Rooms |    Price    |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| 1. Standard   |    P" + standardPrice + "    |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| 2. Deluxe     |    P" + deluxePrice + "    |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| 3. Suite      |    P" + suitePrice + "    |");
            System.Console.WriteLine("\t+===============+=============+");

            System.Console.Write("\nEnter the type of room (1-3): ");
            string? roomType = Console.ReadLine();
            
            System.Console.Write("Enter the date (MM/DD/YYYY): ");
            string? dateBooked = Console.ReadLine();

            if (roomType == "1")
            {
                if (standard == 0)
                    {
                        System.Console.WriteLine("\nSorry, there are no more standard rooms available.");
                        break;
                    }
                standard = standard - 1;
                roomType = "Standard";
                roomPrice = standardPrice;
            }
            else if (roomType == "2")
            {
                if (deluxe == 0)
                    {
                        System.Console.WriteLine("Sorry, there are no more deluxe rooms available.");
                        break;
                    }
                deluxe = deluxe - 1;
                roomType = "Deluxe";
                roomPrice = deluxePrice;
            }
            else if (roomType == "3")
            {
                if (deluxe == 0)
                    {
                        System.Console.WriteLine("Sorry, there are no more suites available.");
                        break;
                    }
                suite = suite - 1;
                roomType = "Suite";
                roomPrice = suitePrice;
            }
            
            Random rnd = new Random();
            int referenceNum = rnd.Next(100000, 999999);
            int roomNum = rnd.Next(001, 100);

            System.Console.WriteLine("\nBooked Confirmed! Thank you!\n");
            System.Console.WriteLine("\t+============================+");
            System.Console.WriteLine("\t    Ref No.    :  " + referenceNum);
            System.Console.WriteLine("\t    Name       :  " + userName);
            System.Console.WriteLine("\t    Date       :  " + dateBooked);
            System.Console.WriteLine("\t    Room Type  :  " + roomType);
            System.Console.WriteLine("\t    Room No.   :  " + roomNum);
            System.Console.WriteLine("\t    Price      :  " + roomPrice);
            System.Console.WriteLine("\t+============================+");
            break;

        case "2":
            System.Console.WriteLine("\t+=============================+");
            System.Console.WriteLine("\t|       THE SYNTAX HOTEL      |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| Type of Rooms |    Price    |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| 1. Standard   |    P" + standardPrice + "    |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| 2. Deluxe     |    P" + deluxePrice + "    |");
            System.Console.WriteLine("\t+===============+=============+");
            System.Console.WriteLine("\t| 3. Suite      |    P" + suitePrice + "    |");
            System.Console.WriteLine("\t+===============+=============+");
            break;

        case "0":
            System.Console.WriteLine("\nThank you for coming to THE SYNTAX HOTEL!");
            hotelBookingSystem = false;
            break;

        default:
            System.Console.WriteLine("\n Invalid number! Please try again.");
            break;
    }
}