namespace _01DefineClass
{
    using System;
    using System.Collections.Generic;
    class GSMTest
    {
        private List<GSM> arrayGSM = new List<GSM>() {new GSM("SamsungS3","Samsung",5.6,"Aleksandra",new Battery("Lilon"),new Display(4,1600000)), new GSM("IPhoneS4","Apple",0,"",new Battery("Lilon"),new Display(3,12432354))};

        public void DisplayInfo()
        {
            GSM.IPhone4S = "The best phone ever!";
            foreach(GSM k in arrayGSM)
            {
                Console.WriteLine(k.ToString());
                
            }
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}
