class Room
{
    public int standard = 5;
    public int deluxe = 3;
    public int suite = 2;
    public int standardPrice = 1500;
    public int deluxePrice = 3000;
    public int suitePrice = 5000;
    public string? RoomType { get; set; }
    public int RoomNum { get; set; }
    public int RoomPrice { get; set; }

    public void GetRoomType(string roomType)
    {
        switch (roomType)
        {
            case "1":
                standard = standard - 1;
                RoomType = "Standard";
                break;

            case "2":
                deluxe = deluxe - 1;
                RoomType = "Deluxe";
                break;

            case "3":
                suite = suite - 1;
                RoomType = "Suite";
                break;

            default:
                RoomType = "";
                break;
        }
    }
    public void GetRoomNum()
    {
        Random random = new Random();

        switch (RoomType)
        {
            case "Standard":
                RoomNum = random.Next(100, 200);
                break;

            case "Deluxe":
                RoomNum = random.Next(200, 300);
                break;

            case "Suite":
                RoomNum = random.Next(300, 400);
                break;

            default:
                RoomNum = 0;
                break;
        }
    }
    public void GetRoomPrice(int roomDays)
    {
        switch (RoomType)
        {
            case "Standard":
                RoomPrice = standardPrice * roomDays;
                break;

            case "Deluxe":
                RoomPrice = deluxePrice * roomDays;
                break;

            case "Suite":
                RoomPrice = suitePrice * roomDays;
                break;

            default:
                RoomPrice = 0;
                break;
        }
    }
}