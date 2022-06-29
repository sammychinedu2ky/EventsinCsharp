// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pub = new Publisher();
var sub = new Subscriber(pub);
var sub2 = new Subscriber(pub);
pub.DoSomething("swac");
public class Publisher
{
    public event EventHandler<string>? RaiseEvent;

    public void DoSomething(string message)
    {
        RaiseEvent?.Invoke(this, message);
    }
   
}


public class Subscriber {

    public  Subscriber(Publisher publisher)
    {
        publisher.RaiseEvent += HandleEvent;
    }
    
    private void HandleEvent(object? sender, string e)
    {
        Console.WriteLine($"Event message is {e}");
    }
}
