bool p1 = true;
bool p2 = true;
bool p3 = true;
bool p4 = false;
bool m1 = true;
bool m2 = true;
bool m3 = true;
bool m4 = false;

if ((p1 = p4) && (m1 = m4) || (p2=p4)&& (m2=m4) || (p3=p4)&&(m3=m4))
{
    Console.WriteLine("такой ученик существует");
}
else
{
    Console.WriteLine("такого ученика не существует");
}