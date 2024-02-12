using System;
namespace Lab3CSharp
{

    class Bird : Animal
    {
        public string FeatherColor { get; set; }

        public Bird(int legs, string type, string featherColor) : base(legs, type)
        {
            FeatherColor = featherColor;
        }

        public override void Show()
        {
            Console.WriteLine($"Птах: Вид птаха {type},кількість ніг {legs}, Колір пір'я: {FeatherColor}");
        }
    }
}