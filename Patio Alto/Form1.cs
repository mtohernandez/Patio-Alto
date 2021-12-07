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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    
        public void signIn()
        {
            try
            {

                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString; //Importamos la conexion hecha en el archivo
             
                using(SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    if (textBox_username.Text == "" && textBox_password.Text == "") {
                        MessageBox.Show("Empty Values, not able to log in.");
                    } 
                    else
                    {
                        using (SqlCommand cmd = new SqlCommand("select username, password_ from usuarios where username='" + textBox_username.Text + "'AND password_='" + textBox_password.Text + "'", conexion))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {
                                //Goes to dashBoard
                                //MessageBox.Show("Login Exitoso");
                                conexion.Close();
                                this.Hide();
                                new DashBoard().Show();
                            }
                            else
                            {
                                MessageBox.Show("Usuario No Encontrado");
                            }
                        }
                    }
                    
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            signIn();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Show Registration form
            new Registration().Show();
        }
    }
}
