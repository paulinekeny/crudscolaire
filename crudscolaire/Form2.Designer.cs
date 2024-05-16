namespace crudscolaire
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtreglement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcredit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtanne = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnvalider = new System.Windows.Forms.Button();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.cmbclasse = new System.Windows.Forms.ComboBox();
            this.txtrechercher = new System.Windows.Forms.TextBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsuprimer = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ajout Etudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(26, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "prénom";
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(95, 76);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(129, 22);
            this.txtprenom.TabIndex = 6;
            // 
            // txtreglement
            // 
            this.txtreglement.Location = new System.Drawing.Point(399, 129);
            this.txtreglement.Name = "txtreglement";
            this.txtreglement.Size = new System.Drawing.Size(129, 22);
            this.txtreglement.TabIndex = 8;
            this.txtreglement.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(277, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "montantverser";
            // 
            // txtcredit
            // 
            this.txtcredit.Location = new System.Drawing.Point(399, 73);
            this.txtcredit.Name = "txtcredit";
            this.txtcredit.Size = new System.Drawing.Size(129, 22);
            this.txtcredit.TabIndex = 10;
            this.txtcredit.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(277, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "crédit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(95, 123);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(129, 22);
            this.txtnom.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(26, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "nom";
            // 
            // txtanne
            // 
            this.txtanne.Location = new System.Drawing.Point(659, 76);
            this.txtanne.Name = "txtanne";
            this.txtanne.Size = new System.Drawing.Size(129, 22);
            this.txtanne.TabIndex = 14;
            this.txtanne.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(557, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "année scolaire";
            // 
            // btnvalider
            // 
            this.btnvalider.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnvalider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalider.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnvalider.Location = new System.Drawing.Point(29, 158);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(102, 36);
            this.btnvalider.TabIndex = 15;
            this.btnvalider.Text = "valider";
            this.btnvalider.UseVisualStyleBackColor = false;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // dGV1
            // 
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(1, 222);
            this.dGV1.Name = "dGV1";
            this.dGV1.RowHeadersWidth = 51;
            this.dGV1.RowTemplate.Height = 24;
            this.dGV1.Size = new System.Drawing.Size(799, 228);
            this.dGV1.TabIndex = 16;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(86, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 22);
            this.txtid.TabIndex = 47;
            this.txtid.Visible = false;
            // 
            // cmbclasse
            // 
            this.cmbclasse.FormattingEnabled = true;
            this.cmbclasse.Location = new System.Drawing.Point(622, 152);
            this.cmbclasse.Name = "cmbclasse";
            this.cmbclasse.Size = new System.Drawing.Size(129, 24);
            this.cmbclasse.TabIndex = 46;
            this.cmbclasse.SelectedIndexChanged += new System.EventHandler(this.cmbclasse_SelectedIndexChanged);
            // 
            // txtrechercher
            // 
            this.txtrechercher.Location = new System.Drawing.Point(622, 182);
            this.txtrechercher.Name = "txtrechercher";
            this.txtrechercher.Size = new System.Drawing.Size(129, 22);
            this.txtrechercher.TabIndex = 45;
            // 
            // btnmodifier
            // 
            this.btnmodifier.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnmodifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifier.Location = new System.Drawing.Point(177, 158);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(102, 36);
            this.btnmodifier.TabIndex = 44;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = false;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnsuprimer
            // 
            this.btnsuprimer.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnsuprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuprimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsuprimer.Location = new System.Drawing.Point(321, 158);
            this.btnsuprimer.Name = "btnsuprimer";
            this.btnsuprimer.Size = new System.Drawing.Size(102, 36);
            this.btnsuprimer.TabIndex = 43;
            this.btnsuprimer.Text = "Suprimer";
            this.btnsuprimer.UseVisualStyleBackColor = false;
            this.btnsuprimer.Click += new System.EventHandler(this.btnsuprimer_Click);
            // 
            // btnrechercher
            // 
            this.btnrechercher.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnrechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechercher.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnrechercher.Location = new System.Drawing.Point(470, 158);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(120, 36);
            this.btnrechercher.TabIndex = 42;
            this.btnrechercher.Text = "Rechercher";
            this.btnrechercher.UseVisualStyleBackColor = false;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 228);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.cmbclasse);
            this.Controls.Add(this.txtrechercher);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.btnsuprimer);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.btnvalider);
            this.Controls.Add(this.txtanne);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcredit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtreglement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtreglement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcredit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtanne;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.ComboBox cmbclasse;
        private System.Windows.Forms.TextBox txtrechercher;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnsuprimer;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}