using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect_PIU;


namespace ComponenteUI
{
    public partial class Form1 : Form
    {
        AdminFisier adminComponenta;
        AdminFisierCumparare adminCumparare;

        private const int LATIME_CONTROL = 130;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 130;
        private const int OFFSET_Y = 20;
        private const int OFFSET_X = 600;

       
        private Label lblHeaderID;
        private Label lblHeaderTIP;
        private Label lblHeaderBrand;
        private Label lblHeaderModel;
        private Label lblHeaderPret;

        
        private Label[] lblsID;
        private Label[] lblsTIP;
        private Label[] lblsBrand;
        private Label[] lblsModel;
        private Label[] lblsPret;

        private Label lblHeaderIDcumpara;
        private Label lblHeaderNume;
        private Label lblHeaderPrenume;
        private Label lblHeaderAdresa;

        private Label[] lblsIDcumpara;
        private Label[] lblsNume;
        private Label[] lblsPrenume;
        private Label[] lblsAdresa;

        private int nrCumparari = 0;
        private int nrComponente = 0;
        private int nextIDcomponente = 1;
        private int nextIDcumparare = 1;

       

        public Form1()
        {
            string NumeFisierCumpara = ConfigurationManager.AppSettings["NumeFisierCumpara"];
            string NumeFisierComponente = ConfigurationManager.AppSettings["NumeFisierComponente"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            
            string caleCompletaFisierCumpara = locatieFisierSolutie + "\\" + "Cumpara.txt";
            string caleCompletaFisierComponente = locatieFisierSolutie + "\\" + "Componente.txt";

            adminCumparare = new AdminFisierCumparare(caleCompletaFisierCumpara);
            adminComponenta = new AdminFisier(caleCompletaFisierComponente); 

            InitializeComponent();

            this.Size = new Size(520, 520);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(200, 150);
            this.Font = new Font("Comic Sans", 11, FontStyle.Bold);
            //this.ForeColor = Color.Purple;
            this.Text = "Cumpara componente";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblMesajComponente.Text = "";
            lblMesajComponente.ForeColor = Color.Red;

            update_nr_nextID_componente(ref nrComponente, ref nextIDcomponente, adminComponenta);
            update_nr_nextID_comanda(ref nrCumparari, ref nextIDcumparare, adminCumparare);

            AfisareComponente();
            AfisareComanda();
            Clear();
        }
        private void AfisareComponente()
        {
            
            lblHeaderID = new Label();
            lblHeaderID.Width = LATIME_CONTROL;
            lblHeaderID.Text = "ID";
            lblHeaderID.Left = OFFSET_X + 0 * DIMENSIUNE_PAS_X;
            lblHeaderID.Top = OFFSET_Y;
            lblHeaderID.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderID);

            lblHeaderTIP = new Label();
            lblHeaderTIP.Width = LATIME_CONTROL;
            lblHeaderTIP.Text = "Tip componenta";
            lblHeaderTIP.Left = OFFSET_X + 1 * DIMENSIUNE_PAS_X;
            lblHeaderTIP.Top = OFFSET_Y;
            lblHeaderTIP.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderTIP);

            lblHeaderBrand = new Label();
            lblHeaderBrand.Width = LATIME_CONTROL;
            lblHeaderBrand.Text = "Brand";
            lblHeaderBrand.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderBrand.Top = OFFSET_Y;
            lblHeaderBrand.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderBrand);

