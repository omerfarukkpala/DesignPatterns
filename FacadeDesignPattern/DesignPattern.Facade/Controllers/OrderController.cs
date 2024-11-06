using DesignPattern.Facade.FacadePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.Facade.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult OrderDetailStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderDetailStart(int customerID, int productID, int orderID, int productCount, decimal productPrice)
        {
            OrderFacade order = new OrderFacade();
            order.CompleteOrderDetail(customerID, productID, orderID, productCount, productPrice);
            return RedirectToAction("OrderStart");
        }

        [HttpGet]
        public IActionResult OrderStart()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderStart(int customerID)
        {
            OrderFacade orderFacade = new OrderFacade();
            orderFacade.CompleteOrder(customerID);
            return View();
        }

    }
}
