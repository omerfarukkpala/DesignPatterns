using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class SubjectIDDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public SubjectIDDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageIDSubject(Message message)
        {
           if(message.Subject == "1")
            {
                message.Subject = "Toplantı";
            }
           if(message .Subject == "2")
            {
                message.Subject = "Scrum ";
            }
            if (message.Subject == "3")
            {
                message.Subject = "Hafta Degerlendirme";
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageIDSubject(message);
        }
    }
}

