using CQRS_MY.CQRS.Handlers.ProductHandlers;
using Microsoft.AspNetCore.Mvc;

namespace CQRS_MY.Controllers
{
    public class ProductController : Controller
    {
        private readonly GetProductQueryHandler _getProductQueryHandler;
        private readonly GetProductQueryHandler2 _getProductQueryHandler2;


        public ProductController(GetProductQueryHandler getProductQueryHandler, GetProductQueryHandler2 getProductQueryHandler2)
        {
            _getProductQueryHandler = getProductQueryHandler;
            _getProductQueryHandler2 = getProductQueryHandler2;
        }

        //Depocuya Göre veri listesi
        public IActionResult StoragerIndex()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }

        //Muhasebeciye Göre veri listesi
        public IActionResult AccounterIndex()
        {
            var values = _getProductQueryHandler.Handle();
            return View(values);
        }
    }
}
