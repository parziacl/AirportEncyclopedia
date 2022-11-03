using AirportType;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Serialization;


namespace AirportEncyclopedia.Pages
{
    public class IndexModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            // get all landing sites
            var task = client.GetAsync("https://pkgstore.datahub.io/core/airport-codes/airport-codes_json/data/9ca22195b4c64a562a0a8be8d133e700/airport-codes_json.json");
            HttpResponseMessage result = task.Result;
            List<AirportSizeAndType> LandingSites = new List<AirportSizeAndType>();
            if (result.IsSuccessStatusCode)
            {
                Task<string> readString = result.Content.ReadAsStringAsync();
                string jsonString = readString.Result;
                LandingSites = AirportSizeAndType.FromJson(jsonString);
            }
            ViewData["landingsite"] = LandingSites;
        }
    }
}
        
                
    
