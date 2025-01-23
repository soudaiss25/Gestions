namespace Gestions
{
    partial class FmProprietaire
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
            this.dgProprietaire = new System.Windows.Forms.DataGridView();
            this.tfPrenom = new System.Windows.Forms.TextBox();
            this.tfNinea = new System.Windows.Forms.TextBox();
            this.tfCni = new System.Windows.Forms.TextBox();
            this.tfEmail = new System.Windows.Forms.TextBox();
            this.tf_Telphone = new System.Windows.Forms.TextBox();
            this.tfNom = new System.Windows.Forms.TextBox();
            this.tf_prenom = new System.Windows.Forms.Label();
            this.tf_nom = new System.Windows.Forms.Label();
            this.tf_telephone = new System.Windows.Forms.Label();
            this.tf_email = new System.Windows.Forms.Label();
            this.tf_CNI = new System.Windows.Forms.Label();
            this.tf_ninea = new System.Windows.Forms.Label();
            this.tfRccn = new System.Windows.Forms.TextBox();
            this.tf_rccn = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnChoisir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProprietaire)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProprietaire
            // 
            this.dgProprietaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProprietaire.Location = new System.Drawing.Point(334, 45);
            this.dgProprietaire.Name = "dgProprietaire";
            this.dgProprietaire.RowHeadersWidth = 62;
            this.dgProprietaire.RowTemplate.Height = 28;
            this.dgProprietaire.Size = new System.Drawing.Size(612, 579);
            this.dgProprietaire.TabIndex = 0;
            this.dgProprietaire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgProprietaire_CellContentClick);
            // 
            // tfPrenom
            // 
            this.tfPrenom.Location = new System.Drawing.Point(22, 71);
            this.tfPrenom.Name = "tfPrenom";
            this.tfPrenom.Size = new System.Drawing.Size(214, 26);
            this.tfPrenom.TabIndex = 1;
            this.tfPrenom.TextChanged += new System.EventHandler(this.tfPrenom_TextChanged);
            // 
            // tfNinea
            // 
            this.tfNinea.Location = new System.Drawing.Point(22, 435);
            this.tfNinea.Name = "tfNinea";
            this.tfNinea.Size = new System.Drawing.Size(208, 26);
            this.tfNinea.TabIndex = 2;
            this.tfNinea.TextChanged += new System.EventHandler(this.tfNinea_TextChanged);
            // 
            // tfCni
            // 
            this.tfCni.Location = new System.Drawing.Point(22, 353);
            this.tfCni.Name = "tfCni";
            this.tfCni.Size = new System.Drawing.Size(214, 26);
            this.tfCni.TabIndex = 3;
            this.tfCni.TextChanged += new System.EventHandler(this.tfCni_TextChanged);
            // 
            // tfEmail
            // 
            this.tfEmail.Location = new System.Drawing.Point(22, 286);
            this.tfEmail.Name = "tfEmail";
            this.tfEmail.Size = new System.Drawing.Size(214, 26);
            this.tfEmail.TabIndex = 4;
            this.tfEmail.TextChanged += new System.EventHandler(this.tfEmail_TextChanged);
            // 
            // tf_Telphone
            // 
            this.tf_Telphone.Location = new System.Drawing.Point(22, 220);
            this.tf_Telphone.Name = "tf_Telphone";
            this.tf_Telphone.Size = new System.Drawing.Size(214, 26);
            this.tf_Telphone.TabIndex = 5;
            this.tf_Telphone.TextChanged += new System.EventHandler(this.tf_Telphone_TextChanged);
            // 
            // tfNom
            // 
            this.tfNom.Location = new System.Drawing.Point(22, 150);
            this.tfNom.Name = "tfNom";
            this.tfNom.Size = new System.Drawing.Size(214, 26);
            this.tfNom.TabIndex = 6;
            this.tfNom.TextChanged += new System.EventHandler(this.tfNom_TextChanged);
            // 
            // tf_prenom
            // 
            this.tf_prenom.AutoSize = true;
            this.tf_prenom.Location = new System.Drawing.Point(22, 45);
            this.tf_prenom.Name = "tf_prenom";
            this.tf_prenom.Size = new System.Drawing.Size(64, 20);
            this.tf_prenom.TabIndex = 7;
            this.tf_prenom.Text = "Prenom";
            // 
            // tf_nom
            // 
            this.tf_nom.AutoSize = true;
            this.tf_nom.Location = new System.Drawing.Point(18, 127);
            this.tf_nom.Name = "tf_nom";
            this.tf_nom.Size = new System.Drawing.Size(42, 20);
            this.tf_nom.TabIndex = 8;
            this.tf_nom.Text = "Nom";
            // 
            // tf_telephone
            // 
            this.tf_telephone.AutoSize = true;
            this.tf_telephone.Location = new System.Drawing.Point(22, 197);
            this.tf_telephone.Name = "tf_telephone";
            this.tf_telephone.Size = new System.Drawing.Size(84, 20);
            this.tf_telephone.TabIndex = 9;
            this.tf_telephone.Text = "Telephone";
            // 
            // tf_email
            // 
            this.tf_email.AutoSize = true;
            this.tf_email.Location = new System.Drawing.Point(22, 263);
            this.tf_email.Name = "tf_email";
            this.tf_email.Size = new System.Drawing.Size(48, 20);
            this.tf_email.TabIndex = 10;
            this.tf_email.Text = "Email";
            // 
            // tf_CNI
            // 
            this.tf_CNI.AutoSize = true;
            this.tf_CNI.Location = new System.Drawing.Point(22, 330);
            this.tf_CNI.Name = "tf_CNI";
            this.tf_CNI.Size = new System.Drawing.Size(36, 20);
            this.tf_CNI.TabIndex = 11;
            this.tf_CNI.Text = "CNI";
            // 
            // tf_ninea
            // 
            this.tf_ninea.AutoSize = true;
            this.tf_ninea.Location = new System.Drawing.Point(18, 412);
            this.tf_ninea.Name = "tf_ninea";
            this.tf_ninea.Size = new System.Drawing.Size(58, 20);
            this.tf_ninea.TabIndex = 12;
            this.tf_ninea.Text = "NINEA";
            // 
            // tfRccn
            // 
            this.tfRccn.Location = new System.Drawing.Point(22, 513);
            this.tfRccn.Name = "tfRccn";
            this.tfRccn.Size = new System.Drawing.Size(208, 26);
            this.tfRccn.TabIndex = 13;
            this.tfRccn.TextChanged += new System.EventHandler(this.tfRccn_TextChanged);
            // 
            // tf_rccn
            // 
            this.tf_rccn.AutoSize = true;
            this.tf_rccn.Location = new System.Drawing.Point(18, 487);
            this.tf_rccn.Name = "tf_rccn";
            this.tf_rccn.Size = new System.Drawing.Size(54, 20);
            this.tf_rccn.TabIndex = 14;
            this.tf_rccn.Text = "RCCN";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(236, 569);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 33);
            this.btnSupprimer.TabIndex = 15;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(120, 569);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(92, 33);
            this.btnModifier.TabIndex = 16;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(7, 569);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(92, 33);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(351, 6);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(92, 33);
            this.btnChoisir.TabIndex = 18;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // FmProprietaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 636);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.tf_rccn);
            this.Controls.Add(this.tfRccn);
            this.Controls.Add(this.tf_ninea);
            this.Controls.Add(this.tf_CNI);
            this.Controls.Add(this.tf_email);
            this.Controls.Add(this.tf_telephone);
            this.Controls.Add(this.tf_nom);
            this.Controls.Add(this.tf_prenom);
            this.Controls.Add(this.tfNom);
            this.Controls.Add(this.tf_Telphone);
            this.Controls.Add(this.tfEmail);
            this.Controls.Add(this.tfCni);
            this.Controls.Add(this.tfNinea);
            this.Controls.Add(this.tfPrenom);
            this.Controls.Add(this.dgProprietaire);
            this.Name = "FmProprietaire";
            this.Text = "Proprietaire";
            this.Load += new System.EventHandler(this.FmProprietaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProprietaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProprietaire;
        private System.Windows.Forms.TextBox tfPrenom;
        private System.Windows.Forms.TextBox tfNinea;
        private System.Windows.Forms.TextBox tfCni;
        private System.Windows.Forms.TextBox tfEmail;
        private System.Windows.Forms.TextBox tf_Telphone;
        private System.Windows.Forms.TextBox tfNom;
        private System.Windows.Forms.Label tf_prenom;
        private System.Windows.Forms.Label tf_nom;
        private System.Windows.Forms.Label tf_telephone;
        private System.Windows.Forms.Label tf_email;
        private System.Windows.Forms.Label tf_CNI;
        private System.Windows.Forms.Label tf_ninea;
        private System.Windows.Forms.TextBox tfRccn;
        private System.Windows.Forms.Label tf_rccn;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnChoisir;
    }
}