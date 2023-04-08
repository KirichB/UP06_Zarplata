namespace UP06_Zarplata
{
    partial class Sotrydnik
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
            this.Vihod_sotrudnik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Vihod_sotrudnik
            // 
            this.Vihod_sotrudnik.Location = new System.Drawing.Point(725, 2);
            this.Vihod_sotrudnik.Name = "Vihod_sotrudnik";
            this.Vihod_sotrudnik.Size = new System.Drawing.Size(75, 23);
            this.Vihod_sotrudnik.TabIndex = 0;
            this.Vihod_sotrudnik.Text = "Выход";
            this.Vihod_sotrudnik.UseVisualStyleBackColor = true;
            this.Vihod_sotrudnik.Click += new System.EventHandler(this.Vihod_sotrudnik_Click);
            // 
            // Sotrydnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Vihod_sotrudnik);
            this.Name = "Sotrydnik";
            this.Text = "Sotrydnik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Vihod_sotrudnik;
    }
}