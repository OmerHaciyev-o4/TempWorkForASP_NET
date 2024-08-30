namespace MyFirstWebApp.Models
{
    public class Repository : IRepository
    {
        public Task<IEnumerable<MyModel>> GetAllItemsAsync()
        {
            return null;
        }
    }
}
