namespace inkopslistan_ovn_2_8
{
    partial class frmInköpslista
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
            this.lblVara = new System.Windows.Forms.Label();
            this.tbxVara = new System.Windows.Forms.TextBox();
            this.tbxPris = new System.Windows.Forms.TextBox();
            this.lblPris = new System.Windows.Forms.Label();
            this.tbxMängd = new System.Windows.Forms.TextBox();
            this.lblMängd = new System.Windows.Forms.Label();
            this.gbxVarutyp = new System.Windows.Forms.GroupBox();
            this.rbnLösvikt = new System.Windows.Forms.RadioButton();
            this.rbnStycksak = new System.Windows.Forms.RadioButton();
            this.btnLäggTill = new System.Windows.Forms.Button();
            this.lbxLista = new System.Windows.Forms.ListBox();
            this.tbxSumma = new System.Windows.Forms.TextBox();
            this.lblSumma = new System.Windows.Forms.Label();
            this.gbxVarutyp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblVara
            // 
            this.lblVara.AutoSize = true;
            this.lblVara.Location = new System.Drawing.Point(13, 13);
            this.lblVara.Name = "lblVara";
            this.lblVara.Size = new System.Drawing.Size(38, 17);
            this.lblVara.TabIndex = 0;
            this.lblVara.Text = "Vara";
            // 
            // tbxVara
            // 
            this.tbxVara.Location = new System.Drawing.Point(124, 13);
            this.tbxVara.Name = "tbxVara";
            this.tbxVara.Size = new System.Drawing.Size(100, 22);
            this.tbxVara.TabIndex = 1;
            // 
            // tbxPris
            // 
            this.tbxPris.Location = new System.Drawing.Point(124, 55);
            this.tbxPris.Name = "tbxPris";
            this.tbxPris.Size = new System.Drawing.Size(100, 22);
            this.tbxPris.TabIndex = 3;
            // 
            // lblPris
            // 
            this.lblPris.AutoSize = true;
            this.lblPris.Location = new System.Drawing.Point(13, 55);
            this.lblPris.Name = "lblPris";
            this.lblPris.Size = new System.Drawing.Size(32, 17);
            this.lblPris.TabIndex = 2;
            this.lblPris.Text = "Pris";
            // 
            // tbxMängd
            // 
            this.tbxMängd.Location = new System.Drawing.Point(124, 95);
            this.tbxMängd.Name = "tbxMängd";
            this.tbxMängd.Size = new System.Drawing.Size(100, 22);
            this.tbxMängd.TabIndex = 5;
            // 
            // lblMängd
            // 
            this.lblMängd.AutoSize = true;
            this.lblMängd.Location = new System.Drawing.Point(13, 95);
            this.lblMängd.Name = "lblMängd";
            this.lblMängd.Size = new System.Drawing.Size(51, 17);
            this.lblMängd.TabIndex = 4;
            this.lblMängd.Text = "Mängd";
            // 
            // gbxVarutyp
            // 
            this.gbxVarutyp.Controls.Add(this.rbnStycksak);
            this.gbxVarutyp.Controls.Add(this.rbnLösvikt);
            this.gbxVarutyp.Location = new System.Drawing.Point(111, 146);
            this.gbxVarutyp.Name = "gbxVarutyp";
            this.gbxVarutyp.Size = new System.Drawing.Size(113, 100);
            this.gbxVarutyp.TabIndex = 6;
            this.gbxVarutyp.TabStop = false;
            this.gbxVarutyp.Text = "Varutyp";
            // 
            // rbnLösvikt
            // 
            this.rbnLösvikt.AutoSize = true;
            this.rbnLösvikt.Location = new System.Drawing.Point(13, 22);
            this.rbnLösvikt.Name = "rbnLösvikt";
            this.rbnLösvikt.Size = new System.Drawing.Size(73, 21);
            this.rbnLösvikt.TabIndex = 0;
            this.rbnLösvikt.TabStop = true;
            this.rbnLösvikt.Text = "Lösvikt";
            this.rbnLösvikt.UseVisualStyleBackColor = true;
            // 
            // rbnStycksak
            // 
            this.rbnStycksak.AutoSize = true;
            this.rbnStycksak.Location = new System.Drawing.Point(13, 60);
            this.rbnStycksak.Name = "rbnStycksak";
            this.rbnStycksak.Size = new System.Drawing.Size(85, 21);
            this.rbnStycksak.TabIndex = 1;
            this.rbnStycksak.TabStop = true;
            this.rbnStycksak.Text = "Stycksak";
            this.rbnStycksak.UseVisualStyleBackColor = true;
            // 
            // btnLäggTill
            // 
            this.btnLäggTill.Location = new System.Drawing.Point(26, 395);
            this.btnLäggTill.Name = "btnLäggTill";
            this.btnLäggTill.Size = new System.Drawing.Size(84, 30);
            this.btnLäggTill.TabIndex = 7;
            this.btnLäggTill.Text = "Lägg till";
            this.btnLäggTill.UseVisualStyleBackColor = true;
            this.btnLäggTill.Click += new System.EventHandler(this.btnLäggTill_Click);
            // 
            // lbxLista
            // 
            this.lbxLista.FormattingEnabled = true;
            this.lbxLista.ItemHeight = 16;
            this.lbxLista.Location = new System.Drawing.Point(251, 13);
            this.lbxLista.Name = "lbxLista";
            this.lbxLista.Size = new System.Drawing.Size(222, 372);
            this.lbxLista.TabIndex = 8;
            // 
            // tbxSumma
            // 
            this.tbxSumma.Location = new System.Drawing.Point(373, 403);
            this.tbxSumma.Name = "tbxSumma";
            this.tbxSumma.Size = new System.Drawing.Size(100, 22);
            this.tbxSumma.TabIndex = 10;
            // 
            // lblSumma
            // 
            this.lblSumma.AutoSize = true;
            this.lblSumma.Location = new System.Drawing.Point(262, 403);
            this.lblSumma.Name = "lblSumma";
            this.lblSumma.Size = new System.Drawing.Size(55, 17);
            this.lblSumma.TabIndex = 9;
            this.lblSumma.Text = "Summa";
            // 
            // frmInköpslista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 450);
            this.Controls.Add(this.tbxSumma);
            this.Controls.Add(this.lblSumma);
            this.Controls.Add(this.lbxLista);
            this.Controls.Add(this.btnLäggTill);
            this.Controls.Add(this.gbxVarutyp);
            this.Controls.Add(this.tbxMängd);
            this.Controls.Add(this.lblMängd);
            this.Controls.Add(this.tbxPris);
            this.Controls.Add(this.lblPris);
            this.Controls.Add(this.tbxVara);
            this.Controls.Add(this.lblVara);
            this.Name = "frmInköpslista";
            this.Text = "Inköpslista";
            this.gbxVarutyp.ResumeLayout(false);
            this.gbxVarutyp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVara;
        private System.Windows.Forms.TextBox tbxVara;
        private System.Windows.Forms.TextBox tbxPris;
        private System.Windows.Forms.Label lblPris;
        private System.Windows.Forms.TextBox tbxMängd;
        private System.Windows.Forms.Label lblMängd;
        private System.Windows.Forms.GroupBox gbxVarutyp;
        private System.Windows.Forms.RadioButton rbnStycksak;
        private System.Windows.Forms.RadioButton rbnLösvikt;
        private System.Windows.Forms.Button btnLäggTill;
        private System.Windows.Forms.ListBox lbxLista;
        private System.Windows.Forms.TextBox tbxSumma;
        private System.Windows.Forms.Label lblSumma;
    }
}

