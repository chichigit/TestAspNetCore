using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestAspNetCore.Services;
using TestAspNetCore.Services.Base;

namespace TestAspNetCore.Pages
{
    public class DBDataModel : PageModel
    {
        private readonly InsightTestContext _context;
        private readonly IConfiguration _config;
        public ServiceResponseBase<List<Number>> data { get; set; }

        public DBDataModel(InsightTestContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public void OnGet()
        {
           data = new DBDataServices(_context, _config).GetNumbers();
        }

       
    }
}
