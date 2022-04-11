namespace Model
{
    public class DigitalStopWatch
    {
        public bool IsRunning { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DigitalStopWatch()
        {
            IsRunning = false;
            Console.WriteLine("----------------- Digital Stop Watch ------------------------------");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("");
        }
        public bool Start()
        {
            if (IsRunning)
            {
                Console.WriteLine("Stopwatch is already running...");
                return false;
            }
            IsRunning = true;
            StartTime = DateTime.Now;
            Console.WriteLine("Stopwatch started...");
            return true;
        }

        public bool Stop()
        {
            if (!IsRunning)
            {
                Console.WriteLine("Stopwatch is not running...");
                return false;
            }
            IsRunning = false;
            EndTime = DateTime.Now;
            Console.WriteLine("Stopwatch is stopped...");
            Console.WriteLine("");
            Console.WriteLine("Time Elapsed:");
            Console.WriteLine(EndTime.ToUniversalTime() - StartTime.ToUniversalTime());
            Console.WriteLine("");
            Console.WriteLine("");
            return true;
        }


    }
}