using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics;
using WebApicall.Models;

namespace WebApicall.Controllers
{

    public class User
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }


    }
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {



            #region Web apiden get
            ////RestCharp nugetten indir - Bir rest api ile iletişim kurmaya yarar
            ////NewtonSoft nugetten indir. - Json formatını bir tipe dönüştürmeye yarar
            //var client = new RestClient("https://localhost:7021/Test");

            //var request = new RestRequest();
            //request.Method = Method.Get;
            //var response = client.ExecuteGet(request);

            //User user = JsonConvert.DeserializeObject<User>(response.Content);

            #endregion


            #region Get Free api data
            var client = new RestClient("https://dog.ceo/api/breeds/image/random");

            var request = new RestRequest();
            request.Method = Method.Get;
            var restResponse = client.ExecuteGet(request);
            ViewModel viewmodel=JsonConvert.DeserializeObject<ViewModel>(restResponse.Content);


            return View(viewmodel);
            #endregion
            #region Web api Post


            //User userjson = new User
            //{

            //    Id = 1,
            //    Name = "Tahsin",
            //    Token = "Token"

            //};
            ////RestCharp nugetten indir - Bir rest api ile iletişim kurmaya yarar
            ////NewtonSoft nugetten indir. - Json formatını bir tipe dönüştürmeye yarar
            //var client = new RestClient("https://localhost:7021/Test");

            //var request = new RestRequest();

            //request.Method = Method.Post;

            //request.AddParameter("user", Newtonsoft.Json.JsonConvert.SerializeObject(userjson));
            //var response = client.ExecuteGet(request);

            //User? user = JsonConvert.DeserializeObject<User>(response.Content);
            #endregion
            //return View();
        }
        

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        public IActionResult KübraSinifDeneme()
        {
            return View();
        }
    }
}