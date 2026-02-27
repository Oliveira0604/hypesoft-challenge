namespace Hypesoft.Application.Commands.Category;

using Hypesoft.Application.DTOs;
using MediatR;

public class UpdateCategoryNameCommand(UpdateCategoryNameRequest request) : IRequest<bool>;