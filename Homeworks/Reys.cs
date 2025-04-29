namespace Homeworks;

public class Reys
{
    public int Number;
    public string City_to_leave;
    public string City_to_reach;
    public int    Time_of_way;
    public int    price;
    public Car car;
    public bool is_completed;

    public Reys(int number,string cityToLeave, string cityToReach, int timeOfWay, int price)
    {
        Number = number;
        City_to_leave = cityToLeave;
        City_to_reach = cityToReach;
        Time_of_way = timeOfWay;
        this.price = price;
    }

    public Reys(bool isCompleted)
    {
        is_completed = false;
    }
}