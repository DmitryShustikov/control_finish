// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Ввод исходного массива строк с клавиатуры
        Console.Write("Введите элементы массива через пробел: ");
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
string[] inputArray = Console.ReadLine().Split(' ');
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.

// Формирование нового массива строк с длиной меньше или равной 3 символам
string[] resultArray = FilterArray(inputArray);

        // Вывод нового массива
        Console.WriteLine("Новый массив строк:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    

    static string[] FilterArray(string[] inputArray)
    {
// Создание нового массива подходящих строк
        string[] resultArray = new string[inputArray.Length];
        int count = 0;

        // Фильтрация исходного массива и добавление подходящих строк в новый массив
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[count] = str;
                count++;
            }
        }

        // Обрезаем resultArray до фактической длины
        Array.Resize(ref resultArray, count);
        return resultArray;

    }
        