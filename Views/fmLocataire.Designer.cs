namespace Gestions.Views
{
    partial class fmLocataire
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
            this.btnChoisir = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.tf_ninea = new System.Windows.Forms.Label();
            this.tf_email = new System.Windows.Forms.Label();
            this.tf_telephone = new System.Windows.Forms.Label();
            this.tf_nom = new System.Windows.Forms.Label();
            this.tf_prenom = new System.Windows.Forms.Label();
            this.tfNom = new System.Windows.Forms.TextBox();
            this.tf_Telphone = new System.Windows.Forms.TextBox();
            this.tfEmail = new System.Windows.Forms.TextBox();
            this.tfCni = new System.Windows.Forms.TextBox();
            this.tfPrenom = new System.Windows.Forms.TextBox();
            this.dgLocataire = new System.Windows.Forms.DataGridView();
            this.btn_Contrat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgLocataire)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(393, 52);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(92, 32);
            this.btnChoisir.TabIndex = 35;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            this.btnChoisir.Click += new System.EventHandler(this.btnChoisir_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(50, 615);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(92, 32);
            this.btnAjouter.TabIndex = 34;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(162, 615);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(92, 32);
            this.btnModifier.TabIndex = 33;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(278, 615);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(92, 32);
            this.btnSupprimer.TabIndex = 32;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // tf_ninea
            // 
            this.tf_ninea.AutoSize = true;
            this.tf_ninea.Location = new System.Drawing.Point(66, 382);
            this.tf_ninea.Name = "tf_ninea";
            this.tf_ninea.Size = new System.Drawing.Size(36, 20);
            this.tf_ninea.TabIndex = 29;
            this.tf_ninea.Text = "CNI";
            // 
            // tf_email
            // 
            this.tf_email.AutoSize = true;
            this.tf_email.Location = new System.Drawing.Point(64, 309);
            this.tf_email.Name = "tf_email";
            this.tf_email.Size = new System.Drawing.Size(48, 20);
            this.tf_email.TabIndex = 28;
            this.tf_email.Text = "Email";
            // 
            // tf_telephone
            // 
            this.tf_telephone.AutoSize = true;
            this.tf_telephone.Location = new System.Drawing.Point(64, 243);
            this.tf_telephone.Name = "tf_telephone";
            this.tf_telephone.Size = new System.Drawing.Size(84, 20);
            this.tf_telephone.TabIndex = 27;
            this.tf_telephone.Text = "Telephone";
            // 
            // tf_nom
            // 
            this.tf_nom.AutoSize = true;
            this.tf_nom.Location = new System.Drawing.Point(60, 174);
            this.tf_nom.Name = "tf_nom";
            this.tf_nom.Size = new System.Drawing.Size(42, 20);
            this.tf_nom.TabIndex = 26;
            this.tf_nom.Text = "Nom";
            // 
            // tf_prenom
            // 
            this.tf_prenom.AutoSize = true;
            this.tf_prenom.Location = new System.Drawing.Point(64, 91);
            this.tf_prenom.Name = "tf_prenom";
            this.tf_prenom.Size = new System.Drawing.Size(64, 20);
            this.tf_prenom.TabIndex = 25;
            this.tf_prenom.Text = "Prenom";
            // 
            // tfNom
            // 
            this.tfNom.Location = new System.Drawing.Point(64, 197);
            this.tfNom.Name = "tfNom";
            this.tfNom.Size = new System.Drawing.Size(214, 26);
            this.tfNom.TabIndex = 24;
            // 
            // tf_Telphone
            // 
            this.tf_Telphone.Location = new System.Drawing.Point(64, 266);
            this.tf_Telphone.Name = "tf_Telphone";
            this.tf_Telphone.Size = new System.Drawing.Size(214, 26);
            this.tf_Telphone.TabIndex = 23;
            // 
            // tfEmail
            // 
            this.tfEmail.Location = new System.Drawing.Point(64, 332);
            this.tfEmail.Name = "tfEmail";
            this.tfEmail.Size = new System.Drawing.Size(214, 26);
            this.tfEmail.TabIndex = 22;
            // 
            // tfCni
            // 
            this.tfCni.Location = new System.Drawing.Point(64, 405);
            this.tfCni.Name = "tfCni";
            this.tfCni.Size = new System.Drawing.Size(208, 26);
            this.tfCni.TabIndex = 21;
            // 
            // tfPrenom
            // 
            this.tfPrenom.Location = new System.Drawing.Point(64, 117);
            this.tfPrenom.Name = "tfPrenom";
            this.tfPrenom.Size = new System.Drawing.Size(214, 26);
            this.tfPrenom.TabIndex = 20;
            // 
            // dgLocataire
            // 
            this.dgLocataire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLocataire.Location = new System.Drawing.Point(376, 91);
            this.dgLocataire.Name = "dgLocataire";
            this.dgLocataire.RowHeadersWidth = 62;
            this.dgLocataire.RowTemplate.Height = 28;
            this.dgLocataire.Size = new System.Drawing.Size(612, 578);
            this.dgLocataire.TabIndex = 19;
            // 
            // btn_Contrat
            // 
            this.btn_Contrat.Location = new System.Drawing.Point(509, 52);
            this.btn_Contrat.Name = "btn_Contrat";
            this.btn_Contrat.Size = new System.Drawing.Size(93, 33);
            this.btn_Contrat.TabIndex = 36;
            this.btn_Contrat.Text = "contrat";
            this.btn_Contrat.UseVisualStyleBackColor = true;
            this.btn_Contrat.Click += new System.EventHandler(this.btn_Contrat_Click);
            // 
            // fmLocataire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1050);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Contrat);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.tf_ninea);
            this.Controls.Add(this.tf_email);
            this.Controls.Add(this.tf_telephone);
            this.Controls.Add(this.tf_nom);
            this.Controls.Add(this.tf_prenom);
            this.Controls.Add(this.tfNom);
            this.Controls.Add(this.tf_Telphone);
            this.Controls.Add(this.tfEmail);
            this.Controls.Add(this.tfCni);
            this.Controls.Add(this.tfPrenom);
            this.Controls.Add(this.dgLocataire);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmLocataire";
            this.Text = "Locataire";
            this.Load += new System.EventHandler(this.fmLocataire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLocataire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label tf_ninea;
        private System.Windows.Forms.Label tf_email;
        private System.Windows.Forms.Label tf_telephone;
        private System.Windows.Forms.Label tf_nom;
        private System.Windows.Forms.Label tf_prenom;
        private System.Windows.Forms.TextBox tfNom;
        private System.Windows.Forms.TextBox tf_Telphone;
        private System.Windows.Forms.TextBox tfEmail;
        private System.Windows.Forms.TextBox tfCni;
        private System.Windows.Forms.TextBox tfPrenom;
        private System.Windows.Forms.DataGridView dgLocataire;
        private System.Windows.Forms.Button btn_Contrat;
    }
}