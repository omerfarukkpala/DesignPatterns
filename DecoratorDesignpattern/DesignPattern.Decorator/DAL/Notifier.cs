namespace DesignPattern.Decorator.DAL
{
    public class Notifier
    {
        public  int NotifierID { get; set; }
        public  string Creator { get; set; }
        public  string Subject { get; set; }
        public  string Type { get; set; }

        public  string Channel { get; set; }
    }
}
