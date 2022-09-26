using FiguresLibrary;

Circle circle = new();
Triangle triangle = new();
int radius;
int a, b, c;

Console.WriteLine("Enter radius (int) :");
if(int.TryParse(Console.ReadLine(), out radius))
{
    circle.Radius = radius;
    Console.WriteLine(@"Area: {0}, Perimeter: {1}", circle.Area, circle.Perimeter);
}
else Console.WriteLine("Wrong value!");


Console.WriteLine("Enter triangle's sides ( EXAMPLE: 11 7 45:");
var result = Console.ReadLine().Split( new[] {' '});
if(int.TryParse(result[0],out a) && int.TryParse(result[1],out b) && int.TryParse(result[2],out c))
{
    triangle.A = a;
    triangle.B = b;
    triangle.C = c;
    Console.WriteLine(@"Area: {0}, Perimeter: {1}, IsIsosceles = {2}",
        triangle.Area, triangle.Perimeter,triangle.IsIsosceles);
}
else Console.WriteLine("Wrong value!");


