namespace Hypesoft.Application.Commands;

using Hypesoft.Application.DTOs;
using MediatR;

public class UpdateCategoryNameCommand(UpdateCategoryNameRequest request) : IRequest<bool>;