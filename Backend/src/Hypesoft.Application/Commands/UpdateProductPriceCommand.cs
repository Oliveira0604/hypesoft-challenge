namespace Hypesoft.Application.Commands;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductPriceCommand(UpdateProductPriceRequest request) : IRequest<bool>;