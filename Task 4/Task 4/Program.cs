namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventManager eventManager = new EventManager();

            eventManager.AddHandler(() => Console.WriteLine("Event handler 1"));
            eventManager.AddHandler(() => Console.WriteLine("Event handler 2"));

            eventManager.TriggerEvent();
        }
    }
}