int a = 9;
int b = 10;
int c = 255;

int max = a;

if (max < b) max = b;
if (max < c) max = c;

Console.Write("max = ");
Console.WriteLine(max);
