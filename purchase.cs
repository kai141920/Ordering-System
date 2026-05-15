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

        // =========================================
        // HTTP CLIENT
        // =========================================

        HttpClient client =
        new HttpClient();

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
            // =====================================
            // CHECK SESSION
            // =====================================

            if (Session.customer_id <= 0)
            {
                MessageBox.Show(
                    "No logged in customer."
                );

                return;
            }

            await LoadOrders();
        }

        // =========================================
        // LOAD ORDERS
        // =========================================

        private async Task LoadOrders()
        {
            try
            {
                int customer_id =
                Session.customer_id;

                string url =
                apiUrl + customer_id;

                HttpResponseMessage response =
                await client.GetAsync(url);

                string json =
                await response.Content
                .ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "API ERROR\n\n" + json
                    );

                    return;
                }

                List<OrderModel> orders =
                JsonConvert.DeserializeObject
                <List<OrderModel>>(json);

                // =====================================
                // DISPLAY TO DATAGRIDVIEW
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

                dgvList.Columns["category"]
                .HeaderText = "Category";

                dgvList.Columns["quantity"]
                .HeaderText = "Qty";

                dgvList.Columns["total_amount"]
                .HeaderText = "Total";

                dgvList.Columns["payment_status"]
                .HeaderText = "Status";

                dgvList.Columns["order_date"]
                .HeaderText = "Date";

                // =====================================
                // DESIGN
                // =====================================

                dgvList.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

                dgvList.RowTemplate.Height =
                35;

                dgvList.AllowUserToAddRows =
                false;

                dgvList.ReadOnly =
                true;

                dgvList.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

                dgvList.MultiSelect =
                false;

                dgvList.ClearSelection();

                // =====================================
                // COLUMN WIDTHS
                // =====================================

                // SMALL

                dgvList.Columns["order_id"]
                .Width = 50;

                dgvList.Columns["quantity"]
                .Width = 70;

                // MEDIUM

                dgvList.Columns["payment_status"]
                .Width = 90;

                dgvList.Columns["total_amount"]
                .Width = 100;

                // LARGE

                dgvList.Columns["fullname"]
                .Width = 170;

                dgvList.Columns["equipment_name"]
                .Width = 150;

                dgvList.Columns["category"]
                .Width = 120;

                // DATE

                dgvList.Columns["order_date"]
                .Width = 150;

                // =====================================
                // DATE FORMAT
                // =====================================

                dgvList.Columns["order_date"]
                .DefaultCellStyle.Format =
                "MMM dd, yyyy";

                // =====================================
                // TOTAL FORMAT
                // =====================================

                dgvList.Columns["total_amount"]
                .DefaultCellStyle.Format =
                "₱#,##0.00";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
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
        // ORDER LIST BUTTON
        // =========================================

        private void btnOrderList_Click(
            object sender,
            EventArgs e)
        {
            purchase purchaselist =
            new purchase();

            purchaselist.Show();

            this.Hide();
        }

        // =========================================
        // LOGOUT BUTTON
        // =========================================

        private void btnLogout_Click(
            object sender,
            EventArgs e)
        {
            Form1 f =
            new Form1();

            f.Show();

            this.Hide();
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

        public string category { get; set; }

        public int quantity { get; set; }

        public decimal total_amount { get; set; }

        public string payment_status { get; set; }

        public DateTime order_date { get; set; }
    }
}