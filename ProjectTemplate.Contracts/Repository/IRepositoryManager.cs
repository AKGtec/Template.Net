namespace ProjectTemplate.Contracts.Repository;

public interface IRepositoryManager
{
    // Add your specific repository interfaces here
    // Example: IUserRepository User { get; }
    // Example: IProductRepository Product { get; }
    
    void Save();
    Task SaveAsync();
}
