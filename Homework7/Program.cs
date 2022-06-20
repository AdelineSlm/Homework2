Console.Clear();
//Написать программу, которая обменивает элементы первой строки и последней строки
Console.WriteLine("Первое задание");
void FillArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = new Random().Next(-10, 10);
        }
    }
}
void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            Console.Write($"{arr[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void ChangeArray(int[,] matr, int row1, int row2)
{
    int tmp = 0;
    if (row1 < 0 || row1 > matr.GetLength(0) - 1)
        Console.WriteLine("Заданные строки массива вне его диапазона!");
    else if (row2 < 0 || row2 > matr.GetLength(0) - 1) {
        Console.WriteLine("Заданные строки массива вне его диапазона!");
    }
    else
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            tmp = matr[row2, j];
            matr[row2, j] = matr[row1, j];
            matr[row1, j] = tmp;
        }
}

Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillArray(matrix);
Console.WriteLine("Начальный полученный массив: ");
PrintArray(matrix);
ChangeArray(matrix, 0, columns - 1);
Console.WriteLine("Массив после замены элементов первой и последней строк: ");
PrintArray(matrix);
Console.WriteLine();

//Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива
Console.WriteLine("Второе задание");
void SortArray(int[,] matr, int row)
{
    int min_j = 0;
    int matr_min = 0;
    int tmp = 0;
    int length = matr.GetLength(1);
    while (length > 0)
    {
        matr_min = matr[row, 0];
        min_j = 0;
        for (int j = 0; j < length; j++)
        {
            if (matr[row, j] < matr_min)
            {
                min_j = j;
                matr_min = matr[row, j];
            }

        }
        tmp = matr[row, length - 1];
        matr[row, length - 1] = matr[row, min_j];
        matr[row, min_j] = tmp;
        length = length - 1;
    }
}

Console.Write("Введите кол-во строк: ");
int rows_new = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columns_new = int.Parse(Console.ReadLine());
int[,] matrix_new = new int[rows_new, columns_new];
FillArray(matrix_new);
Console.WriteLine("Начальный полученный массив: ");
Console.WriteLine();
PrintArray(matrix_new);
Console.WriteLine();
for (int i = 0; i < columns_new; i++)
    SortArray(matrix_new, i);
Console.WriteLine("Массив после сортировки по убыванию каждой строки: ");
Console.WriteLine();
PrintArray(matrix_new);
Console.WriteLine();

//Написать программу, которая в двумерном массиве заменяет строки на столбцы
Console.WriteLine("Третье задание");
int[,] ChangeColumns(int[,] matr)
{
    int length = matr.GetLength(0);
    int[,] matr_new = new int[length, length];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            matr_new[i, j] = matr[j, i];
        }
    }
    return matr_new;
}

Console.Write("Введите кол-во строк: ");
int rowsNew = int.Parse(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int columnsNew = int.Parse(Console.ReadLine());
int[,] matrixNew = new int[rowsNew, columnsNew];
if (matrixNew.GetLength(0) != matrixNew.GetLength(1))
    Console.WriteLine("Матрица не квадратная, замена строк на столбцы невозможна!");
else
{
    FillArray(matrixNew);
    Console.WriteLine("Начальный полученный массив: ");
    Console.WriteLine();
    PrintArray(matrixNew);
    Console.WriteLine();
    matrixNew = ChangeColumns(matrixNew);
    Console.WriteLine("Массив после замены строк на столбцы: ");
    Console.WriteLine();
    PrintArray(matrixNew);
}
Console.WriteLine();

//В прямоугольной матрице найти строку с наименьшей суммой элементов
Console.WriteLine("Четвертое задание");
int FindSum(int[,] matr)
{
    int length = matr.GetLength(0);
    int[] sums = new int[length];
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            sums[i] = sums[i] + matr[i, j];
        }
    }
    int iMax = 0;
    int max = sums[0];
    for (int i = 1; i < length; i++)
        if (sums[i] < max)
        {
            max = sums[i];
            iMax = i;
        }
    return iMax + 1;
}

Console.WriteLine("Введите количество строк: ");
int row_new = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int col_new = int.Parse(Console.ReadLine());
int[,] matr_new = new int[row_new, col_new];
FillArray(matr_new);
Console.WriteLine("Полученный массив: ");
Console.WriteLine();
PrintArray(matr_new);
Console.WriteLine($"Номер строки с минимальной суммой элементов: {FindSum(matr_new)}");