
Console.WriteLine("Taschenrechner: ");
string ab = Console.ReadLine();

// Sucht -,+,* o. / , wenn es exestiert komm ein Wert von 0 oder mehr raus
int plus = ab.IndexOf('+');
int minus = ab.IndexOf('-');
int mal = ab.IndexOf('*');
int geteilt = ab.IndexOf('/');



// ab wird zu einen Array gemacht namens vs
    string[] vs = ab.Split(new char[] { '+', '-', '*', '/' });

// die arrays werden zu Int, damit man damit rechnen kann 
int num = int.Parse(vs[0]);
int num1 = int.Parse(vs[1]);


int p2p = num + num1;
int m2m = num - num1;
int mm2m = num * num1;
int g2g = num / num1;

// es muss immer mehr oder gleich als 0 sein, bei -1 ist kein Rechen Operator vorhanden

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









