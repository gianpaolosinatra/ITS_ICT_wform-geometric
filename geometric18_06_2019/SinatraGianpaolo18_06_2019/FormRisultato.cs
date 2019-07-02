using System;
using System.Windows.Forms;
using SinatraGianpaolo18_06_2019.classes;
namespace SinatraGianpaolo18_06_2019
{
    public partial class FormRisultato : Form
    {
        private double _area = 0;
        private string _risultato = "";
        private bool flag3d = false;

        public FormRisultato(string risultato, double area)
        {
            _area = area;
            _risultato = risultato;
            InitializeComponent();
            lblRisultato.Text = risultato;
        }


        private void FormRisultato_Load(object sender, EventArgs e)
        {
            
        }

        private void btn3dMod_Click(object sender, EventArgs e)
        {
            flag3d = !flag3d;
            SwitchVolumeItems();

        }

        private void SwitchVolumeItems()
        {
            if (flag3d)
            {
                lblAltezzaV.Visible = true;
                txtAltezzaV.Visible = true;
                btnAltezzaV.Visible = true;
            }
            else
            {
                lblAltezzaV.Visible = false;
                txtAltezzaV.Visible = false;
                txtAltezzaV.Text = "";
                btnAltezzaV.Visible = false;
            }

        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            double altezzaV = G3D.GetDouble(txtAltezzaV.Text);
            if (txtAltezzaV.Text == "")
                MessageBox.Show("Inserisci l' ALTEZZA del solido prima di continuare.");
            else
            {
                lblRisultato.Text = _risultato + 
                "\n Altezza Solido: " + txtAltezzaV.Text +
                "\n Volume: " +
                G3D.CalcoloVolume(_area, Double.Parse(txtAltezzaV.Text)).ToString();
                txtAltezzaV.Text = "";
            }
        }




    }
}
