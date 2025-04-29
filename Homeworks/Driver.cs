namespace Homeworks;

public class Driver
{
    public string Name;
    public Reys Reys;

    private bool blocked;


    public Driver(string name)
    {
        Name = name;
    }


    public void MarkAsCompleted()
    {
        Console.WriteLine($"Is car {Reys.car.Name} conditions correct? enter A or B (A=True, B=False)");
        var con = Console.ReadLine();
        if (con == "A")
        {
            Reys.car.is_good_condition = true;
            Console.WriteLine($" Car is {Reys.car.Name} conditions correct");
            Reys.is_completed = true;
            Console.WriteLine($" Reys number: {Reys.Number} is marked as completed");
            Reys=null;
        }
        else
        {
            Reys.car.is_good_condition = false;
            Console.WriteLine($" Car is {Reys.car.Name} conditions is not correct");
            Reys.is_completed = true;
            Console.WriteLine($" Reys number: {Reys.Number} is marked as completed");
            Reys=null;
        }
       
    }
    

    public void Fix(Car c)
    {
        Console.WriteLine("What is a problem with car?");
        Console.ReadLine();
        c.is_good_condition = false;
        Console.WriteLine($" Car  {c.Name}  was sent to be repaired");
        
    }
}