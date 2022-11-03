using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChaquecuerosCol.Pages
{
    public class CarritoModel : PageModel
    {
        private readonly ILogger<CarritoModel> _logger;

        public CarritoModel(ILogger<CarritoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}