namespace TgJobsApi.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public  partial class SalesOrderHeader
    {
        public SalesOrderHeader()
        {
            this.SalesOrderDetails = new List<SalesOrderDetail>();
        }

        public SalesOrderHeader(int Id, int CustomerId, DateTime OrderDate, DateTime? ShipDate, byte Status) 
            : this()
        {
            this.SalesOrderID = Id;
            this.CustomerID = CustomerId;
            this.OrderDate = OrderDate;
            this.ShipDate = ShipDate;
            this.Status = Status;
            
        }

        public int SalesOrderID { get; set; }

        public int CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime? ShipDate { get; set; }

        /// <summary>
        /// 1. Pending
        /// 2. Sent
        /// 3. Complete
        /// </summary>
        public byte Status { get; set; }
        
        public double Total { get { return this.SalesOrderDetails.Sum(x => x.Price); } }

        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
    }
}
