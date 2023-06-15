namespace ComponenteUI
{
    partial class Form1
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
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbProgrameStudiu = new System.Windows.Forms.GroupBox();
            this.rdbCase = new System.Windows.Forms.RadioButton();
            this.rdbMem = new System.Windows.Forms.RadioButton();
            this.rdbPower = new System.Windows.Forms.RadioButton();
            this.rdbSSD = new System.Windows.Forms.RadioButton();
            this.rdbMobo = new System.Windows.Forms.RadioButton();
            this.rdbCPU = new System.Windows.Forms.RadioButton();
            this.rdbGPU = new System.Windows.Forms.RadioButton();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.lblMesajComponente = new System.Windows.Forms.Label();
            this.btnAdaugaComponenta = new System.Windows.Forms.Button();
            this.btnAfiseazaComponenta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblIDcomponenta = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtIDcomponenta_d = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.btnAfiseazaComanda = new System.Windows.Forms.Button();
            this.lblMesajComanda = new System.Windows.Forms.Label();
            this.lblCauta = new System.Windows.Forms.Label();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelBlack = new System.Windows.Forms.Label();
            this.btnCauta = new System.Windows.Forms.Button();
            this.lblMesajCauta = new System.Windows.Forms.Label();
            this.gpbProgrameStudiu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.SystemColors.Info;
            this.txtBrand.Location = new System.Drawing.Point(101, 34);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(160, 20);
            this.txtBrand.TabIndex = 0;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBrand.Location = new System.Drawing.Point(14, 37);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(37, 15);
            this.lblBrand.TabIndex = 1;
            this.lblBrand.Text = "Brand";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblModel.Location = new System.Drawing.Point(12, 62);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(38, 15);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.No;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adauga Componenta";
            // 
            // gpbProgrameStudiu
            // 
            this.gpbProgrameStudiu.Controls.Add(this.rdbCase);
            this.gpbProgrameStudiu.Controls.Add(this.rdbMem);
            this.gpbProgrameStudiu.Controls.Add(this.rdbPower);
            this.gpbProgrameStudiu.Controls.Add(this.rdbSSD);
            this.gpbProgrameStudiu.Controls.Add(this.rdbMobo);
            this.gpbProgrameStudiu.Controls.Add(this.rdbCPU);
            this.gpbProgrameStudiu.Controls.Add(this.rdbGPU);
            this.gpbProgrameStudiu.Location = new System.Drawing.Point(102, 122);
            this.gpbProgrameStudiu.Margin = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Name = "gpbProgrameStudiu";
            this.gpbProgrameStudiu.Padding = new System.Windows.Forms.Padding(4);
            this.gpbProgrameStudiu.Size = new System.Drawing.Size(200, 111);
            this.gpbProgrameStudiu.TabIndex = 55;
            this.gpbProgrameStudiu.TabStop = false;
            // 
            // rdbCase
            // 
            this.rdbCase.AutoSize = true;
            this.rdbCase.Location = new System.Drawing.Point(8, 64);
            this.rdbCase.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCase.Name = "rdbCase";
            this.rdbCase.Size = new System.Drawing.Size(49, 17);
            this.rdbCase.TabIndex = 14;
            this.rdbCase.TabStop = true;
            this.rdbCase.Text = "Case";
            this.rdbCase.UseVisualStyleBackColor = true;
            // 
            // rdbMem
            // 
            this.rdbMem.AutoSize = true;
            this.rdbMem.Location = new System.Drawing.Point(8, 89);
            this.rdbMem.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMem.Name = "rdbMem";
            this.rdbMem.Size = new System.Drawing.Size(62, 17);
            this.rdbMem.TabIndex = 13;
            this.rdbMem.TabStop = true;
            this.rdbMem.Text = "Memory";
            this.rdbMem.UseVisualStyleBackColor = true;
            // 
            // rdbPower
            // 
            this.rdbPower.AutoSize = true;
            this.rdbPower.Location = new System.Drawing.Point(105, 39);
            this.rdbPower.Margin = new System.Windows.Forms.Padding(4);
            this.rdbPower.Name = "rdbPower";
            this.rdbPower.Size = new System.Drawing.Size(90, 17);
            this.rdbPower.TabIndex = 12;
            this.rdbPower.TabStop = true;
            this.rdbPower.Text = "Power Supply";
            this.rdbPower.UseVisualStyleBackColor = true;
            // 
            // rdbSSD
            // 
            this.rdbSSD.AutoSize = true;
            this.rdbSSD.Location = new System.Drawing.Point(8, 39);
            this.rdbSSD.Margin = new System.Windows.Forms.Padding(4);
            this.rdbSSD.Name = "rdbSSD";
            this.rdbSSD.Size = new System.Drawing.Size(47, 17);
            this.rdbSSD.TabIndex = 11;
            this.rdbSSD.TabStop = true;
            this.rdbSSD.Text = "SSD";
            this.rdbSSD.UseVisualStyleBackColor = true;
            // 
            // rdbMobo
            // 
            this.rdbMobo.AutoSize = true;
            this.rdbMobo.Location = new System.Drawing.Point(105, 64);
            this.rdbMobo.Margin = new System.Windows.Forms.Padding(4);
            this.rdbMobo.Name = "rdbMobo";
            this.rdbMobo.Size = new System.Drawing.Size(85, 17);
            this.rdbMobo.TabIndex = 10;
            this.rdbMobo.TabStop = true;
            this.rdbMobo.Text = "Motherboard";
            this.rdbMobo.UseVisualStyleBackColor = true;
            // 
            // rdbCPU
            // 
            this.rdbCPU.AutoSize = true;
            this.rdbCPU.Location = new System.Drawing.Point(8, 14);
            this.rdbCPU.Margin = new System.Windows.Forms.Padding(4);
            this.rdbCPU.Name = "rdbCPU";
            this.rdbCPU.Size = new System.Drawing.Size(47, 17);
            this.rdbCPU.TabIndex = 8;
            this.rdbCPU.TabStop = true;
            this.rdbCPU.Text = "CPU";
            this.rdbCPU.UseVisualStyleBackColor = true;
            // 
            // rdbGPU
            // 
            this.rdbGPU.AutoSize = true;
            this.rdbGPU.Location = new System.Drawing.Point(106, 14);
            this.rdbGPU.Margin = new System.Windows.Forms.Padding(4);
            this.rdbGPU.Name = "rdbGPU";
            this.rdbGPU.Size = new System.Drawing.Size(48, 17);
            this.rdbGPU.TabIndex = 9;
            this.rdbGPU.TabStop = true;
            this.rdbGPU.Text = "GPU";
            this.rdbGPU.UseVisualStyleBackColor = true;
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPret.Location = new System.Drawing.Point(12, 88);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(28, 15);
            this.lblPret.TabIndex = 56;
            this.lblPret.Text = "Pret";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTip.Location = new System.Drawing.Point(10, 122);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(87, 15);
            this.lblTip.TabIndex = 57;
            this.lblTip.Text = "Tip Componenta";
            // 
            // txtModel
            // 
            this.txtModel.BackColor = System.Drawing.SystemColors.Info;
            this.txtModel.Location = new System.Drawing.Point(101, 59);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(160, 20);
            this.txtModel.TabIndex = 58;
            // 
            // txtPret
            // 
            this.txtPret.BackColor = System.Drawing.SystemColors.Info;
            this.txtPret.Location = new System.Drawing.Point(101, 85);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(160, 20);
            this.txtPret.TabIndex = 59;
            // 
            // lblMesajComponente
            // 
            this.lblMesajComponente.AutoSize = true;
            this.lblMesajComponente.Location = new System.Drawing.Point(15, 269);
            this.lblMesajComponente.Name = "lblMesajComponente";
            this.lblMesajComponente.Size = new System.Drawing.Size(34, 13);
            this.lblMesajComponente.TabIndex = 80;
            this.lblMesajComponente.Text = "mesaj";
            // 
            // btnAdaugaComponenta
            // 
            this.btnAdaugaComponenta.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdaugaComponenta.Location = new System.Drawing.Point(101, 240);
            this.btnAdaugaComponenta.Name = "btnAdaugaComponenta";
            this.btnAdaugaComponenta.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugaComponenta.TabIndex = 81;
            this.btnAdaugaComponenta.Text = "Adauga";
            this.btnAdaugaComponenta.UseVisualStyleBackColor = false;
            this.btnAdaugaComponenta.Click += new System.EventHandler(this.btnAdaugaComponenta_Click);
            // 
            // btnAfiseazaComponenta
            // 
            this.btnAfiseazaComponenta.BackColor = System.Drawing.SystemColors.Info;
            this.btnAfiseazaComponenta.Location = new System.Drawing.Point(227, 240);
            this.btnAfiseazaComponenta.Name = "btnAfiseazaComponenta";
            this.btnAfiseazaComponenta.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseazaComponenta.TabIndex = 82;
            this.btnAfiseazaComponenta.Text = "Afiseaza";
            this.btnAfiseazaComponenta.UseVisualStyleBackColor = false;
            this.btnAfiseazaComponenta.Click += new System.EventHandler(this.btnAfiseazaComponenta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "Comanda componenta:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNume.Location = new System.Drawing.Point(84, 349);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(37, 15);
            this.lblNume.TabIndex = 84;
            this.lblNume.Text = "Nume";
            // 
            // lblPrenume
            // 
            this.lblPrenume.AutoSize = true;
            this.lblPrenume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrenume.Location = new System.Drawing.Point(70, 380);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(51, 15);
            this.lblPrenume.TabIndex = 85;
            this.lblPrenume.Text = "Prenume";
            // 
            // lblIDcomponenta
            // 
            this.lblIDcomponenta.AutoSize = true;
            this.lblIDcomponenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIDcomponenta.Location = new System.Drawing.Point(10, 406);
            this.lblIDcomponenta.Name = "lblIDcomponenta";
            this.lblIDcomponenta.Size = new System.Drawing.Size(111, 15);
            this.lblIDcomponenta.TabIndex = 86;
            this.lblIDcomponenta.Text = "ID componenta dorita";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAdresa.Location = new System.Drawing.Point(48, 437);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(73, 15);
            this.lblAdresa.TabIndex = 87;
            this.lblAdresa.Text = "Adresa livrare";
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.SystemColors.Info;
            this.txtNume.Location = new System.Drawing.Point(132, 342);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(160, 20);
            this.txtNume.TabIndex = 88;
            // 
            // txtPrenume
            // 
            this.txtPrenume.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrenume.Location = new System.Drawing.Point(132, 373);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(160, 20);
            this.txtPrenume.TabIndex = 89;
            // 
            // txtIDcomponenta_d
            // 
            this.txtIDcomponenta_d.BackColor = System.Drawing.SystemColors.Info;
            this.txtIDcomponenta_d.Location = new System.Drawing.Point(132, 399);
            this.txtIDcomponenta_d.Name = "txtIDcomponenta_d";
            this.txtIDcomponenta_d.Size = new System.Drawing.Size(160, 20);
            this.txtIDcomponenta_d.TabIndex = 90;
            // 
            // txtAdresa
            // 
            this.txtAdresa.BackColor = System.Drawing.SystemColors.Info;
            this.txtAdresa.Location = new System.Drawing.Point(132, 430);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(160, 20);
            this.txtAdresa.TabIndex = 91;
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdaugaComanda.Location = new System.Drawing.Point(51, 459);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(138, 23);
            this.btnAdaugaComanda.TabIndex = 92;
            this.btnAdaugaComanda.Text = "Salveaza info comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = false;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // btnAfiseazaComanda
            // 
            this.btnAfiseazaComanda.BackColor = System.Drawing.SystemColors.Info;
            this.btnAfiseazaComanda.Location = new System.Drawing.Point(227, 459);
            this.btnAfiseazaComanda.Name = "btnAfiseazaComanda";
            this.btnAfiseazaComanda.Size = new System.Drawing.Size(138, 23);
            this.btnAfiseazaComanda.TabIndex = 93;
            this.btnAfiseazaComanda.Text = "Afiseaza comenzi";
            this.btnAfiseazaComanda.UseVisualStyleBackColor = false;
            this.btnAfiseazaComanda.Click += new System.EventHandler(this.btnAfiseazaComanda_Click);
            // 
            // lblMesajComanda
            // 
            this.lblMesajComanda.AutoSize = true;
            this.lblMesajComanda.Location = new System.Drawing.Point(15, 497);
            this.lblMesajComanda.Name = "lblMesajComanda";
            this.lblMesajComanda.Size = new System.Drawing.Size(0, 13);
            this.lblMesajComanda.TabIndex = 94;
            // 
            // lblCauta
            // 
            this.lblCauta.AutoSize = true;
            this.lblCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCauta.Location = new System.Drawing.Point(86, 517);
            this.lblCauta.Name = "lblCauta";
            this.lblCauta.Size = new System.Drawing.Size(64, 15);
            this.lblCauta.TabIndex = 95;
            this.lblCauta.Text = "Cauta dupa";
            // 
            // txtCauta
            // 
            this.txtCauta.BackColor = System.Drawing.SystemColors.Info;
            this.txtCauta.Location = new System.Drawing.Point(154, 514);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(100, 20);
            this.txtCauta.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 97;
            // 
            // labelBlack
            // 
            this.labelBlack.AutoSize = true;
            this.labelBlack.Location = new System.Drawing.Point(273, 550);
            this.labelBlack.Name = "labelBlack";
            this.labelBlack.Size = new System.Drawing.Size(0, 13);
            this.labelBlack.TabIndex = 98;
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.SystemColors.Info;
            this.btnCauta.Location = new System.Drawing.Point(167, 540);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 99;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // lblMesajCauta
            // 
            this.lblMesajCauta.AutoSize = true;
            this.lblMesajCauta.Location = new System.Drawing.Point(16, 567);
            this.lblMesajCauta.Name = "lblMesajCauta";
            this.lblMesajCauta.Size = new System.Drawing.Size(0, 13);
            this.lblMesajCauta.TabIndex = 100;
            this.lblMesajCauta.Click += new System.EventHandler(this.lblMesajCauta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 613);
            this.Controls.Add(this.lblMesajCauta);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.labelBlack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.lblCauta);
            this.Controls.Add(this.lblMesajComanda);
            this.Controls.Add(this.btnAfiseazaComanda);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtIDcomponenta_d);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblIDcomponenta);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAfiseazaComponenta);
            this.Controls.Add(this.btnAdaugaComponenta);
            this.Controls.Add(this.lblMesajComponente);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.gpbProgrameStudiu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtBrand);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbProgrameStudiu.ResumeLayout(false);
            this.gpbProgrameStudiu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbProgrameStudiu;
        private System.Windows.Forms.RadioButton rdbCase;
        private System.Windows.Forms.RadioButton rdbMem;
        private System.Windows.Forms.RadioButton rdbPower;
        private System.Windows.Forms.RadioButton rdbSSD;
        private System.Windows.Forms.RadioButton rdbMobo;
        private System.Windows.Forms.RadioButton rdbCPU;
        private System.Windows.Forms.RadioButton rdbGPU;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label lblMesajComponente;
        private System.Windows.Forms.Button btnAdaugaComponenta;
        private System.Windows.Forms.Button btnAfiseazaComponenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPrenume;
        private System.Windows.Forms.Label lblIDcomponenta;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.TextBox txtIDcomponenta_d;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Button btnAdaugaComanda;
        private System.Windows.Forms.Button btnAfiseazaComanda;
        private System.Windows.Forms.Label lblMesajComanda;
        private System.Windows.Forms.Label lblCauta;
        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelBlack;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Label lblMesajCauta;
    }
}

