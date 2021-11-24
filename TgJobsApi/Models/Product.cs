namespace TgJobsApi.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class Product
    {
        public Product() { }

        public Product(int Id, string Name, string Color, double Price, double? Weight)
        {
            this.ProductID = Id;
            this.Name = Name;
            this.Color = Color;
            this.Price = Price;
            this.Weight = Weight;
        }

        public int ProductID { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public double Price { get; set; }

        public double? Weight { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }
    }
}
