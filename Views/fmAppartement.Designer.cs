namespace Gestions.Views
{
    partial class fmAppartement
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtSurface = new System.Windows.Forms.TextBox();
            this.txtNombrePlace = new System.Windows.Forms.TextBox();
            this.txtCapacite = new System.Windows.Forms.TextBox();
            this.dgAppartement = new System.Windows.Forms.DataGridView();
            this.CbDisponible = new System.Windows.Forms.ComboBox();
            this.CbProprietaire = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnContrat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surface ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de place";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capacite";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Disponible";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Proprietaire";
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(30, 89);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(266, 26);
            this.txtAdresse.TabIndex = 6;
            // 
            // txtSurface
            // 
            this.txtSurface.Location = new System.Drawing.Point(30, 151);
            this.txtSurface.Name = "txtSurface";
            this.txtSurface.Size = new System.Drawing.Size(266, 26);
            this.txtSurface.TabIndex = 7;
            // 
            // txtNombrePlace
            // 
            this.txtNombrePlace.Location = new System.Drawing.Point(30, 222);
            this.txtNombrePlace.Name = "txtNombrePlace";
            this.txtNombrePlace.Size = new System.Drawing.Size(272, 26);
            this.txtNombrePlace.TabIndex = 8;
            // 
            // txtCapacite
            // 
            this.txtCapacite.Location = new System.Drawing.Point(30, 294);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.Size = new System.Drawing.Size(272, 26);
            this.txtCapacite.TabIndex = 9;
            // 
            // dgAppartement
            // 
            this.dgAppartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppartement.Location = new System.Drawing.Point(357, 60);
            this.dgAppartement.Name = "dgAppartement";
            this.dgAppartement.RowHeadersWidth = 62;
            this.dgAppartement.RowTemplate.Height = 28;
            this.dgAppartement.Size = new System.Drawing.Size(644, 631);
            this.dgAppartement.TabIndex = 12;
            // 
            // CbDisponible
            // 
            this.CbDisponible.FormattingEnabled = true;
            this.CbDisponible.Location = new System.Drawing.Point(30, 383);
            this.CbDisponible.Name = "CbDisponible";
            this.CbDisponible.Size = new System.Drawing.Size(272, 28);
            this.CbDisponible.TabIndex = 13;
            // 
            // CbProprietaire
            // 
            this.CbProprietaire.FormattingEnabled = true;
            this.CbProprietaire.Location = new System.Drawing.Point(30, 466);
            this.CbProprietaire.Name = "CbProprietaire";
            this.CbProprietaire.Size = new System.Drawing.Size(266, 28);
            this.CbProprietaire.TabIndex = 14;
            this.CbProprietaire.SelectedIndexChanged += new System.EventHandler(this.CbProprietaire_SelectedIndexChanged);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(-3, 543);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(112, 35);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Location = new System.Drawing.Point(237, 543);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(112, 35);
            this.btnSupp.TabIndex = 16;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(118, 543);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(112, 35);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(370, 17);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(112, 35);
            this.btnChoisir.TabIndex = 18;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click_1);
            // 
            // btnContrat
            // 
            this.btnContrat.Location = new System.Drawing.Point(518, 18);
            this.btnContrat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnContrat.Name = "btnContrat";
            this.btnContrat.Size = new System.Drawing.Size(112, 35);
            this.btnContrat.TabIndex = 19;
            this.btnContrat.Text = "Contrat";
            this.btnContrat.UseVisualStyleBackColor = true;
            this.btnContrat.Click += new System.EventHandler(this.btnContrat_Click);
            // 
            // fmAppartement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 708);
            this.Controls.Add(this.btnContrat);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.CbProprietaire);
            this.Controls.Add(this.CbDisponible);
            this.Controls.Add(this.dgAppartement);
            this.Controls.Add(this.txtCapacite);
            this.Controls.Add(this.txtNombrePlace);
            this.Controls.Add(this.txtSurface);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmAppartement";
            this.Text = "Appartement";
            this.Load += new System.EventHandler(this.fmAppartement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtSurface;
        private System.Windows.Forms.TextBox txtNombrePlace;
        private System.Windows.Forms.TextBox txtCapacite;
        private System.Windows.Forms.DataGridView dgAppartement;
        private System.Windows.Forms.ComboBox CbDisponible;
        private System.Windows.Forms.ComboBox CbProprietaire;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnContrat;
    }
}