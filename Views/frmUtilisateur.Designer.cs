namespace Gestions.Views
{
    partial class frmUtilisateur
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
            this.nom = new System.Windows.Forms.Label();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prenom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Telephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_chosir = new System.Windows.Forms.Button();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.btn_Contrat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.statutColletcion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(12, 57);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(40, 20);
            this.nom.TabIndex = 0;
            this.nom.Text = "nom";
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(17, 515);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 29);
            this.btn_Ajouter.TabIndex = 1;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(6, 80);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(267, 26);
            this.txtNom.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "email";
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(8, 133);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(64, 20);
            this.prenom.TabIndex = 4;
            this.prenom.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identifiant";
            // 
            // Telephone
            // 
            this.Telephone.AutoSize = true;
            this.Telephone.Location = new System.Drawing.Point(8, 206);
            this.Telephone.Name = "Telephone";
            this.Telephone.Size = new System.Drawing.Size(84, 20);
            this.Telephone.TabIndex = 6;
            this.Telephone.Text = "Telephone";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(12, 229);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(261, 26);
            this.txtTelephone.TabIndex = 7;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(6, 156);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(267, 26);
            this.txtPrenom.TabIndex = 8;
            this.txtPrenom.MouseLeave += new System.EventHandler(this.txtPrenom_MouseLeave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(267, 26);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.MouseLeave += new System.EventHandler(this.txtEmail_MouseLeave);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(6, 392);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(267, 26);
            this.txtIdentifiant.TabIndex = 10;
            this.txtIdentifiant.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtIdentifiant_MouseDown);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(255, 515);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(114, 29);
            this.btn_Supprimer.TabIndex = 11;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(136, 515);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(82, 29);
            this.btn_Modifier.TabIndex = 12;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            // 
            // btn_chosir
            // 
            this.btn_chosir.Location = new System.Drawing.Point(476, 12);
            this.btn_chosir.Name = "btn_chosir";
            this.btn_chosir.Size = new System.Drawing.Size(75, 32);
            this.btn_chosir.TabIndex = 13;
            this.btn_chosir.Text = "choisir";
            this.btn_chosir.UseVisualStyleBackColor = true;
            this.btn_chosir.Click += new System.EventHandler(this.btn_chosir_Click);
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(406, 62);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.RowHeadersWidth = 62;
            this.dgUtilisateur.RowTemplate.Height = 28;
            this.dgUtilisateur.Size = new System.Drawing.Size(606, 532);
            this.dgUtilisateur.TabIndex = 14;
            // 
            // btn_Contrat
            // 
            this.btn_Contrat.Location = new System.Drawing.Point(617, 12);
            this.btn_Contrat.Name = "btn_Contrat";
            this.btn_Contrat.Size = new System.Drawing.Size(75, 32);
            this.btn_Contrat.TabIndex = 15;
            this.btn_Contrat.Text = "contrat";
            this.btn_Contrat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "role";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // statutColletcion
            // 
            this.statutColletcion.FormattingEnabled = true;
            this.statutColletcion.Items.AddRange(new object[] {
            "Admin",
            "Gestionnaire"});
            this.statutColletcion.Location = new System.Drawing.Point(6, 457);
            this.statutColletcion.Name = "statutColletcion";
            this.statutColletcion.Size = new System.Drawing.Size(261, 28);
            this.statutColletcion.TabIndex = 16;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 593);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statutColletcion);
            this.Controls.Add(this.btn_Contrat);
            this.Controls.Add(this.dgUtilisateur);
            this.Controls.Add(this.btn_chosir);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.Telephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.nom);
            this.Name = "frmUtilisateur";
            this.Text = "frmUtilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Telephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_chosir;
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Button btn_Contrat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox statutColletcion;
    }
}