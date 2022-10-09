int Min(int arg1, int arg2, int arg3) // Min это просто имя переменной int
{
    int result = arg1; // если поменяем знаки на >, то найдем максимальное
    if(arg2 < result) result = arg2;
    if(arg3 < result) result = arg3;
    return result;
}

int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};
// array[0] = 12; // меняем элемент массива под индексом 0 на 12
// Console.WriteLine(array[0]); // вывод 12

int res = Min(
    Min(array[0], array[1], array[2]),
    Min(array[3], array[4], array[5]),
    Min(array[6], array[7], array[8])
);
Console.WriteLine(res);