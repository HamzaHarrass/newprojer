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
    public partial class Form2 : Form
    {
        public Form2()
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
        private void afficher()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from client", cn);
            da.Fill(ds, "client");

            //dataGridView1.DataSource = ds.Tables["client"];

            bs.DataSource = ds.Tables["client"];
            dataGridView1.DataSource = bs;


            DataColumn[] t = new DataColumn[1];
            t[0] = ds.Tables["client"].Columns["cin"];
            ds.Tables["client"].PrimaryKey = t;

            Textbox6.Text = ds.Tables["client"].Rows.Count.ToString();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            afficher();
        }

        private void gg(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(" Merci de remplir les champs");
                return;
            }
            DataRow ligne;
            ligne = ds.Tables["client"].NewRow();
            ligne["Cin"] = textBox1.Text;
            ligne["Nom"] = textBox2.Text;
            ligne["Prenom"] = textBox3.Text;
            ligne["Tele"] = textBox4.Text;
            for (int i = 0; i < ds.Tables["client"].Rows.Count; i++)
            {
                if (textBox1.Text== ds.Tables["client"].Rows[i][0].ToString())
                {
                    MessageBox.Show("client existe déja");
                    return;
                }
            }
            ds.Tables["client"].Rows.Add(ligne);
            MessageBox.Show("client ajouter avec succes");
            dataGridView1.DataSource = ds.Tables["client"];
            Enregistrer();
           
        }



        public void NAVIGATION()
        {

            textBox1.Text = ds.Tables["client"].Rows[cpt][0].ToString();
            textBox2.Text = ds.Tables["client"].Rows[cpt][1].ToString();
            textBox3.Text = ds.Tables["client"].Rows[cpt][2].ToString();
            textBox4.Text = ds.Tables["client"].Rows[cpt][3].ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i < ds.Tables["client"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["client"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["client"].Rows[i][1] = textBox2.Text;
                    ds.Tables["client"].Rows[i][2] = textBox3.Text;
                    ds.Tables["client"].Rows[i][3] = textBox4.Text;
                    MessageBox.Show("client modifier ");
                      dataGridView1.DataSource = ds.Tables["client"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("client n'existe pas");
            }

            Enregistrer();
            afficher();

         
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            bool tr = false;
            for (int i = 0; i < ds.Tables["client"].Rows.Count; i++)
            {
                if (textBox1.Text == ds.Tables["client"].Rows[i][0].ToString())
                {
                    tr = true;
                    ds.Tables["client"].Rows[i].Delete();
                    MessageBox.Show("client supprimer ");
                    dataGridView1.DataSource = ds.Tables["client"];
                    break;
                }
            }
            if (tr == false)
            {
                MessageBox.Show("client n'existe pas");
            }

            Enregistrer();
            afficher();


       
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

            if(radioButton1.Checked==true)
            {
                SqlDataAdapter dd = new SqlDataAdapter("select * from client where cin = '"+textBox1.Text+"'",cn);
                DataTable dt = new DataTable();
                dd.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            if (radioButton2.Checked == true)
            {
                SqlDataAdapter dd = new SqlDataAdapter("select * from client where nom = '" + textBox2.Text + "'", cn);
                DataTable dt = new DataTable();
                dd.Fill(dt);
                dataGridView1.DataSource = dt;

            }

            if (radioButton3.Checked == true)
            {
                SqlDataAdapter dd = new SqlDataAdapter("select * from client where prenom = '" + textBox3.Text + "'", cn);
                DataTable dt = new DataTable();
                dd.Fill(dt);
                dataGridView1.DataSource = dt;

            }


            if (radioButton4.Checked == true)
            {
                SqlDataAdapter dd = new SqlDataAdapter("select * from client where tele = '" + textBox4.Text + "'", cn);
                DataTable dt = new DataTable();
                dd.Fill(dt);
                dataGridView1.DataSource = dt;

            }




            //dr = ds.Tables["client"].Rows.Find(textBox1.Text);
            //if (dr != null)
            //{

            //    textBox1.Text = dr[0].ToString();
            //    textBox2.Text = dr[1].ToString();
            //    textBox3.Text = dr[2].ToString();
            //    textBox4.Text = dr[3].ToString();


            //}
            //else
            //{
            //    MessageBox.Show("ne existe pas");
            //}
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = "";
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
            cpt = ds.Tables["client"].Rows.Count - 1;
            NAVIGATION();

        }


        private void Enregistrer()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Client", cn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Client");
            afficher();
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            Enregistrer();

           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            afficher();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
