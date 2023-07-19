namespace CheckOutApp.Products
{
    public interface IPriceStrategy 
    {
        public int CalculatePrice(string sku,int price,int qty);
    }

    public class CalculationPerUnit : IPriceStrategy
    {
        public int CalculatePrice(string sku,int price,int qty) 
        {
            int calculateAmount;
            calculateAmount = (price * qty);
            return calculateAmount;
        }
    }

    public class DiscountCalculation : IPriceStrategy
    {
        int calculateDiscountAmount;
        public int CalculatePrice(string sku, int price, int qty) 
        {
            
            Dictionary<string, int> saleRule = new Dictionary<string, int>();
            saleRule.Add("A:3", 130);
            saleRule.Add("B:2", 45);
            PriceRule priceRule = new PriceRule(saleRule);
            int? specialPrice = priceRule.CheckPrice(sku, qty);

            if (specialPrice != null) 
            {
                calculateDiscountAmount = (int)((price * qty) - specialPrice);
            }
            return calculateDiscountAmount;
        }
    }
}
