namespace GeekBrains
{
    class Program
    {
        public static void Main()
        {
            string?[] resultArray = GetResultArray(GetArray());
        }

        // Метод заполнения пользователем массива
        private static string?[] GetArray()
        {
            // Ввод длины массива и проверка корректности

            Console.WriteLine("Введите длину массива");
            string? arrayLengthString = Console.ReadLine();
            bool result = int.TryParse(arrayLengthString, out int arrayLength) && arrayLength > 0;
            while ((result == false))
            {
                Console.WriteLine("Ведите длину массива (целое число больше 0)");
                arrayLengthString = Console.ReadLine();
                result = int.TryParse(arrayLengthString, out arrayLength) && arrayLength > 0;
            }

            // Заполнение массива
            string?[] array = new string[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine($"Введите {i}-й элемент массива");
                array[i] = Console.ReadLine();
            }
            Console.Write("Введенный пользователем ");
            PrintStringArray(array);
            return array;
        }

        // Метод вывода массива в консоль

        private static void PrintStringArray(string?[] array)
        {
            Console.WriteLine("массив");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("*" + array[i] + "*");
            }
            Console.WriteLine();
        }

        // Метод решения задачи
        private static string?[] GetResultArray(string?[] array)
        {
            int count = 0;
            string?[] resultArray = new string[count];

            // Переменная регулировки длины того что попадает в resultArray

            int maxLengthElem = 3;

            // Решение задачи

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]?.Length <= maxLengthElem)
                {
                    Array.Resize(ref resultArray, resultArray.Length + 1);
                    resultArray[count] = array[i];
                    count++;
                }
            }

            // Вывод в консоль результатов

            if (count > 0)
            {
                Console.Write("Получившийся ");
                PrintStringArray(resultArray);
            }
            else
            {
                Console.WriteLine("В введенном массиве нет элементов удовлетворяющих условию задачи []");
            }
            return resultArray;
        }
    }
}
