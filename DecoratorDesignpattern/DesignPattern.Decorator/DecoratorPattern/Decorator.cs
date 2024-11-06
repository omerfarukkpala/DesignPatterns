using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class Decorator : INotifier
    {
        private readonly INotifier _notifier;

        public Decorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        virtual  public void CreateNotify(Notifier notifier)
        {
            notifier.Creator = "Admin";
            notifier.Subject = "Toplantı";
            notifier.Type = "Public";
            notifier.Channel = "Whatsapp";
            _notifier.CreateNotify(notifier);
        }
    }
}
