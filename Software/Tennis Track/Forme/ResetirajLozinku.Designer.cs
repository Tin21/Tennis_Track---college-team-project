﻿namespace Tennis_Track.Forme
{
    partial class ResetirajLozinku
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
            this.btnPovratak = new System.Windows.Forms.Button();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnResetirajLozinku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPovratak
            // 
            this.btnPovratak.Location = new System.Drawing.Point(651, 401);
            this.btnPovratak.Margin = new System.Windows.Forms.Padding(15);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(125, 25);
            this.btnPovratak.TabIndex = 8;
            this.btnPovratak.Text = "Povratak";
            this.btnPovratak.UseVisualStyleBackColor = true;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // TxtUsername
            // 
            this.TxtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUsername.ForeColor = System.Drawing.SystemColors.Desktop;
            this.TxtUsername.Location = new System.Drawing.Point(275, 161);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.TxtUsername.Multiline = true;
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(250, 30);
            this.TxtUsername.TabIndex = 9;
            this.TxtUsername.Text = "Korisničko ime";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(275, 204);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 30);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Text = "Email";
            // 
            // btnResetirajLozinku
            // 
            this.btnResetirajLozinku.Location = new System.Drawing.Point(324, 247);
            this.btnResetirajLozinku.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.btnResetirajLozinku.Name = "btnResetirajLozinku";
            this.btnResetirajLozinku.Size = new System.Drawing.Size(153, 43);
            this.btnResetirajLozinku.TabIndex = 11;
            this.btnResetirajLozinku.Text = "Resetiraj lozinku";
            this.btnResetirajLozinku.UseVisualStyleBackColor = true;
            this.btnResetirajLozinku.Click += new System.EventHandler(this.btnResetirajLozinku_Click);
            // 
            // ResetirajLozinku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tennis_Track.Properties.Resources.How_to_Grip_a_Tennis_Racket_Properly;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnResetirajLozinku);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.btnPovratak);
            this.Name = "ResetirajLozinku";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetiraj lozinku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnResetirajLozinku;
    }
}