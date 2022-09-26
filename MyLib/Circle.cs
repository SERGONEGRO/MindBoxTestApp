using MyLib;

namespace FiguresLibrary
{
    public class Circle : IFigure
    {
        public int Radius { get; set; }
        public double Perimeter => (double)(2 * Radius * Math.PI);
        public double Area => (double)(Math.PI*(Math.Pow(Radius, 2)));

        public Circle(int r)
        {
            Radius = r;
        }
        public Circle() {  }
    }
}
