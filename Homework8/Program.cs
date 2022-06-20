Console.Clear();
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

//Найти произведение двух матриц
Console.WriteLine("Первое задание");
int[,] ProdMatrix(int[,] matr1, int[,] matr2)
{
    int[,] matr3 = new int[matr1.GetLength(0), matr2.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1); k++)
                matr3[i, j] += matr1[i, k] * matr2[k, j];
        }
    }
    return matr3;
}

Console.WriteLine("Введите кол-во строк первой матрицы: ");
int rows1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов первой матрицы: ");
int columns1 = int.Parse(Console.ReadLine());
int[,] matrix1 = new int[rows1, columns1];
Console.WriteLine("Введите кол-во строк второй матрицы: ");
int rows2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите кол-во столбцов второй матрицы: ");
int columns2 = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix2 = new int[rows2, columns2];
if (rows1 != columns2) 
    Console.WriteLine("Невозможно найти произведение матриц, т.к. кол-во строк первой матрицы не равно кол-ву столбцов второй!");
else if (columns1 != rows2) 
    Console.WriteLine("Невозможно найти произведение матриц, т.к. кол-во столбцов первой матрицы не равно кол-ву строк второй!");
else
{
    FillArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine("Матрица 1:");
    PrintArray(matrix1);
    Console.WriteLine("Матрица 2:");
    PrintArray(matrix2);
    Console.WriteLine("Произведение матриц:");
    PrintArray((ProdMatrix(matrix1, matrix2)));
}
Console.WriteLine();

//В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент
Console.WriteLine("Второе задание");
int[] IndexArray(int[,] matr)
{
    int[] index = new int[2];
    int min = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < min)
            {
                min = matr[i, j];
                index[0] = i;
                index[1] = j;
            }
        }
    }
    return index;
}
int[,] Delete(int[,] matr, int row, int column)
{
    int[,] matrix_new = new int[matr.GetLength(0) - 1, matr.GetLength(1) - 1];
    for (int i = 0; i < matr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < matr.GetLength(1) - 1; j++)
        {
            if (i >= row && j < column)
                matrix_new[i, j] = matr[i + 1, j];
            else if (j >= column && i < row)
                matrix_new[i, j] = matr[i, j + 1];
            else if (i >= row && j >= column)
                matrix_new[i, j] = matr[i + 1, j + 1];
            else
                matrix_new[i, j] = matr[i, j];
        }
    }
    return matrix_new;
}

Console.WriteLine("Введите кол-во строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int columns = int.Parse(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillArray(matrix);
Console.WriteLine("Полученный массив целых чисел:");
PrintArray(matrix);
Console.WriteLine($"Индекс первого минимального элемента: строка = {IndexArray(matrix)[0] + 1}, столбец = {IndexArray(matrix)[1] + 1}");
Console.WriteLine("Массив после удаления строки и столбца, на пересечении которых расположен наименьший элемент:");
PrintArray(Delete(matrix, IndexArray(matrix)[0], IndexArray(matrix)[1]));
Console.WriteLine();

//Сформировать трехмерный массив не повторяющимися двузначными числами, показать его построчно на экран выводя индексы соответствующего элемента
Console.WriteLine("Третье задание");
void Fill3DArray(int[,,] matr)
{
    int count = 10;
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = count;
                count += 2;
            }
}
void Print3DArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
                Console.Write($"Элемент[{i},{j},{k}] = {matr[i, j, k]} ");
            Console.WriteLine();
        }
}

Console.Write("Введите 1-е измерение массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2-е измерение массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 3-е измерение массива: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,,] matrix3D = new int[n, m, k];
Fill3DArray(matrix3D);
Print3DArray(matrix3D);
Console.WriteLine();

//Показать треугольник Паскаля 
void PrintTriangle(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        string matrPrint = String.Empty;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == 0)
                Console.Write("    ");
            else
            {
                matrPrint = Convert.ToString(matr[i, j]);
                while (matrPrint.Length < 4) 
                    matrPrint += " ";
                Console.Write(matrPrint);
            }
        }
        Console.WriteLine();
    }
}
int[,] FillTriangle(int height)
{
    int[,] pascal = new int[height, height * 2 + 1];
    pascal[0, height] = 1;
    for (int i = 1; i < height; i++)
        for (int j = 1; j < height * 2; j++)
            pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j + 1];
    return pascal;
}

Console.Write("Введите высоту треугольника Паскаля: ");
int height = int.Parse(Console.ReadLine());
PrintTriangle(FillTriangle(height));