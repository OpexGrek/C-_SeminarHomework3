// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//X1 - points[0], Y1 - points[1], Z1 - points[2], X2 - points[3], Y2 - points[4], Z2 - points[5]
//D=SQRT(x2-x1)^2+(y2-y1)^2+(z2-z1)^2

Console.Clear();
int[] points = new int[6];

Console.WriteLine("Input coordinate point A");
for (int i = 0; i < 3; i++)
{
    string A = Convert.ToString(Console.ReadLine());    
    
    bool result = int.TryParse(A, out int B);           // Проверка на ввод букв
    if (result == false)
    {
        Console.WriteLine("You should input only numbers");
        Environment.Exit(0);
    }
    else points[i] = Convert.ToInt32(A);
}


Console.WriteLine("Input coordinate point B");
for (int i = 3; i < 6; i++)
{
    string C = Convert.ToString(Console.ReadLine());    
    
    bool result = int.TryParse(C, out int E);       // Проверка на ввод букв
    if (result == false)
    {
        Console.WriteLine("You should input only numbers");
        Environment.Exit(0);
    }
    else points[i] = Convert.ToInt32(C);
}
   
int X = points[3] - points[0];
int Y = points[4] - points[1];
int Z = points[5] - points[2];
double D = Math.Sqrt(X * X + Y * Y + Z * Z);
Console.WriteLine("Distance between points: " + D);