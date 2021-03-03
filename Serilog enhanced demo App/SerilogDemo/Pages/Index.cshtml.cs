using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerilogDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("you requested the index page ");
            try
            {
                
                for (int i = 0; i < 10; i++)
                {
                    if (i == 6)
                    {
                        throw new Exception("this is our demo exception");
                    }
                    else
                    {
                        _logger.LogInformation("the value of i is {0} ",i);
                    }
                }
            }
            catch (Exception e)
            {
               _logger.LogError(e,"we caught this exception in index get call");
            }
        }
    }
}
