Console.WriteLine("Первое задание");
int c = new Random().Next(1, 7); //Выдает сгенерированное число, 1 - пн, 7 - вс
Console.WriteLine(c);
if (c < 6) {
    Console.WriteLine("Номер дня недели является будним");
}
else Console.WriteLine("Номер дня недели является выходным");
Console.WriteLine();

Console.WriteLine("Второе задание");
Console.WriteLine("Введите число 1: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int b = int.Parse(Console.ReadLine());
if (a == b*b) {
    Console.WriteLine("Число 1 является квадратом числа 2");
}
else if (b == a*a) {
    Console.WriteLine("Число 2 является квадратом числа 1");
}
else if (a != b*b && b != a*a) {
    Console.WriteLine("Ни одно из чисел не является квадратом другого");
}
Console.WriteLine();

Console.WriteLine("Третье задание");
int chet = int.Parse(Console.ReadLine());
switch (chet)
{
    case 1:
        Console.WriteLine("Первая четверть. Диапазон координат: х = (0, +inf), у = (0, +inf)");
        break;
    case 2:
        Console.WriteLine("Вторая четверть. Диапазон координат: х = (-inf, 0), у = (0, +inf)");
        break;
    case 3:
        Console.WriteLine("Третья четверть. Диапазон координат: х = (-inf, 0), у = (-inf, 0)");
        break;
    case 4:
        Console.WriteLine("Четвертая четверть. Диапазон координат: х = (0, +inf), у = (-inf, 0)");
        break;
    default:
        Console.WriteLine("Такого значения четверти не существует");
        break;
}
Console.WriteLine();

Console.WriteLine("Четвертое задание");
Console.WriteLine("Введите координаты первой точки А.");
Console.WriteLine("х1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("у1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки В.");
Console.WriteLine("х2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("у2");
int y2 = int.Parse(Console.ReadLine());

double distanceAB = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1));
Console.WriteLine("Расстояние между двумя точками на плоскости: {0}", distanceAB);
Console.WriteLine();
