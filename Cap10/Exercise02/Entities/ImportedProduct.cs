using System.Globalization;

namespace Cap10.Exercise02.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        private double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("f2", CultureInfo.InvariantCulture)
                + " (Customs Fee: $ " + CustomsFee + ")";
        }
    }
}
