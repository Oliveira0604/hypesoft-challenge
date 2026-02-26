namespace Hypesoft.Application.Commands;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductNameCommand(UpdateProductNameRequest request) : IRequest<bool>;