namespace MyFirstWebApp.Models
{
    public interface IRepository
    {
        Task<IEnumerable<MyModel>> GetAllItemsAsync();
    }
}
