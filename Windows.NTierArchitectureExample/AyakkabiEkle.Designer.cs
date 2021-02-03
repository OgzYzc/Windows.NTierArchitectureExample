
namespace Windows.NTierArchitectureExample
{
    partial class AyakkabiEkle
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
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Numara = new System.Windows.Forms.TextBox();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(254, 159);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(100, 20);
            this.txt_Marka.TabIndex = 0;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(254, 185);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 20);
            this.txt_Model.TabIndex = 1;
            // 
            // txt_Numara
            // 
            this.txt_Numara.Location = new System.Drawing.Point(254, 211);
            this.txt_Numara.Name = "txt_Numara";
            this.txt_Numara.Size = new System.Drawing.Size(100, 20);
            this.txt_Numara.TabIndex = 2;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(254, 287);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 3;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(254, 316);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(75, 23);
            this.btn_Sil.TabIndex = 4;
            this.btn_Sil.Text = "SİL";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(254, 345);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 5;
            this.btn_Update.Text = "GÜNCELLE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // AyakkabiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 478);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_Numara);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Marka);
            this.Name = "AyakkabiEkle";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Numara;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Update;
    }
}

