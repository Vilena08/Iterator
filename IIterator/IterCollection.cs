using System.Collections; // Подключаем для использования ArrayList

public class IterCollection : IIterCollection
{
    // Внутреннее хранилище данных. Используем ArrayList, так как он простой и не требует дженериков.
    private ArrayList _items = new ArrayList();

    // Пустой конструктор.
    public IterCollection()
    {
    }

    // Конструктор, заполняющий коллекцию числами от 1 до size.
    // Это нужно для демонстрации, чтобы было что перебирать.
    public IterCollection(int size)
    {
        for (int elementIndex = 0; elementIndex < size; ++elementIndex)
        {
            _ = _items.Add(elementIndex + 1); // Добавляем числа 1, 2, 3...
        }
    }

    // Реализация метода из интерфейса: возвращает новый итератор, связанный с этой коллекцией.
    public IIterator GetIterator()
    {
        return new Iterator(this); // Передаем ссылку на текущую коллекцию в итератор.
    }

    // Метод для получения элемента по индексу (используется итератором).
    public object GetItem(int index)
    {
        return _items[index];
    }

    // Метод для получения количества элементов (используется итератором).
    public int GetCount()
    {
        return _items.Count;
    }
}