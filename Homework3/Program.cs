Console.Clear();

Console.WriteLine("Первое задание");
Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Квадраты чисел:");
for (int i = 1; i <= n; i++){
    Console.Write("{0}" + " ", i*i);
}
Console.WriteLine();

Console.WriteLine("Второе задание");
Console.WriteLine("Введите число:");
int B = int.Parse(Console.ReadLine());
int count = 1;
Console.WriteLine("Кубы чисел:");
while (count <= B){
    int prod = 0;
    prod = count*count*count;
    Console.Write(prod + " ");
    count++;
}
Console.WriteLine();

Console.WriteLine("Третье задание");
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());
int sum = 0;
int cou = 1;
while (cou <= num){
    sum += cou;
    cou++;
}
Console.WriteLine("Сумма чисел: {0}",sum);
Console.WriteLine();

Console.WriteLine("Четвертое задание");
Console.WriteLine("Введите число A:");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine());
int result = 1;
if (numberB == 0){
    result = 1;
} 
else if (numberA < 0){
    Console.WriteLine("Отрицательная степень");
}
for (int i = 0; i < numberB; i++){
    result *= numberA;
}
Console.WriteLine("Результат: {0}", result);
Console.WriteLine();

Console.WriteLine("Пятое задание");
Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int[] array = new int[10];   //завели массив для хранения цифр числа
int summ = 0;
for (int i = 0; i < 10; i++) {
    if (number > 1){
        array[i] = number % 10;
    }
    number /= 10;
    Console.Write(array[i] + " ");
}
for (int i = 0; i < 10; i++) {
    summ += array[i];
}
Console.WriteLine();
Console.WriteLine("Сумма цифр: {0}", summ);

Console.WriteLine("Шестое задание");
double[] array1 = {54, 25, 46, 4, 15, -32, 13, 51};   //завели массив для чисел
Console.WriteLine("Кубы чисел:");
for (int i = 0; i < 8; i++) {
    if (array1[i] % 2 == 0){
        array1[i] = Math.Pow(array1[i], 3);
        Console.Write(array1[i] + " ");
    }
}
Console.WriteLine();

Console.WriteLine("Седьмое задание");
Console.WriteLine("Вывод элементов массива на экран:");
int[] array2 = {0, 1, 0, 1, 1, 1, 0, 0};

//for (int i = 0; i < 8; i++) {
//    array[i] = int.Parse(Console.ReadLine());
//}

for (int i = 0; i < 8; i++) {
    Console.Write(array2[i] + " ");
}
Console.WriteLine();

