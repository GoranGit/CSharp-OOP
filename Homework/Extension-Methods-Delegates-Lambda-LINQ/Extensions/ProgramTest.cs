
namespace Extensions
{
    using System;
    using System.Collections;
    using Extensions.IEnumerableExtensions;
    using Extensions.StringBuilderExtensions;
    using System.Text;

    public class ProgramTest
    {
        public static void Main()
        {
            StringBuilder str = new StringBuilder("Hello World!");
            Console.WriteLine(str);
            Console.WriteLine(str.Substring(6, 5).ToString());
            int[] array = new int[10];
            for(int i=0;i<10;i++)
            {
                array[i] = i+1;
                Console.WriteLine(i+1);
            }
            Console.WriteLine("Sum = {0} \n Product = {1} \n min = {2} \n max = {3} \n average={4}",array.Sum(),array.Product(),array.Min(),array.Max(), array.Average());
         
        }
    }
}
