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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static SqlConnection cn = new SqlConnection("Data Source=ABOU;Initial Catalog=réservation_hotel;Integrated Security=True");
        public static SqlDataAdapter da;
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();
        public static DataRow dr;
        public static SqlCommandBuilder cb;
         public static BindingSource bs = new BindingSource();
        public static SqlCommand cmd;
        public static int cpt;

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || comboBox1.Text == "" || textBox3.Text == "" || dateTimePicker1.Text == "" || dateTimePicker2.Text == "" || dateTimePicker3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            dr = ds.Tables["Reservation"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = comboBox1.Text;
            dr[2] = textBox3.Text;
            dr[3] = dateTimePicker1.Value;
            dr[4] = dateTimePicker2.Value;
            dr[5] = dateTimePicker3.Value;
            dr[6] = textBox4.Text;

            for (int i = 0; i < ds.Tables["Reservation"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Reservation"].Rows[i][0].ToString())
                {
                    MessageBox.Show("Reservation existe déja");
                    return;
                }
            }
            ds.Tables["Reservation"].Rows.Add(dr);
            MessageBox.Show("Reservation ajouter avec succes");
            dataGridView1.DataSource = ds.Tables["Reservation"];
            afficher();
  
        }
        private void afficher ()
        {

            SqlDataAdapter da = new SqlDataAdapter("select * from Reservation", cn);
            da.Fill(ds, "Reservation");


            bs.DataSource = ds.Tables["Reservation"];
            dataGridView1.DataSource = bs;


            DataColumn[] t = new DataColumn[1];
            t[0] = ds.Tables["Reservation"].Columns["Id_Res"];
            ds.Tables["Reservation"].PrimaryKey = t;


            Textbox6.Text = ds.Tables["Reservation"].Rows.Count.ToString();


        }
        public void NAVIGATION()
        {

            textBox1.Text = ds.Tables["Reservation"].Rows[cpt][0].ToString();
            comboBox1.Text = ds.Tables["Reservation"].Rows[cpt][1].ToString();
            textBox3.Text = ds.Tables["Reservation"].Rows[cpt][2].ToString();
            this.dateTimePicker1.Value = Convert.ToDateTime(ds.Tables["Reservation"].Rows[cpt][3].ToString());
            this.dateTimePicker2.Value = Convert.ToDateTime(ds.Tables["Reservation"].Rows[cpt][4].ToString());
            this.dateTimePicker3.Value = Convert.ToDateTime(ds.Tables["Reservation"].Rows[cpt][5].ToString());
            textBox4.Text = ds.Tables["Reservation"].Rows[cpt][6].ToString();

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            string req = " select Cin from Client";
            da = new SqlDataAdapter(req, cn);
            da.Fill(ds, "Client");
            comboBox1.DisplayMember = "cin";
            comboBox1.ValueMember = "cin";
            comboBox1.DataSource = ds.Tables["client"];

            afficher();

            


        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            cpt = 0;
            NAVIGATION();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {

            try
            {
                cpt++;
                NAVIGATION();
            }
            catch
            {
                MessageBox.Show("vous etes sur le dernier enregistrement");
                cpt--;

            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {

            try
            {
                cpt--;
                NAVIGATION();
            }
            catch
            {
                MessageBox.Show("vous etes sur le premier enregistrement");
                cpt++;

            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

            cpt = ds.Tables["Reservation"].Rows.Count - 1;
            NAVIGATION();
        }
        private void Enregistrer()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Reservation", cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Reservation");
          
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            bool tr = false;
            for (int i = 0; i < ds.Tables["Reservation"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Reservation"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["Reservation"].Rows[i][1] = comboBox1.Text; ;
                    ds.Tables["Reservation"].Rows[i][2] = textBox3.Text;
                    ds.Tables["Reservation"].Rows[i][3] = dateTimePicker1.Value;
                    ds.Tables["Reservation"].Rows[i][4] = dateTimePicker2.Value;
                    ds.Tables["Reservation"].Rows[i][5] = dateTimePicker3.Value;
                    ds.Tables["Reservation"].Rows[i][6] = textBox4.Text; ;
                    MessageBox.Show("Reservation modifier ");
                    dataGridView1.DataSource = ds.Tables["Reservation"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("Reservation n'existe pas");
            }

            Enregistrer();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            bool tr = false;
            for (int i = 0; i < ds.Tables["Reservation"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Reservation"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["Reservation"].Rows[i].Delete();
                    MessageBox.Show("Reservation supprimer ");
                    dataGridView1.DataSource = ds.Tables["Reservation"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("Reservation n'existe pas");
            }

            Enregistrer();
            afficher();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Reservation"].Rows.Find(textBox1.Text);
            if (dr != null)
            {

                textBox1.Text = dr[0].ToString();
                comboBox1.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dr[3].ToString());
                dateTimePicker2.Value = Convert.ToDateTime(dr[4].ToString());
                dateTimePicker3.Value = Convert.ToDateTime(dr[5].ToString());
                textBox4.Text = dr[6].ToString();

            }
            else
            {
                MessageBox.Show("ne existe pas");
            }

        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; comboBox1.Text = ""; textBox3.Text = ""; dateTimePicker1.Text = ""; dateTimePicker2.Text = ""; dateTimePicker3.Text = ""; textBox4.Text = "";

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
