using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages
{
    public class Demo3Model : PageModel
    {
            [BindProperty]
            public string Name { get; set; }

            public void OnGet()
            {
            }
        }
    }
