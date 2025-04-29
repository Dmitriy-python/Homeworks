namespace Homeworks;

public class Passanger
{
    public string Name;


    public Passanger(string name)
    {
        Name = name;
    }


    public void Zayavka(Station s)
    {
        Console.WriteLine("Укажите место назначения");
        var place=Console.ReadLine();
        Console.WriteLine("Укажите дату");
        var data=Console.ReadLine();
        Console.WriteLine("Укажите время");
        var time=Console.ReadLine();
        
        s.FindTrain(place, time, data);
    }
}