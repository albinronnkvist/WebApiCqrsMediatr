using CqrsMediatrExample.Core.Queries;
using CqrsMediatrExample.Database;
using CqrsMediatrExample.Models;
using MediatR;

namespace CqrsMediatrExample.Core.Handlers
{
    // This class will handle GetProductsQuery, in this case, returning the list of products.
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<Product>>
    {
        private readonly FakeDataStore _fakeDataStore;

        public GetProductsHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        // We implement a single method called Handle, which returns the values from our FakeDataStore
        public async Task<IEnumerable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            return await _fakeDataStore.GetAllProducts();
        }
    }
}
