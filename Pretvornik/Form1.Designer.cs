namespace Pretvornik
{
    partial class Pretvornik
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
            this.vnosCm = new System.Windows.Forms.TextBox();
            this.pretvori = new System.Windows.Forms.Button();
            this.vnosFt = new System.Windows.Forms.TextBox();
            this.vnosInch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "cm";
            // 
            // vnosCm
            // 
            this.vnosCm.Location = new System.Drawing.Point(148, 202);
            this.vnosCm.Name = "vnosCm";
            this.vnosCm.Size = new System.Drawing.Size(100, 31);
            this.vnosCm.TabIndex = 1;
            this.vnosCm.TextChanged += new System.EventHandler(this.vnosCm_TextChanged);
            // 
            // pretvori
            // 
            this.pretvori.Location = new System.Drawing.Point(315, 189);
            this.pretvori.Name = "pretvori";
            this.pretvori.Size = new System.Drawing.Size(135, 57);
            this.pretvori.TabIndex = 2;
            this.pretvori.Text = "pretvori";
            this.pretvori.UseVisualStyleBackColor = true;
            this.pretvori.Click += new System.EventHandler(this.pretvori_Click);
            // 
            // vnosFt
            // 
            this.vnosFt.Location = new System.Drawing.Point(498, 202);
            this.vnosFt.Name = "vnosFt";
            this.vnosFt.Size = new System.Drawing.Size(100, 31);
            this.vnosFt.TabIndex = 3;
            this.vnosFt.TextChanged += new System.EventHandler(this.vnosFt_TextChanged);
            // 
            // vnosInch
            // 
            this.vnosInch.Location = new System.Drawing.Point(636, 202);
            this.vnosInch.Name = "vnosInch";
            this.vnosInch.Size = new System.Drawing.Size(100, 31);
            this.vnosInch.TabIndex = 4;
            this.vnosInch.TextChanged += new System.EventHandler(this.vnosInch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "inch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ft";
            // 
            // Pretvornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vnosInch);
            this.Controls.Add(this.vnosFt);
            this.Controls.Add(this.pretvori);
            this.Controls.Add(this.vnosCm);
            this.Controls.Add(this.label1);
            this.Name = "Pretvornik";
            this.Text = "Pretvornik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vnosCm;
        private System.Windows.Forms.Button pretvori;
        private System.Windows.Forms.TextBox vnosFt;
        private System.Windows.Forms.TextBox vnosInch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

