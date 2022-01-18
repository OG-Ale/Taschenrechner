
Console.WriteLine("Taschenrechner: ");
string ab = Console.ReadLine();


int plus = ab.IndexOf('+');
int minus = ab.IndexOf('-');
int mal = ab.IndexOf('*');
int geteilt = ab.IndexOf('/');




    string[] vs = ab.Split(new char[] { '+', '-', '*', '/' });


int num = int.Parse(vs[0]);
int num1 = int.Parse(vs[1]);

int p2p = num + num1;
int m2m = num - num1;
int mm2m = num * num1;
int g2g = num / num1;



if (plus >= 0)
{
    Console.WriteLine(p2p);
}

if (minus >= 0)
{
    Console.WriteLine(m2m);
}

if (mal >= 0)
{
    Console.WriteLine(mm2m);
}

if (geteilt >= 0)
{
    Console.WriteLine(g2g);
}







