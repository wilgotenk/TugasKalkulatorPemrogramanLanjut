
namespace TugasDelegateDanEvent
{
    partial class HasilPerhitungan
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
            this.btnHitung = new System.Windows.Forms.Button();
            this.Hasil = new System.Windows.Forms.GroupBox();
            this.listHasil = new System.Windows.Forms.ListBox();
            this.Hasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(12, 337);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(405, 27);
            this.btnHitung.TabIndex = 0;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // Hasil
            // 
            this.Hasil.Controls.Add(this.listHasil);
            this.Hasil.Location = new System.Drawing.Point(12, 12);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(405, 319);
            this.Hasil.TabIndex = 1;
            this.Hasil.TabStop = false;
            this.Hasil.Text = "[ Hasil ]";
            // 
            // listHasil
            // 
            this.listHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listHasil.FormattingEnabled = true;
            this.listHasil.ItemHeight = 15;
            this.listHasil.Location = new System.Drawing.Point(6, 19);
            this.listHasil.Name = "listHasil";
            this.listHasil.Size = new System.Drawing.Size(393, 289);
            this.listHasil.TabIndex = 0;
            // 
            // HasilPerhitungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 371);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.btnHitung);
            this.Name = "HasilPerhitungan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasil Perhitungan";
            this.Hasil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.GroupBox Hasil;
        private System.Windows.Forms.ListBox listHasil;
    }
}

