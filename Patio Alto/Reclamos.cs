using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;


namespace HighGarden
{
    public partial class Reclamos : Form
    {
        public Reclamos()
        {
            InitializeComponent();
        }

        public void enviarmail()
        {
            var fromAddress = new MailAddress("expensiveindustryreal@gmail.com", "Patio");
            var toAddress = new MailAddress("expensiveindustryreal@gmail.com", "Patio");
            const string fromPassword = "therealindustry12";
            string subject = "ALERTA DE RECLAMO";
            string body = reclamoTotal.Text;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            };
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body
            })
            {
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Mensaje enviado");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        public void data()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                string data_vuelos = "select *  from pasajeros";

                SqlConnection conexion3 = new SqlConnection(cnn); //Conexion con el server
                conexion3.Open();
                SqlDataAdapter adaptor_vuelos = new SqlDataAdapter(data_vuelos, conexion3); //Adaptor to adapt the data to the table
                DataTable dt = new DataTable(); //Crear nueva tabla
                adaptor_vuelos.Fill(dt); //Llenar datos de la tabla
                dataGridPasajeros.DataSource = dt;
                conexion3.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nombreBox.Text = dataGridPasajeros.SelectedCells[3].Value.ToString();
            CorreoElectro.Text = dataGridPasajeros.SelectedCells[6].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enviarmail();
            reclamoTotal.Text = "";

        }

        private void x_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
