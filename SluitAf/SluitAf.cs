using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SluitAf
{
    public partial class SluitAf : Form
    {
        private int tijd = 0;
        private string afsluitTijd = "";

        public SluitAf()
        {
            InitializeComponent();
        }

        private void rb5Min_CheckedChanged(object sender, EventArgs e)
        {
            tijd = 300;
            btOk.Enabled = true;
        }

        private void rb10Min_CheckedChanged(object sender, EventArgs e)
        {
            tijd = 600;
            btOk.Enabled = true;
        }

        private void rb30Min_CheckedChanged(object sender, EventArgs e)
        {
            tijd = 1800;
            btOk.Enabled = true;
        }

        private void rb1H_CheckedChanged(object sender, EventArgs e)
        {
            tijd = 3600;
            btOk.Enabled = true;
        }

        private void cbAnders_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAnders.Checked)
            {
                nudMinuten.Visible = true;
                lbMinuten.Visible = true;
                rb5Min.Enabled = false;
                rb10Min.Enabled = false;
                rb30Min.Enabled = false;
                rb1H.Enabled = false;
            }
            else
            {
                nudMinuten.Visible = false;
                lbMinuten.Visible = false;
                rb5Min.Enabled = true;
                rb10Min.Enabled = true;
                rb30Min.Enabled = true;
                rb1H.Enabled = true;
            }
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            if (cbAnders.Checked)
            {
                tijd = (int) nudMinuten.Value * 60;
            }
            Process.Start("shutdown", "/s /t " + tijd);
            btAnnuleren.Enabled = true;
            btOk.Enabled = false;
        }

        private void btAnnuleren_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "-a");
            btOk.Enabled = true;
            btAnnuleren.Enabled = false;
        }

        private void btn_obt_OK_Click(object sender, EventArgs e)
        {
            afsluitTijd = tbTijd.Text;

            timer1.Start();

            string optie = "";

            if (rbAfsluiten.Checked)
            {
                optie = "sluit af";
            }
            else
            {
                optie = "gaat in slaapstand";
            }

            MessageBox.Show("Computer " + optie + " om " + afsluitTijd, "Bericht", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.ToString("HH:mm") == afsluitTijd)
            {
                if (rbAfsluiten.Checked)
                {
                    Process.Start("shutdown", "/s /t 10");
                }
                else
                {
                    Process.Start("shutdown", "/h");
                }
                timer1.Stop();
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bekijkHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Over over = new Over();
            over.Show();
        }

        private void SluitAf_Load(object sender, EventArgs e)
        {
            tbTijd.Text = "10:15";
        }
    }
}