Console.Write("Введите элементы массива через пробел: ");
string[] inputArray = Console.ReadLine().Split(' ');
string[] resultArray = FilterArray(inputArray);

        Console.WriteLine("Новый массив строк:");
        foreach (string str in resultArray)
        {
            Console.WriteLine(str);
        }
    

    static string[] FilterArray(string[] inputArray)
    {
        string[] resultArray = new string[inputArray.Length];
        int count = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                resultArray[count] = str;
                count++;
            }
        }

        Array.Resize(ref resultArray, count);
        return resultArray;

    }
        
