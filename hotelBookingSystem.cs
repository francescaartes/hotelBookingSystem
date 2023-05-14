Console.WriteLine("THE SYNTAX HOTEL");

int standard = 5;
int deluxe = 3;
int suite = 2;

int standardPrice = 1500;
int deluxePrice = 3000;
int suitePrice = 5000;
int roomPrice = 0;

string? userChoice = "";

while (userChoice != "0")
{
    Console.WriteLine();
    Console.WriteLine("Menu: ");
    Console.WriteLine("1. Book a hotel room");
    Console.WriteLine("2. View hotel rooms and prices");
    Console.WriteLine("0. Exit");

    System.Console.Write("Enter the number: ");
    userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            System.Console.Write("\nEnter your name: ");
            string? userName = Console.ReadLine();

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

            System.Console.Write("\nEnter the type of room (1-3): ");
            string? roomType = Console.ReadLine();

            System.Console.Write("Enter how many days you want to stay: ");
            int roomDays = Convert.ToInt16(Console.ReadLine());
            
            System.Console.Write("Enter the date of check-in (MM/DD/YYYY): ");
            string? inDate = Console.ReadLine();
            System.Console.Write("Enter the date of check-out (MM/DD/YYYY): ");
            string? outDate = Console.ReadLine();

            if (roomType == "1")
            {
                if (standard == 0)
                    {
                        System.Console.WriteLine("\nSorry, there are no more standard rooms available.");
                        break;
                    }
                standard = standard - 1;
                roomType = "Standard";
                roomPrice = standardPrice * roomDays;
            }
            else if (roomType == "2")
            {
                if (deluxe == 0)
                    {
                        System.Console.WriteLine("\nSorry, there are no more deluxe rooms available.");
                        break;
                    }
                deluxe = deluxe - 1;
                roomType = "Deluxe";
                roomPrice = deluxePrice * roomDays;
            }
            else if (roomType == "3")
            {
                if (suite == 0)
                    {
                        System.Console.WriteLine("\nSorry, there are no more suites available.");
                        break;
                    }
                suite = suite - 1;
                roomType = "Suite";
                roomPrice = suitePrice * roomDays;
            }
            else 
            {
                System.Console.WriteLine("\nInvalid booking! Please try again.");
                break;
            }

            Random rnd = new Random();
            int referenceNum = rnd.Next(100000000, 999999999);
            int roomNum = rnd.Next(100, 300);
            
            System.Console.WriteLine("\nBook Confirmed! Thank you!\n");
            System.Console.WriteLine("\t                  THE SYNTAX HOTEL                ");
            System.Console.WriteLine("\t+================================================+");
            System.Console.WriteLine("\t    Ref No.       :  " + referenceNum);
            System.Console.WriteLine("\t    Name          :  " + userName);
            System.Console.WriteLine("\t    Date          :  " + inDate + " - " + outDate);
            System.Console.WriteLine("\t    Room Type     :  " + roomType);
            System.Console.WriteLine("\t    Room No.      :  " + roomNum);
            System.Console.WriteLine("\t    Total Price   :  P" + roomPrice + ".00");
            System.Console.WriteLine("\t+================================================+");
            break;

        case "2":
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
            break;

        case "0":
            System.Console.WriteLine("\nThank you for coming to THE SYNTAX HOTEL!");
            break;

        default:
            System.Console.WriteLine("\n Invalid choice! Please try again.");
            break;
    }
}