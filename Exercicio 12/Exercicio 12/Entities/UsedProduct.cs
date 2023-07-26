
namespace Exercicio_12.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag() 
        {
            Name = Name + " (used)";
            return base.PriceTag() + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy")+")";       
        }
    }
}
