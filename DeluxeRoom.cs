class DeluxeRoom : Room
{
    public static int availableDeluxe = 3;
    public static int deluxePrice = 3000;

    public DeluxeRoom(string roomType, int roomDays) : base(roomType, roomDays) { }

    protected override string GetRoomType(string roomType)
    {
        availableDeluxe--;
        return "Deluxe";
    }

    protected override int GetRoomNum()
    {
        Random random = new Random();
        return random.Next(200, 300);
    }

    protected override int GetRoomPrice(int roomDays)
    {
        return deluxePrice * roomDays;
    }
}
