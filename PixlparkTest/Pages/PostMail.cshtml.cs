using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PixlparkTest.Pages
{
    public class GetMailModel : PageModel
    {
        public string Email = "";
        public void OnGet()
        {
        }
        public void OnPost()
        {
            Email = Request.Form["e-mail"];
        }
    }
}
