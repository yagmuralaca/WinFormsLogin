namespace WinFormsLogin
{
    partial class loginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_kadi = new System.Windows.Forms.Label();
            this.txt_kadi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_kadi
            // 
            this.lbl_kadi.AutoSize = true;
            this.lbl_kadi.Location = new System.Drawing.Point(52, 94);
            this.lbl_kadi.Name = "lbl_kadi";
            this.lbl_kadi.Size = new System.Drawing.Size(73, 15);
            this.lbl_kadi.TabIndex = 0;
            this.lbl_kadi.Text = "Kullanıcı Adı";
            // 
            // txt_kadi
            // 
            this.txt_kadi.Location = new System.Drawing.Point(52, 126);
            this.txt_kadi.Name = "txt_kadi";
            this.txt_kadi.Size = new System.Drawing.Size(240, 23);
            this.txt_kadi.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(52, 212);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(240, 23);
            this.txt_sifre.TabIndex = 3;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(52, 180);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(30, 15);
            this.lbl_sifre.TabIndex = 2;
            this.lbl_sifre.Text = "Şifre";
            // 
            // btn_giris
            // 
            this.btn_giris.BackColor = System.Drawing.Color.Tomato;
            this.btn_giris.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_giris.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_giris.Location = new System.Drawing.Point(123, 267);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(102, 30);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "GİRİŞ";
            this.btn_giris.UseVisualStyleBackColor = false;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(340, 389);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_kadi);
            this.Controls.Add(this.lbl_kadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "loginForm";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_kadi;
        private TextBox txt_kadi;
        private TextBox txt_sifre;
        private Label lbl_sifre;
        private Button btn_giris;
    }
}