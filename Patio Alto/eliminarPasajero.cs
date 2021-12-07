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
    public partial class eliminarPasajero : Form
    {
        public eliminarPasajero()
        {
            InitializeComponent();
        }

        public void enviarmail()
        {
            //Enviando Mail De Bienvenida A Los usuarios
            var fromAddress = new MailAddress("expensiveindustryreal@gmail.com", "Patio");
            var toAddress = new MailAddress(CorreoElectro.Text, nombreBox.Text);
            const string fromPassword = "therealindustry12";
            string subject = "¡Muchas gracias por visitarnos!";
            string body = "Fue un gusto atenderte.";

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
                }catch(Exception ex)
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

        public void eliminar()
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            SqlConnection conexion3 = new SqlConnection(cnn);
            conexion3.Open();
            string comand_borrar = "DELETE from pasajeros WHERE pasajero_id='" + pasajerosID_.Text + "'"; //This deletion is just a slide
            SqlCommand borrar = new SqlCommand(comand_borrar, conexion3);//Terminar este metodo
            borrar.ExecuteNonQuery(); //FIXED

            string comand_b = "UPDATE vuelos SET puestos_disponibles+=1 WHERE vuelos_id='" + vuelosID.Text + "'"; //hope this works
            SqlCommand act = new SqlCommand(comand_b, conexion3);
            act.ExecuteNonQuery(); //Actualizar cada vuelo

        }


        private void eliminarPasajero_Load(object sender, EventArgs e)
        {

        }

        private void dataGridPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pasajerosID_.Text = dataGridPasajeros.SelectedCells[0].Value.ToString();
            vuelosID.Text = dataGridPasajeros.SelectedCells[1].Value.ToString();
            estadoPasajero.Text = dataGridPasajeros.SelectedCells[2].Value.ToString();
            nombreBox.Text = dataGridPasajeros.SelectedCells[3].Value.ToString();
            apellidoBox.Text = dataGridPasajeros.SelectedCells[4].Value.ToString();
            edadBox.Text = dataGridPasajeros.SelectedCells[5].Value.ToString();
            CorreoElectro.Text = dataGridPasajeros.SelectedCells[6].Value.ToString();
        }

        private void eliminarPasajero_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasajerosID_.Text == "" || vuelosID.Text == "" || estadoPasajero.Text == "" || nombreBox.Text == "" || apellidoBox.Text == "" || edadBox.Text == "" || CorreoElectro.Text == "")
                {
                    MessageBox.Show("Empty Values Are Not Allowed", "Error");
                }
                else
                {
                    eliminar();
                    enviarmail();
                    MessageBox.Show("Eliminacion Exitosa");
                    pasajerosID_.Text = ""; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
