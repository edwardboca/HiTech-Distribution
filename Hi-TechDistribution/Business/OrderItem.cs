using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hi_TechDistribution.DataAccess;

namespace Hi_TechDistribution.Business
{
    public class OrderItem
    {
        private int orderId;
        private int isbn;
        private int quantity;
        private double payment;

        public int OrderId { get => orderId; set => orderId = value; }
        public int Isbn { get => isbn; set => isbn = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Payment { get => payment; set => payment = value; }

        public void SaveOrderedItem(OrderItem odr1)
        {
            OrderItemDB.SaveRecord(odr1);
        }

        public List<OrderItem> GetOrderItemsList()
        {
            return (OrderItemDB.GetRecordList());
        }

        public void DeleteOrderItem(int orderId)
        {
            OrderItemDB.DeleteRecord(orderId);
        }
        public void UpdateBook(OrderItem odr1)
        {
            OrderItemDB.UpdateRecord(odr1);
        }

        public List<OrderItem> SearchOrder(int orderId)
        {
            return (OrderItemDB.SearchRecord(orderId));
        }
        public List<OrderItem> SearchOrderById(int custId)
        {
            return (OrderItemDB.SearchRecordByCust(custId));
        }

    }
}
