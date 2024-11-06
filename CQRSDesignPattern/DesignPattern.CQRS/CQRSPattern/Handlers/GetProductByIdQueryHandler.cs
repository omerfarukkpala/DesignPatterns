using DesignPattern.CQRS.CQRSPattern.Queries;
using DesignPattern.CQRS.CQRSPattern.Results;
using DesignPattern.CQRS.DAL;

namespace DesignPattern.CQRS.CQRSPattern.Handlers
{
    public class GetProductByIdQueryHandler
    {
        private readonly Context _context;

        public GetProductByIdQueryHandler(Context context)
        {
            _context = context;
        }

        public GetProductByIdQueryResult Handle(GetProductByIdQuery query)
        {
            var values = _context.Products.Find(query.Id);
            return new GetProductByIdQueryResult
            {
                Name = values.Name,
                Price = values.Price,
                Stock = values.Stock,
                ProductID =values.ProductID
            };
        }
    }
}
