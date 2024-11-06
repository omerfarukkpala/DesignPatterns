namespace DesignPattern.Composite.CompositePattern
{
    public interface IComponent
    {
        public  int Id { get; set; }
        public  string Name { get; set; }

        int TotalCount();
        string Display();// Sidebarımızı(Kategorilerimizi) oluşturacak olan html kodları tutacak. 
    }
}
