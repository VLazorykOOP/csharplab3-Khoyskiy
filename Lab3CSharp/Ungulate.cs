using System;
namespace Lab3CSharp
{
	class Ungulate : Animal
    {
		public bool huts { get; set; }

        public Ungulate(int legs,string type, bool huts) : base(legs,type)
		{
			this.huts = huts;
		}
		public override void Show()
		{
			Console.WriteLine($"Парнокопитне: Вид тварини {type}, кількість ніг {legs}, чи хижий {huts}");
		}
	}
}
