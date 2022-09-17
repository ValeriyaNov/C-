
int a = 28;
int b = 9;
int c = 5;
int d = 7;
int f = 2;
int g = 8;

int max = a;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
if ( d > max ) max = d;
if ( f > max ) max = f;
if ( g > max ) max = g;

Console.WriteLine($"Максимальное число = {max}");