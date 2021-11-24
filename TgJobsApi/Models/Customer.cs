namespace TgJobsApi.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;

    public partial class Customer
    {
        public Customer() { }

        public Customer(int Id, string Name, string EmailAddres)
        {
            this.CustomerID = Id;
            this.Name = Name;
            this.EmailAddress = EmailAddres;
        }

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string EmailAddress { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public virtual ICollection<Product> Products { get; set; }
    }
}
