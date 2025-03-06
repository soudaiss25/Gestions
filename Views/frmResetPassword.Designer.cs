namespace Gestions.Views
{
    partial class frmResetPassword
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.tf_password = new System.Windows.Forms.Label();
            this.tf_username = new System.Windows.Forms.Label();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 45);
            this.button1.TabIndex = 11;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(494, 268);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(168, 45);
            this.btn_valider.TabIndex = 10;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // tf_password
            // 
            this.tf_password.AutoSize = true;
            this.tf_password.Location = new System.Drawing.Point(146, 170);
            this.tf_password.Name = "tf_password";
            this.tf_password.Size = new System.Drawing.Size(173, 20);
            this.tf_password.TabIndex = 9;
            this.tf_password.Text = "Confirme Mot de passe";
            // 
            // tf_username
            // 
            this.tf_username.AutoSize = true;
            this.tf_username.Location = new System.Drawing.Point(146, 87);
            this.tf_username.Name = "tf_username";
            this.tf_username.Size = new System.Drawing.Size(105, 20);
            this.tf_username.TabIndex = 8;
            this.tf_username.Text = "Mot de passe";
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(150, 193);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(320, 26);
            this.txtMotDePasse.TabIndex = 7;
            this.txtMotDePasse.TextChanged += new System.EventHandler(this.txtMotDePasse_TextChanged);
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(150, 110);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(320, 26);
            this.txtIdentifiant.TabIndex = 6;
            // 
            // frmResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 420);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.tf_password);
            this.Controls.Add(this.tf_username);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtIdentifiant);
            this.Name = "frmResetPassword";
            this.Text = "Changer votre mot De passe";
            this.Load += new System.EventHandler(this.frmResetPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label tf_password;
        private System.Windows.Forms.Label tf_username;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.TextBox txtIdentifiant;
    }
}