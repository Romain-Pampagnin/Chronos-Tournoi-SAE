namespace ArbitrageTournoiSAE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flp_participants = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.pnl_compteurTemps = new System.Windows.Forms.Panel();
            this.lbl_compteurTemps = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.txt_nomParticipant = new System.Windows.Forms.TextBox();
            this.lbl_ajouterParticipant = new System.Windows.Forms.Label();
            this.btn_ajouterParticipant = new System.Windows.Forms.Button();
            this.dgv_debug = new System.Windows.Forms.DataGridView();
            this.btn_updateBDD = new System.Windows.Forms.Button();
            this.btn_leatherBoard = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pct_stonks = new System.Windows.Forms.PictureBox();
            this.pnl_compteurTemps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debug)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_stonks)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_participants
            // 
            this.flp_participants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_participants.AutoScroll = true;
            this.flp_participants.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_participants.Location = new System.Drawing.Point(15, 166);
            this.flp_participants.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.flp_participants.Name = "flp_participants";
            this.flp_participants.Size = new System.Drawing.Size(1068, 316);
            this.flp_participants.TabIndex = 0;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("ArcadeClassic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(16, 21);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(606, 34);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Tournoi  de  SAE  de  grosses  legendes";
            // 
            // pnl_compteurTemps
            // 
            this.pnl_compteurTemps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_compteurTemps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_compteurTemps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_compteurTemps.Controls.Add(this.lbl_compteurTemps);
            this.pnl_compteurTemps.Location = new System.Drawing.Point(876, 12);
            this.pnl_compteurTemps.Name = "pnl_compteurTemps";
            this.pnl_compteurTemps.Size = new System.Drawing.Size(207, 43);
            this.pnl_compteurTemps.TabIndex = 2;
            // 
            // lbl_compteurTemps
            // 
            this.lbl_compteurTemps.AutoSize = true;
            this.lbl_compteurTemps.BackColor = System.Drawing.Color.Transparent;
            this.lbl_compteurTemps.Location = new System.Drawing.Point(53, 7);
            this.lbl_compteurTemps.Name = "lbl_compteurTemps";
            this.lbl_compteurTemps.Size = new System.Drawing.Size(102, 28);
            this.lbl_compteurTemps.TabIndex = 3;
            this.lbl_compteurTemps.Text = "label1";
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Font = new System.Drawing.Font("ArcadeClassic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(739, 15);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(57, 37);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "►";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.Location = new System.Drawing.Point(802, 15);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(57, 37);
            this.btn_stop.TabIndex = 4;
            this.btn_stop.Text = "■";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // txt_nomParticipant
            // 
            this.txt_nomParticipant.Location = new System.Drawing.Point(22, 97);
            this.txt_nomParticipant.Name = "txt_nomParticipant";
            this.txt_nomParticipant.Size = new System.Drawing.Size(225, 35);
            this.txt_nomParticipant.TabIndex = 5;
            // 
            // lbl_ajouterParticipant
            // 
            this.lbl_ajouterParticipant.AutoSize = true;
            this.lbl_ajouterParticipant.Font = new System.Drawing.Font("ArcadeClassic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ajouterParticipant.ForeColor = System.Drawing.Color.White;
            this.lbl_ajouterParticipant.Location = new System.Drawing.Point(17, 73);
            this.lbl_ajouterParticipant.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ajouterParticipant.Name = "lbl_ajouterParticipant";
            this.lbl_ajouterParticipant.Size = new System.Drawing.Size(271, 20);
            this.lbl_ajouterParticipant.TabIndex = 6;
            this.lbl_ajouterParticipant.Text = "Ajouter  un.e  participant.e";
            // 
            // btn_ajouterParticipant
            // 
            this.btn_ajouterParticipant.Location = new System.Drawing.Point(262, 99);
            this.btn_ajouterParticipant.Name = "btn_ajouterParticipant";
            this.btn_ajouterParticipant.Size = new System.Drawing.Size(75, 29);
            this.btn_ajouterParticipant.TabIndex = 0;
            this.btn_ajouterParticipant.Text = "ADD";
            this.btn_ajouterParticipant.UseVisualStyleBackColor = true;
            this.btn_ajouterParticipant.Click += new System.EventHandler(this.btn_ajouterParticipant_Click);
            // 
            // dgv_debug
            // 
            this.dgv_debug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_debug.Location = new System.Drawing.Point(21, 361);
            this.dgv_debug.Name = "dgv_debug";
            this.dgv_debug.RowHeadersWidth = 51;
            this.dgv_debug.RowTemplate.Height = 24;
            this.dgv_debug.Size = new System.Drawing.Size(240, 150);
            this.dgv_debug.TabIndex = 0;
            this.dgv_debug.Visible = false;
            // 
            // btn_updateBDD
            // 
            this.btn_updateBDD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_updateBDD.Location = new System.Drawing.Point(739, 73);
            this.btn_updateBDD.Name = "btn_updateBDD";
            this.btn_updateBDD.Size = new System.Drawing.Size(97, 81);
            this.btn_updateBDD.TabIndex = 7;
            this.btn_updateBDD.Text = "Update  BDD";
            this.btn_updateBDD.UseVisualStyleBackColor = true;
            this.btn_updateBDD.Click += new System.EventHandler(this.btn_updateBDD_Click);
            // 
            // btn_leatherBoard
            // 
            this.btn_leatherBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_leatherBoard.Location = new System.Drawing.Point(626, 73);
            this.btn_leatherBoard.Name = "btn_leatherBoard";
            this.btn_leatherBoard.Size = new System.Drawing.Size(107, 81);
            this.btn_leatherBoard.TabIndex = 8;
            this.btn_leatherBoard.Text = "LeatherBoard";
            this.btn_leatherBoard.UseVisualStyleBackColor = true;
            this.btn_leatherBoard.Click += new System.EventHandler(this.btn_leatherBoard_Click);
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.Font = new System.Drawing.Font("ArcadeClassic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(993, 490);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(90, 31);
            this.btn_close.TabIndex = 9;
            this.btn_close.Text = "Quitter";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pct_stonks
            // 
            this.pct_stonks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pct_stonks.Location = new System.Drawing.Point(876, 61);
            this.pct_stonks.Name = "pct_stonks";
            this.pct_stonks.Size = new System.Drawing.Size(207, 97);
            this.pct_stonks.TabIndex = 0;
            this.pct_stonks.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1098, 533);
            this.Controls.Add(this.pct_stonks);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_leatherBoard);
            this.Controls.Add(this.btn_updateBDD);
            this.Controls.Add(this.btn_ajouterParticipant);
            this.Controls.Add(this.dgv_debug);
            this.Controls.Add(this.lbl_ajouterParticipant);
            this.Controls.Add(this.txt_nomParticipant);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pnl_compteurTemps);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.flp_participants);
            this.Font = new System.Drawing.Font("ArcadeClassic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_compteurTemps.ResumeLayout(false);
            this.pnl_compteurTemps.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debug)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_stonks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_participants;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Panel pnl_compteurTemps;
        private System.Windows.Forms.Label lbl_compteurTemps;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_ajouterParticipant;
        private System.Windows.Forms.TextBox txt_nomParticipant;
        private System.Windows.Forms.Label lbl_ajouterParticipant;
        private System.Windows.Forms.DataGridView dgv_debug;
        private System.Windows.Forms.Button btn_updateBDD;
        private System.Windows.Forms.Button btn_leatherBoard;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.PictureBox pct_stonks;
    }
}

