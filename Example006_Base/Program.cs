int a = 2;
int b = 4;
int c = 0;
int d = 5;
int e = 3;

int max = a;

if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.Write("max = ");
Console.WriteLine(max);