namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductUpdateByIdQuery
    {
        public GetProductUpdateByIdQuery(int id)
        {
            ID = id;
        }

        public  int ID { get; set; }
    }
}
