namespace Odstevalnik
{
    partial class Odstevalnik
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
            this.steviloPrikaz = new System.Windows.Forms.Label();
            this.ponastavi = new System.Windows.Forms.Button();
            this.ustavi = new System.Windows.Forms.Button();
            this.zacni = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // steviloPrikaz
            // 
            this.steviloPrikaz.AutoSize = true;
            this.steviloPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.steviloPrikaz.Location = new System.Drawing.Point(303, 60);
            this.steviloPrikaz.Name = "steviloPrikaz";
            this.steviloPrikaz.Size = new System.Drawing.Size(133, 147);
            this.steviloPrikaz.TabIndex = 0;
            this.steviloPrikaz.Text = "9";
            // 
            // ponastavi
            // 
            this.ponastavi.Location = new System.Drawing.Point(132, 275);
            this.ponastavi.Name = "ponastavi";
            this.ponastavi.Size = new System.Drawing.Size(129, 57);
            this.ponastavi.TabIndex = 1;
            this.ponastavi.Text = "Ponastavi";
            this.ponastavi.UseVisualStyleBackColor = true;
            this.ponastavi.Click += new System.EventHandler(this.ponastavi_Click);
            // 
            // ustavi
            // 
            this.ustavi.Location = new System.Drawing.Point(307, 275);
            this.ustavi.Name = "ustavi";
            this.ustavi.Size = new System.Drawing.Size(129, 57);
            this.ustavi.TabIndex = 2;
            this.ustavi.Text = "Ustavi";
            this.ustavi.UseVisualStyleBackColor = true;
            this.ustavi.Click += new System.EventHandler(this.ustavi_Click);
            // 
            // zacni
            // 
            this.zacni.Location = new System.Drawing.Point(470, 275);
            this.zacni.Name = "zacni";
            this.zacni.Size = new System.Drawing.Size(129, 57);
            this.zacni.TabIndex = 3;
            this.zacni.Text = "Začni";
            this.zacni.UseVisualStyleBackColor = true;
            this.zacni.Click += new System.EventHandler(this.zacni_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Odstevalnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.zacni);
            this.Controls.Add(this.ustavi);
            this.Controls.Add(this.ponastavi);
            this.Controls.Add(this.steviloPrikaz);
            this.Name = "Odstevalnik";
            this.Text = "Odštevalnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label steviloPrikaz;
        private System.Windows.Forms.Button ponastavi;
        private System.Windows.Forms.Button ustavi;
        private System.Windows.Forms.Button zacni;
        private System.Windows.Forms.Timer timer;
    }
}

