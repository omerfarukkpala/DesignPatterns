using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class OrderFacade
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();

        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        // Siparis islemlerinin gerceklesmesi icin yazilan method
        public void CompleteOrderDetail(int customerID,int productID,int orderID,int productCount,decimal productPrice)
        {
            orderDetail.CustomerID = customerID;
            orderDetail.ProductID = productID;
            orderDetail.OrderID = orderID;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            decimal totalProductPrice = productPrice * productCount;
            orderDetail.ProductTotalPrice = totalProductPrice;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productID, productCount);

        }

        public void CompleteOrder(int customerID)
        {
            order.CustomerID = customerID;
            addOrder.AddNewOrder(order);
        }
    }
}
