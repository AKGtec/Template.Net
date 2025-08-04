using AutoMapper;
using ProjectTemplate.Contracts;
using ProjectTemplate.Contracts.Repository;
using ProjectTemplate.Service.Contracts;

namespace ProjectTemplate.Service;

public sealed class ServiceManager : IServiceManager
{
    // Add your specific services here
    // private readonly Lazy<IUserService> _userService;
    // private readonly Lazy<IProductService> _productService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper)
    {
        // Initialize your services here
        // _userService = new Lazy<IUserService>(() => new UserService(repositoryManager, logger, mapper));
        // _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, logger, mapper));
    }

    // Add your service properties here
    // public IUserService UserService => _userService.Value;
    // public IProductService ProductService => _productService.Value;
}
