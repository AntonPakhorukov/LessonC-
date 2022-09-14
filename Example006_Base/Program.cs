int a = 1;
int b = 8;
int c = 3;
int d = 2;
int e = 6;
int max = a;
if (a > max) {
    max = a;
} else if (b > max) {
    max = b;
} else if (c > max) {
    max = c;
} else if (d > max) {
    max = d;
} else if (e > max) {
    max = e;
}
Console.WriteLine(max);