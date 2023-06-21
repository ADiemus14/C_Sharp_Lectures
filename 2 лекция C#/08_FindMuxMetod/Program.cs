// Найти наибольшее из 9 чисел

// Console.Write("Введите значение 1-го числа: ");
// int a = ToInt32(ReadLine());

// Console.Write("Введите значение 2-го числа: ");
// int b = ToInt32(ReadLine());

// Console.Write("Введите значение 3-го числа: ");
// int c = ToInt32(ReadLine());

// Console.Write("Введите значение 4-го числа: ");
// int d = ToInt32(ReadLine());

// Console.Write("Введите значение 5-го числа: ");
// int e = ToInt32(ReadLine());

// Console.Write("Введите значение 6-го числа: ");
// int f = ToInt32(ReadLine());

// Console.Write("Введите значение 7-го числа: ");
// int g = ToInt32(ReadLine());

// Console.Write("Введите значение 8-го числа: ");
// int h = ToInt32(ReadLine());

// Console.Write("Введите значение 9-го числа: ");
// int i = ToInt32(ReadLine());

//После этого опишем тело метода:

int Max(int args1, int args2, int args3)
{
    int result = args1;
    if(args2>result) result=args2;
    if(args3>result) result=args3;
    return result;
}

int getData()
{
    Console.Write("Введите значение: ");
    return Convert.ToInt32(Console.ReadLine());
}
int max = Max(
                Max(getData(), getData(), getData()),
                Max(getData(), getData(), getData()),
                Max(getData(), getData(), getData())
            );


Console.Write($"Максимальное значение из 9 чисел - {max}");
//Итак, возьмём некоторый аргумент 1, опишем некоторый аргумент 2 и 3.

// int max1 = Max(a1, b1, c1);
// int max1 = Max(a2, b2, c2);
// int max1 = Max(a3, b3, c3);
// int max1 = Max(max1, max2, max3);
/*Перепишем результирующий вариант. Возьмём значение max переменной max и то, что
посчитали. Но вместо того, чтобы использовать дополнительные переменные, внутри
аргумента передадим функцию*/
