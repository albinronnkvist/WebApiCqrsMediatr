using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Core.Queries
{
    // Our request will return a list of products.
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}
