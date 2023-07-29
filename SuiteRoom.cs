class SuiteRoom : Room
{
    public static int availableSuite = 1;
    public static int suitePrice = 5000;

    public SuiteRoom(string roomType, int roomDays) : base(roomType, roomDays) { }

    protected override string GetRoomType(string roomType)
    {
        availableSuite--;
        return "Suite";
    }

    protected override int GetRoomNum()
    {
        Random random = new Random();
        return random.Next(300, 400);
    }

    protected override int GetRoomPrice(int roomDays)
    {
        return suitePrice * roomDays;
    }
}