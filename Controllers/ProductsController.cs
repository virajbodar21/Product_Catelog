using Product_Catelog.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Product_Catelog.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            List<Product> P_ALL = GetProductData();

            return View("Products", P_ALL);
        }

        // GET: Products/Details/101
        public ActionResult Details(int id)
        {
            List<Product> P_ALL = GetProductData();

            Product p1 = P_ALL.FirstOrDefault(x => x.ProductId == id);

            if (p1 == null)
            {
                return HttpNotFound();
            }

            return View("View",p1);
        }

        private List<Product> GetProductData()
        {
            List<Product> pTemp = new List<Product>();

            Product p1 = new Product();
            Product p2 = new Product();
            Product p3 = new Product();

            p1.ProductId = 101;
            p1.ProductName = "Iphone Fold";
            p1.ProductPrice = 299900;
            p1.ProductCategory = "Mobile";
            p1.ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyHz1ahObPtBffT6haivs6XZIqpIguGytB5vsQRqPcSzmumsSKglg7-GL&s=10";

            p2.ProductId = 102;
            p2.ProductName = "MacBook Pro";
            p2.ProductPrice = 239900;
            p2.ProductCategory = "Laptop";
            p2.ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRTIXkmezMrHpRL53bHk3grSIEJgT2xHGBeNzqUYgFw5Iluwc_CqFJvfXMJ&s=10";

            p3.ProductId = 103;
            p3.ProductName = "Apple Series 12";
            p3.ProductPrice = 56900;
            p3.ProductCategory = "Watch";
            p3.ImageUrl = "https://images.macrumors.com/t/R60d6OCJ_N_smfAvTluWVyQiFd0=/1600x900/smart/article-new/2026/09/apple-watch-series-12.jpg";

            pTemp.Add(p1);
            pTemp.Add(p2);
            pTemp.Add(p3);

            return pTemp;
        }
    }
}