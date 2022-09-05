namespace WindowsFormsApplication5
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 37);
            this.panel1.TabIndex = 101;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Black;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ImageActive")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(834, 5);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(26, 25);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 68;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 65;
            this.label1.Text = " Imprimer";
            // 
            // textbox3
            // 
            this.textbox3.BackColor = System.Drawing.Color.White;
            this.textbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox3.ForeColor = System.Drawing.Color.Black;
            this.textbox3.HintForeColor = System.Drawing.Color.Black;
            this.textbox3.HintText = "";
            this.textbox3.isPassword = false;
            this.textbox3.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textbox3.LineIdleColor = System.Drawing.SystemColors.ControlLight;
            this.textbox3.LineMouseHoverColor = System.Drawing.Color.White;
            this.textbox3.LineThickness = 3;
            this.textbox3.Location = new System.Drawing.Point(442, 43);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.textbox3.Name = "textbox3";
            this.textbox3.Size = new System.Drawing.Size(189, 30);
            this.textbox3.TabIndex = 131;
            this.textbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "Imprimer";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(670, 43);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.SteelBlue;
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(173)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(154, 31);
            this.bunifuFlatButton7.TabIndex = 130;
            this.bunifuFlatButton7.Text = "Imprimer";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton7.Click += new System.EventHandler(this.bunifuFlatButton7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(304, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 18);
            this.label4.TabIndex = 129;
            this.label4.Text = "Numéro_Chambre:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.HintForeColor = System.Drawing.Color.Black;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.LineIdleColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.White;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(82, 43);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 30);
            this.textBox1.TabIndex = 127;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(40, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 128;
            this.label2.Text = "Cin:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 80);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(868, 360);
            this.crystalReportViewer1.TabIndex = 126;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(868, 441);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.bunifuFlatButton7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Label label1;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox textbox3;
        internal Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private System.Windows.Forms.Label label4;
        internal Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}