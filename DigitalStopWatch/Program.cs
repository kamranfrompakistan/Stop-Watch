using Model;

namespace StopWatchConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? Option;
            bool ExitProgram;
            DigitalStopWatch StopWatch = new DigitalStopWatch();

            ExitProgram = false;

            while (!ExitProgram)
            {
                Console.WriteLine("Enter your choice 1 for start, 2 for stop, any other key for exit");
                Option = Console.ReadLine().Trim();

                switch (Option)
                {
                    case "1":
                        StopWatch.Start();
                        break;
                    case "2":
                        StopWatch.Stop();
                        break;
                    default:
                        ExitProgram = true;
                        break;
                }
            }
        }
    }
}
