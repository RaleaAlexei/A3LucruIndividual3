namespace Prob1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbPrenume = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAnulNasterii = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCNP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMedia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btInsereaza = new System.Windows.Forms.Button();
            this.dgwSalariati = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.tbGrupa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSalariati)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(12, 27);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 23);
            this.tbNume.TabIndex = 1;
            // 
            // tbPrenume
            // 
            this.tbPrenume.Location = new System.Drawing.Point(12, 71);
            this.tbPrenume.Name = "tbPrenume";
            this.tbPrenume.Size = new System.Drawing.Size(100, 23);
            this.tbPrenume.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenume";
            // 
            // tbAnulNasterii
            // 
            this.tbAnulNasterii.Location = new System.Drawing.Point(12, 115);
            this.tbAnulNasterii.Name = "tbAnulNasterii";
            this.tbAnulNasterii.Size = new System.Drawing.Size(100, 23);
            this.tbAnulNasterii.TabIndex = 5;
            this.tbAnulNasterii.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Anul nasterii";
            // 
            // tbCNP
            // 
            this.tbCNP.Location = new System.Drawing.Point(12, 159);
            this.tbCNP.MaxLength = 13;
            this.tbCNP.Name = "tbCNP";
            this.tbCNP.Size = new System.Drawing.Size(100, 23);
            this.tbCNP.TabIndex = 7;
            this.tbCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.digitOnly_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "CNP";
            // 
            // tbMedia
            // 
            this.tbMedia.Location = new System.Drawing.Point(118, 27);
            this.tbMedia.Name = "tbMedia";
            this.tbMedia.Size = new System.Drawing.Size(100, 23);
            this.tbMedia.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Distanta Parcursa";
            // 
            // btInsereaza
            // 
            this.btInsereaza.Location = new System.Drawing.Point(118, 159);
            this.btInsereaza.Name = "btInsereaza";
            this.btInsereaza.Size = new System.Drawing.Size(100, 23);
            this.btInsereaza.TabIndex = 14;
            this.btInsereaza.Text = "Insereaza";
            this.btInsereaza.UseVisualStyleBackColor = true;
            this.btInsereaza.Click += new System.EventHandler(this.btInsereaza_Click);
            // 
            // dgwSalariati
            // 
            this.dgwSalariati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSalariati.Location = new System.Drawing.Point(12, 188);
            this.dgwSalariati.Name = "dgwSalariati";
            this.dgwSalariati.RowTemplate.Height = 25;
            this.dgwSalariati.Size = new System.Drawing.Size(410, 201);
            this.dgwSalariati.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Plata Maxima";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbGrupa
            // 
            this.tbGrupa.Location = new System.Drawing.Point(118, 71);
            this.tbGrupa.Name = "tbGrupa";
            this.tbGrupa.Size = new System.Drawing.Size(100, 23);
            this.tbGrupa.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Plata pe KM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 401);
            this.Controls.Add(this.tbGrupa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwSalariati);
            this.Controls.Add(this.btInsereaza);
            this.Controls.Add(this.tbMedia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCNP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAnulNasterii);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrenume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSalariati)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btInsereaza;
        private DataGridView dgwSalariati;
        public TextBox tbNume;
        public TextBox tbPrenume;
        public TextBox tbAnulNasterii;
        public TextBox tbCNP;
        public TextBox tbMedia;
        private Button button1;
        public TextBox tbGrupa;
        private Label label6;
    }
}