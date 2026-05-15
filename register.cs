using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Ordering_System
{
    public partial class register : Form
    {
        internal static int customer_id;

        public register()
        {
            InitializeComponent();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtfullname.Text == "" ||
                txtAddress.Text == "" ||
                txtEmail.Text == "" ||
                txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Please fill all fields."
                );

                return;
            }

            try
            {
                // CORRECT API URL

                string apiUrl =
                "http://localhost:3000/api/customer/register";

                // DATA

                var data = new
                {
                    fullname = txtfullname.Text,
                    address = txtAddress.Text,
                    email = txtEmail.Text,
                    password = txtPassword.Text
                };

                // JSON

                string json =
                JsonConvert.SerializeObject(data);

                var content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response =
                    await client.PostAsync(
                        apiUrl,
                        content
                    );

                    string result =
                    await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(
                            "Registration Successful!"
                        );

                      
                    }
                    else
                    {
                        MessageBox.Show(
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
    }
}