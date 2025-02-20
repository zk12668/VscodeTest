namespace 里氏替换;

public class Car
{
    public string Color { get; set; }
    public double Length {get; set; }
    public void Run()
    {
        Console.WriteLine($"长{Length}米的{Color}车开了");
       
    }

}
public class Truck:Car
{
    //public  string Color { get; set; }
    //public  double Length {get; set; }
    public string Carriage { get; set; }
    
    public void Freight()
    {
          
          Console.WriteLine($"长{Length}米的{Color}{Carriage}车开了");
    }

}

public class Bus:Car
{
    public  string Color { get; set; }
    public  double Length {get; set; }
    //public string Carriage { get; set; }
    
    public void Run()
    {
          
          Console.WriteLine($"长{Length}米的{Color}车开了");
    }

}
public class SUV:Car
{
    //public  string Color { get; set; }
    //public  double Length {get; set; }
    public string seat { get; set; }
    
  



}