namespace Hypesoft.Application.Commands.Product;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductNameCommand(UpdateProductNameRequest request) : IRequest<bool>;