using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class Decorator : ISendMessage
    {
        private readonly ISendMessage _sendMessage;

        public Decorator(ISendMessage sendMessage)
        {
            _sendMessage = sendMessage;
        }

       virtual  public void SendMessage(Message message)
        {
            message.Receiver = "Everybody";
            message.Sender = "Admin";
            message.Content = "Merhaba bu bir toplantı mesajıdır.";
            message.Subject = "Toplantı";
            _sendMessage.SendMessage(message);

        }
    }
}
