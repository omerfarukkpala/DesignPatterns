using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern
{
    public class MailDecorator : Decorator
    {
        private readonly INotifier _notifier;
        Context context = new Context();

        public MailDecorator(INotifier notifier) : base(notifier)
        {
            _notifier = notifier;
        }

        public void SendMailNotify(Notifier notifier)
        {
            notifier.Subject = "Günlük Sabah Toplantısı";
            notifier.Creator = "Scrum Master";
            notifier.Channel = "Gmail-Outlook";
            notifier.Type = "Private Team";
            context.Notifiers.Add(notifier);
            context.SaveChanges();
        }

        public override void CreateNotify(Notifier notifier)
        {
            base.CreateNotify(notifier);
            SendMailNotify(notifier);
        }
    }
}
