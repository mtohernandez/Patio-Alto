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

namespace HighGarden
{
    public partial class modificarPasajero : Form
    {
        public modificarPasajero()
        {
            InitializeComponent();
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

        public void modificar()
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString; //This probably shouldnt be here

            
            SqlConnection conexion3 = new SqlConnection(cnn);
            conexion3.Open();
            string comand;      
            comand = "UPDATE pasajeros SET vuelo_id='" + vuelosID.Text + "',nombre_pasajero='" + nombreBox.Text + "',apellido_pasajero='" + apellidoBox.Text + "', edad_pasajero=" + edadBox.Text + ", correo_electronico_pasajero='" + CorreoElectro.Text + "' WHERE pasajero_id='" + pasajerosID_.Text + "'";
            SqlCommand cmd_u = new SqlCommand(comand, conexion3);
            cmd_u.ExecuteNonQuery();
        }

        private void modificarPasajero_Load(object sender, EventArgs e)
        {

        }

        private void modificarPasajero_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (pasajerosID_.Text == "" || vuelosID.Text == "" || estadoPasajero.Text == "" || nombreBox.Text == "" || apellidoBox.Text == "" || edadBox.Text == "" || CorreoElectro.Text == "")
                {
                    MessageBox.Show("Empty Values Are Not Allowed", "Error");
                }else if(vuelosID.Text != dataGridPasajeros.SelectedCells[1].Value.ToString() && estadoPasajero.Text == "NORMAL")
                {
                    MessageBox.Show("No Puede Modificar El Vuelo ID", "Estado Pasajero Normal");
                }
                else
                {
                    modificar();
                    MessageBox.Show("Modificado Con Exito");
                    pasajerosID_.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            data();
        }

        private void estadoPasajero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
