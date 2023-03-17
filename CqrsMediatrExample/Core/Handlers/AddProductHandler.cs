using CqrsMediatrExample.Core.Commands;
using CqrsMediatrExample.Database;
using MediatR;

namespace CqrsMediatrExample.Core.Handlers
{
    public class AddProductHandler : IRequestHandler<AddProductCommand, Unit>
    {
        private readonly FakeDataStore _fakeDataStore;
        public AddProductHandler(FakeDataStore fakeDataStore)
        {
            _fakeDataStore = fakeDataStore;
        }

        // Unit represents the void type,
        // So here we just create the product and return void
        public async Task<Unit> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _fakeDataStore.AddProduct(request.Product);

            return Unit.Value;
        }
    }
}
