using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_TechDistribution.Business
{
    public class Order
    {
        private int orderId;
        private int customerId;
        private DateTime orderDate;
        private DateTime shipDate;
        private string shipCity;
        private int employeeId;
        private string orderBy;

        public int OrderId { get => orderId; set => orderId = value; }
        public int CustomerId { get => customerId; set => customerId = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
        public DateTime ShipDate { get => shipDate; set => shipDate = value; }
        public string ShipCity { get => shipCity; set => shipCity = value; }
        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string OrderBy { get => orderBy; set => orderBy = value; }
    }
}
