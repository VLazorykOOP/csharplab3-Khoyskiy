using System;
namespace Lab3CSharp
{
	public class Romb
	{
		private int side;
		private double diagonale1;
        private double diagonale2;
        private int color;

		public Romb(int side,double diagonale, int color)
		{
			this.side = side;
			this.diagonale1 = diagonale;
			this.diagonale2 = Math.Sqrt(4 * side * side - diagonale * diagonale);
            this.color = color;
            Cheak();
		}
		private void Cheak()
		{
			if(double.IsNaN(diagonale2) || side <= 0 || diagonale1 <= 0)
			{
				double a = Math.Sqrt(Math.Pow(diagonale1,2)+Math.Pow(diagonale2,2));
				if (a != side)
				{
					Console.WriteLine("Не існує, створиться квадрат з стороною 4.");
					this.side = 4;
					this.diagonale1 = side * Math.Sqrt(2);
					this.diagonale2 = diagonale1;
					this.color = 0;
				}
            }
		}
		public double GetDiagonal1()
		{
			return diagonale1;
		}
        public double GetDiagonal2()
        {
            return diagonale2;
        }
        public void Print()
		{
			Console.WriteLine("Інформація про даний ромб "+ this.side + " " + this.diagonale1 + " "+ this.diagonale2+ " "+ this.color);
			Console.WriteLine("Чи є квадратом - " + Is_Square(this));
		}
		public int Per(int side)
		{
			int per;
			if (side < 0)  Console.WriteLine("Не існує");
			per = side * 4;
			return per;
		}
		public double Area(double diagonale)
		{
			return diagonale1 * diagonale2 / 2;
		}
		private bool Is_Square(Romb romb)
		{
			if(romb.GetDiagonal1() == romb.GetDiagonal2()) return true;
			else return false;
		}
		
	}
}
