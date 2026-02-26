namespace Hypesoft.Application.Commands;

using MediatR;
using Hypesoft.Application.DTOs;

public class CreateCategoryCommand(CreateCategoryRequest request) : IRequest<bool>;