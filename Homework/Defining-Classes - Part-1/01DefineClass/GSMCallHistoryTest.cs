namespace _01DefineClass
{
    using System;
    class GSMCallHistoryTest
    {

        public void Display()
        {
            GSM gsm = new GSM("HTC One", "HTC");
            gsm.AddCall(new Call(DateTime.Now,"+38970545885",240));
            gsm.AddCall(new Call(DateTime.Now.Add(new TimeSpan(4,4,4)), "+38970545885", 240));
            gsm.AddCall(new Call(DateTime.Now.Add(new TimeSpan(5, 5, 5)), "+38970545555", 300));

            foreach (Call k in gsm.CallHistory)
            Console.WriteLine(k.ToString());

            Console.WriteLine();
            Console.WriteLine("Price of all calls: "+gsm.CalcCallPrice(0.37));

            Call longes = new Call(DateTime.Now,"",0);


            foreach(Call k in gsm.CallHistory)
            {
                if (k.Duration > longes.Duration)
                    longes = k;
            }

            gsm.DeleteCall(longes);
            Console.WriteLine("Price after deleted (longest duration): "+gsm.CalcCallPrice(0.37));

            gsm.ClearCallHistory();

            foreach (Call k in gsm.CallHistory)
                Console.WriteLine(k.ToString());
        }

    }
}
