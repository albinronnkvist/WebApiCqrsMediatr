using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Core.Commands
{
    // So, our record has a single Product property and inherits from the IRequest interface.
    // Notice this time the IRequest signature doesn’t have a type parameter. This is because we aren’t returning a value.
    public record AddProductCommand(Product Product) : IRequest;
}
