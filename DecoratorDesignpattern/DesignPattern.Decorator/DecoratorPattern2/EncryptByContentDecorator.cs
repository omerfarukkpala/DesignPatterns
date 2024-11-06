using DesignPattern.Decorator.DAL;

namespace DesignPattern.Decorator.DecoratorPattern2
{
    public class EncryptByContentDecorator : Decorator
    {
        private readonly ISendMessage _sendMessage;
        Context context = new Context();
        public EncryptByContentDecorator(ISendMessage sendMessage) : base(sendMessage)
        {
            _sendMessage = sendMessage;
        }

        public void SendMessageByEncryptoContent(Message message)
        {
            message.Sender = "Takım Lideri";
            message.Receiver = "Yazılım Ekibi";
            message.Content = "Saat 17:00 de Publish yapılacak";
            message.Subject = "Publish";
            string data = "";
            data = message.Content;
            char[] chars = data.ToCharArray();
            foreach (var item in chars)
            {
                message.Content += Convert.ToChar(item + 3).ToString();
            }
            context.Messages.Add(message);
            context.SaveChanges();
        }
        public override void SendMessage(Message message)
        {
            base.SendMessage(message);
            SendMessageByEncryptoContent(message);
        }
    }
}
