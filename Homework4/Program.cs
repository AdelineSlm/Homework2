Console.Clear();
//-----------------------Exersize1--------------------------------------
Console.WriteLine("Первое задание");
Console.WriteLine("Вывод элементов массива на экран:");
int[] array = new int[8];
for (int i = 0; i < 8; i++) {
    array[i] = new Random().Next(0, 2);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

//-----------------------Exersize2--------------------------------------
Console.WriteLine();
Console.WriteLine("Второе задание");
int[] arr = new int[12];
int sum_even = 0;
int sum_odd = 0;
Console.WriteLine("Вывод элементов массива на экран:");
for (int i = 0; i < 8; i++) {
    arr[i] = new Random().Next(0, 10);
    Console.Write(arr[i] + " ");
}

for (int i = 0; i < 8; i++) {
    if (arr[i] % 2 == 0){
        sum_even += arr[i];
    }
    else {
        sum_odd += arr[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма четных элементов: {0}", sum_even);
Console.WriteLine("Сумма нечетных элементов: {0}", sum_odd);

//---------------Version if the array is filled with any integers-----------
Console.WriteLine();
int[] arr_n = new int[12];
int sum_plus = 0;
int sum_minus = 0;
Console.WriteLine("Вывод элементов массива с целыми числами на экран:");
for (int i = 0; i < 12; i++) {
    arr_n[i] = new Random().Next(-10, 10);
    Console.Write(arr_n[i] + " ");
}

for (int i = 0; i < 12; i++) {
    if (arr_n[i] > 0){
        sum_plus += arr_n[i];
    }
    else {
        sum_minus += arr_n[i];
    }
}
Console.WriteLine();
Console.WriteLine("Сумма положительных элементов: {0}", sum_plus);
Console.WriteLine("Сумма отрицательных элементов: {0}", sum_minus);

//-----------------------Exersize3--------------------------------------
Console.WriteLine();
Console.WriteLine("Третье задание");
Console.WriteLine("Вывод элементов массива:");
int[] array_3 = new int[10];
int count_even = 0;
int count_odd = 0;
for (int i = 0; i < 10; i++) {
    array_3[i] = new Random().Next(100, 1000);
    Console.Write(array_3[i] + " ");
}
for (int i = 0; i < 10; i++) {
    if (array_3[i] % 2 == 0){
        count_even += 1;
    }
    else {
        count_odd += 1;
    }
}
Console.WriteLine();
Console.WriteLine("Количество четных элементов: {0}", count_even);
Console.WriteLine("Количество нечетных элементов: {0}", count_odd);

//-----------------------Exersize4--------------------------------------
Console.WriteLine();
Console.WriteLine("Четвертое задание");
Console.WriteLine("Вывод элементов массива:");
int[] big_array = new int[10];
int count_array = 0;
for (int i = 0; i < 10; i++){
    big_array[i] = new Random().Next(1, 200);
    Console.Write(big_array[i] + " ");
}
for (int i = 0; i < 10; i++) {
    if (big_array[i] >= 10 && big_array[i] <= 99){
        count_array += 1;
    }
}
Console.WriteLine();
Console.WriteLine("Количество элементов в диапазоне [10, 99]: {0}", count_array);

//-----------------------Exersize5--------------------------------------
Console.WriteLine();
Console.WriteLine("Пятое задание");
Console.WriteLine("Вывод элементов массива:");
int[] Array1 = new int[10];
int[] Array2 = new int[5];
for (int i = 0; i < 10; i++) {
    Array1[i] = new Random().Next(-15, 16);
    Console.Write(Array1[i] + " ");
}
Console.WriteLine();
int count = 0;
Console.WriteLine("Вывод элементов массива, содержащего произведения:");
for (int j = 0; j < Array2.Length; j++){
    Array2[j] = Array1[count]*Array1[Array1.Length - count - 1];
    Console.Write(Array2[j] + " ");
    count++;
}
Console.WriteLine();