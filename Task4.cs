
namespace ConsoleApp12
{
    internal class Task4
    {
        static int Calcul(string input)
        {
            int result = 1;
            int number = 0;
            bool isFirstNumber = true;

            foreach (char c in input)
            {
                if (c == '*')
                {
                    result *= number;
                    isFirstNumber = true;
                }
                else if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    if (isFirstNumber)
                    {
                        number = digit;
                        isFirstNumber = false;
                    }
                    else
                    {
                        number = number * 10 + digit;
                    }
                }
                else
                {
                    throw new FormatException();
                }
            }

            result *= number;
            return result;
        }
        public static void Task()
        {
            Console.WriteLine("Input: ");
            string input = Console.ReadLine();
            try
            {
                int result = Calcul(input);
                Console.WriteLine("Res: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR");
            }
            catch (OverflowException)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
