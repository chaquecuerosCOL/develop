using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChaquecuerosCol.Pages
{
    public class NosotrosModel : PageModel
    {
        private readonly ILogger<NosotrosModel> _logger;

        public NosotrosModel(ILogger<NosotrosModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}