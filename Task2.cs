
namespace ConsoleApp12
{
    internal class Task2
    {
        public static void Task()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            //int number = BinaryStringToInt(input);
            //Console.WriteLine("Введене число: " + number);
            try
            {
                int result = 0;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] == '1')
                    {
                        result += (int)Math.Pow(2, input.Length - 1 - i);
                    }
                    else if (input[i] != '0')
                    {
                        throw new FormatException();
                    }
                }
                Console.WriteLine(result);
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
