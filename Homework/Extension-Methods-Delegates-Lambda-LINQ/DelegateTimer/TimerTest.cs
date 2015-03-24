namespace DelegateTimer
{
    using System;
    using System.Threading.Tasks;

    public class TimerTest
    {
        public static void Main()
        {

            Timer timer = new Timer(2, 10, Print);
            Console.Write("Loading ");
            Console.CursorVisible = false;
            timer.Run();

        }
        public static void Print()
        {
            Console.Write(".");
        }
    }
}
