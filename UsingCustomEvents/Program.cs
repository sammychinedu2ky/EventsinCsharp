// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var pub = new Publisher();
var sub = new Subscriber(pub);
var sub2 = new Subscriber(pub);
pub.DoSomething("swac");

public class CustomEventArgs : EventArgs
{
    public string? Message { get; set; }
}
public class Publisher
{
    public delegate void CustomEventHandler(object sender, CustomEventArgs e);
    public event CustomEventHandler? RaiseEvent;

    public void DoSomething(string message)
    {
        RaiseEvent?.Invoke(this, new CustomEventArgs { Message = message });
    }

}


public class Subscriber
{

    public Subscriber(Publisher publisher)
    {
        publisher.RaiseEvent += HandleEvent;
    }

    private void HandleEvent(object? sender, CustomEventArgs e)
    {
        Console.WriteLine($"Event message is {e.Message}");
    }
}
