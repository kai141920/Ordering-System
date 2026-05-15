using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordering_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // =========================================
        // REGISTER LINK
        // =========================================

        private void LinkRegister_LinkClicked(
            object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            register register =
            new register();

            register.Show();

            this.Hide();
        }

        // =========================================
        // LOGIN BUTTON
        // =========================================

        private async void btnLogin_Click(
            object sender,
            EventArgs e)
        {
            // =====================================
            // VALIDATION
            // =====================================

            if (txtUsername.Text == "" ||
                txtPassword.Text == "")
            {
                MessageBox.Show(
                    "Please enter email and password."
                );

                return;
            }

            try
            {
                // =================================
                // API URL
                // =================================

                string apiUrl =
                "http://localhost:3000/api/customer/login";

                // =================================
                // LOGIN DATA
                // =================================

                var loginData = new
                {
                    email =
                    txtUsername.Text,

                    password =
                    txtPassword.Text
                };

                // =================================
                // JSON
                // =================================

                string json =
                JsonConvert.SerializeObject(
                    loginData
                );

                StringContent content =
                new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                using (HttpClient client =
                    new HttpClient())
                {
                    // =============================
                    // SEND REQUEST
                    // =============================

                    HttpResponseMessage response =
                    await client.PostAsync(
                        apiUrl,
                        content
                    );

                    string result =
                    await response.Content
                    .ReadAsStringAsync();

                    // =============================
                    // SUCCESS
                    // =============================

                    if (response.IsSuccessStatusCode)
                    {
                        // =========================
                        // DESERIALIZE
                        // =========================

                        dynamic data =
                        JsonConvert.DeserializeObject(result);

                        Session.customer_id =
                        data.customer.customer_id;

                        Session.fullname =
                        data.customer.fullname;

                        // =========================
                        // DEBUG
                        // =========================

                        MessageBox.Show(
                            "Welcome " +
                            Session.fullname
                        );

                        // =========================
                        // OPEN PURCHASE
                        // =========================

                        purchase dash =
                        new purchase();

                        dash.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Login Failed\n\n" +
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

    // =========================================
    // LOGIN RESPONSE MODEL
    // =========================================

    public class LoginResponse
    {
        public int customer_id { get; set; }

        public string fullname { get; set; }

        public string email { get; set; }
    }
}