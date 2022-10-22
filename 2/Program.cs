// 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


void Print(double x1, double y1, double z1, double x2, double y2, double z2, double res)
{
    string output = $"|A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2})| = {Math.Round(res, 2)}";
    Console.WriteLine(output);
}

double GetDistance3D(double ax, double ay, double bx, double by, double az, double bz)
{
    return Math.Sqrt(Math.Pow(ay - by, 2) + 
                     Math.Pow(ax - bx, 2) + 
                     Math.Pow(az - bz, 2));
}

double GetValue(string text)
{
    Console.Write(text + ": ");
    double value = Convert.ToDouble(Console.ReadLine());
    return value;
}

double ax = GetValue("ax");
double ay = GetValue("ay");
double az = GetValue("az");
double bx = GetValue("bx");
double by = GetValue("by");
double bz = GetValue("bz");

double dis = GetDistance3D(ax, ay, bx, by, az, bz);
Print(ax, ay, bx, by, az, bz, dis);