﻿
namespace TugasDelegateDanEvent
{
    partial class Hitung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Operasi = new System.Windows.Forms.ComboBox();
            this.NilaiA = new System.Windows.Forms.TextBox();
            this.NilaiB = new System.Windows.Forms.TextBox();
            this.btnProses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nilai A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai B";
            // 
            // Operasi
            // 
            this.Operasi.Cursor = System.Windows.Forms.Cursors.Default;
            this.Operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operasi.FormattingEnabled = true;
            this.Operasi.Location = new System.Drawing.Point(61, 12);
            this.Operasi.Name = "Operasi";
            this.Operasi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Operasi.Size = new System.Drawing.Size(132, 21);
            this.Operasi.TabIndex = 3;
            // 
            // NilaiA
            // 
            this.NilaiA.Location = new System.Drawing.Point(61, 44);
            this.NilaiA.Name = "NilaiA";
            this.NilaiA.Size = new System.Drawing.Size(132, 20);
            this.NilaiA.TabIndex = 4;
            // 
            // NilaiB
            // 
            this.NilaiB.Location = new System.Drawing.Point(61, 75);
            this.NilaiB.Name = "NilaiB";
            this.NilaiB.Size = new System.Drawing.Size(132, 20);
            this.NilaiB.TabIndex = 5;
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(118, 101);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 6;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // Hitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(212, 132);
            this.Controls.Add(this.btnProses);
            this.Controls.Add(this.NilaiB);
            this.Controls.Add(this.NilaiA);
            this.Controls.Add(this.Operasi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hitung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hitung";
            this.Load += new System.EventHandler(this.Hitung_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Operasi;
        private System.Windows.Forms.TextBox NilaiA;
        private System.Windows.Forms.TextBox NilaiB;
        private System.Windows.Forms.Button btnProses;
    }
}