namespace VlakPrihaja
{
    partial class VlakPrihaja
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
            this.kvadrat1 = new System.Windows.Forms.Panel();
            this.kvadrat2 = new System.Windows.Forms.Panel();
            this.zacni = new System.Windows.Forms.Button();
            this.ustavi = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kvadrat1
            // 
            this.kvadrat1.Location = new System.Drawing.Point(194, 87);
            this.kvadrat1.Name = "kvadrat1";
            this.kvadrat1.Size = new System.Drawing.Size(114, 108);
            this.kvadrat1.TabIndex = 0;
            // 
            // kvadrat2
            // 
            this.kvadrat2.Location = new System.Drawing.Point(413, 87);
            this.kvadrat2.Name = "kvadrat2";
            this.kvadrat2.Size = new System.Drawing.Size(114, 108);
            this.kvadrat2.TabIndex = 1;
            // 
            // zacni
            // 
            this.zacni.Location = new System.Drawing.Point(194, 279);
            this.zacni.Name = "zacni";
            this.zacni.Size = new System.Drawing.Size(114, 59);
            this.zacni.TabIndex = 2;
            this.zacni.Text = "Začni";
            this.zacni.UseVisualStyleBackColor = true;
            this.zacni.Click += new System.EventHandler(this.zacni_Click);
            // 
            // ustavi
            // 
            this.ustavi.Location = new System.Drawing.Point(413, 279);
            this.ustavi.Name = "ustavi";
            this.ustavi.Size = new System.Drawing.Size(114, 59);
            this.ustavi.TabIndex = 3;
            this.ustavi.Text = "Ustavi";
            this.ustavi.UseVisualStyleBackColor = true;
            this.ustavi.Click += new System.EventHandler(this.ustavi_Click);
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // VlakPrihaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ustavi);
            this.Controls.Add(this.zacni);
            this.Controls.Add(this.kvadrat2);
            this.Controls.Add(this.kvadrat1);
            this.Name = "VlakPrihaja";
            this.Text = "Vlak prihaja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel kvadrat1;
        private System.Windows.Forms.Panel kvadrat2;
        private System.Windows.Forms.Button zacni;
        private System.Windows.Forms.Button ustavi;
        private System.Windows.Forms.Timer timer;
    }
}

