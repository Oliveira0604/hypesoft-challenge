namespace Hypesoft.Application.Commands.Product;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductStockCommand(UpdateProductStockRequest request) : IRequest<bool>;