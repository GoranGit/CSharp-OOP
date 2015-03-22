namespace Test.ProgramTests
{
    using System;
    using Structure;

    [Version("2.1")]
   public class TestAttribute
    {
       public static void Test()
        {
            Type type = typeof(TestAttribute);
          var allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute  attr in allAttributes)
            {
                Console.WriteLine("This class has version {0}", attr.Version);
                
            }
        }
    }
}
 