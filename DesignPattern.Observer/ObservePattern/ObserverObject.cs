using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObservePattern
{
    public class ObserverObject
    {
        private readonly List<IObserver> _observer;

      
        public ObserverObject()
        {
            _observer = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer) // Aboneligi olustur
        {
            _observer.Add(observer);
        }

        public void RemoveObserver(IObserver observer) // Aboneligi sil
        {
            _observer.Remove(observer);
        }

        public void NotifyObserver(AppUser appUser) // Her bir kullanici icin tetiklenmesi
        {
            _observer.ForEach(x =>
            {
                x.CreateNewUser(appUser);
            }); // yeni kullanici icin gozlemleme isleminde o listede ne varsa listenin butun ogelerini tek tek dolas
        }
    }
}
