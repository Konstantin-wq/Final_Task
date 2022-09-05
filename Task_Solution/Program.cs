//============================================================================
//Программа, которая из имеющегося массива строк формирует массив из строк,  =
// длина которых меньше либо равна 3 символа.                                =
//============================================================================


//--------------------------------
// Первый вариант решения задачи 
//--------------------------------

//Получаем от пользователя данные о размере массива и просим ввести значение каждого элемента
Console.Clear();

string[] UserArray()
{
    Console.ForegroundColor = ConsoleColor.Red;
    int m = 0;
    Console.WriteLine("Введите количество элементов массива:");
    m = int.Parse(Console.ReadLine() ?? "");
    string[] ReadNumber = new string[m];
    Console.WriteLine("Введите элементы массива:");

    for (int i = 0; i < ReadNumber.Length; i++)
    {
        Console.WriteLine("Введите " + i + " элемент массива");
        ReadNumber[i] = Console.ReadLine() ?? "";

    }
    Console.ResetColor();
    return (ReadNumber);
}


//Метод нахождения символов в массиве с длиной меньше либо равной 3
string[] SearchLength(string[] inputArray)
{
    string[] outputArray = new string[0];
    int m = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {

        if (inputArray[i].Length <= 3)
        {
            Array.Resize(ref outputArray, outputArray.Length + 1);
            outputArray[m] = inputArray[i];
            m++;
        }

    }
    if (outputArray.Length == 0)
    {
        return (new string[0]);

    }
    else
    {
        Console.WriteLine("Элементы которые соответствуют заданному условию:");
        return (outputArray);
    }
}


//Вывод результата на экран
void PrintColourStringArray(string[] inputArray)
{
    Console.ForegroundColor = ConsoleColor.Red;
    if (inputArray.Length == 0)
    {
        Console.WriteLine("Элементов соответствующих заданию не обнаружено");
    }
    else
    {
        int i = 0;
        while (i < inputArray.Length - 1)
        {
            Console.Write(inputArray[i] + ", ");
            i++;
        }

        Console.WriteLine(inputArray[i]);
    }
    Console.ResetColor();
}



string[] secondBufferArray = UserArray();
PrintColourStringArray(SearchLength(secondBufferArray));






