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
    public partial class Form4 : Form
    {
        public Form4()
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
            if (textBox1.Text == "" || comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            DataRow ligne;
            ligne = ds.Tables["Chambre"].NewRow();
            ligne["Numéro_Ch"] = textBox1.Text;
            ligne["Id_Res"] = comboBox1.Text;
            ligne["Type_ch"] = textBox2.Text;
            ligne["catégorie_ch"] = textBox3.Text;
            ligne["prix_ch"] = textBox4.Text;
            for (int i = 0; i < ds.Tables["Chambre"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Chambre"].Rows[i][0].ToString())
                {
                    MessageBox.Show("Chambre existe déja");
                    return;
                }
            }
            ds.Tables["Chambre"].Rows.Add(ligne);
            MessageBox.Show("Chambre ajouter avec succes");
            dataGridView1.DataSource = ds.Tables["Chambre"];

            afficher();
            Enregistrer();
        }

        private void afficher()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Chambre", cn);
            da.Fill(ds, "Chambre");

            //dataGridView1.DataSource = ds.Tables["client"];

            bs.DataSource = ds.Tables["Chambre"];
            dataGridView1.DataSource = bs;


            DataColumn[] t = new DataColumn[1];
            t[0] = ds.Tables["Chambre"].Columns["Numéro_Ch"];
            ds.Tables["Chambre"].PrimaryKey = t;

            Textbox6.Text = ds.Tables["Chambre"].Rows.Count.ToString();
        }

        private void Enregistrer()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Chambre", cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Chambre");
            afficher();
        }
        public void NAVIGATION()
        {

            textBox1.Text = ds.Tables["Chambre"].Rows[cpt][0].ToString();
            comboBox1.Text = ds.Tables["Chambre"].Rows[cpt][1].ToString();
            textBox2.Text = ds.Tables["Chambre"].Rows[cpt][2].ToString();
            textBox3.Text = ds.Tables["Chambre"].Rows[cpt][3].ToString();
            textBox4.Text = ds.Tables["Chambre"].Rows[cpt][4].ToString();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

            string req = " select Id_Res from Reservation";
            da = new SqlDataAdapter(req, cn);
            da.Fill(ds, "Reservation");
            comboBox1.DisplayMember = "Id_Res";
            comboBox1.ValueMember = "Id_Res";
            comboBox1.DataSource = ds.Tables["Reservation"];



            afficher();



        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Enregistrer();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i < ds.Tables["Chambre"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Chambre"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["Chambre"].Rows[i][1] = comboBox1.Text;
                    ds.Tables["Chambre"].Rows[i][2] = textBox2.Text;
                    ds.Tables["Chambre"].Rows[i][3] = textBox3.Text;
                    ds.Tables["Chambre"].Rows[i][4] = textBox4.Text;
                    MessageBox.Show("Chambre modifier ");
                    dataGridView1.DataSource = ds.Tables["Chambre"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("Chambre n'existe pas");
            }

            Enregistrer();
            afficher();



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i < ds.Tables["Chambre"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["Chambre"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["Chambre"].Rows[i].Delete();
                    MessageBox.Show("Chambre supprimer ");
                    dataGridView1.DataSource = ds.Tables["Chambre"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("Chambre n'existe pas");
            }

            Enregistrer();
            afficher();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            dr = ds.Tables["Chambre"].Rows.Find(textBox1.Text);
            if (dr != null)
            {
                textBox1.Text = dr[0].ToString();
                comboBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[3].ToString();
                textBox4.Text = dr[4].ToString();

            }
            else
            {
                MessageBox.Show("ne existe pas");
            }
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

            cpt = ds.Tables["Chambre"].Rows.Count - 1;
            NAVIGATION();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; comboBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
