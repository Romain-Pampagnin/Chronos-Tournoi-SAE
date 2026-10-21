using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ArbitrageTournoiSAE
{
    public partial class ucParticipant : UserControl
    {
        private string nom;
        private bool timeIsRunning;
        private int time;
        private bool enPause;
        public ucParticipant(string inNom, int inTemps)
        {
            InitializeComponent();
            nom = inNom;
            time = inTemps;
            lbl_nom.Text = nom;
            lbl_compteurTemps.Text = updateTemps(time);
            enPause = false;


            lbl_compteurTemps.Text = this.time.ToString();
            Timer compteurGlobal = new Timer();
            compteurGlobal.Interval = 1000;
            compteurGlobal.Tick += ajouteSeconde;
            compteurGlobal.Start();
        }

        private void ajouteSeconde(object sender, EventArgs e)
        {
            if (timeIsRunning)
            {
                this.time++;
                lbl_compteurTemps.Text = updateTemps(time);
            }
        }

        private string updateTemps(int temps)
        {
            TimeSpan time = TimeSpan.FromSeconds(temps);
            return time.ToString(@"hh\:mm\:ss");

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timeIsRunning = true;
            pnl_compteurTemps.BackColor = Color.FromArgb(0, 150, 10);
            enPause = false;
            lbl_nom.Text = nom;
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timeIsRunning = false;
            pnl_compteurTemps.BackColor = Color.FromArgb(190, 40, 40);
            enPause = true;
            lbl_nom.Text = nom + " (en pause)";
        }

        public void setStatusOn()
        {
            this.timeIsRunning = true;
            pnl_compteurTemps.BackColor = Color.FromArgb(0, 150, 10);
        }

        public void setStatusOff()
        {
            this.timeIsRunning = false;
            pnl_compteurTemps.BackColor = Color.FromArgb(190, 40, 40);
        }

        public bool isPaused() {
            return enPause;
        }

        public void deactivateButtons() { 
            this.btn_start.Enabled = false;
            this.btn_stop.Enabled = false;
        }

        public void reactivateButtons()
        {
            this.btn_start.Enabled = true;
            this.btn_stop.Enabled = true;
        }

        public string getNom() {
            return this.nom;
        }

        public int getTemps()
        {
            return this.time;
        }
    }
}
