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
    public partial class agregarPasajeros : Form
    {
        public agregarPasajeros()
        {
            InitializeComponent();
        }

        public void enviarmail()
        {
            //Enviando Mail De Bienvenida A Los usuarios
            bool error = false;
            var fromAddress = new MailAddress("expensiveindustryreal@gmail.com", "Patio");
            var toAddress = new MailAddress(CorreoElectro.Text, nombreBox.Text);
            const string fromPassword = "therealindustry12";
            string subject = "¡" + nombreBox.Text + " te damos la bienvenida a Patio Alto!";
            string body = "Te habla Mateo, espero que te la pases muy bien.\nTu ID de vuelo -->"+vuelosID.Text+"\nID personal -->"+pasajerosID_.Text;

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

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    error = true;
                }

            }

            if (!error)
            {
                agregar_pasajero();
            }
            else
            {
                MessageBox.Show("No se puedo Agregar El pasajero", "Puede ser el Correo");
            }

        }

        public void agregar_pasajero()
        {

            try //Usto si es util
            {

                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString; //Importamos la conexion hecha en el archivo

                SqlConnection conexion = new SqlConnection(cnn);

                conexion.Open(); //Se necesita abrir una conexion OTRA VEZ

                SqlCommand cmd = new SqlCommand("select pasajero_id from pasajeros where pasajero_id='" + pasajerosID_.Text + "'", conexion);

                SqlDataReader dr = cmd.ExecuteReader();
                if (pasajerosID_.Text == "" || vuelosID.Text == ""  || nombreBox.Text == "" || apellidoBox.Text == "" || edadComboBox.Text == "" || CorreoElectro.Text == "")
                {
                    MessageBox.Show("Empty Values Are Not Allowed", "Error");
                }
                else
                {

                    if (dr.Read())
                    {
                        MessageBox.Show("Esta ID ya existe.", "ID error");

                    }
                    else
                    {

                        dr.Close();
                        string vuelo_agregado;

                        if (normalButton.Checked)
                        {
                            vuelo_agregado = "INSERT INTO pasajeros VALUES(" + pasajerosID_.Text + ",'" + vuelosID.Text + "','NORMAL','" + nombreBox.Text + "','" + apellidoBox.Text + "'," + edadComboBox.Text + ",'" + CorreoElectro.Text + "')";
                            string actualizar_vuelo = "UPDATE vuelos SET puestos_disponibles-=1 WHERE vuelos_id='" + vuelosID.Text + "'";
                            SqlCommand cmd_3 = new SqlCommand(actualizar_vuelo, conexion);
                            cmd_3.ExecuteNonQuery();
                        }
                        else 
                        {
                            vuelo_agregado = "INSERT INTO pasajeros VALUES(" + pasajerosID_.Text + ",'X','NEUTRO','" + nombreBox.Text + "','" + apellidoBox.Text + "'," + edadComboBox.Text + ",'" + CorreoElectro.Text + "')";
                        }
                       
                        
                        SqlCommand cmd_2 = new SqlCommand(vuelo_agregado, conexion);
                        cmd_2.ExecuteNonQuery();

                        

                        MessageBox.Show("Pasajero Agregado");
                        conexion.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void data()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                string data_vuelos = "select *  from vuelos";

                SqlConnection conexion3 = new SqlConnection(cnn); //Conexion con el server
                conexion3.Open();
                SqlDataAdapter adaptor_vuelos = new SqlDataAdapter(data_vuelos, conexion3); //Adaptor to adapt the data to the table
                DataTable dt = new DataTable(); //Crear nueva tabla
                adaptor_vuelos.Fill(dt); //Llenar datos de la tabla
                dataGridPasajeros.DataSource = dt;
                conexion3.Close();


                //Mail?


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void agregarPasajeros_Load(object sender, EventArgs e)
        {

        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            data();
        }

        private void dataGridPasajeros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vuelosID.Text = dataGridPasajeros.SelectedCells[0].Value.ToString();
           
        }

        private void vuelosID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void agregarpasajero_button_Click(object sender, EventArgs e)
        {
            //Chekear si el vuelo ya esta lleno, si no esta entonces agregar el pasajero
            if(vuelosID.Text == "" || nombreBox.Text == "" || apellidoBox.Text == "" || edadComboBox.Text == "" || CorreoElectro.Text == "")
            {
                MessageBox.Show("Empty Values Are Not Allowed");
            }
            else if(dataGridPasajeros.SelectedCells[3].Value.ToString() == "0")
            {
                MessageBox.Show("El vuelo ya esta lleno", "Error");
            }
            else
            {
                try
                {
                    enviarmail();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                
                
                
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void estadoPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
