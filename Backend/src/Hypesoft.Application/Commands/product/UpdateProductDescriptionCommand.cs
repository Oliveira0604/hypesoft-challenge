namespace Hypesoft.Application.Commands.Product;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductDescriptionCommand(UpdateProductDescriptionRequest request) : IRequest<bool>;