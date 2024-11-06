namespace DesignPattern.Iterator.IteratorPattern
{
    public interface Iterator<T>
    {
        T CurrentItem { get; }
        bool NextLocation();

    }
}
