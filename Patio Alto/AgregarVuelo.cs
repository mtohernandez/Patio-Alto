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
    public partial class AgregarVuelo : Form
    {
        public AgregarVuelo()
        {
            InitializeComponent();
        }

        public void agregar_vuelo()
        {

            try //Usto si es util
            {

                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString; //Importamos la conexion hecha en el archivo

                SqlConnection conexion = new SqlConnection(cnn);

                conexion.Open(); //Se necesita abrir una conexion OTRA VEZ

                SqlCommand cmd = new SqlCommand("select vuelos_id from vuelos where vuelos_id='" + vuelo_id.Text + "'", conexion);
                  
                SqlDataReader dr = cmd.ExecuteReader();
                if (vuelo_id.Text == "" || destino_box.Text == "" || origen_box.Text == "" || puestos_disponibles.Text == "" || hora_salida.Text == "" || estado_vuelo.Text == "")
                {
                    MessageBox.Show("Empty Values Are Not Allowed", "Error");
                }
                else {

                    if (dr.Read())
                    {
                        MessageBox.Show("Esta ID ya existe.", "ID error");

                    }
                    else
                    {

                        dr.Close();

                        string vuelo_agregado = "INSERT INTO vuelos VALUES('" + vuelo_id.Text + "','" + destino_box.Text + "','" + origen_box.Text + "',"+puestos_disponibles.Text+",'" + hora_salida.Text + "','" + estado_vuelo.Text + "',"+puestos_disponibles.Text + ")";
                        SqlCommand cmd_2 = new SqlCommand(vuelo_agregado, conexion);
                        cmd_2.ExecuteNonQuery();
                        MessageBox.Show("Vuelo Agregado");
                        conexion.Close();
                    }
                }           

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void modificar_vuelo_Click(object sender, EventArgs e) //Realmente es agregar vuelo
        {
            agregar_vuelo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cancelarmodificar_vuelo_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
