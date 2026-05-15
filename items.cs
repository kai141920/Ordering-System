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
        // API URLS
        // =========================================

        string equipmentUrl =
        "http://localhost:3000/api/equipment";

        string orderUrl =
        "http://localhost:3000/api/order";

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
        // FORM LOAD
        // =========================================

        private async void items_Load(
            object sender,
            EventArgs e)
        {
            // =====================================
            // DISPLAY CUSTOMER NAME
            // =====================================

            txtFullname.Text =
            Session.fullname;

            // =====================================
            // QUANTITY DEFAULT
            // =====================================

            nudQty.Minimum = 1;

            nudQty.Value = 1;

            // =====================================
            // LOAD EQUIPMENT
            // =====================================

            await LoadEquipment();
        }

        // =========================================
        // LOAD EQUIPMENT
        // =========================================

        private async Task LoadEquipment()
        {
            try
            {
                using (HttpClient client =
                    new HttpClient())
                {
                    HttpResponseMessage response =
                    await client.GetAsync(
                        equipmentUrl
                    );

                    response.EnsureSuccessStatusCode();

                    string json =
                    await response.Content
                    .ReadAsStringAsync();

                    // DEBUG JSON

                    // MessageBox.Show(json);

                    equipmentList =
                    JsonConvert.DeserializeObject
                    <List<EquipmentModel>>(json);

                    // CLEAR FIRST

                    cmbEquipment.DataSource = null;

                    // SET DATASOURCE

                    cmbEquipment.DataSource =
                    equipmentList;

                    cmbEquipment.DisplayMember =
                    "equipment_name";

                    cmbEquipment.ValueMember =
                    "id";

                    // SELECT FIRST ITEM

                    if (cmbEquipment.Items.Count > 0)
                    {
                        cmbEquipment.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error loading equipment:\n\n" +
                    ex.Message
                );
            }
        }

        // =========================================
        // EQUIPMENT CHANGED
        // =========================================

        private void cmbEquipment_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            try
            {
                if (cmbEquipment.SelectedItem != null)
                {
                    EquipmentModel equipment =
                    (EquipmentModel)cmbEquipment.SelectedItem;

                    // =================================
                    // PRICE
                    // =================================

                    selectedPrice =
                    equipment.price;

                    lblPrice.Text =
                    "₱" +
                    selectedPrice.ToString("N2");

                    // =================================
                    // COMPUTE TOTAL
                    // =================================

                    ComputeTotal();
                }
            }
            catch
            {

            }
        }

        // =========================================
        // QUANTITY CHANGED
        // =========================================

        private void nudQty_ValueChanged(
            object sender,
            EventArgs e)
        {
            ComputeTotal();
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
                if (cmbEquipment.SelectedItem == null)
                {
                    MessageBox.Show(
                        "Please select equipment."
                    );

                    return;
                }

                EquipmentModel equipment =
                (EquipmentModel)cmbEquipment.SelectedItem;

                decimal total =
                selectedPrice *
                nudQty.Value;

                // =====================================
                // ORDER DATA
                // =====================================

                var orderData = new
                {
                    customer_id =
                    Session.customer_id,

                    equipment_id =
                    equipment.id,

                    quantity =
                    Convert.ToInt32(
                        nudQty.Value
                    ),

                    total_amount =
                    total,

                    payment_status =
                    "Pending"
                };

                string json =
                JsonConvert.SerializeObject(
                    orderData
                );

                var content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                using (HttpClient client =
                    new HttpClient())
                {
                    HttpResponseMessage response =
                    await client.PostAsync(
                        orderUrl,
                        content
                    );

                    string result =
                    await response.Content
                    .ReadAsStringAsync();

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
                            "Purchase Failed\n\n" +
                            result
                        );
                    }
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
        // LABEL CLICK
        // =========================================

        private void label1_Click(
            object sender,
            EventArgs e)
        {

        }
    }

    // =========================================
    // EQUIPMENT MODEL
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