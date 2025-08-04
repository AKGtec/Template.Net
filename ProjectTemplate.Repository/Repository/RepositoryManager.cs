using ProjectTemplate.Contracts.Repository;
using ProjectTemplate.Models.DataSource;

namespace ProjectTemplate.Repository.Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly ProjectTemplateContext _repositoryContext;
    
    // Add your specific repositories here
    // private readonly Lazy<IUserRepository> _userRepository;
    // private readonly Lazy<IProductRepository> _productRepository;

    public RepositoryManager(ProjectTemplateContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        
        // Initialize your repositories here
        // _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
        // _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(repositoryContext));
    }

    // Add your repository properties here
    // public IUserRepository User => _userRepository.Value;
    // public IProductRepository Product => _productRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();

    public async Task SaveAsync() => await _repositoryContext.SaveChangesAsync();
}
