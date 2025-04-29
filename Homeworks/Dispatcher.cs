namespace Homeworks;

public class Dispatcher
{
    public string Name;
    public List<Driver> blockeddrivers = new List<Driver>();


    public Dispatcher(string name)
    {
        Name = name;
    }



    public void give_car_to_reys(Reys r, Car c)
    {
        switch (c.is_good_condition)
        {
            case false:
                Console.WriteLine("Car condition is not correct choose another car");
                break;
            case true:
                r.car = c;
                Console.WriteLine("Car picked up");
                break;
        }
    }


    public void give_reys(Driver d, Reys r)
    {
        if (blockeddrivers.Contains(d))
            Console.WriteLine("Driver is blocked");
        
        else
        {
            switch (r.is_completed) 
            {
               case true:
                Console.WriteLine("Reys cant be given because it is completed");
                break;
               case false:
                d.Reys = r;
                Console.WriteLine($"Reys number: {r.Number} was given to a driver: {d.Name} journey by {r.car.Name}");
                break;
            }
        
        }
    }

    public void BlockDriver(Driver d)
    {
        blockeddrivers.Add(d);
        Console.WriteLine("Blocked driver");
    }
}