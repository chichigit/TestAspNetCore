using TestAspNetCore.Pages;
using TestAspNetCore.Services.Base;

namespace TestAspNetCore.Services
{
    public class DBDataServices
    {
        private readonly InsightTestContext _context;
        private readonly IConfiguration _config;
        public DBDataServices(InsightTestContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public ServiceResponseBase<List<Number>> GetNumbers()
        {
            var numbers = _context.Numbers.ToList();
            var result = new ServiceResponseBase<List<Number>>();
            result.ReturnData = numbers;
            result.Message = "success";

            return result;
        }

    }
}
