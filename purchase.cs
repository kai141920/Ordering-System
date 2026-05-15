using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Ordering_System
{
    public partial class purchase : Form
    {
        // =========================================
        // API URL
        // =========================================

        string apiUrl =
        "http://localhost:3000/api/order/customer/";

        public purchase()
        {
            InitializeComponent();
        }

        // =========================================
        // FORM LOAD
        // =========================================

        private async void purchase_Load(
            object sender,
            EventArgs e)
        {
            await LoadOrders();
        }

        // =========================================
        // LOAD ORDERS
        // =========================================

        private async Task LoadOrders()
        {
            try
            {
                using (HttpClient client =
                    new HttpClient())
                {
                    // =====================================
                    // CHECK SESSION
                    // =====================================

                    int customer_id =
                    Session.customer_id;

                    MessageBox.Show(
                        "Customer ID: " +
                        customer_id
                    );

                    // =====================================
                    // URL
                    // =====================================

                    string url =
                    apiUrl + customer_id;

                    MessageBox.Show(url);

                    // =====================================
                    // API REQUEST
                    // =====================================

                    HttpResponseMessage response =
                    await client.GetAsync(url);

                    response.EnsureSuccessStatusCode();

                    // =====================================
                    // JSON RESPONSE
                    // =====================================

                    string json =
                    await response
                    .Content
                    .ReadAsStringAsync();

                    MessageBox.Show(json);

                    // =====================================
                    // CONVERT JSON
                    // =====================================

                    List<OrderModel> orders =
                    JsonConvert.DeserializeObject
                    <List<OrderModel>>(json);

                    // =====================================
                    // DISPLAY
                    // =====================================

                    dgvList.DataSource = null;

                    dgvList.DataSource = orders;

                    // =====================================
                    // HEADERS
                    // =====================================

                    dgvList.Columns["order_id"]
                    .HeaderText = "ID";

                    dgvList.Columns["fullname"]
                    .HeaderText = "Customer";

                    dgvList.Columns["equipment_name"]
                    .HeaderText = "Equipment";

                    dgvList.Columns["quantity"]
                    .HeaderText = "Qty";

                    dgvList.Columns["total_amount"]
                    .HeaderText = "Total";

                    dgvList.Columns["payment_status"]
                    .HeaderText = "Status";

                    dgvList.Columns["order_date"]
                    .HeaderText = "Date";

                    dgvList.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // =========================================
        // ORDER BUTTON
        // =========================================

        private void btnOrder_Click(
            object sender,
            EventArgs e)
        {
            items itemsForm =
            new items();

            itemsForm.Show();

            this.Hide();
        }

        // =========================================
        // CELL CLICK
        // =========================================

        private void dgvList_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }
    }

    // =========================================
    // MODEL
    // =========================================

    public class OrderModel
    {
        public int order_id { get; set; }

        public string fullname { get; set; }

        public string equipment_name { get; set; }

        public int quantity { get; set; }

        public decimal total_amount { get; set; }

        public string payment_status { get; set; }

        public DateTime order_date { get; set; }
    }
}