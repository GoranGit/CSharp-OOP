namespace _01DefineClass
{
    using System;
    class Program
    {
        static void Main()
        {
            GSMTest test = new GSMTest();
            test.DisplayInfo();

            GSMCallHistoryTest test2 = new GSMCallHistoryTest();
            test2.Display();

        }
    }
}
