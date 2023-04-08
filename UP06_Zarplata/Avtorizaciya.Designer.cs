namespace UP06_Zarplata
{
    partial class Avtorizaciya
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
            this.Log_lab = new System.Windows.Forms.Label();
            this.Pas_lab = new System.Windows.Forms.Label();
            this.Log_text = new System.Windows.Forms.TextBox();
            this.Pas_text = new System.Windows.Forms.TextBox();
            this.Vhod_but = new System.Windows.Forms.Button();
            this.Avtorizac_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Log_lab
            // 
            this.Log_lab.AutoSize = true;
            this.Log_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_lab.Location = new System.Drawing.Point(26, 122);
            this.Log_lab.Name = "Log_lab";
            this.Log_lab.Size = new System.Drawing.Size(47, 16);
            this.Log_lab.TabIndex = 0;
            this.Log_lab.Text = "Логин";
            this.Log_lab.Click += new System.EventHandler(this.Log_lab_Click);
            // 
            // Pas_lab
            // 
            this.Pas_lab.AutoSize = true;
            this.Pas_lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pas_lab.Location = new System.Drawing.Point(26, 154);
            this.Pas_lab.Name = "Pas_lab";
            this.Pas_lab.Size = new System.Drawing.Size(57, 16);
            this.Pas_lab.TabIndex = 0;
            this.Pas_lab.Text = "Пароль";
            // 
            // Log_text
            // 
            this.Log_text.Location = new System.Drawing.Point(89, 118);
            this.Log_text.Name = "Log_text";
            this.Log_text.Size = new System.Drawing.Size(189, 20);
            this.Log_text.TabIndex = 1;
            // 
            // Pas_text
            // 
            this.Pas_text.Location = new System.Drawing.Point(89, 150);
            this.Pas_text.Name = "Pas_text";
            this.Pas_text.Size = new System.Drawing.Size(189, 20);
            this.Pas_text.TabIndex = 1;
            // 
            // Vhod_but
            // 
            this.Vhod_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Vhod_but.Location = new System.Drawing.Point(138, 205);
            this.Vhod_but.Name = "Vhod_but";
            this.Vhod_but.Size = new System.Drawing.Size(76, 35);
            this.Vhod_but.TabIndex = 2;
            this.Vhod_but.Text = "Войти";
            this.Vhod_but.UseVisualStyleBackColor = true;
            this.Vhod_but.Click += new System.EventHandler(this.Vhod_but_Click);
            // 
            // Avtorizac_text
            // 
            this.Avtorizac_text.AutoSize = true;
            this.Avtorizac_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Avtorizac_text.Location = new System.Drawing.Point(114, 64);
            this.Avtorizac_text.Name = "Avtorizac_text";
            this.Avtorizac_text.Size = new System.Drawing.Size(141, 25);
            this.Avtorizac_text.TabIndex = 0;
            this.Avtorizac_text.Text = "Авторизация";
            // 
            // Avtorizaciya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(354, 322);
            this.Controls.Add(this.Vhod_but);
            this.Controls.Add(this.Pas_text);
            this.Controls.Add(this.Log_text);
            this.Controls.Add(this.Avtorizac_text);
            this.Controls.Add(this.Pas_lab);
            this.Controls.Add(this.Log_lab);
            this.Name = "Avtorizaciya";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Avtorizaciya_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Log_lab;
        private System.Windows.Forms.Label Pas_lab;
        private System.Windows.Forms.TextBox Log_text;
        private System.Windows.Forms.TextBox Pas_text;
        private System.Windows.Forms.Button Vhod_but;
        private System.Windows.Forms.Label Avtorizac_text;
    }
}