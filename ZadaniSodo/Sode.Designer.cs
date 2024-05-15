namespace ZadaniSodo
{
    partial class ZadaniSodo
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
            this.components = new System.ComponentModel.Container();
            this.gumbStevilo = new System.Windows.Forms.Button();
            this.dosezeneTocke = new System.Windows.Forms.Label();
            this.steviloKlikov = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // gumbStevilo
            // 
            this.gumbStevilo.Location = new System.Drawing.Point(175, 130);
            this.gumbStevilo.Name = "gumbStevilo";
            this.gumbStevilo.Size = new System.Drawing.Size(121, 70);
            this.gumbStevilo.TabIndex = 0;
            this.gumbStevilo.UseVisualStyleBackColor = true;
            this.gumbStevilo.Click += new System.EventHandler(this.gumbStevilo_Click);
            // 
            // dosezeneTocke
            // 
            this.dosezeneTocke.AutoSize = true;
            this.dosezeneTocke.Location = new System.Drawing.Point(405, 106);
            this.dosezeneTocke.Name = "dosezeneTocke";
            this.dosezeneTocke.Size = new System.Drawing.Size(240, 25);
            this.dosezeneTocke.TabIndex = 1;
            this.dosezeneTocke.Text = "Število doseženih točk: ";
            // 
            // steviloKlikov
            // 
            this.steviloKlikov.AutoSize = true;
            this.steviloKlikov.Location = new System.Drawing.Point(405, 175);
            this.steviloKlikov.Name = "steviloKlikov";
            this.steviloKlikov.Size = new System.Drawing.Size(239, 25);
            this.steviloKlikov.TabIndex = 2;
            this.steviloKlikov.Text = "Število klikov na gumb: ";
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ZadaniSodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.steviloKlikov);
            this.Controls.Add(this.dosezeneTocke);
            this.Controls.Add(this.gumbStevilo);
            this.Name = "ZadaniSodo";
            this.Text = "Zadani sode stevilke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button gumbStevilo;
        private System.Windows.Forms.Label dosezeneTocke;
        private System.Windows.Forms.Label steviloKlikov;
        private System.Windows.Forms.Timer timer;
    }
}

