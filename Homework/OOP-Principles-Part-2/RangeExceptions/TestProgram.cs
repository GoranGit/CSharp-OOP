
namespace RangeExceptions
{
    public class TestProgram
    {
        public static void Main()
        {
            try
            {
                Check(50, 2, 45);
            }
            catch(InvalidRangeException<int> e)
            {
                System.Console.WriteLine(e.Message);
                    
            }


        }
        public static void Check(int value,int start,int end)
        {
            if(value<start || value > end)
                throw new InvalidRangeException<int>("invalid range exception!", start, end);

        }
    }
}
