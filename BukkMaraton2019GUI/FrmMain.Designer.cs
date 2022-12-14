namespace BukkMaraton2019GUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUI01 = new System.Windows.Forms.Label();
            this.cb = new System.Windows.Forms.ComboBox();
            this.lblUI02 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.lblUI03 = new System.Windows.Forms.Label();
            this.lblUI04 = new System.Windows.Forms.Label();
            this.lblAVGkmph = new System.Windows.Forms.Label();
            this.lblAVGmps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUI01
            // 
            this.lblUI01.AutoSize = true;
            this.lblUI01.Location = new System.Drawing.Point(12, 21);
            this.lblUI01.Name = "lblUI01";
            this.lblUI01.Size = new System.Drawing.Size(44, 28);
            this.lblUI01.TabIndex = 0;
            this.lblUI01.Text = "Táv:";
            // 
            // cb
            // 
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "Mini - 16km",
            "Rövid - 38km",
            "Pedelec - 54km",
            "Közép - 57km",
            "Hosszú - 94km"});
            this.cb.Location = new System.Drawing.Point(62, 18);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(225, 36);
            this.cb.TabIndex = 1;
            // 
            // lblUI02
            // 
            this.lblUI02.AutoSize = true;
            this.lblUI02.Location = new System.Drawing.Point(12, 79);
            this.lblUI02.Name = "lblUI02";
            this.lblUI02.Size = new System.Drawing.Size(166, 28);
            this.lblUI02.TabIndex = 0;
            this.lblUI02.Text = "Idő [óra:perc:mp]:";
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(184, 76);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(103, 34);
            this.tb.TabIndex = 2;
            this.tb.Text = "01:00:00";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(313, 18);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(103, 92);
            this.btn.TabIndex = 3;
            this.btn.Text = "Számol";
            this.btn.UseVisualStyleBackColor = true;
            // 
            // lblUI03
            // 
            this.lblUI03.AutoSize = true;
            this.lblUI03.Location = new System.Drawing.Point(12, 167);
            this.lblUI03.Name = "lblUI03";
            this.lblUI03.Size = new System.Drawing.Size(204, 28);
            this.lblUI03.TabIndex = 0;
            this.lblUI03.Text = "Átlagsebesség [km/h]:";
            // 
            // lblUI04
            // 
            this.lblUI04.AutoSize = true;
            this.lblUI04.Location = new System.Drawing.Point(12, 216);
            this.lblUI04.Name = "lblUI04";
            this.lblUI04.Size = new System.Drawing.Size(191, 28);
            this.lblUI04.TabIndex = 0;
            this.lblUI04.Text = "Átlagsebesség [m/s]:";
            // 
            // lblAVGkmph
            // 
            this.lblAVGkmph.AutoSize = true;
            this.lblAVGkmph.Location = new System.Drawing.Point(222, 167);
            this.lblAVGkmph.Name = "lblAVGkmph";
            this.lblAVGkmph.Size = new System.Drawing.Size(0, 28);
            this.lblAVGkmph.TabIndex = 4;
            // 
            // lblAVGmps
            // 
            this.lblAVGmps.AutoSize = true;
            this.lblAVGmps.Location = new System.Drawing.Point(222, 216);
            this.lblAVGmps.Name = "lblAVGmps";
            this.lblAVGmps.Size = new System.Drawing.Size(0, 28);
            this.lblAVGmps.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 287);
            this.Controls.Add(this.lblAVGmps);
            this.Controls.Add(this.lblAVGkmph);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.lblUI04);
            this.Controls.Add(this.lblUI03);
            this.Controls.Add(this.lblUI02);
            this.Controls.Add(this.lblUI01);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMain";
            this.Text = "Bükk Maraton 2019";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUI01;
        private ComboBox cb;
        private Label lblUI02;
        private TextBox tb;
        private Button btn;
        private Label lblUI03;
        private Label lblUI04;
        private Label lblAVGkmph;
        private Label lblAVGmps;
    }
}