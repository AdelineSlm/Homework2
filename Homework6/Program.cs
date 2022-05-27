Console.Clear();
//Показать двумерный массив размером m×n заполненный вещественными числами
Console.WriteLine("Первое задание");
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

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine());
double[,] matrix = new double[rows, columns];
FillArray(matrix);
Console.WriteLine("Вывод массива: ");
PrintArray(matrix);
Console.WriteLine();

//Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.WriteLine("Второе задание");
void CreateArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = i + j;
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int rows_new = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns_new = int.Parse(Console.ReadLine());
double[,] matr = new double[rows_new, columns_new];
CreateArray(matr);
Console.WriteLine("Вывод массива: ");
PrintArray(matr);
Console.WriteLine();

//В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.WriteLine("Третье задание");
void SqrFun(double[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            //если не считаем 0 четным числом:
            if(i == 0 || j == 0){
                arr[i,j] = arr[i,j];
            }
            else if(i % 2 == 0 && j % 2 == 0){
                arr[i,j] = Math.Pow(arr[i,j], 2);
            }
        }
    }
}

Console.WriteLine("Введите количество строк: ");
int rows_n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int columns_n = int.Parse(Console.ReadLine());
double[,] matrix_new = new double[rows_n, columns_n];
FillArray(matrix_new);
Console.WriteLine("Вывод изначального массива: ");
PrintArray(matrix_new);
SqrFun(matrix_new);
Console.WriteLine("Вывод нового массива: ");
PrintArray(matrix_new);
