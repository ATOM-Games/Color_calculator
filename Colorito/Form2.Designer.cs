namespace Colorito
{
    partial class Form2
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
            this.OPD = new System.Windows.Forms.OpenFileDialog();
            this.Kartinka = new System.Windows.Forms.PictureBox();
            this.opne_button = new System.Windows.Forms.Button();
            this.color_pipetka = new System.Windows.Forms.Panel();
            this.RGBA_color_label = new System.Windows.Forms.Label();
            this.butook = new System.Windows.Forms.Button();
            this.X_X = new System.Windows.Forms.NumericUpDown();
            this.Y_Y = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // OPD
            // 
            this.OPD.FileName = "openFileDialog1";
            this.OPD.Title = "ТИТЬКА";
            // 
            // Kartinka
            // 
            this.Kartinka.Location = new System.Drawing.Point(12, 12);
            this.Kartinka.Name = "Kartinka";
            this.Kartinka.Size = new System.Drawing.Size(245, 240);
            this.Kartinka.TabIndex = 0;
            this.Kartinka.TabStop = false;
            // 
            // opne_button
            // 
            this.opne_button.Location = new System.Drawing.Point(263, 12);
            this.opne_button.Name = "opne_button";
            this.opne_button.Size = new System.Drawing.Size(75, 23);
            this.opne_button.TabIndex = 1;
            this.opne_button.Text = "Open";
            this.opne_button.UseVisualStyleBackColor = true;
            this.opne_button.Click += new System.EventHandler(this.opne_button_Click);
            // 
            // color_pipetka
            // 
            this.color_pipetka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_pipetka.Location = new System.Drawing.Point(263, 227);
            this.color_pipetka.Name = "color_pipetka";
            this.color_pipetka.Size = new System.Drawing.Size(25, 25);
            this.color_pipetka.TabIndex = 2;
            // 
            // RGBA_color_label
            // 
            this.RGBA_color_label.AutoSize = true;
            this.RGBA_color_label.Location = new System.Drawing.Point(294, 233);
            this.RGBA_color_label.Name = "RGBA_color_label";
            this.RGBA_color_label.Size = new System.Drawing.Size(35, 13);
            this.RGBA_color_label.TabIndex = 3;
            this.RGBA_color_label.Text = "label1";
            // 
            // butook
            // 
            this.butook.Location = new System.Drawing.Point(263, 198);
            this.butook.Name = "butook";
            this.butook.Size = new System.Drawing.Size(75, 23);
            this.butook.TabIndex = 4;
            this.butook.Text = "select";
            this.butook.UseVisualStyleBackColor = true;
            this.butook.Click += new System.EventHandler(this.butook_Click);
            // 
            // X_X
            // 
            this.X_X.Location = new System.Drawing.Point(263, 172);
            this.X_X.Name = "X_X";
            this.X_X.Size = new System.Drawing.Size(75, 20);
            this.X_X.TabIndex = 5;
            // 
            // Y_Y
            // 
            this.Y_Y.Location = new System.Drawing.Point(344, 172);
            this.Y_Y.Name = "Y_Y";
            this.Y_Y.Size = new System.Drawing.Size(75, 20);
            this.Y_Y.TabIndex = 6;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 264);
            this.Controls.Add(this.Y_Y);
            this.Controls.Add(this.X_X);
            this.Controls.Add(this.butook);
            this.Controls.Add(this.RGBA_color_label);
            this.Controls.Add(this.color_pipetka);
            this.Controls.Add(this.opne_button);
            this.Controls.Add(this.Kartinka);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Kartinka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OPD;
        private System.Windows.Forms.PictureBox Kartinka;
        private System.Windows.Forms.Button opne_button;
        private System.Windows.Forms.Panel color_pipetka;
        private System.Windows.Forms.Label RGBA_color_label;
        private System.Windows.Forms.Button butook;
        private System.Windows.Forms.NumericUpDown X_X;
        private System.Windows.Forms.NumericUpDown Y_Y;
    }
}