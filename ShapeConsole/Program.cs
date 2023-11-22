// See https://aka.ms/new-console-template for more information
using ShapeLib;
IShape s1 = new Circle();
s1.Draw();



Circle s2 = new Circle();
s2.CalculateArea();

s2.Draw();
s2.GetDetails();
Console.WriteLine(((Paint)s1).FillColor("red"));

Rectangle r1 = new Rectangle();
r1.CalculateArea();

r1.Draw();
r1.GetDetails();
Console.WriteLine(((Paint)s2).FillColor("blue"));