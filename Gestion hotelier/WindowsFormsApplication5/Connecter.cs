using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static SqlConnection con = new SqlConnection("Data Source=ABOU;Initial Catalog=réservation_hotel;Integrated Security=True");
         public static int i;

        private void button1_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            SqlCommand com = con.CreateCommand();
            com.CommandType = CommandType.Text;
            com.CommandText = "Select * From utilisateur Where Nom_Utilisateur='" + textBox1.Text + "' and Mot_de_passe ='" + textBox2.Text + "' ";
            com.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());


            if (i == 0)
            {
                label1.Text = ("Désole, utilisateur Incorrecte!");
                panel2.BackColor = Color.Red;
            }

            else
            {

                this.Hide();
                Form1 ss = new Form1();
                ss.Show();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
