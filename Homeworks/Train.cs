namespace Homeworks;

public class Train
{
    public int TrainNumber;
    public string Place;
    public string Time;
    public string Date;
    public int Cost;


    public Train(int trainNumber, string place, string time, string date, int cost)
    {
        TrainNumber = trainNumber;
        Place = place;
        Time = time;
        Date = date;
        Cost =cost;
    }
}