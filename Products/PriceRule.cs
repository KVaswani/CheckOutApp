namespace CheckOutApp.Products
{
    public class PriceRule
    {
        private Dictionary<string, int> _rule = new Dictionary<string, int>();

        public PriceRule(Dictionary<string, int> priceRule)
        {
            _rule = priceRule;
        }

        public int? CheckPrice(string sku, int price)
        {
            string dicKey = string.Format("{0}:{1}", sku, price);
            return _rule.ContainsKey(dicKey) ? (int?)_rule[dicKey] : null;
        }
    }
}
