using DesignPattern.Mediator.MediatorPattern.Results;
using MediatR;

namespace DesignPattern.Mediator.MediatorPattern.Queries
{
    public class GetAllProductQuery :IRequest<List<GetAllProductQueryResult>>
    {

    }
}
