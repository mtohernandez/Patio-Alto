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
 

/*
 * This file is the main menu of the program, 
 * 
 * Encountered error are:
 * dr.Read --> Should be closed
 * Syntax errors --> solved
 * data view --> WORKING on it
 * 
 * Comments:
 * Still need to develop the last 3 buttons
 * Make a reservation
 * Delete reservation
 * Add, delete, modify passengers
 * 
  */


namespace HighGarden
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        public void datagrid(bool vuelos)
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                string data_vuelos = "select *  from vuelos";

                SqlConnection conexion3 = new SqlConnection(cnn); //Conexion con el server

                if (vuelos)
                {
                    SqlDataAdapter adaptor_vuelos = new SqlDataAdapter(data_vuelos, conexion3); //Adaptor to adapt the data to the table
                    DataTable dt = new DataTable(); //Crear nueva tabla
                    adaptor_vuelos.Fill(dt); //Llenar datos de la tabla
                    dataGrid_vuelos.DataSource = dt;
                }
                else
                {
                    string data_pasajeros = "select *  from pasajeros";
                    SqlDataAdapter adaptor_pasajeros = new SqlDataAdapter(data_pasajeros, conexion3); //Adaptor to adapt the data to the table
                    DataTable dt2 = new DataTable(); //Crear nueva tabla
                    adaptor_pasajeros.Fill(dt2); //Llenar datos de la tabla
                    dataGrid_pasajeros.DataSource = dt2;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            
        }

        private void actualizar_vuelos_Click(object sender, EventArgs e)
        {
            //Se actualiza los vuelos y pasajeros (por ahora)
            datagrid(true);
        }

        private void actualizar_pasajeros_Click(object sender, EventArgs e)
        {
            datagrid(false);
        }

        private void modificar_vuelos_Click(object sender, EventArgs e)
        {
            new ModificarVuelos().Show();
        }

        private void agregar_vuelos_Click(object sender, EventArgs e)
        {
            
            new AgregarVuelo().Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eliminar_vuelos_Click(object sender, EventArgs e)
        {
            new eliminarVuelo().Show();
        }

        private void agregar_pasajero_Click(object sender, EventArgs e)
        {
            new agregarPasajeros().Show();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            Clocklbl.Text = DateTime.Now.ToString("HH:mm:ss tt"); //24 hour format 
        }

        private void modificar_pasajero_Click(object sender, EventArgs e)
        {
            new modificarPasajero().Show();
        }

        private void eliminar_pasajero_Click(object sender, EventArgs e)
        {
            new eliminarPasajero().Show();
        }

        private void procesarreclamo_button_Click(object sender, EventArgs e)
        {
            new Reclamos().Show();
        }
    }
}
