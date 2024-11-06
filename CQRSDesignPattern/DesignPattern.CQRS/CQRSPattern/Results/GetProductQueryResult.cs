namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public  int ProductID { get; set; }
        public  string ProductName { get; set; }
        public  int Stock { get; set; }
        public  decimal Price { get; set; }
    }
}
