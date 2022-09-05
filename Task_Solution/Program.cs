//============================================================================
//Программа, которая из имеющегося массива строк формирует массив из строк,  =
// длина которых меньше либо равна 3 символа.                                =
//============================================================================

Console.Clear();
//--------------------------------
// Первый вариант решения задачи 
//--------------------------------

//Получаем от пользователя данные о размере массива и просим ввести значение каждого элемента
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



//Метод для вывода результата на экран
void PrintFirstStringArray(string[] inputArray)
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
PrintFirstStringArray(SearchLength(secondBufferArray));



//--------------------------------
// Второй вариант решения задачи 
//--------------------------------

//Получаем размер массива с консоли и заполняем случайными символами

string[] FillingArray()
{


    int m = 0;
    Console.WriteLine("Введите количество элементов массива:");
    m = int.Parse(Console.ReadLine() ?? "");
    string[] ReadNumber = new string[m];

    Random rnd = new Random();
    for (int i = 0; i < ReadNumber.Length; i++)
    {
        int stringLength = rnd.Next(1, 6);
        int randNumber;
        char symbol;
        string str = "";
        for (int j = 0; j < stringLength; j++)
        {
            randNumber = rnd.Next(0, 92);
            symbol = Convert.ToChar(randNumber + 33);
            str = str + symbol;

        }
        ReadNumber[i] = str;
    }

    return (ReadNumber);
}

void PrintSecondStringArray(string[] inputArray)
{
    Console.ForegroundColor = ConsoleColor.Green;
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


string[] bufferArray = FillingArray();
//Выводим на экран сгенерированный массив
PrintSecondStringArray(bufferArray);
//Ищем элементы
PrintSecondStringArray(SearchLength(bufferArray));