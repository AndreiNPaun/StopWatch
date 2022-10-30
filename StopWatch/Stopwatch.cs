using System.Data;

namespace StopWatch;

public class Stopwatch
{
    private int ConvertedInput;
    private string Choice;
    private DateTime dateNow;

    public void Start()
    {
        
        var dateNow = DateTime.Now;
        Console.WriteLine($"Time right now is {dateNow}");
    }

    public TimeSpan Stop()
    {
            var newDate = DateTime.Now;
            var timeSpan = newDate - dateNow;

            Console.WriteLine(timeSpan);

            return timeSpan;
    }

    public void Execute()
    {
        var exit = true;

        Console.WriteLine("Please select from the following list an option:");
        Console.WriteLine("1. Start");
        Console.WriteLine("2. Stop");
        Console.WriteLine("3. Reset");
        Console.WriteLine("4. Exit");

        while (true)
        {

            Choice = Console.ReadLine().ToLower();

            switch (Choice)
            {
                case "1":
                    Start();
                    break;

                case "2":
                    Stop();
                    break;

                case "3":
                    Console.WriteLine("3");
                    break;

                case "4":
                    exit = false;
                    break;

                default:
                    Console.WriteLine("Options does not exist, please try again.");
                    break;
            }

            if (exit == false)
                break;
        }
    }
}