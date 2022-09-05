using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
          
   /* This is the width of the expanded panel */
   if(panel1.Width == 223)
   {
      panel1.Visible = false;
     /* Hide the logo */
    pictureBox1.Visible = false;
     panel1.Width = 48;
      bunifuTransition1.ShowSync(panel1);
   }
   else
   {
      panel1.Visible = false;
      panel1.Width = 223;
    /* Show the logo */
   pictureBox1.Visible = true;
      bunifuTransition1.ShowSync(panel1);
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void abriforminpanel(object formhijo)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();



        }


        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            abriforminpanel(new Form2());
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            abriforminpanel(new Form3());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            abriforminpanel(new Form4());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            abriforminpanel(new Form6());
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}