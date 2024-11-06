namespace DesignPattern.Iterator.IteratorPattern
{
    public class VisitRouteIterator : Iterator<VisitRoute>
    {
        private VisitRouteMover _visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }

        private int currentIndex = 0; // baslangic indexi

        public VisitRoute CurrentItem { get; set; }

        public bool NextLocation()
        {
            if(currentIndex< _visitRouteMover.VisitRouteCount)
            {
                CurrentItem = _visitRouteMover.visitRoutes[currentIndex++];
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