            lblHeaderModel = new Label();
            lblHeaderModel.Width = LATIME_CONTROL;
            lblHeaderModel.Text = "Model";
            lblHeaderModel.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderModel.Top = OFFSET_Y;
            lblHeaderModel.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderModel);

            lblHeaderPret = new Label();
            lblHeaderPret.Width = LATIME_CONTROL;
            lblHeaderPret.Text = "Pret";
            lblHeaderPret.Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X;
            lblHeaderPret.Top = OFFSET_Y;
            lblHeaderPret.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderPret);

            int nrComponente = 0;
            Componenta[] componente = adminComponenta.GetComponenta(out nrComponente);

            lblsID = new Label[nrComponente];
            lblsTIP = new Label[nrComponente];
            lblsBrand = new Label[nrComponente];
            lblsModel = new Label[nrComponente];
            lblsPret = new Label[nrComponente];

            int i = 0;

            foreach (Componenta componenta in componente)
            {
                if (i >= nrComponente)
                        break;
                
                lblsID[i] = new Label();
                lblsID[i].Width = LATIME_CONTROL;
                lblsID[i].Text = componenta.idComponenta.ToString();
                lblsID[i].Left = OFFSET_X + 0;
                lblsID[i].Top = OFFSET_Y + (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsID[i]);

                lblsTIP[i] = new Label();
                lblsTIP[i].Width = LATIME_CONTROL;
                lblsTIP[i].Text = ((Componenta.tipComponente)componenta.tipComponenta).ToString();
                lblsTIP[i].Left = OFFSET_X + DIMENSIUNE_PAS_X ;
                lblsTIP[i].Top = OFFSET_Y + (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsTIP[i]);

                lblsBrand[i] = new Label();
                lblsBrand[i].Width = LATIME_CONTROL;
                lblsBrand[i].Text = componenta.brand;
                lblsBrand[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsBrand[i].Top = OFFSET_Y + (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsBrand[i]);

                lblsModel[i] = new Label();
                lblsModel[i].Width = LATIME_CONTROL;
                lblsModel[i].Text = componenta.model;
                lblsModel[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsModel[i].Top = OFFSET_Y + (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsModel[i]);

                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = componenta.pret.ToString() + " ron";
                lblsPret[i].Left = OFFSET_X + 4 * DIMENSIUNE_PAS_X ;
                lblsPret[i].Top = OFFSET_Y + (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPret[i]);

                i++;
            }

        }

        private void AfisareComanda()
        {
           
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderNume.Top = OFFSET_Y;
            lblHeaderNume.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderNume);

            lblHeaderPrenume = new Label();
            lblHeaderPrenume.Width = LATIME_CONTROL;
            lblHeaderPrenume.Text = "Prenume";
            lblHeaderPrenume.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderPrenume.Top = OFFSET_Y;
            lblHeaderPrenume.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderPrenume);

            lblHeaderAdresa = new Label();
            lblHeaderAdresa.Width = LATIME_CONTROL;
            lblHeaderAdresa.Text = "Adresa";
            lblHeaderAdresa.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderAdresa.Top = OFFSET_Y;
            lblHeaderAdresa.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderAdresa);

            lblHeaderIDcumpara = new Label();
            lblHeaderIDcumpara.Width = LATIME_CONTROL;
            lblHeaderIDcumpara.Text = "ID componenta";
            lblHeaderIDcumpara.Left = OFFSET_X + 0;
            lblHeaderIDcumpara.Top = OFFSET_Y;
            lblHeaderIDcumpara.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderIDcumpara);


            int nrCumparari = 0;

            Cumpara[] cumparari = adminCumparare.GetCumparare(out nrCumparari);

            lblsIDcumpara = new Label[nrCumparari]; 
            lblsNume = new Label[nrCumparari];
            lblsPrenume = new Label[nrCumparari];
            lblsAdresa= new Label[nrCumparari];

            int j = 0;

            foreach (Cumpara cumparare in cumparari)
            {
                if (j >= nrCumparari)
                    break;

                lblsIDcumpara[j] = new Label();
                lblsIDcumpara[j].Width = LATIME_CONTROL;
                lblsIDcumpara[j].Text = cumparare.idComponenta.ToString();
                lblsIDcumpara[j].Left = OFFSET_X + 0;
                lblsIDcumpara[j].Top = OFFSET_Y + (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsID[j]);

                lblsNume[j] = new Label();
                lblsNume[j].Width = LATIME_CONTROL;
                lblsNume[j].Text = cumparare.nume;
                lblsNume[j].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsNume[j].Top = OFFSET_Y + (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[j]);

                lblsPrenume[j] = new Label();
                lblsPrenume[j].Width = LATIME_CONTROL;
                lblsPrenume[j].Text = cumparare.prenume;
                lblsPrenume[j].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsPrenume[j].Top = OFFSET_Y + (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPrenume[j]);

                lblsAdresa[j] = new Label();
                lblsAdresa[j].Width = LATIME_CONTROL;
                lblsAdresa[j].Text = cumparare.adresa;
                lblsAdresa[j].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsAdresa[j].Top = OFFSET_Y + (j + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsAdresa[j]);

                j++;
            }
        }

        private void btnAdaugaComponenta_Click(object sender, EventArgs e)
        {

            if (!ComponentaValidareDateIntrare()) return;
            
            update_nr_nextID_componente(ref nrComponente, ref nextIDcomponente, adminComponenta);
            
            Componenta componenta = new Componenta(nextIDcomponente, SelectComponenta(), txtBrand.Text,txtModel.Text,float.Parse(txtPret.Text));
            
            adminComponenta.AdaugaComponenta(componenta);
            lblMesajComponente.Text = "Componenta adaugata";
            lblMesajComponente.ForeColor = Color.Green;

            ResetareControaleComponente();
            //AfisareComponente();
        }

        private bool ComponentaValidareDateIntrare()
        {
            string eroare = "";
            string brand = txtBrand.Text;
            string model = txtModel.Text;

            bool validare = true;

            if (brand.Length<1)
            {
                lblBrand.ForeColor = Color.Red;
                validare = false;
                eroare += " Date brand invalide!!! ";
            }
            else 
            {
             lblBrand.ForeColor = Color.MediumPurple;
            }

            if (model.Length<1) 
            { 
            
            lblModel.ForeColor = Color.Red;
            validare = false;
                eroare += " Date model invalide!!! ";
            }
            else 
            { 
             lblModel.ForeColor = Color.MediumPurple;
            }

            if (SelectComponenta() == 0)
            {
                lblTip.ForeColor = Color.Red;
                validare = false;
                eroare += " Selecteaza un tip de componenta !!! ";
            }
            else
            {
                lblTip.ForeColor = Color.MediumPurple;
            }
            if (!float.TryParse(txtPret.Text, out float PretVal))
            {
                lblPret.ForeColor = Color.Red;
                validare = false;
                eroare += " Pret invalid!!!\n";
            }
            else
            {
                if (PretVal > 0)
                    lblPret.ForeColor = Color.MediumPurple;
                else
                {
                    lblPret.ForeColor = Color.Red;
                    validare = false;
                    eroare += "Pret invalid!!!\n";
                }
            }

            lblMesajComponente.Text = eroare;

            return validare;

        }

       public static void update_nr_nextID_componente(ref int nrComponente, ref int nextIDcomponenta, AdminFisier adminComponente)
        {
            Componenta[] componente = adminComponente.GetComponenta(out nrComponente);
            if (nrComponente != 0)
                nextIDcomponenta = componente[nrComponente - 1].idComponenta + 1;

        }

        private void ResetareControaleComponente ()
        {
            txtBrand.Text = txtModel.Text = txtPret.Text = string.Empty;

            rdbCPU.Checked= false;
            rdbGPU.Checked= false;
            rdbMobo.Checked= false;
            rdbSSD.Checked= false;
            rdbPower.Checked= false;
            rdbMem.Checked= false;
            rdbCase.Checked= false;
        }

        private int SelectComponenta()
        {
            if (rdbCPU.Checked)
                return 1;
            if (rdbGPU.Checked)
                return 2;
            if (rdbMobo.Checked)
                return 3;
            if (rdbSSD.Checked)
                return 4;
            if (rdbPower.Checked)
                return 5;
            if (rdbMem.Checked)
                return 6;
            if (rdbCase.Checked)
                return 7;

            return 0;
    
        }

        private void btnAfiseazaComponenta_Click(object sender, EventArgs e)
        {
            Clear();
            AfisareComponente();
            this.Width= 1300;
        }

        private void Clear()
        {
            bool isVizibil = false;

            lblHeaderIDcumpara.Visible = isVizibil;
            lblHeaderNume.Visible = isVizibil;
            lblHeaderPrenume.Visible = isVizibil;
            lblHeaderAdresa.Visible = isVizibil;

            foreach (Label lbl in lblsID)
                lbl.Visible = isVizibil;

            foreach (Label lbl in lblsNume)
                lbl.Visible = isVizibil;

            foreach (Label lbl in lblsPrenume)
                lbl.Visible = isVizibil;

            foreach (Label lbl in lblsAdresa)
                lbl.Visible = isVizibil;




            lblHeaderID.Visible = isVizibil;
            lblHeaderTIP.Visible = isVizibil;
            lblHeaderBrand.Visible = isVizibil;
            lblHeaderModel.Visible = isVizibil;
            lblHeaderPret.Visible = isVizibil;

            foreach (Label lbl in lblsID)
                lbl.Visible = isVizibil;
            foreach (Label lbl in lblsTIP)
                lbl.Visible = isVizibil;
            foreach (Label lbl in lblsBrand)
                lbl.Visible = isVizibil;
            foreach (Label lbl in lblsModel)
                lbl.Visible = isVizibil;
            foreach (Label lbl in lblsPret)
                lbl.Visible = isVizibil;

         

        }

        private bool CumparaValidareDateIntrare()
        {
            string eroare = "";
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string adresa = txtAdresa.Text;

            bool validare = true;

            if (nume.Length < 1)
            {
                lblNume.ForeColor = Color.Red;
                validare = false;
                eroare += " Date nume invalide!!! ";
            }
            else
            {
                lblNume.ForeColor = Color.MediumPurple;
            }
            if (prenume.Length < 1)
            {
                lblPrenume.ForeColor = Color.Red;
                validare = false;
                eroare += " Date prenume invalide!!! ";
            }
            else
            {
                lblPrenume.ForeColor = Color.MediumPurple;
            }

            if (adresa.Length < 1)
            {
                lblAdresa.ForeColor = Color.Red;
                validare = false;
                eroare += " Date adresa invalide!!! ";
            }
            else
            {
                lblAdresa.ForeColor = Color.MediumPurple;
            }
            if (!int.TryParse(txtIDcomponenta_d.Text, out int idComponenta))
            {
                lblIDcomponenta.ForeColor = Color.Red;
                validare = false;
                eroare += " ID invalid! ";
            }
            else
            {
                Componenta componenta = adminComponenta.GetComponenta(idComponenta);
                if (componenta.idComponenta !=0)
                    lblIDcomponenta.ForeColor = Color.MediumPurple;
                else
                {
                    lblIDcomponenta.ForeColor = Color.Red;
                    validare = false;
                    eroare += " Componenta nu exista! ";
                }
            }

            lblMesajComanda.Text = eroare;
            return validare;
        }

        public static void update_nr_nextID_comanda(ref int nrCumparari, ref int nextIDcumparare, AdminFisierCumparare adminComanda)
        {
            Cumpara[] cumparari = adminComanda.GetCumparare(out nrCumparari);
            if (nrCumparari != 0)
                nextIDcumparare = cumparari[nrCumparari - 1].idCumparare + 1;
        }

        private void ResetareControaleComanda()
        {
            txtNume.Text = txtPrenume.Text = txtIDcomponenta_d.Text = txtAdresa.Text = string.Empty;

        }

        private void btnAdaugaComanda_Click(object sender, EventArgs e)
        {
            if (!CumparaValidareDateIntrare()) return;

            update_nr_nextID_comanda(ref nrCumparari, ref nextIDcumparare, adminCumparare);

            Cumpara cumparare = new Cumpara(nextIDcumparare, int.Parse(txtIDcomponenta_d.Text), txtNume.Text, txtPrenume.Text, txtAdresa.Text);

            adminCumparare.AdaugareCumparare(cumparare);
            lblMesajComanda.Text = "Comanda finalizata";
            lblMesajComanda.ForeColor = Color.Green;

            ResetareControaleComanda();

        }

        private void btnAfiseazaComanda_Click(object sender, EventArgs e)
        {
            Clear();
            AfisareComanda();
            this.Width = 1200;
        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            bool validare = true;
            string eroare = "";
            Componenta componenta = new Componenta();

            if (!int.TryParse(txtCauta.Text, out int idComponenta))
            {
                lblCauta.ForeColor = Color.Red;
                validare = false;
                eroare += "ID invalid!";
            }
            else
            {
                componenta = adminComponenta.GetComponenta(idComponenta);
                if(componenta.idComponenta != 0)
                {
                    lblCauta.ForeColor = Color.Red;
                }
                else
                {
                    lblCauta.ForeColor = Color.Red;
                    validare = false;
                    eroare += "ID invalid!";
                    
                }
            }
            lblMesajCauta.Text = eroare;
            if (!validare) return;
            lblMesajCauta.Text = "Componenta gasita:  " + componenta.ShowInfo();
            lblMesajCauta.ForeColor = Color.MediumPurple;
            ResetareControaleCautare();
        }

        private void ResetareControaleCautare()
        {
            txtCauta.Text = string.Empty;
            lblCauta.ForeColor = Color.Black;
        }

            private void lblMesajCauta_Click(object sender, EventArgs e)
        {

        }
    }
}
