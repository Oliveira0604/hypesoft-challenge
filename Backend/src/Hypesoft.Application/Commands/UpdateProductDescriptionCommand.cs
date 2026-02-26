namespace Hypesoft.Application.Commands;

using MediatR;
using Hypesoft.Application.DTOs;

public class UpdateProductDescriptionCommand(UpdateProductDescriptionRequest request) : IRequest<bool>;