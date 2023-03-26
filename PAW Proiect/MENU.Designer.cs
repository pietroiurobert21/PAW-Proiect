namespace PAW_Proiect
{
    partial class MENU
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
            this.cbChoice = new System.Windows.Forms.ComboBox();
            this.bChoice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbChoice
            // 
            this.cbChoice.FormattingEnabled = true;
            this.cbChoice.Items.AddRange(new object[] {
            "Administrator",
            "Client"});
            this.cbChoice.Location = new System.Drawing.Point(505, 262);
            this.cbChoice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbChoice.Name = "cbChoice";
            this.cbChoice.Size = new System.Drawing.Size(307, 37);
            this.cbChoice.TabIndex = 0;
            // 
            // bChoice
            // 
            this.bChoice.Location = new System.Drawing.Point(505, 361);
            this.bChoice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bChoice.Name = "bChoice";
            this.bChoice.Size = new System.Drawing.Size(307, 61);
            this.bChoice.TabIndex = 1;
            this.bChoice.Text = "continua";
            this.bChoice.UseVisualStyleBackColor = true;
            this.bChoice.Click += new System.EventHandler(this.bChoice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(576, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ce sunteti?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PAW_Proiect.Properties.Resources.Icons8_Windows_8_Users_Administrator_2_64;
            this.pictureBox1.Location = new System.Drawing.Point(504, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 73);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 816);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bChoice);
            this.Controls.Add(this.cbChoice);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MENU";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbChoice;
        private System.Windows.Forms.Button bChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}