Console.Clear();
void FillArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}

//Найти точку пересечения двух прямых
Console.WriteLine("Первое задание");
Console.WriteLine("Введите число b1:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число k1:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число b2:");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите число k2:");
double k2 = double.Parse(Console.ReadLine());
double x, y;
x = (b2 - b1)/(k1 - k2);
y = k1*x + b1;
double[,] array = {{x, y},};
PrintArray(array);
Console.WriteLine();

//Программа масштабирования фигуры
Console.WriteLine("Второе задание");
void Scaling(double[,] arr, double k){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = arr[i, j]*k;
        }
    }    
}

double[,] coord = new double[4, 2];
//создание координат
FillArray(coord);
Console.WriteLine("Вывод исходных координат: ");
PrintArray(coord);
Scaling(coord, 2);
Console.WriteLine("Вывод новых координат: ");
PrintArray(coord);
Console.WriteLine();

//Программа копирования массива
Console.WriteLine("Третье задание");
//arr - массив, в который копируем, arr1 - копируемый массив
void ArrayCopy(double[,] arr, double[,] arr1){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = arr1[i, j];
        }
    }    
}
//первый массив
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];
FillArray(matrix);
Console.WriteLine("Вывод массива: ");
PrintArray(matrix);
//второй массив и копирование
double[,] matrix_copy = new double[rows, columns];
Console.WriteLine("Вывод пустого массива: ");
PrintArray(matrix_copy);
ArrayCopy(matrix_copy, matrix);
Console.WriteLine("Вывод скопированного массива: ");
PrintArray(matrix_copy);
Console.WriteLine();
