// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pub = new Publisher();
var sub = new Subscriber(pub);
var sub2 = new Subscriber(pub);
pub.DoSomething();
public class Publisher
{
    public event EventHandler? RaiseEvent;

    public void DoSomething()
    {
        RaiseEvent?.Invoke(this, EventArgs.Empty);
    }

}


public class Subscriber
{

    public Subscriber(Publisher publisher)
    {
        publisher.RaiseEvent += HandleEvent;
    }

    private void HandleEvent(object? sender, EventArgs e)
    {
        Console.WriteLine($"Event message is {e}");
    }
}
