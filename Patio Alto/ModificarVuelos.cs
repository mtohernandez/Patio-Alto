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
    public partial class ModificarVuelos : Form
    {
        public ModificarVuelos()
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

        public void modificar()
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString; //This probably shouldnt be here
            

            SqlConnection conexion3 = new SqlConnection(cnn);
            conexion3.Open();
            string comand = "UPDATE vuelos SET destino_vuelo='" + destino_box.Text + "',estado_del_vuelo='" + estado_vuelo.Text + "',hora_de_salida='" + hora_salida.Text + "' WHERE vuelos_id='" + vuelo_id.Text + "'";
            SqlCommand cmd_u = new SqlCommand(comand, conexion3);
            cmd_u.ExecuteNonQuery();


            if(estado_vuelo.Text == "NO DISPONIBLE")
            {
                comand = "UPDATE pasajeros SET estado_pasajero = 'PENDIENTE' WHERE vuelo_id = '" + vuelo_id.Text + "'";
                SqlCommand cmd_d = new SqlCommand(comand, conexion3);
                cmd_d.ExecuteNonQuery();
            }
            else
            {
                comand = "UPDATE pasajeros SET estado_pasajero = 'NORMAL' WHERE vuelo_id = '" + vuelo_id.Text + "'";
                SqlCommand cmd_d2 = new SqlCommand(comand, conexion3);
                cmd_d2.ExecuteNonQuery();
            }
  
            conexion3.Close();
        }

        private void ModificarVuelos_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (vuelo_id.Text == "" || destino_box.Text == "" || origen_box.Text == "" || puestos_disponibles.Text == "" || hora_salida.Text == "" || estado_vuelo.Text == "")
                {
                    MessageBox.Show("Empty Values Are Not Allowed", "Error");
                }
                else
                {
                    modificar();
                    MessageBox.Show("Modificado Con Exito");
                }
                    
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cancelarButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }
    }
}
