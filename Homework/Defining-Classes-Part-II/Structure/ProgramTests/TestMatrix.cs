namespace Test.ProgramTests
{
    using System;
    using Structure;
    using Test.ProgramTests;
    public static class TestMatrix
    {
        public static void Test()
        {
           
            Matrix<int> operandOne = new Matrix<int>(3, 7);
            Matrix<int> operandTwo = new Matrix<int>(3, 7);
            Matrix<int> operandThree = new Matrix<int>(7, 3);


           for (int i = 0; i < 3; i++)
               for (int j = 0; j < 7; j++)
               {
                   operandOne[i, j] = j;
                   operandTwo[i, j] = i;
               }

           for (int i = 0; i < 7; i++)
               for (int j = 0; j < 3; j++)
               {
                   operandThree[i, j] = j;
               }

           Console.WriteLine("Operand one matrix = \n {0}", operandOne.ToString());
           Console.WriteLine("Operand two matrix = \n {0}", operandTwo.ToString());
           Console.WriteLine("Operand three matrix= \n {0}", operandThree.ToString());

           Console.WriteLine("OperandOne+OperandTwo = \n {0}",operandOne + operandTwo);
           Console.WriteLine("OperandOne-OperandTwo = \n {0}", operandOne - operandTwo);
           Console.WriteLine("OperandOne*OperandThree = \n {0}", operandOne * operandThree);
           if (operandTwo)
           {
               Console.WriteLine("The operand two matrix doesn't contains 0");
           }
           else
               Console.WriteLine("The operand two matrix contains 0");
        }
      
    }
}
