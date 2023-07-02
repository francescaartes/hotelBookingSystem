class Room
{
    public static int standard = 5;
    public static int deluxe = 3;
    public static int suite = 1;
    public static int standardPrice = 1500;
    public static int deluxePrice = 3000;
    public static int suitePrice = 5000;
    public string? Type { get; private set; }
    public int Number { get; private set; }
    public int Price { get; private set; }
    public Room(string roomType, int roomDays)
    {
        Type = GetRoomType(roomType);
        Number = GetRoomNum();
        Price = GetRoomPrice(roomDays);
    }

    private string GetRoomType(string roomType)
    {
        switch (roomType)
        {
            case "1":
                standard = standard - 1;
                return "Standard";

            case "2":
                deluxe = deluxe - 1;
                return "Deluxe";

            case "3":
                suite = suite - 1;
                return "Suite";

            default:
                return "";
        }
    }
    private int GetRoomNum()
    {
        Random random = new Random();

        switch (Type)
        {
            case "Standard":
                return random.Next(100, 200);

            case "Deluxe":
                return random.Next(200, 300);

            case "Suite":
                return random.Next(300, 400);

            default:
                return 0;
        }
    }
    private int GetRoomPrice(int roomDays)
    {
        switch (Type)
        {
            case "Standard":
                return standardPrice * roomDays;

            case "Deluxe":
                return deluxePrice * roomDays;

            case "Suite":
                return suitePrice * roomDays;

            default:
                return 0;
        }
    }
    public static bool CheckRoomAvailability(string roomType)
    {
        if (standard == 0 && roomType == "1")
        {
            return true;
        }
        else if (deluxe == 0 && roomType == "2")
        {
            return true;
        }
        else if (suite == 0 && roomType == "3")
        {
            return true;
        }
        else return false;
    }
}