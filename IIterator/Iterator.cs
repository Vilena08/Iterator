public class Iterator : IIterator
{
    // Ссылка на коллекцию, которую мы перебираем.
    private readonly IterCollection _collection;

    // Текущая позиция указателя в коллекции (начинается с 0).
    private int _currentIndex;

    // Конструктор: привязываем итератор к конкретной коллекции.
    public Iterator(IterCollection collection)
    {
        _collection = collection;
        _currentIndex = 0;
    }

    // Возвращает первый элемент (индекс 0).
    public object First()
    {
        return _collection.GetItem(0);
    }

    // Возвращает элемент, на который указывает текущий индекс.
    public object Current()
    {
        return _collection.GetItem(_currentIndex);
    }

    // Проверка: не вышли ли мы за пределы коллекции.
    public bool Finished()
    {
        return _currentIndex >= _collection.GetCount();
    }

    // Перемещаем указатель вперед и возвращаем "прошедший" элемент.
    // Обратите внимание: мы сначала берем элемент, а потом увеличиваем индекс (пост-инкремент).
    public object Next()
    {
        return _collection.GetItem(_currentIndex++);
    }
}