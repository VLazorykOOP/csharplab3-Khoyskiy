using System;
namespace Lab3CSharp
{
	public class Romb
	{
		private double side;
		private double diagonale;
		private string color;

		public Romb(int side, int diagonale, string color)
		{
			this.side = side;
			this.diagonale = diagonale;
			this.color = color;
		}
		public void Print_side()
		{
			Console.WriteLine();
		}
	}
}
