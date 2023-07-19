using CheckOutApp.Products;

namespace CheckOutApp
{
    public partial class Checkout : Form
    {
        List<ItemViewModel> _cart { get; set; }
        int discount;
        int amount;
        public Checkout()
        {
            InitializeComponent();
            _cart = new List<ItemViewModel>();
        }

        private void ScanItem(ItemViewModel item)
        {
            if (!CheckExist(item))
            {
                item.Qunatity = 1;
                _cart.Add(item);
            }
            else { _cart.Find(x => x.Sku == item.Sku).Qunatity++; }
        }

        public bool CheckExist(ItemViewModel item)
        {
            ItemViewModel _ItemModel = _cart.Find(x => x.Sku == item.Sku);
            if (_ItemModel != null)
                return true;
            else
            {
                return false;
            }
        }
        public void Calculation(ItemViewModel item)
        {
            /*This object will calculate the price per unit*/
            CalculationPerUnit calculationPerUnit = new CalculationPerUnit();
            /*This object will helps to calculate the discount price of product*/
            DiscountCalculation discountCalculation = new DiscountCalculation();
            try
            {
                if (item != null)
                {
                    for (int i = 0; i < _cart.Count; i++)
                    {
                        if (_cart[i].Qunatity >= 2)
                        {
                            discount = discountCalculation.CalculatePrice(_cart[i].Sku, _cart[i].Price, _cart[i].Qunatity);
                        }
                        amount = calculationPerUnit.CalculatePrice(_cart[i].Sku, _cart[i].Price, _cart[i].Qunatity);
                    }
                    if (discount != 0)
                    {
                        lblDiscountValue.Text = discount.ToString();


                    }
                    lblSubTotalValue.Text = amount.ToString();
                    lblTotalValue.Text = (amount - discount).ToString();
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                BindTheGridView();
            }
        }

        public void BindTheGridView()
        {
            dgvShoppingCart.DataSource = null;
            dgvShoppingCart.Rows.Clear();
            dgvShoppingCart.DataSource = _cart;
        }
        private void btnItemA_Click(object sender, EventArgs e)
        {
            ItemViewModel itemViewModel = new ItemViewModel
            {
                Sku = "A",
                Price = 50
            };
            ScanItem(itemViewModel);
            Calculation(itemViewModel);
        }

        private void btnItemB_Click(object sender, EventArgs e)
        {
            ItemViewModel itemViewModel = new ItemViewModel
            {
                Sku = "B",
                Price = 30
            };
            ScanItem(itemViewModel);
            Calculation(itemViewModel);

        }

        private void btnItemC_Click(object sender, EventArgs e)
        {
            ItemViewModel itemViewModel = new ItemViewModel
            {
                Sku = "C",
                Price = 20
            };
            ScanItem(itemViewModel);
            Calculation(itemViewModel);
        }

        private void btnItemD_Click(object sender, EventArgs e)
        {
            ItemViewModel itemViewModel = new ItemViewModel
            {
                Sku = "D",
                Price = 15
            };
            ScanItem(itemViewModel);
            Calculation(itemViewModel);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            lblSubTotalValue.Text = "0";
            lblTotalValue.Text = "0";
            lblDiscountValue.Text = "0";
            BindTheGridView();
        }
    }
}