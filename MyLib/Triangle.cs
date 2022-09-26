using MyLib;

namespace FiguresLibrary
{
    public class Triangle : IFigure
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }
        public bool IsIsosceles
        { get
            {
                if ((Math.Pow(A, 2) + Math.Pow(B, 2) == Math.Pow(C, 2))
                || (Math.Pow(B, 2) + Math.Pow(C, 2) == Math.Pow(A, 2))
                || (Math.Pow(C, 2) + Math.Pow(A, 2) == Math.Pow(B, 2)))
                    return true;
                else return false;
            }
        }
        /// <summary>
        /// Semi-perimeter
        /// </summary>
        private double p => (double)(A + B + C) / 2;
        public double Perimeter => A + B + C;

        public double Area => (double)Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }
        public Triangle() { }
    }
}
