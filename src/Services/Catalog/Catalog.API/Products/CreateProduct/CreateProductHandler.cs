using MediatR;
using System.ComponentModel;
using System.Reflection;
using BuildingBlocks.CQRS;
using Catalog.API.Models;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(string Name, List<string> Category,string Description,string ImageFile,decimal Price)
    : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid  Id);
    public class CreateProductHandler 
        : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {       //create Product entity from command Object
                //Save to DB
                //Return CreateProductResult result

            var product = new Product
            {
                Name = command.Name,
                Category = command.Category,
                Description = command.Description,
                ImageFile = command.ImageFile,
                Price = command.Price
            };

            //Save to DB
            //Return  result
            return new CreateProductResult(Guid.NewGuid());

            //throw new NotImplementedException();
        }
    }
}
