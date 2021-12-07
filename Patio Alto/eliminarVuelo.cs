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
    public partial class eliminarVuelo : Form
    {
        public eliminarVuelo()
        {
            InitializeComponent();
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
                dataGridVuelos.DataSource = dt;
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
            string comand_borrar = "DELETE from vuelos WHERE vuelos_id='" + vuelo_id.Text + "'"; //This deletion is just a slide
            SqlCommand borrar = new SqlCommand(comand_borrar, conexion3);//Terminar este metodo
            borrar.ExecuteNonQuery(); //FIXED
            
            //checkear cada persiona y pasar estado a VUELO PERDIDO
            /*
             * Estados de un pasajero: (todos deben tener un vuelo asignado)
             * NORMAL = Se encuentra en el aeropuerto y esta a la espera del vuelo
             * VPERDIDO = El vuelo fue cancelado o ya no estara disponible
             * PENDIENTE = El vuelo esta pero no esta disponible
             * 
             */
            string comand_b = "UPDATE pasajeros SET estado_pasajero= 'VPERDIDO' WHERE vuelo_id='"+vuelo_id.Text+"'"; //hope this works
            SqlCommand act = new SqlCommand(comand_b, conexion3);
            act.ExecuteNonQuery(); //Actualizar cada pasajero

        }

        private void eliminarVuelo_Load(object sender, EventArgs e)
        {

        }

        private void dataGridVuelos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vuelo_id.Text = dataGridVuelos.SelectedCells[0].Value.ToString();
            destino_box.Text = dataGridVuelos.SelectedCells[1].Value.ToString();
            origen_box.Text = dataGridVuelos.SelectedCells[2].Value.ToString();
            puestos_disponibles.Text = dataGridVuelos.SelectedCells[3].Value.ToString();
            hora_salida.Text = dataGridVuelos.SelectedCells[4].Value.ToString();
            estado_vuelo.Text = dataGridVuelos.SelectedCells[5].Value.ToString();
            maxcapacidad.Text = dataGridVuelos.SelectedCells[6].Value.ToString();
        }

        private void buscarButton_Click(object sender, EventArgs e)
        {
            data();
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (vuelo_id.Text == "" || destino_box.Text == "" || origen_box.Text == "" || puestos_disponibles.Text == "" || hora_salida.Text == "" || estado_vuelo.Text == "")
                {
                    MessageBox.Show("Empty Values Are Not Allowed", "Error");
                }
                else
                {
                    eliminar();
                    MessageBox.Show("Eliminacion Exitosa");
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
