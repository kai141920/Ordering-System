using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_System
{
    public partial class items : Form
    {
        // =========================================
        // API
        // =========================================

        string equipmentUrl =
        "http://localhost:3000/api/equipments";

        string orderUrl =
        "http://localhost:3000/api/order";

        // =========================================
        // HTTP CLIENT
        // =========================================

        HttpClient client =
        new HttpClient();

        // =========================================
        // EQUIPMENT LIST
        // =========================================

        List<EquipmentModel> equipmentList =
        new List<EquipmentModel>();

        decimal selectedPrice = 0;

        public items()
        {
            InitializeComponent();
        }

        // =========================================
        // LOAD EQUIPMENTS
        // =========================================

        private async Task LoadEquipments()
        {
            try
            {
                HttpResponseMessage response =
                await client.GetAsync(
                    equipmentUrl
                );

                string json =
                await response.Content
                .ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show(json);
                    return;
                }

                equipmentList =
                JsonConvert.DeserializeObject
                <List<EquipmentModel>>(json);

                if (equipmentList == null)
                {
                    MessageBox.Show(
                        "No equipment found."
                    );

                    return;
                }

                // =====================================
                // REMOVE STOCK 0
                // =====================================

                equipmentList =
                equipmentList
                .Where(x => x.stock > 0)
                .ToList();

                // =====================================
                // DISTINCT EQUIPMENT NAMES
                // =====================================

                var distinctEquipments =
                equipmentList
                .Select(x => x.equipment_name)
                .Distinct()
                .ToList();

                // =====================================
                // LOAD COMBOBOX
                // =====================================

                cmbEquipment.DataSource = null;

                cmbEquipment.DataSource =
                distinctEquipments;

                // =====================================
                // NO AVAILABLE STOCK
                // =====================================

                if (distinctEquipments.Count == 0)
                {
                    MessageBox.Show(
                        "No available equipment."
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        // =========================================
        // COMPUTE TOTAL
        // =========================================

        private void ComputeTotal()
        {
            decimal total =
            selectedPrice *
            nudQty.Value;

            lblTotal.Text =
            "₱" +
            total.ToString("N2");
        }

        // =========================================
        // PURCHASE BUTTON
        // =========================================

        private async void btnPurchase_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                // =================================
                // CHECK LOGIN
                // =================================

                if (Session.customer_id <= 0)
                {
                    MessageBox.Show(
                        "Customer not logged in."
                    );

                    return;
                }

                // =================================
                // CHECK CATEGORY
                // =================================

                if (cmbCategory.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Select category."
                    );

                    return;
                }

                // =================================
                // SELECTED EQUIPMENT
                // =================================

                EquipmentModel equipment =
                (EquipmentModel)
                cmbCategory.SelectedItem;

                int qty =
                Convert.ToInt32(
                    nudQty.Value
                );

                decimal total =
                equipment.price * qty;

                // =================================
                // ORDER DATA
                // =================================

                var orderData = new
                {
                    customer_id =
                    Session.customer_id,

                    equipment_id =
                    equipment.id,

                    quantity =
                    qty,

                    payment_status =
                    "Pending"
                };

                string json =
                JsonConvert.SerializeObject(
                    orderData
                );

                StringContent content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                // =================================
                // API REQUEST
                // =================================

                HttpResponseMessage response =
                await client.PostAsync(
                    orderUrl,
                    content
                );

                string result =
                await response.Content
                .ReadAsStringAsync();

                // =================================
                // SUCCESS
                // =================================

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(
                        "Purchase Successful!"
                    );

                    purchase p =
                    new purchase();

                    p.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        result
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        // =========================================
        // EQUIPMENT CHANGED
        // =========================================

        private void cmbEquipment_SelectedIndexChanged_1(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbEquipment.SelectedItem == null)
                {
                    return;
                }

                // =================================
                // SELECTED EQUIPMENT NAME
                // =================================

                string selectedEquipment =
                cmbEquipment.SelectedItem
                .ToString();

                // =================================
                // FILTER CATEGORY
                // =================================

                var categories =
                equipmentList
                .Where(x =>
                    x.equipment_name ==
                    selectedEquipment
                )
                .ToList();

                // =================================
                // LOAD CATEGORY DROPDOWN
                // =================================

                cmbCategory.DataSource = null;

                cmbCategory.DataSource =
                categories;

                cmbCategory.DisplayMember =
                "category";

                cmbCategory.ValueMember =
                "id";

                // =================================
                // AUTO PRICE
                // =================================

                if (categories.Count > 0)
                {
                    selectedPrice =
                    categories[0].price;

                    lblPrice.Text =
                    "₱" +
                    selectedPrice.ToString("N2");

                    ComputeTotal();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message
                );
            }
        }

        private void nudQty_ValueChanged_1(
            object sender,
            EventArgs e)
        {
            ComputeTotal();
        }

        // =========================================
        // FORM LOAD
        // =========================================

        private async void items_Load_1(
            object sender,
            EventArgs e)
        {
            // =====================================
            // DISPLAY CUSTOMER
            // =====================================

            txtFullname.Text =
            Session.fullname;

            // =====================================
            // QUANTITY
            // =====================================

            nudQty.Minimum = 1;

            nudQty.Value = 1;

            // =====================================
            // LOAD EQUIPMENTS
            // =====================================

            await LoadEquipments();

            // =====================================
            // UPDATE TOTAL
            // =====================================

            ComputeTotal();
        }

        // =========================================
        // MODEL
        // =========================================

        public class EquipmentModel
        {
            public int id { get; set; }

            public string equipment_name { get; set; }

            public string category { get; set; }

            public decimal price { get; set; }

            public int stock { get; set; }
        }

        // =========================================
        // ORDER LIST
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
        // LOGOUT
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

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbCategory.SelectedItem != null)
                {
                    EquipmentModel equipment =
                    (EquipmentModel)
                    cmbCategory.SelectedItem;

                    // =============================
                    // UPDATE PRICE
                    // =============================

                    selectedPrice =
                    equipment.price;

                    lblPrice.Text =
                    "₱" +
                    selectedPrice.ToString("N2");

                    // =============================
                    // UPDATE TOTAL
                    // =============================

                    ComputeTotal();
                }
            }
            catch
            {

            }
        }
    }
}