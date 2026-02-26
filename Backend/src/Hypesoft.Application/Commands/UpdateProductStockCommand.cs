namespace Hypesoft.Application.Commands;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductStockCommand(UpdateProductStockRequest request) : IRequest<bool>;