namespace Structure
{
    using System;
    using Test.ProgramTests;
    using System.Collections.Generic;
    public class StartProgram
    {
        public static void Main()
        {
            TestAttribute.Test();
            TestPoints.Test();
            TestGenericList.Test();
            TestMatrix.Test();

        }
    }
}
