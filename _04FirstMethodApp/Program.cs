namespace _04FirstMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Method 1
            truth();

            //Method 2
            int a = dvidedTwo();
            Console.WriteLine(a);

            //Method 3
            int b = multiplyTwo(a);
            Console.WriteLine(b);

            //Method 4
            greeting("Arda","AKTAŞ");
        }

        private static void truth()
        {
            Console.WriteLine("Bu gece Ay çok Güzel Değil mi ?");
        }

        private static int dvidedTwo()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 100);
            return a / 2;
        }

        private static int multiplyTwo(int a)
        {
            return a * 2;
        }

        private static void greeting(string name,string surname)
        {
            Console.WriteLine($"Hoş Geldiniz, {name} {surname}");
        }

    }
}
