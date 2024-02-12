namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скільки створити?");
            int n = int.Parse(Console.ReadLine());
            Romb[] rombs = new Romb[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Введіть дані ромба(сторона, більша діагональ, колір)");
                int s = int.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                rombs[i] = new Romb(s, d, c);
            }
            foreach(Romb romb in rombs)
            {
                romb.Print();
            }
        }
    }
}
