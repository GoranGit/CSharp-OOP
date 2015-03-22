
namespace Test.ProgramTests
{
    using System;
    using Structure;
    public static class TestGenericList
    {
       public static void Test()
       {
           GenericList<int> k = new GenericList<int>(4);
           k.Add(3);
           k.Add(4);
           k.Add(5);
           k.InsertAt(1,324);
           k.Add(10);
           k.Add(11);
           Console.WriteLine(k.ToString());
           Console.WriteLine("Max ={0} Min= {1} \n Element at index 3 is:{2} \n Index of element 324 is:{3}",k.Max(),k.Min(),k[3],k.IndexOf(324));
           k.Clear();
           Console.WriteLine(k.ToString());
       }

    }
}
