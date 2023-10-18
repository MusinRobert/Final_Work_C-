string[] GetSelectArray(string[] array)
{
    List<string> list = new List<string>();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            list.Add(array[i]);
    }
    string[] newArray = list.ToArray();
    return newArray;
}

int SetNumber(string message)
{
    Console.WriteLine($"{message}");
    string strNum = Console.ReadLine()!;
    int num = 0;

    if (int.TryParse(strNum, out num))
    {
        return num;
    }

    System.Console.WriteLine("Выберите 0 или 1");
    return SetNumber(message);
}

Console.Clear();
System.Console.WriteLine("Нажмите 0, если хотите выбрать массив по умолчанию");
System.Console.WriteLine("Нажмите 1, если хотите ввести значения самостоятельно");
System.Console.WriteLine();
int numTask = SetNumber("Выберите одно из двух действий");
switch (numTask)
{
    case 0:
        string[] array = { "a", "b", "Yellow", "4589", "199", "-9i7", "-&?" };
        string[] newArray = GetSelectArray(array);
        Console.WriteLine($"[{string.Join(", ", array)}]");
        Console.WriteLine($"[{string.Join(", ", newArray)}]");
        break;

    case 1:
        Console.Write("Введите значения через пробел, используя числа, спецсимволы и латинские буквы: ");
        array = Console.ReadLine()!.Split().ToArray();
        newArray = GetSelectArray(array);

        Console.WriteLine($"[{string.Join(", ", array)}]");
        Console.WriteLine($"[{string.Join(", ", newArray)}]");
        break;

    default: System.Console.WriteLine("Выберите 0 или 1"); break;
}