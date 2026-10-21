namespace ArbitrageTournoiSAE
{
    partial class ucParticipant
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.pnl_compteurTemps = new System.Windows.Forms.Panel();
            this.lbl_compteurTemps = new System.Windows.Forms.Label();
            this.pnl_compteurTemps.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.ForeColor = System.Drawing.Color.White;
            this.lbl_nom.Location = new System.Drawing.Point(19, 10);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(88, 23);
            this.lbl_nom.TabIndex = 0;
            this.lbl_nom.Text = "label1";
            // 
            // btn_stop
            // 
            this.btn_stop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_stop.Location = new System.Drawing.Point(194, 53);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(57, 37);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "■";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_start.Font = new System.Drawing.Font("ArcadeClassic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(194, 10);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(57, 37);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "►";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pnl_compteurTemps
            // 
            this.pnl_compteurTemps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_compteurTemps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.pnl_compteurTemps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_compteurTemps.Controls.Add(this.lbl_compteurTemps);
            this.pnl_compteurTemps.Location = new System.Drawing.Point(3, 36);
            this.pnl_compteurTemps.Name = "pnl_compteurTemps";
            this.pnl_compteurTemps.Size = new System.Drawing.Size(185, 55);
            this.pnl_compteurTemps.TabIndex = 7;
            // 
            // lbl_compteurTemps
            // 
            this.lbl_compteurTemps.AutoSize = true;
            this.lbl_compteurTemps.BackColor = System.Drawing.Color.Transparent;
            this.lbl_compteurTemps.ForeColor = System.Drawing.Color.White;
            this.lbl_compteurTemps.Location = new System.Drawing.Point(47, 16);
            this.lbl_compteurTemps.Name = "lbl_compteurTemps";
            this.lbl_compteurTemps.Size = new System.Drawing.Size(88, 23);
            this.lbl_compteurTemps.TabIndex = 3;
            this.lbl_compteurTemps.Text = "label1";
            // 
            // Participant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(60)))), ((int)(((byte)(88)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_compteurTemps);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_nom);
            this.Font = new System.Drawing.Font("ArcadeClassic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Participant";
            this.Size = new System.Drawing.Size(263, 99);
            this.pnl_compteurTemps.ResumeLayout(false);
            this.pnl_compteurTemps.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Panel pnl_compteurTemps;
        private System.Windows.Forms.Label lbl_compteurTemps;
    }
}
