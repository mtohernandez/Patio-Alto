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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

     

        public void registro_form()
        {
            try
            {

                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString; //Importamos la conexion hecha en el archivo

                using (SqlConnection conexion2 = new SqlConnection(cnn))
                {
                    conexion2.Open(); //Not sure if i need this (i do)

                    SqlCommand cmd_s = new SqlCommand("select username from usuarios where username='" + username_register.Text + "'", conexion2);
                    SqlDataReader dr = cmd_s.ExecuteReader(); //Read the data 

                    if (username_register.Text == "" || password_register.Text == "" || edad_register.Text =="" || correo_register.Text == "")
                    {
                        MessageBox.Show("Empty Values Are Not Allowed.", "Error"); //Show that empty values are not allowed
                    }
                    else
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Username ya esta registrado.", "Error"); //Checked if username already exist
                        }
                        else
                        {
                            dr.Close();
                            string registro = "INSERT INTO usuarios VALUES('" + username_register.Text + "','" + password_register.Text + "'," + edad_register.Text + ",'" + correo_register.Text + "')";
                            SqlCommand cmd_r = new SqlCommand(registro, conexion2);
                            cmd_r.ExecuteNonQuery();
                            MessageBox.Show("Registro Exitoso.");
                            this.Hide();
                            new Form1().Show();

                            conexion2.Close();
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void resgistrarse_button_Click(object sender, EventArgs e)
        {
            registro_form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
