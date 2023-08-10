using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestAspNetCore.Pages
{
    public class Error2Model : PageModel
    {
        private readonly ILogger<Error2Model> _logger;

        private int number;

        public Error2Model(ILogger<Error2Model> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            int c = 0;
            int a = 1 / c;

            number = a;
        }
    }
}
