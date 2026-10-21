using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArbitrageTournoiSAE
{
    public partial class LeatherBoard : Form
    {
        public LeatherBoard(DataTable tab)
        {
            InitializeComponent();
            DataTable tabAffichage = new DataTable();
            tabAffichage.Columns.Add("nom", typeof(string));
            tabAffichage.Columns.Add("temps", typeof(string));
            tabAffichage.Columns.Add("tempsSec", typeof(int));
            
            foreach (DataRow dr in tab.Rows)
            {
                DataRow newDr = tabAffichage.NewRow();

                newDr["nom"] = dr["nom"];
                newDr["tempsSec"] = dr["temps"];
                TimeSpan time = TimeSpan.FromSeconds(Convert.ToInt32(dr["temps"]));
                newDr["temps"] = time.ToString(@"hh\:mm\:ss");

                tabAffichage.Rows.Add(newDr);
            }
            dgv_leatherBoard.DataSource = tabAffichage;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
