class Room
{
    public string? Type { get; private set; }
    public int Number { get; private set; }
    public int Price { get; private set; }
    public Room(string roomType, int roomDays)
    {
        Type = GetRoomType(roomType);
        Number = GetRoomNum();
        Price = GetRoomPrice(roomDays);
    }
    protected virtual string GetRoomType(string roomType)
    {
        return "";
    }
    protected virtual int GetRoomNum()
    {
        return 0;
    }
    protected virtual int GetRoomPrice(int roomDays)
    {
        return 0;
    }
    public static bool CheckRoomAvailability(string roomType)
    {
        if (StandardRoom.availableStandard == 0 && roomType == "1")
        {
            return true;
        }
        else if (DeluxeRoom.availableDeluxe == 0 && roomType == "2")
        {
            return true;
        }
        else if (SuiteRoom.availableSuite == 0 && roomType == "3")
        {
            return true;
        }
        else return false;
    }
}