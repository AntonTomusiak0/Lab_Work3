
namespace ConsoleApp12
{
    internal class Task1
    {
        public static void Task()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                Console.WriteLine("Number: " + number);
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR INT SIZE");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR INPUT ONLY NUMBERS");
            }
        }
    }     
}