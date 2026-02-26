namespace Hypesoft.Application.Commands;

using MediatR;
using Hypesoft.Application.DTOs;

public class CreateProductCommand(CreateProductRequest request) : IRequest<bool>;
