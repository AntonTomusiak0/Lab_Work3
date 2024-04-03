namespace ConsoleApp12
{
    internal class CreditCard
    {
        public string Number { get; set; }
        public string PIP { get; set; }
        public string CVC { get; set; }
        public int expirDateYear { get; set; }
        public static void Card(string num, string name, string cvc, int exp)
        {
            if (num.Length >= 20)
            {
                throw new ArgumentException("ERROR", nameof(num));
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("ERROR", nameof(name));
            }

            if (cvc.Length >= 3)
            {
                //throw new ArgumentException("ERROR", nameof(cvc));
            }

            if (exp <= 2024)
            {
                throw new ArgumentException("ERROR", nameof(exp));
            }
        }
    }
}
