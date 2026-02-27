namespace Hypesoft.Application.Commands.Category;

using MediatR;
using Hypesoft.Application.DTOs;

public class CreateCategoryCommand(CreateCategoryRequest request) : IRequest<bool>;