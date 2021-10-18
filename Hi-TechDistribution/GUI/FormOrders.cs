using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hi_TechDistribution.DataAccess;
using Hi_TechDistribution.Business;
using Hi_TechDistribution.Validation;
using Hi_TechDistribution.EntityDB;

namespace Hi_TechDistribution.GUI
{
    public partial class FormOrders : Form
    {
        HiTechEntities1 dBEntities = new HiTechEntities1();

        public FormOrders()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string input;
            input = txtOrderId.Text.Trim();
            if (!ValidatorOrder.IsValidOrderId(input.ToString()))
            {
                txtOrderId.Clear();
                return;
            }
            input = txtShipCity.Text.Trim();
            if (!ValidatorOrder.IsValidCity(input))
            {
                txtShipCity.Clear();
                return;
            }

            Order odr = new Order();
            odr.OrderId = Convert.ToInt32(txtOrderId.Text.Trim());
            odr.CustomerId = Convert.ToInt32(cmbCustomerId.SelectedItem);
            odr.OrderDate = System.DateTime.Now;
            odr.ShipDate = Convert.ToDateTime(maskedtxtStartDate.Text.Trim());
            odr.ShipCity = txtShipCity.Text.Trim();
            odr.EmployeeId = Convert.ToInt32(cmbEmployeeId.SelectedItem);
            odr.OrderBy = Convert.ToString(cmbOrderBy.SelectedItem);
            dBEntities.Orders.Add(odr);
            dBEntities.SaveChanges();
            MessageBox.Show("Order has been added successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Orders_Load(object sender, EventArgs e)
        {
            comboBoxOption.SelectedIndex = 0;
            cmbOrderBy.SelectedIndex = 0;
            var listCustomer = from cust in CustomerDB.ListRecord()
                               select cust;
            cmbCustomerId.Items.Add("--Select CustomerId--");
            cmbCustomerId.SelectedIndex = 0;
            foreach (Customer item in listCustomer)
            {
                cmbCustomerId.Items.Add(item.CustomerId);
            }
            cmbEmployeeId.Items.Add("--Select EmployeeId--");
            cmbEmployeeId.SelectedIndex = 0;
            var listEmp = from emp in EmployeeDB.GetRecordList()
                          select emp;
            foreach (Employee item in listEmp)

            {
                cmbEmployeeId.Items.Add(item.EmployeeId);
            }
        }

        private void BtnListStudents_Click(object sender, EventArgs e)
        {
            var orderList = from order in dBEntities.Orders
                            select order;
            string display = "";
            foreach (Order item in orderList)
            {
                display += item.OrderId + "," + item.CustomerId + "," + item.OrderDate + "," + item.ShipDate + "," + item.ShipCity + item.EmployeeId + "," + item.OrderBy + "," + "\n";
            }

            listViewOrder.Items.Clear();
            foreach (var item in orderList)
            {
                ListViewItem _item = new ListViewItem(Convert.ToString(item.OrderId));
                _item.SubItems.Add(Convert.ToString(item.CustomerId));
                _item.SubItems.Add(item.OrderDate.ToString());
                _item.SubItems.Add(item.ShipDate.ToString());
                _item.SubItems.Add(item.ShipCity);
                _item.SubItems.Add(Convert.ToString(item.EmployeeId));
                _item.SubItems.Add(item.OrderBy);
                listViewOrder.Items.Add(_item);
            }

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int search = Convert.ToInt32(txtOrderId.Text.Trim());
            var odr = (from od in dBEntities.Orders
                       where od.OrderId == search
                       select od).SingleOrDefault();
            dBEntities.Orders.Remove(odr);
            dBEntities.SaveChanges();
            MessageBox.Show("Order has been deleted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BtnModify_Click(object sender, EventArgs e)
        {


            int searchId = Convert.ToInt32(txtOrderId.Text.Trim());
            var order = (from od in dBEntities.Orders
                         where od.OrderId == searchId
                         select od).First<Order>();
            if (order != null)
            {
                order.CustomerId = Convert.ToInt32(cmbCustomerId.SelectedItem);
                order.ShipDate = Convert.ToDateTime(maskedtxtStartDate.Text.Trim());
                order.ShipCity = txtShipCity.Text.Trim();
                order.EmployeeId = Convert.ToInt32(cmbEmployeeId.SelectedItem);
                order.OrderBy = Convert.ToString(cmbOrderBy.SelectedItem);
                dBEntities.SaveChanges();
                MessageBox.Show("Order has been Updated successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

            if (comboBoxOption.SelectedIndex == 1)
            {
                int search = Convert.ToInt32(txtInput.Text.Trim());
                var odr = (from od in dBEntities.Orders
                           where od.OrderId == search
                           select od).SingleOrDefault();
                txtOrderId.ReadOnly = true;
                if (odr.OrderId == search)
                {
                    txtOrderId.Text = Convert.ToString(odr.OrderId);
                    cmbCustomerId.SelectedItem = odr.CustomerId;
                    maskedtxtStartDate.Text = Convert.ToString(odr.ShipDate);
                    txtShipCity.Text = odr.ShipCity;
                    cmbEmployeeId.SelectedItem = odr.EmployeeId;
                    cmbOrderBy.SelectedItem = odr.OrderBy;
                }
            }
            else
            {
                string search = txtInput.Text.ToUpper().Trim();
                var orderList = (from order in dBEntities.Orders
                                 where order.ShipCity.ToUpper() == search
                                 select order);
                //var orderList = (from od in dBEntities.Orders
                //                 where od.ShipCity.ToUpper() == search
                //                 select od).SingleOrDefault();
                string display = "";


                foreach (Order item in orderList)
                {
                    display += item.OrderId + "," + item.CustomerId + "," + item.OrderDate + "," + item.ShipDate + "," + item.ShipCity + item.EmployeeId + "," + item.OrderBy + "," + "\n";
                }

                listViewOrder.Items.Clear();
                foreach (var item in orderList)
                {
                    ListViewItem _item = new ListViewItem(Convert.ToString(item.OrderId));
                    _item.SubItems.Add(Convert.ToString(item.CustomerId));
                    _item.SubItems.Add(item.OrderDate.ToString());
                    _item.SubItems.Add(item.ShipDate.ToString());
                    _item.SubItems.Add(item.ShipCity);
                    _item.SubItems.Add(Convert.ToString(item.EmployeeId));
                    _item.SubItems.Add(item.OrderBy);
                    listViewOrder.Items.Add(_item);
                }


            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderClerks back = new FormOrderClerks();
            back.Show();
        }

        private void MaskedtxtStartDate_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GbEmployee_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int searchId = Convert.ToInt32(txtOrderId.Text.Trim());
            var order = (from od in dBEntities.Orders
                         where od.OrderId == searchId
                         select od).First<Order>();
            if (order != null)
            {
                order.CustomerId = Convert.ToInt32(cmbCustomerId.SelectedItem);
                order.ShipDate = Convert.ToDateTime(maskedtxtStartDate.Text.Trim());
                order.ShipCity = txtShipCity.Text.Trim();
                order.EmployeeId = Convert.ToInt32(cmbEmployeeId.SelectedItem);
                order.OrderBy = Convert.ToString(cmbOrderBy.SelectedItem);
                dBEntities.SaveChanges();
                MessageBox.Show("Order has been Updated successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnListOrders_Click(object sender, EventArgs e)
        {
            var orderList = from order in dBEntities.Orders
                            select order;
            string display = "";
            foreach (Order item in orderList)
            {
                display += item.OrderId + "," + item.CustomerId + "," + item.OrderDate + "," + item.ShipDate + "," + item.ShipCity + item.EmployeeId + "," + item.OrderBy + "," + "\n";
            }

            listViewOrder.Items.Clear();
            foreach (var item in orderList)
            {
                ListViewItem _item = new ListViewItem(Convert.ToString(item.OrderId));
                _item.SubItems.Add(Convert.ToString(item.CustomerId));
                _item.SubItems.Add(item.OrderDate.ToString());
                _item.SubItems.Add(item.ShipDate.ToString());
                _item.SubItems.Add(item.ShipCity);
                _item.SubItems.Add(Convert.ToString(item.EmployeeId));
                _item.SubItems.Add(item.OrderBy);
                listViewOrder.Items.Add(_item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOrderClerks back = new FormOrderClerks();
            back.Show();
        }
    }
}

