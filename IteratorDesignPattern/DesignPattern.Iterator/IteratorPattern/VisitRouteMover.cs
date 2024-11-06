namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitRoute>
    {
        public List<VisitRoute> visitRoutes = new List<VisitRoute>();
        public void AddVisitRoute(VisitRoute visitRoute)
        {
            visitRoutes.Add(visitRoute); // yeni route ekleme
        }

        //ziyaret edilen rota sayisini tutmak icin 
        public  int VisitRouteCount { get => visitRoutes.Count; }

        public Iterator<VisitRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);

        }
    }
}
