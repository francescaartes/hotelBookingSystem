class StandardRoom : Room
{
    public static int availableStandard = 5;
    public static int standardPrice = 1500;

    public StandardRoom(string roomType, int roomDays) : base(roomType, roomDays) { }

    protected override string GetRoomType(string roomType)
    {
        availableStandard--;
        return "Standard";
    }

    protected override int GetRoomNum()
    {
        Random random = new Random();
        return random.Next(100, 200);
    }

    protected override int GetRoomPrice(int roomDays)
    {
        return standardPrice * roomDays;
    }
}