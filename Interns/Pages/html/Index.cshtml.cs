using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Interns.Pages
{
    public class Index777Model : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Index777Model(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
