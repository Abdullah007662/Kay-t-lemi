namespace Kayıt_İşlemi
{
    partial class YöneticiGiriş
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
            this.Kullanıcıad = new System.Windows.Forms.TextBox();
            this.GirişYap = new System.Windows.Forms.Button();
            this.kullanıcıŞifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Kullanıcıad
            // 
            this.Kullanıcıad.Location = new System.Drawing.Point(234, 105);
            this.Kullanıcıad.Name = "Kullanıcıad";
            this.Kullanıcıad.Size = new System.Drawing.Size(197, 36);
            this.Kullanıcıad.TabIndex = 1;
            // 
            // GirişYap
            // 
            this.GirişYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.GirişYap.ForeColor = System.Drawing.Color.Black;
            this.GirişYap.Location = new System.Drawing.Point(247, 189);
            this.GirişYap.Name = "GirişYap";
            this.GirişYap.Size = new System.Drawing.Size(156, 40);
            this.GirişYap.TabIndex = 3;
            this.GirişYap.Text = "Giriş Yap";
            this.GirişYap.UseVisualStyleBackColor = false;
            this.GirişYap.Click += new System.EventHandler(this.GirişYap_Click);
            // 
            // kullanıcıŞifre
            // 
            this.kullanıcıŞifre.Location = new System.Drawing.Point(234, 147);
            this.kullanıcıŞifre.Name = "kullanıcıŞifre";
            this.kullanıcıŞifre.Size = new System.Drawing.Size(197, 36);
            this.kullanıcıŞifre.TabIndex = 2;
            this.kullanıcıŞifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "KullanıcıAdı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(719, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personel Kayıt Sistemi Yönetici Girişi";
            // 
            // YöneticiGiriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(774, 429);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanıcıŞifre);
            this.Controls.Add(this.GirişYap);
            this.Controls.Add(this.Kullanıcıad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "YöneticiGiriş";
            this.Text = "YöneticiGiriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Kullanıcıad;
        private System.Windows.Forms.Button GirişYap;
        private System.Windows.Forms.TextBox kullanıcıŞifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}