using SinatraGianpaolo18_06_2019.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinatraGianpaolo18_06_2019
{
    public partial class FormGeometria : Form
    {
        public int flag = -1;
        public FormGeometria()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void BtnCalcola_Click(object sender, EventArgs e)
        {
            
            {
                switch (flag)
                {
                    case 0:
                        double raggio = G3D.GetDouble(txtRaggio.Text);
                        if (rbtnCerchio.Checked && txtRaggio.Text == "" || G3D.IsNegative(raggio))
                            MessageBox.Show("Inserisci un RAGGIO valido prima di continuare.");
                        else
                        {
                            Cerchio c = new Cerchio(raggio);
                            FormRisultato cForm = new FormRisultato(c.ToString(), c.CalcoloArea());
                            cForm.Show();
                        }
                        break;
                    case 1:
                        double qLato = G3D.GetDouble(txtLato.Text);
                        if (rbtnQuadrato.Checked && txtLato.Text == "" || G3D.IsNegative(qLato))
                            MessageBox.Show("Inserisci un LATO valido prima di continuare.");
                        else
                        {
                            Quadrato q = new Quadrato(qLato);
                            FormRisultato qForm = new FormRisultato(q.ToString(), q.CalcoloArea());
                            qForm.Show();
                        }
                        break;
                    case 3:
                        double tBase = G3D.GetDouble(txtBase.Text);
                        double tAltezza = G3D.GetDouble(txtAltezza.Text);
                        if (rbtnTriangolo.Checked && txtBase.Text == "" || txtAltezza.Text == "" || G3D.IsNegative(tAltezza, tBase))
                            MessageBox.Show("Inserisci BASE e ALTEZZA validi prima di continuare.");
                        else
                        {
                            TriangoloIso t = new TriangoloIso(tBase, tAltezza);
                            FormRisultato tForm = new FormRisultato(t.ToString(), t.CalcoloArea());
                            tForm.Show();
                        }
                        break;
                    case 4:
                        double rBase = G3D.GetDouble(txtBase.Text);
                        double rAltezzaa = G3D.GetDouble(txtAltezza.Text);
                        if (rbtnRettangolo.Checked && txtBase.Text == "" || txtAltezza.Text == "" || G3D.IsNegative(rBase, rAltezzaa))
                            MessageBox.Show("Inserisci BASE e ALTEZZA validi prima di continuare.");
                        else
                        {
                            Rettangolo r = new Rettangolo(rBase, rAltezzaa);
                            FormRisultato rForm = new FormRisultato(r.ToString(), r.CalcoloArea());
                            rForm.Show();
                        }
                        break;
                    case 5:
                        double pLato = G3D.GetDouble(txtLato.Text);
                        if (rbtnPentagono.Checked && txtLato.Text == "" || G3D.IsNegative(pLato))
                            MessageBox.Show("Inserisci un LATO valido prima di continuare.");
                        else
                        {
                            Pentagono p = new Pentagono(pLato);
                            FormRisultato pForm = new FormRisultato(p.ToString(), p.CalcoloArea());
                            pForm.Show();
                        }
                        break;
                    case 6:
                        double esLato = G3D.GetDouble(txtLato.Text);
                        if (rbtnEsagono.Checked && txtLato.Text == "" || G3D.IsNegative(esLato))
                            MessageBox.Show("Inserisci un LATO valido prima di continuare.");
                        else
                        {
                            Esagono es = new Esagono(esLato);
                            FormRisultato esForm = new FormRisultato(es.ToString(), es.CalcoloArea());
                            esForm.Show();
                        }
                        break;
                    default:
                        MessageBox.Show("Errore!");
                        break;
                }
            }
            }

        


        private void RbtnCerchio_CheckedChanged(object sender, EventArgs e)
        {
            ActivateElements();
            if (rbtnCerchio.Checked)
            {
                flag = 0;
            }
        }

        private void RbtnQuadrato_CheckedChanged(object sender, EventArgs e)
        {
            ActivateElements();
            if (rbtnQuadrato.Checked)
            {
                flag = 1;
            }
        }

        private void RbtnEsagono_CheckedChanged(object sender, EventArgs e)
        {
            ActivateElements();
            if (rbtnEsagono.Checked)
            {
                flag = 6;
            }
        }

        private void RbtnRettangolo_CheckedChanged(object sender, EventArgs e)
        {
            ActivateElements();
            if (rbtnRettangolo.Checked)
            {
                flag = 4;
            }
        }

        private void RbtnTriangolo_CheckedChanged(object sender, EventArgs e)
        {
            ActivateElements();
            if (rbtnTriangolo.Checked)
            {
                flag = 3;
            }
        }

        private void RbtnPentagono_CheckedChanged(object sender, EventArgs e)
        {
            ActivateElements();
            if (rbtnPentagono.Checked)
            {
                flag = 5;
            }
        }

       


        private void ActivateElements()
        {
            if (rbtnCerchio.Checked)
            {
                txtRaggio.Enabled = true;
                txtBase.Enabled = false;
                txtBase.Text = "";
                txtAltezza.Enabled = false;
                txtAltezza.Text = "";
                txtLato.Enabled = false;
                txtLato.Text = "";
            }
            else if (rbtnRettangolo.Checked || rbtnTriangolo.Checked)
            {
                txtRaggio.Enabled = false;
                txtRaggio.Text = "";
                txtBase.Enabled = true;
                txtAltezza.Enabled = true;
                txtLato.Enabled = false;
                txtLato.Text = "";
            }
            else if (rbtnQuadrato.Checked || rbtnPentagono.Checked || rbtnEsagono.Checked)
            {
                txtRaggio.Enabled = false;
                txtRaggio.Text = "";
                txtBase.Enabled = false;
                txtBase.Text = "";
                txtAltezza.Enabled = false;
                txtAltezza.Text = "";
                txtLato.Enabled = true;
            }
        }

        private void LblBase_Click(object sender, EventArgs e)
        {

        }

        private void txtRaggio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
