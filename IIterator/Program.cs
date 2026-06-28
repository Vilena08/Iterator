using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // 1. Создаем коллекцию из 10 элементов (числа 1, 2, 3...10).
        IIterCollection collection = new IterCollection(10);

        // 2. Запрашиваем у коллекции итератор.
        IIterator iterator = collection.GetIterator();

        // 3. Перебираем элементы, пока итератор не скажет, что элементы закончились.
        while (!iterator.Finished())
        {
            // Вызываем Next() — он возвращает элемент и сдвигает указатель.
            Console.WriteLine(iterator.Next());
        }

        Console.ReadKey();
    }
}