using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

                cmbEquipment.DataSource = null;

                cmbEquipment.DisplayMember =
                "equipment_name";

                cmbEquipment.ValueMember =
                "id";

                cmbEquipment.DataSource =
                equipmentList;

                if (cmbEquipment.Items.Count > 0)
                {
                    cmbEquipment.SelectedIndex = 0;
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
            if (cmbEquipment.SelectedItem == null)
            {
                lblTotal.Text = "₱0.00";
                return;
            }

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
                // CHECK EQUIPMENT
                // =================================
                if (Session.customer_id <= 0)
                {
                    MessageBox.Show(
                        "Customer not logged in."
                    );

                    return;
                }

                if (cmbEquipment.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Select equipment"
                    );

                    return;
                }

                EquipmentModel equipment =
                (EquipmentModel)
                cmbEquipment.SelectedItem;

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

        private void cmbEquipment_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbEquipment.SelectedItem != null)
                {
                    EquipmentModel equipment =
                    (EquipmentModel)
                    cmbEquipment.SelectedItem;

                    // =============================
                    // PRICE
                    // =============================

                    selectedPrice =
                    equipment.price;

                    lblPrice.Text =
                    "₱" +
                    selectedPrice.ToString("N2");

                    // =============================
                    // TOTAL
                    // =============================

                    ComputeTotal();
                }
            }
            catch
            {

            }
        }

        private void nudQty_ValueChanged_1(object sender, EventArgs e)
        {
            ComputeTotal();
        }

        private async void items_Load_1(object sender, EventArgs e)
        {
            // DISPLAY CUSTOMER

            txtFullname.Text =
            Session.fullname;

            // QUANTITY

            nudQty.Minimum = 1;
            nudQty.Value = 1;

            // LOAD EQUIPMENTS

            await LoadEquipments();

            // UPDATE TOTAL

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
    }
}