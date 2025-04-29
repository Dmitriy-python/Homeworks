namespace Homeworks;

public class Station
{
    public string Name;
    
    public List<Train> trains = new List<Train>();


    public Station(string name)
    {
        Name = name;
    }


    public void FindTrain(string place, string time, string date)
    {
        Train foundtrain = null;
        foreach (var t in trains)
        {
            if (t.Place == place && t.Time == time && t.Date == date)
            {
                 foundtrain = t;
            }
        }
        if (foundtrain == null)
            Console.WriteLine("No train found");
        else
        {
            Console.WriteLine($"Suitable train number: {foundtrain.TrainNumber}");
            Console.WriteLine("Do you want to register it? (y/n)");
            var input = Console.ReadLine();

            switch (input)
            {
                case "y":
                    Console.WriteLine($"Заявка одобрена сумма чека {foundtrain.Cost}");
                    break;
                case "n":
                    Console.WriteLine("Заявка отменена");
                    break;
            }
            
            
        }
            
        
    }

 

    public void AddTrain(Train train)
    {
        trains.Add(train);
    }
    
    
}