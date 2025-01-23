namespace Gestions
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tf_username = new System.Windows.Forms.Label();
            this.tf_password = new System.Windows.Forms.Label();
            this.btn_seConnecter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(264, 145);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(264, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 26);
            this.textBox2.TabIndex = 1;
            // 
            // tf_username
            // 
            this.tf_username.AutoSize = true;
            this.tf_username.Location = new System.Drawing.Point(115, 148);
            this.tf_username.Name = "tf_username";
            this.tf_username.Size = new System.Drawing.Size(127, 20);
            this.tf_username.TabIndex = 2;
            this.tf_username.Text = "Nom d utilisateur";
            this.tf_username.Click += new System.EventHandler(this.label1_Click);
            // 
            // tf_password
            // 
            this.tf_password.AutoSize = true;
            this.tf_password.Location = new System.Drawing.Point(115, 204);
            this.tf_password.Name = "tf_password";
            this.tf_password.Size = new System.Drawing.Size(105, 20);
            this.tf_password.TabIndex = 3;
            this.tf_password.Text = "Mot de passe";
            // 
            // btn_seConnecter
            // 
            this.btn_seConnecter.Location = new System.Drawing.Point(423, 305);
            this.btn_seConnecter.Name = "btn_seConnecter";
            this.btn_seConnecter.Size = new System.Drawing.Size(168, 45);
            this.btn_seConnecter.TabIndex = 4;
            this.btn_seConnecter.Text = "Se Connecter";
            this.btn_seConnecter.UseVisualStyleBackColor = true;
            this.btn_seConnecter.Click += new System.EventHandler(this.btn_seConnecter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(145, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_seConnecter);
            this.Controls.Add(this.tf_password);
            this.Controls.Add(this.tf_username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label tf_username;
        private System.Windows.Forms.Label tf_password;
        private System.Windows.Forms.Button btn_seConnecter;
        private System.Windows.Forms.Button button1;
    }
}

