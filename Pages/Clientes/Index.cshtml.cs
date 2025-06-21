using crudClientes.Data;
using crudClientes.Models;
using crudClientes.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Namespace
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;
        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public List<Cliente> ListClientes { get; set; }
        public async Task OnGet()
        {
            ListClientes = await _context.Cliente.ToListAsync();
        }
    }
}
