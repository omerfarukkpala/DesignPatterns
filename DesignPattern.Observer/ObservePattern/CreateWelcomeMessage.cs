using DesignPattern.Observer.DAL;

namespace DesignPattern.Observer.ObservePattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize kayıt olduğunuz için çok teşekkür ederiz,dergilerimize web sitemizden ulaşabilirsiniz. "
            });
            context.SaveChanges();
        }
    }
}
