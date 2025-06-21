using crudClientes.Data;
using crudClientes.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyApp.Namespace
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;
        public CreateModel(AppDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Cliente Cli { get; set; }
        public async Task<IActionResult> OnPost()
        {
            await _context.Cliente.AddAsync(Cli);
            await _context.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
