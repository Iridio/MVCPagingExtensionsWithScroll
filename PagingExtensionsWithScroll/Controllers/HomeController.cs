using Domain.Entities;
using Domain.Queries;
using PagingExtensionsWithScroll.Models;
using System.Web.Mvc;

namespace PagingExtensionsWithScroll.Controllers
{
  public class HomeController : Controller
  {
    private readonly IQueries<Product> productQueries;

    public HomeController(IQueries<Product> productQueries)
    {
      this.productQueries = productQueries;
    }

    public HomeController()
    {
      //it is a sample, I do not implemet a DI container for simplicity
      //Obviously you do not want to have coupling in your project ;)
      productQueries = new ProductQueries();
    }

    public ActionResult Index(int? page)
    {
      var model = new ProductsViewModel();
      model.Page = page ?? 0;
      int total = 0;
      model.Products = productQueries.GetAll(model.Page, model.PageSize, out total);
      model.TotalRecords = total;
      return View(model);
    }
  }
}
