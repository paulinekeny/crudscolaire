namespace crudscolaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbspecialite = new System.Windows.Forms.ComboBox();
            this.cmbniveau = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnenreg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btneffacer = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ajout Class";
            // 
            // cmbspecialite
            // 
            this.cmbspecialite.FormattingEnabled = true;
            this.cmbspecialite.Items.AddRange(new object[] {
            "IAGE",
            "GL",
            "FC",
            "RI"});
            this.cmbspecialite.Location = new System.Drawing.Point(141, 160);
            this.cmbspecialite.Name = "cmbspecialite";
            this.cmbspecialite.Size = new System.Drawing.Size(121, 24);
            this.cmbspecialite.TabIndex = 1;
            // 
            // cmbniveau
            // 
            this.cmbniveau.FormattingEnabled = true;
            this.cmbniveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2"});
            this.cmbniveau.Location = new System.Drawing.Point(141, 244);
            this.cmbniveau.Name = "cmbniveau";
            this.cmbniveau.Size = new System.Drawing.Size(121, 24);
            this.cmbniveau.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "niveau";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "specialite";
            // 
            // btnenreg
            // 
            this.btnenreg.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnenreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenreg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnenreg.Location = new System.Drawing.Point(16, 323);
            this.btnenreg.Name = "btnenreg";
            this.btnenreg.Size = new System.Drawing.Size(78, 34);
            this.btnenreg.TabIndex = 5;
            this.btnenreg.Text = "Enreg";
            this.btnenreg.UseVisualStyleBackColor = false;
            this.btnenreg.Click += new System.EventHandler(this.btnenreg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(300, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(500, 302);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifier.Location = new System.Drawing.Point(155, 323);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(107, 34);
            this.btnmodifier.TabIndex = 24;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnsuprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsuprimer.Location = new System.Drawing.Point(155, 384);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(107, 35);
            this.btnsuprimer.TabIndex = 23;
            this.btnsuprimer.Text = "Suprimer";
            this.btnsuprimer.UseVisualStyleBackColor = false;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btneffacer
            // 
            this.btneffacer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btneffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneffacer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btneffacer.Location = new System.Drawing.Point(12, 384);
            this.btneffacer.Name = "btneffacer";
            this.btneffacer.Size = new System.Drawing.Size(82, 35);
            this.btneffacer.TabIndex = 22;
            this.btneffacer.Text = "Effacer";
            this.btneffacer.UseVisualStyleBackColor = false;
            this.btneffacer.Click += new System.EventHandler(this.btneffacer_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(85, 92);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(177, 22);
            this.txtid.TabIndex = 25;
            this.txtid.Visible = false;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(870, 498);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btneffacer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnenreg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbniveau);
            this.Controls.Add(this.cmbspecialite);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbspecialite;
        private System.Windows.Forms.ComboBox cmbniveau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnenreg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btneffacer;
        private System.Windows.Forms.TextBox txtid;
    }
}

