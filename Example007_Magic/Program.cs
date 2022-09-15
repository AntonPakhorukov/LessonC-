Console.Clear();
/*
Console.SetCursorPosition(50, 1);
Console.WriteLine("+");
Console.SetCursorPosition(5, 30);
Console.WriteLine("+");
Console.SetCursorPosition(95, 30);
Console.WriteLine("+");
*/
int xa = 50, ya = 1, xb = 5, yb = 30, xc = 95, yc = 30;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa;
int y = ya;
int index = 0;

while (index < 10000) {
    int random = new Random().Next(0,3);
    if (random == 0) {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (random == 1) {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (random == 2) {
        x = (x + xc) / 2;
        y = (y + yc)  / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    index++;
}
