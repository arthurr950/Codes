using System.Globalization;

namespace Exercicio_12.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
        public override string PriceTag()
        {
            Price = TotalPrice();
            return base.PriceTag() + " (Customs fee: $ " + CustomsFee.ToString("F2",CultureInfo.InvariantCulture)+")";
        }
    }
}
