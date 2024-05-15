namespace VozecaPloscad
{
    partial class VozecaPloscad
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
            this.ploscad = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ploscad
            // 
            this.ploscad.Location = new System.Drawing.Point(10, 10);
            this.ploscad.Name = "ploscad";
            this.ploscad.Size = new System.Drawing.Size(124, 69);
            this.ploscad.TabIndex = 0;
            this.ploscad.Text = "Gibanje";
            this.ploscad.UseVisualStyleBackColor = true;
            this.ploscad.Click += new System.EventHandler(this.ploscad_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // VozecaPloscad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 123);
            this.Controls.Add(this.ploscad);
            this.Name = "VozecaPloscad";
            this.Text = "Vozeča ploščad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ploscad;
        private System.Windows.Forms.Timer timer;
    }
}

