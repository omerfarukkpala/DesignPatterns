namespace DesignPattern.CQRS.CQRSPattern.Queries
{
    public class GetProductByIdQuery
    {
        public GetProductByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public  int  Id { get; set; }
    }
}
