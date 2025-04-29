namespace Homeworks;

public class Car
{
    public string Type;
    public string Name;
    public int max_passangers;
    public bool is_good_condition=true;


    public Car(string type, string name, int maxPassangers)
    {
        Type = type;
        Name = name;
        max_passangers = maxPassangers;
    }
    
}