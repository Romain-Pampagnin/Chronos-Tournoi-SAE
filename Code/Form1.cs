using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbitrageTournoiSAE
{
    public partial class Form1 : Form
    {
        private bool timeIsRunning;
        private int time;
        private DataTable participants;
        SQLiteConnection cx;
        public Form1()
        {
            InitializeComponent();
            timeIsRunning = false;
            participants = new DataTable();
            participants.Columns.Add("nom", typeof(string));
            participants.Columns.Add("temps", typeof(int));

            //connection à la BDD
            string path = Directory.GetCurrentDirectory();
            string adresseBDD = "Data Source =" +path + "\\BDD\\bddTournoiSAE.db";
            this.cx = new SQLiteConnection(adresseBDD);
            cx.Open();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //setup l'image de fond du flowLayoutPanel
            string path = Directory.GetCurrentDirectory();
            Image backFlow = new Bitmap(path + "\\Images\\panel_background.jpg");
            flp_participants.BackgroundImage = backFlow;
            //setup image stonks
            pct_stonks.ImageLocation = path + "\\Images\\confused_stonks.jpg";
            pct_stonks.SizeMode = PictureBoxSizeMode.StretchImage;

            //gestion du timer de temps
            this.time = 0;
            lbl_compteurTemps.Text = this.time.ToString();
            Timer compteurGlobal = new Timer();
            compteurGlobal.Interval = 1000;
            compteurGlobal.Tick += ajouteSeconde;
            compteurGlobal.Start();

            //gestion du timer d'update de la base de données
            Timer compteurBDD = new Timer();
            compteurBDD.Interval = 10000;
            compteurBDD.Tick += updateBDD;
            compteurBDD.Start();

            //importer les participants de la BDD si existants
            string sql = @"SELECT * FROM participant";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, this.cx);
            da.Fill(participants);
            foreach (DataRow dr in participants.Rows) {
                ucParticipant newContenderUC = new ucParticipant(dr["nom"].ToString(), Convert.ToInt32(dr["temps"]));   
                flp_participants.Controls.Add(newContenderUC);
            }

            //debug
            dgv_debug.DataSource = participants;

            cx.Close();
        }

        private void ajouteSeconde(object sender, EventArgs e) {
            if (timeIsRunning)
            {
                this.time ++;
                lbl_compteurTemps.Text = updateTemps(time);
            }
        }

        private string updateTemps(int temps) {
            TimeSpan time = TimeSpan.FromSeconds(temps);
            return time.ToString(@"hh\:mm\:ss");

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            timeIsRunning = true;
            pnl_compteurTemps.BackColor = Color.FromArgb(0,150,10);
            foreach (ucParticipant participant in flp_participants.Controls) {
                if (!participant.isPaused())
                {
                    participant.setStatusOn();
                }
                participant.reactivateButtons();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timeIsRunning = false;
            pnl_compteurTemps.BackColor = Color.FromArgb(190, 40, 40);
            foreach (ucParticipant participant in flp_participants.Controls)
            {
                participant.setStatusOff();
                participant.deactivateButtons();
            }
        }

        private void btn_ajouterParticipant_Click(object sender, EventArgs e)
        {
            if (txt_nomParticipant.Text.Length > 0)
            {
                DataRow[] existe = participants.Select("nom= '" + txt_nomParticipant.Text + "'");
                if (existe.Length == 0)
                {
                    ucParticipant newContender = new ucParticipant(txt_nomParticipant.Text, 0);
                    flp_participants.Controls.Add(newContender);
                    DataRow newContenderRow = participants.NewRow();
                    newContenderRow["nom"] = txt_nomParticipant.Text;
                    newContenderRow["temps"] = 0;
                    participants.Rows.Add(newContenderRow);
                    txt_nomParticipant.Text = string.Empty;
                }
            }
            
        }
        private void btn_updateBDD_Click(object sender, EventArgs e)
        {
            updateBDD(sender, e);
        }

        private void updateBDD(object sender, EventArgs e) {
            this.cx.Open();
            //faire une transaction pour ajouter les membres
            SQLiteTransaction transaction = this.cx.BeginTransaction();
            try
            {
                foreach (ucParticipant participant in flp_participants.Controls)
                {
                    //vérifier si le participant existe dans la BDD
                    string sql = "SELECT temps FROM participant WHERE nom ='" + participant.getNom() + "';";
                    SQLiteDataAdapter da = new SQLiteDataAdapter(sql, this.cx);
                    DataTable retour = new DataTable();
                    da.Fill(retour);
                    //si le participant existe dans la BDD -> mettre à jour son temps
                    if (retour.Rows.Count > 0)
                    {
                        string sql2 = @"UPDATE participant SET temps =" + participant.getTemps() + " WHERE nom='" + participant.getNom() + "';";
                        SQLiteCommand cmd2 = new SQLiteCommand(sql2, this.cx);
                        cmd2.Transaction = transaction;
                        cmd2.ExecuteNonQuery();
                    }
                    //sinon, créer un nouveau participant et remplir son temps
                    else
                    {
                        string sql3 = @"INSERT INTO participant VALUES('" + participant.getNom() + "'," + participant.getTemps() + ");";
                        SQLiteCommand cmd3 = new SQLiteCommand(sql3, this.cx);
                        cmd3.Transaction = transaction;
                        cmd3.ExecuteNonQuery();
                    }
                }
                transaction.Commit();
               
            }
            catch (SQLiteException error)
            {
                transaction.Rollback();
                MessageBox.Show(error.Message);
            }
            cx.Close();
        }

        private void btn_leatherBoard_Click(object sender, EventArgs e)
        {
            updateBDD(sender, e);

            this.cx.Open();

            string sql = @"SELECT * FROM participant ORDER BY temps DESC;";
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, this.cx);
            DataTable classementTable = new DataTable();
            da.Fill(classementTable);
            LeatherBoard classement = new LeatherBoard(classementTable);
            classement.Show();

            cx.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            updateBDD(sender, e);
            this.Close();
        }
    }
}
