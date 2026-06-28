public interface IIterCollection
{
    // Метод, который создает и возвращает итератор для этой коллекции.
    // Это "фабрика" итераторов.
    IIterator GetIterator();
}
