
namespace Windows.NTierArchitectureExample
{
    partial class AyakkabiAra
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
            this.btn_Ara = new System.Windows.Forms.Button();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Numara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Ara
            // 
            this.btn_Ara.Location = new System.Drawing.Point(287, 296);
            this.btn_Ara.Name = "btn_Ara";
            this.btn_Ara.Size = new System.Drawing.Size(75, 23);
            this.btn_Ara.TabIndex = 0;
            this.btn_Ara.Text = "ARA";
            this.btn_Ara.UseVisualStyleBackColor = true;
            this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(283, 135);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(100, 20);
            this.txt_Marka.TabIndex = 1;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(283, 175);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(100, 20);
            this.txt_Model.TabIndex = 2;
            // 
            // txt_Numara
            // 
            this.txt_Numara.Location = new System.Drawing.Point(283, 219);
            this.txt_Numara.Name = "txt_Numara";
            this.txt_Numara.Size = new System.Drawing.Size(100, 20);
            this.txt_Numara.TabIndex = 3;
            // 
            // AyakkabiAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 477);
            this.Controls.Add(this.txt_Numara);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.btn_Ara);
            this.Name = "AyakkabiAra";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ara;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.TextBox txt_Model;
        private System.Windows.Forms.TextBox txt_Numara;
    }
}