namespace PAW_Proiect
{
    partial class Form1
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
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.lbDenumire = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.lbPret = new System.Windows.Forms.Label();
            this.bProdus = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.schimbaCuloareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schimbaFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelAdd = new System.Windows.Forms.Label();
            this.ltProdus = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(6, 80);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(217, 30);
            this.tbDenumire.TabIndex = 0;
            // 
            // lbDenumire
            // 
            this.lbDenumire.AutoSize = true;
            this.lbDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDenumire.Location = new System.Drawing.Point(6, 55);
            this.lbDenumire.Name = "lbDenumire";
            this.lbDenumire.Size = new System.Drawing.Size(140, 20);
            this.lbDenumire.TabIndex = 1;
            this.lbDenumire.Text = "Denumire Produs";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(6, 136);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(217, 30);
            this.tbPret.TabIndex = 2;
            // 
            // lbPret
            // 
            this.lbPret.AutoSize = true;
            this.lbPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPret.Location = new System.Drawing.Point(6, 113);
            this.lbPret.Name = "lbPret";
            this.lbPret.Size = new System.Drawing.Size(98, 20);
            this.lbPret.TabIndex = 3;
            this.lbPret.Text = "Pret Produs";
            // 
            // bProdus
            // 
            this.bProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProdus.Location = new System.Drawing.Point(6, 172);
            this.bProdus.Name = "bProdus";
            this.bProdus.Size = new System.Drawing.Size(153, 33);
            this.bProdus.TabIndex = 4;
            this.bProdus.Text = "&Add Produs";
            this.bProdus.UseVisualStyleBackColor = true;
            this.bProdus.Click += new System.EventHandler(this.bProdus_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.AllowDrop = true;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schimbaCuloareaToolStripMenuItem,
            this.schimbaFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(193, 52);
            // 
            // schimbaCuloareaToolStripMenuItem
            // 
            this.schimbaCuloareaToolStripMenuItem.Name = "schimbaCuloareaToolStripMenuItem";
            this.schimbaCuloareaToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.schimbaCuloareaToolStripMenuItem.Text = "schimbaCuloarea";
            this.schimbaCuloareaToolStripMenuItem.Click += new System.EventHandler(this.schimbaCuloareaToolStripMenuItem_Click);
            // 
            // schimbaFontToolStripMenuItem
            // 
            this.schimbaFontToolStripMenuItem.Name = "schimbaFontToolStripMenuItem";
            this.schimbaFontToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.schimbaFontToolStripMenuItem.Text = "schimbaFont";
            this.schimbaFontToolStripMenuItem.Click += new System.EventHandler(this.schimbaFontToolStripMenuItem_Click);
            // 
            // labelAdd
            // 
            this.labelAdd.AutoSize = true;
            this.labelAdd.Location = new System.Drawing.Point(319, 301);
            this.labelAdd.Name = "labelAdd";
            this.labelAdd.Size = new System.Drawing.Size(0, 16);
            this.labelAdd.TabIndex = 5;
            // 
            // ltProdus
            // 
            this.ltProdus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltProdus.FormattingEnabled = true;
            this.ltProdus.ItemHeight = 25;
            this.ltProdus.Location = new System.Drawing.Point(405, 52);
            this.ltProdus.Name = "ltProdus";
            this.ltProdus.Size = new System.Drawing.Size(348, 354);
            this.ltProdus.TabIndex = 6;
            this.ltProdus.SelectedIndexChanged += new System.EventHandler(this.ltProdus_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista Produse existente";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bProdus);
            this.groupBox1.Controls.Add(this.tbPret);
            this.groupBox1.Controls.Add(this.lbPret);
            this.groupBox1.Controls.Add(this.tbDenumire);
            this.groupBox1.Controls.Add(this.lbDenumire);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 224);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adauga Produse";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ltProdus);
            this.Controls.Add(this.labelAdd);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label lbDenumire;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label lbPret;
        private System.Windows.Forms.Button bProdus;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schimbaCuloareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schimbaFontToolStripMenuItem;
        private System.Windows.Forms.ListBox ltProdus;
        public System.Windows.Forms.Label labelAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

