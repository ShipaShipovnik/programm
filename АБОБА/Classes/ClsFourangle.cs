using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АБОБА.Classes
{
    internal class ClsFourangle
    {
        private int x1;
        private int y1;
        private int x2;
        private int y2;
        private int x3;
        private int y3;
        private int x4;
        private int y4;

        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;

        private double diagonal1;
        private double diagonal2;

        public int X1 { get { return x1; } set { x1 = value; } }
        public int Y1 { get { return y1; } set { y1 = value; } }
        public int X2 { get { return x2; } set { x2 = value; } }
        public int Y2 { get { return y2; } set { y2 = value; } }
        public int X3 { get { return x3; } set { x3 = value; } }
        public int Y3 { get { return y3; } set { y3 = value; } }
        public int X4 { get { return x4; } set { x4 = value; } }
        public int Y4 { get { return y4; } set { y4 = value; } }

        public ClsFourangle(int xx1, int yy1, int xx2, int yy2, int xx3, int yy3, int xx4, int yy4)
        {
            x1 = xx1;
            y1 = yy1;
            x2 = xx2;
            y2 = yy2;
            x3 = xx3;
            y3 = yy3;
            x4 = xx4;
            y4 = yy4;
        }
        public void Keyboardinput()
        {
            Console.WriteLine("Введите координаты вершин 4хугнольника");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            x4 = int.Parse(Console.ReadLine());
            y4 = int.Parse(Console.ReadLine());
        }
        public void SidesCalculation()
        {
            sideA = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            sideB = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            sideC = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
            sideD = Math.Sqrt((x1 - x4) * (x1 - x4) + (y1 - y4) * (y1 - y4));
            Console.WriteLine($"Сторона А = {Math.Round(sideA, 2)}");
            Console.WriteLine($"Сторона B = {Math.Round(sideB, 2)}");
            Console.WriteLine($"Сторона C = {Math.Round(sideC, 2)}");
            Console.WriteLine($"Сторона D = {Math.Round(sideD, 2)}");
        }
        public void DiagonalsCalculation()
        {
            diagonal1 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            diagonal2 = Math.Sqrt((x2 - x4) * (x2 - x4) + (y2 - y4) * (y2 - y4));

            Console.WriteLine($"Диагональ 1 = {Math.Round(diagonal1, 2)}");
            Console.WriteLine($"Диагональ 2 = {Math.Round(diagonal2, 2)}");
        }
        public double Perimert()
        {
            return sideA+sideB+sideC+sideD;
        }
    }
}
