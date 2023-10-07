using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using shopapp.business.Abstract;
using shopapp.entity;
using shopapp.webui.Models;


namespace shopapp.webui.Controllers
{
    //localhost:5000/home
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }
        //localhost:5000/home/index
        public IActionResult Index()
        {
            var productViewModel = new ProductListViewModels() { Products = _productService.GetHomePageProducts() };
            return View(productViewModel);
        }
        public async Task<IActionResult> GetProductsFromRestApi()
        {
            var products = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:4200/api/products"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    //deserialize json 
                    products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                }

            }
            return View(products);
        }
        //localhost:5000/home/about
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyView");
        }
    }
}