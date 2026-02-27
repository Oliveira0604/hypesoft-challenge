namespace Hypesoft.Application.Commands.Product;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductPriceCommand(UpdateProductPriceRequest request) : IRequest<bool>;