int n = 100;
int a = 1;
int b = 1;

Console.WriteLine(a);

for (int i = 2; b <= n; i++)
{
    Console.WriteLine(b);
    int c = a + b;
    a = b;
    b = c;
}