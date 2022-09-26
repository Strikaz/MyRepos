
//y=sinsinsinsinsin......sinx
double y = 1, x = double.Parse(Console.ReadLine()), old = 1;
double iter = 1,epsi=0.01;
double E = Math.Pow(Math.E, x);
while (old > epsi)
{ 
    old *= x / iter;
    y += old;
    iter++;
}
Console.Write(y);
Console.Write(" ");
Console.WriteLine(E);

//y=1+x/1+x^2/2!.........
x = double.Parse(Console.ReadLine());
y = x;
epsi = 0.01;
while (y > epsi)
{
    y = Math.Sin(y);
}

Console.Write(y);
Console.Write(" ");
Console.WriteLine(epsi);

//y=1-x^2/2!+x^4/4!.....
y = 1;
x = double.Parse(Console.ReadLine());
old = 1;
iter = 2;
while (Math.Abs(old) * (x * x) / (iter - 1) / iter >epsi)
{
    old *= (x*x)/(iter-1)/iter*-1;
    y += old;
    iter += 2;
}

Console.Write(y);
Console.Write(" ");
Console.WriteLine(Math.Cos(x));

//123456789101112.......
iter = 0;
int k = int.Parse(Console.ReadLine()),len=0;
while (len < k)
{
    iter++;
    len += iter.ToString().Length;

}
Console.WriteLine(iter.ToString()[iter.ToString().Length-len+k-1]);

//точка в рисунке
double x1 = double.Parse(Console.ReadLine()), y1 = double.Parse(Console.ReadLine());
if (((0 <= x1 && x1 <= 1) && (0 <= y1 && y1 <= 1)) || ((-1 <= x1 && x1 <= 0) && y1 <= x1 + 1) || ((-1 <= x1 && x1 <= 0) && (-1 <= y1 && y1 <= 0) && x1 * x1 + y1 * y1 <= 1))
    Console.Write("True");
else
    Console.Write("false");

