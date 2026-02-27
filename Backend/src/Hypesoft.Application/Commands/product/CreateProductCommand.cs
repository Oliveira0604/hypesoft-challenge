namespace Hypesoft.Application.Commands.Product;

using MediatR;
using Hypesoft.Application.DTOs;

public class CreateProductCommand(CreateProductRequest request) : IRequest<bool>;
