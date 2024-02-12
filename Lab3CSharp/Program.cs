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
                Console.WriteLine("Введіть дані ромба(сторона, одна з діагоналей, колір)");
                int s = int.Parse(Console.ReadLine());
                double d = double.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                rombs[i] = new Romb(s, d, c);
            }
            foreach(Romb romb in rombs)
            {
                romb.Print();
            }
            // Створення масиву базового класу Animal
            Animal[] animalsArray = new Animal[6];

            // Ініціалізація елементів масиву
            animalsArray[0] = new Mammal(4,"Жираф",true,false);
            animalsArray[1] = new Mammal(4,"Тигр", true,true);
            animalsArray[2] = new Bird(2,"Соловей","Синій");
            animalsArray[3] = new Bird(2,"Канарка", "Жовтий");
            animalsArray[4] = new Ungulate(4, "Бик", false);
            animalsArray[5] = new Ungulate(4, "Олень", false);

            // Виведення масиву впорядкованого за імене
            foreach (Animal animal in animalsArray)
            {
                animal.Show();
            }
        }
    }
}
