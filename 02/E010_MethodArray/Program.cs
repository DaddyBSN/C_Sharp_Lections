int[] array = {1, 12, 31, 18, 15, 16, 17, 18};

int lenght = array.Length;
int search = 18;

int index = 0;

while(index < lenght)
{
    if(array[index] == search)
    {
        Console.WriteLine(index);
        break; // чтобы условие прервалось при первом нахождении заданного числа
    }
    index++; // index = index + 1;
}