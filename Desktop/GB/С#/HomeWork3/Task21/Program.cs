// Программа, которая принимает координаты двух точек в 3D пространстве и находит расстояние между ними.

System.Console.WriteLine("First point (x,y,z) -->");

int x1 = Convert.ToInt32(System.Console.ReadLine());
int y1 = Convert.ToInt32(System.Console.ReadLine());
int z1 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Second point (x,y,z) -->");

int x2 = Convert.ToInt32(System.Console.ReadLine());
int y2 = Convert.ToInt32(System.Console.ReadLine());
int z2 = Convert.ToInt32(System.Console.ReadLine());

System.Console.WriteLine("Расстояние между точками!: ");
System.Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));
