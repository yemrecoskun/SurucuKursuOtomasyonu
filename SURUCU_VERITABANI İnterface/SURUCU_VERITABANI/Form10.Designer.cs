namespace SURUCU_VERITABANI
{
    partial class Form10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ehliyettctxt = new System.Windows.Forms.TextBox();
            this.ehliyetsiniftxt = new System.Windows.Forms.TextBox();
            this.ehliyetbelgeaditxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ehliyetbelgesisoyadtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(350, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 50;
            this.label1.Text = "Ehliyet Belgesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(350, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(350, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ehliyet sınıfı";
            // 
            // ehliyettctxt
            // 
            this.ehliyettctxt.Location = new System.Drawing.Point(350, 284);
            this.ehliyettctxt.Name = "ehliyettctxt";
            this.ehliyettctxt.Size = new System.Drawing.Size(120, 20);
            this.ehliyettctxt.TabIndex = 63;
            // 
            // ehliyetsiniftxt
            // 
            this.ehliyetsiniftxt.Location = new System.Drawing.Point(350, 356);
            this.ehliyetsiniftxt.Name = "ehliyetsiniftxt";
            this.ehliyetsiniftxt.Size = new System.Drawing.Size(120, 20);
            this.ehliyetsiniftxt.TabIndex = 64;
            // 
            // ehliyetbelgeaditxt
            // 
            this.ehliyetbelgeaditxt.Location = new System.Drawing.Point(350, 140);
            this.ehliyetbelgeaditxt.Name = "ehliyetbelgeaditxt";
            this.ehliyetbelgeaditxt.Size = new System.Drawing.Size(120, 20);
            this.ehliyetbelgeaditxt.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(350, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 23);
            this.label8.TabIndex = 57;
            this.label8.Text = "T.C no";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(350, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 58;
            this.label9.Text = "Soyadı";
            // 
            // ehliyetbelgesisoyadtxt
            // 
            this.ehliyetbelgesisoyadtxt.Location = new System.Drawing.Point(350, 212);
            this.ehliyetbelgesisoyadtxt.Name = "ehliyetbelgesisoyadtxt";
            this.ehliyetbelgesisoyadtxt.Size = new System.Drawing.Size(120, 20);
            this.ehliyetbelgesisoyadtxt.TabIndex = 66;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ehliyetbelgesisoyadtxt);
            this.Controls.Add(this.ehliyetbelgeaditxt);
            this.Controls.Add(this.ehliyetsiniftxt);
            this.Controls.Add(this.ehliyettctxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "Sürücü Kursu Otomasyon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox ehliyettctxt;
        public System.Windows.Forms.TextBox ehliyetsiniftxt;
        public System.Windows.Forms.TextBox ehliyetbelgeaditxt;
        public System.Windows.Forms.TextBox ehliyetbelgesisoyadtxt;
    }
}