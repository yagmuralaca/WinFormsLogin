namespace WinFormsLogin
{
    partial class OgrenciBilgi
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
            this.lbl_hsgldn = new System.Windows.Forms.Label();
            this.dgw_ogr = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ogr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HOŞ GELDİNİZ,";
            // 
            // lbl_hsgldn
            // 
            this.lbl_hsgldn.AutoSize = true;
            this.lbl_hsgldn.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_hsgldn.Location = new System.Drawing.Point(130, 24);
            this.lbl_hsgldn.Name = "lbl_hsgldn";
            this.lbl_hsgldn.Size = new System.Drawing.Size(0, 20);
            this.lbl_hsgldn.TabIndex = 1;
            // 
            // dgw_ogr
            // 
            this.dgw_ogr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgw_ogr.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgw_ogr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ogr.Location = new System.Drawing.Point(12, 70);
            this.dgw_ogr.Name = "dgw_ogr";
            this.dgw_ogr.RowTemplate.Height = 25;
            this.dgw_ogr.Size = new System.Drawing.Size(563, 162);
            this.dgw_ogr.TabIndex = 2;
            // 
            // OgrenciBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(587, 322);
            this.Controls.Add(this.dgw_ogr);
            this.Controls.Add(this.lbl_hsgldn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "OgrenciBilgi";
            this.Text = "Öğrenci Bilgileri";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ogr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_hsgldn;
        private DataGridView dgw_ogr;
    }
}