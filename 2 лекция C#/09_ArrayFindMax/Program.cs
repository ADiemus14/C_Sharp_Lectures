//работа с массивом

int Max(int args1, int args2, int args3)
{
    int result = args1;
    if(args2>result) result=args2;
    if(args3>result) result=args3;
    return result;
}

int[] array = {11, 21, 31, 41, 15, 61, 17, 18, 19};

int maxResult = Max(
                Max(array[0], array[1], array[2]),
                Max(array[3], array[4], array[5]),
                Max(array[6], array[7], array[8])
            );


Console.Write($"Максимальное значение из 9 чисел - {maxResult}");