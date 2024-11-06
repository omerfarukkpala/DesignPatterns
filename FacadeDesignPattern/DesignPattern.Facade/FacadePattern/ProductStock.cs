using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadePattern
{
    public class ProductStock
    {
        Context context = new Context();
        
        //Stok azaltma
        public void StockDecrease(int id,int amount)
        {
            var value = context.Products.Find(id);
            value.ProductStock -= amount;
            context.SaveChanges();
        }
    }
}
