using System.Text.RegularExpressions;

double lado1;
double lado2;
double lado3; 
double semi;
double area;

Console.Clear();

Console.Write("Lado 1..: ");
lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado 1..: ");
lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado 1..: ");
lado3 = Convert.ToDouble(Console.ReadLine());

semi = (lado1 + lado2 + lado3) / 2;

Console.WriteLine(@$"
Semiperímetro..: {semi}");

area = Math.Sqrt (semi * (semi - lado1) * (semi - lado2) * (semi - lado3));

Console.WriteLine($"Área...........: {area}");