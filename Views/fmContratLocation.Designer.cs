namespace Gestions.Views
{
    partial class fmContratLocation
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
            this.btnValider = new System.Windows.Forms.Button();
            this.btnRevoquer = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.dgAppartement = new System.Windows.Forms.DataGridView();
            this.tfMontant = new System.Windows.Forms.TextBox();
            this.tfNumero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAppartement = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLocataire = new System.Windows.Forms.TextBox();
            this.AppartementChoisi = new System.Windows.Forms.Button();
            this.LocataireChoisir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChoisir
            // 
            this.btnChoisir.Location = new System.Drawing.Point(762, 17);
            this.btnChoisir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoisir.Name = "btnChoisir";
            this.btnChoisir.Size = new System.Drawing.Size(112, 35);
            this.btnChoisir.TabIndex = 36;
            this.btnChoisir.Text = "Choisir";
            this.btnChoisir.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(200, 560);
            this.btnValider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(112, 35);
            this.btnValider.TabIndex = 35;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnRevoquer
            // 
            this.btnRevoquer.Location = new System.Drawing.Point(318, 560);
            this.btnRevoquer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRevoquer.Name = "btnRevoquer";
            this.btnRevoquer.Size = new System.Drawing.Size(112, 35);
            this.btnRevoquer.TabIndex = 34;
            this.btnRevoquer.Text = "Revoquer";
            this.btnRevoquer.UseVisualStyleBackColor = true;
            this.btnRevoquer.Click += new System.EventHandler(this.btnRevoquer_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(78, 560);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(112, 35);
            this.btnEnregistrer.TabIndex = 33;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // dgAppartement
            // 
            this.dgAppartement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAppartement.Location = new System.Drawing.Point(711, 60);
            this.dgAppartement.Name = "dgAppartement";
            this.dgAppartement.RowHeadersWidth = 62;
            this.dgAppartement.RowTemplate.Height = 28;
            this.dgAppartement.Size = new System.Drawing.Size(250, 631);
            this.dgAppartement.TabIndex = 30;
            // 
            // tfMontant
            // 
            this.tfMontant.Location = new System.Drawing.Point(78, 342);
            this.tfMontant.Name = "tfMontant";
            this.tfMontant.Size = new System.Drawing.Size(298, 26);
            this.tfMontant.TabIndex = 27;
            // 
            // tfNumero
            // 
            this.tfNumero.Location = new System.Drawing.Point(78, 54);
            this.tfNumero.Name = "tfNumero";
            this.tfNumero.Size = new System.Drawing.Size(298, 26);
            this.tfNumero.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Date de Debut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Montant";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Numero";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(78, 154);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(78, 254);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker2.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Date de Fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Appartement";
            // 
            // txtAppartement
            // 
            this.txtAppartement.Location = new System.Drawing.Point(78, 425);
            this.txtAppartement.Name = "txtAppartement";
            this.txtAppartement.Size = new System.Drawing.Size(298, 26);
            this.txtAppartement.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 42;
            this.label6.Text = "locataire";
            // 
            // txtLocataire
            // 
            this.txtLocataire.Location = new System.Drawing.Point(82, 492);
            this.txtLocataire.Name = "txtLocataire";
            this.txtLocataire.Size = new System.Drawing.Size(294, 26);
            this.txtLocataire.TabIndex = 43;
            // 
            // AppartementChoisi
            // 
            this.AppartementChoisi.Location = new System.Drawing.Point(396, 428);
            this.AppartementChoisi.Name = "AppartementChoisi";
            this.AppartementChoisi.Size = new System.Drawing.Size(110, 32);
            this.AppartementChoisi.TabIndex = 44;
            this.AppartementChoisi.Text = "choisir";
            this.AppartementChoisi.UseVisualStyleBackColor = true;
            // 
            // LocataireChoisir
            // 
            this.LocataireChoisir.Location = new System.Drawing.Point(396, 492);
            this.LocataireChoisir.Name = "LocataireChoisir";
            this.LocataireChoisir.Size = new System.Drawing.Size(110, 30);
            this.LocataireChoisir.TabIndex = 45;
            this.LocataireChoisir.Text = "choisir";
            this.LocataireChoisir.UseVisualStyleBackColor = true;
            this.LocataireChoisir.Click += new System.EventHandler(this.LocataireChoisir_Click);
            // 
            // fmContratLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 663);
            this.ControlBox = false;
            this.Controls.Add(this.LocataireChoisir);
            this.Controls.Add(this.AppartementChoisi);
            this.Controls.Add(this.txtLocataire);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAppartement);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnChoisir);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnRevoquer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dgAppartement);
            this.Controls.Add(this.tfMontant);
            this.Controls.Add(this.tfNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmContratLocation";
            this.Text = "fmContratLocation";
            this.Load += new System.EventHandler(this.fmContratLocation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAppartement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoisir;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnRevoquer;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridView dgAppartement;
        private System.Windows.Forms.TextBox tfMontant;
        private System.Windows.Forms.TextBox tfNumero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAppartement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocataire;
        private System.Windows.Forms.Button AppartementChoisi;
        private System.Windows.Forms.Button LocataireChoisir;
    }
}