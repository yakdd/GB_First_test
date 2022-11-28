string[] CreateStringArray(int length)
{
    // Функция формирования Первоначального Массива
    // Возвращает массив введенных пользователем строк
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
        while (true)
        {
            Console.Write($"Введите {i + 1} строку массива: ");
            var row = Convert.ToString(Console.ReadLine());
            if (row.Length > 0)
            {
                array[i] = row;
                break;
            }
            else Console.WriteLine("Строка не должна быть пустой!");
        }
    }
    return array;
}


string[] CreateSecondArray(string[] iniArray, int count, int filter)
{
    // Функция формирования Требуемого Массива
    // Возвращает массив строк длиной менее 'filter' символов
    string[] array = new string[count];
    int j = 0;
    for (int i = 0; i < iniArray.Length; i++)
    {
        if (iniArray[i].Length <= filter)
        {
            array[j] = iniArray[i];
            j++;
        }
    }
    return array;
}


void PrintArray(string[] array)
{
    // Функция вывода массива в консоль
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}



Console.Write("Сколько строк будет в массиве?: ");
int countElements = Convert.ToInt32(Console.ReadLine());
string[] initialArray = CreateStringArray(countElements);
PrintArray(initialArray);

int maxLength = 3;
int count = default;
for (int i = 0; i < initialArray.Length; i++)
{
    if (initialArray[i].Length <= maxLength) count++;
}

string[] secondArray = CreateSecondArray(initialArray, count, maxLength);
PrintArray(secondArray);
