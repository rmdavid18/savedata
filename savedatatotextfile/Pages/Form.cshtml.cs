using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.AspNetCore.Http;

namespace savedatatotextfile.Pages
{
    public class FormModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            return Page();
        }
        public class BibleData
        {
            public string? Book { get; set; }
            public string? BibleSelection { get; set; }
        
        }
        public class BibbleMain
        {
            
            public string? ChapterInput { get; set; }
            public string? Verse { get; set; }

        }
            

        public void OnPost(IFormFileCollection)
        {

            var client = new RestClient("https://bible-api.com/<biblebook&gt");

            var request = new RestRequest("", Method.Get);

            RestResponse response = client.Execute(request);

            var content = response.Content;

            var area = JsonConvert.DeserializeObject<BibbleMain>(content);
        }
    }
}
