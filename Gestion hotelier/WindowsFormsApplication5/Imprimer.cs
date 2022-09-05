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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public static SqlConnection cn = new SqlConnection("Data Source=ABOU;Initial Catalog=réservation_hotel;Integrated Security=True");
        private void Button1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            SqlDataAdapter aa = new SqlDataAdapter("select * from client where cin='" + textBox1.Text + "'", cn);
            SqlDataAdapter bb = new SqlDataAdapter("select * from reservation", cn);
            SqlDataAdapter ss = new SqlDataAdapter("select * from chambre where Numéro_Ch ='" + textbox3.Text + "' ", cn);



            CrystalReport1 cr = new CrystalReport1();
            DataSet1 ds = new DataSet1();
            aa.Fill(ds, "client");
            bb.Fill(ds, "reservation");
            ss.Fill(ds, "Chambre");

            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
