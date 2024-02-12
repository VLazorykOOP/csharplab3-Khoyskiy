using System;
namespace Lab3CSharp
{
	class Animal
	{
			public int legs { get; set; }
			public string type;
			public Animal(int legs,  string type)
			{
				this.legs = legs;
				this.type = type;	
			}
		public virtual void Show()
		{
			Console.WriteLine($"Кількість ніг: {legs}, Вид тварини {type}");
		}
	}
}
