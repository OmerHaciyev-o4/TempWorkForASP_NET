using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace MyFirstWebApp.Models
{
    public class WorkViewModel:PageModel
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<WorkViewModel> _logger;
        public WorkViewModel(ApplicationDbContext context, ILogger<WorkViewModel> logger)
        {
            _context = context;
            _logger = logger;            
        }

        public IList<Product> Products { get; set; }

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
