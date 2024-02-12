using System;
namespace Lab3CSharp
{
    class Mammal : Ungulate
    {
        public bool HasTail { get; set; }

        public Mammal(int legs,string type, bool hasTail,bool huts) : base(legs,type,huts)
        {
            HasTail = hasTail;
        }

        public override void Show()
        {
            Console.WriteLine($"Савець: Вид тварини {type}, кількість ніг {legs}, Має хвіст: {HasTail}, чи хижий {huts}");
        }
    }
}