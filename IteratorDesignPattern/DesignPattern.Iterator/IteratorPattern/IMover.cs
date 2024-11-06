namespace DesignPattern.Iterator.IteratorPattern
{
    public interface IMover<T>

    {
        Iterator<T> CreateIterator();
    }
}
