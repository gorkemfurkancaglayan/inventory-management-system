namespace BaskanTicaret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelLoginDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelLoginTitle = new System.Windows.Forms.Panel();
            this.btnLoginMinimize = new FontAwesome.Sharp.IconButton();
            this.btnLoginMaximize = new FontAwesome.Sharp.IconButton();
            this.btnLoginClose = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panelLoginDesktop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelLoginTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginDesktop
            // 
            this.panelLoginDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panelLoginDesktop.Controls.Add(this.panel1);
            this.panelLoginDesktop.Controls.Add(this.panelLoginTitle);
            this.panelLoginDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoginDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelLoginDesktop.Name = "panelLoginDesktop";
            this.panelLoginDesktop.Size = new System.Drawing.Size(1132, 553);
            this.panelLoginDesktop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(100, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 447);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(572, 327);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(333, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(266, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Oturum Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(333, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(266, 38);
            this.textBox2.TabIndex = 9;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(333, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(266, 38);
            this.textBox1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(327, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parola";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(327, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kullanıcı adı";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(369, 81);
            this.label2.TabIndex = 2;
            this.label2.Text = "Automotive";
            // 
            // panelLoginTitle
            // 
            this.panelLoginTitle.BackColor = System.Drawing.Color.Black;
            this.panelLoginTitle.Controls.Add(this.btnLoginMinimize);
            this.panelLoginTitle.Controls.Add(this.btnLoginMaximize);
            this.panelLoginTitle.Controls.Add(this.btnLoginClose);
            this.panelLoginTitle.Controls.Add(this.label1);
            this.panelLoginTitle.Controls.Add(this.pictureBox1);
            this.panelLoginTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLoginTitle.Location = new System.Drawing.Point(0, 0);
            this.panelLoginTitle.Name = "panelLoginTitle";
            this.panelLoginTitle.Size = new System.Drawing.Size(1132, 94);
            this.panelLoginTitle.TabIndex = 0;
            this.panelLoginTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLoginTitle_MouseDown);
            // 
            // btnLoginMinimize
            // 
            this.btnLoginMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginMinimize.FlatAppearance.BorderSize = 0;
            this.btnLoginMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnLoginMinimize.IconColor = System.Drawing.Color.White;
            this.btnLoginMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginMinimize.IconSize = 20;
            this.btnLoginMinimize.Location = new System.Drawing.Point(998, -3);
            this.btnLoginMinimize.Name = "btnLoginMinimize";
            this.btnLoginMinimize.Size = new System.Drawing.Size(45, 25);
            this.btnLoginMinimize.TabIndex = 6;
            this.btnLoginMinimize.UseVisualStyleBackColor = true;
            this.btnLoginMinimize.Click += new System.EventHandler(this.btnLoginMinimize_Click_1);
            // 
            // btnLoginMaximize
            // 
            this.btnLoginMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginMaximize.FlatAppearance.BorderSize = 0;
            this.btnLoginMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnLoginMaximize.IconColor = System.Drawing.Color.White;
            this.btnLoginMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginMaximize.IconSize = 20;
            this.btnLoginMaximize.Location = new System.Drawing.Point(1042, -1);
            this.btnLoginMaximize.Name = "btnLoginMaximize";
            this.btnLoginMaximize.Size = new System.Drawing.Size(45, 25);
            this.btnLoginMaximize.TabIndex = 5;
            this.btnLoginMaximize.UseVisualStyleBackColor = true;
            this.btnLoginMaximize.Click += new System.EventHandler(this.btnLoginMaximize_Click_1);
            // 
            // btnLoginClose
            // 
            this.btnLoginClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginClose.FlatAppearance.BorderSize = 0;
            this.btnLoginClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginClose.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnLoginClose.IconColor = System.Drawing.Color.White;
            this.btnLoginClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoginClose.IconSize = 20;
            this.btnLoginClose.Location = new System.Drawing.Point(1087, 0);
            this.btnLoginClose.Name = "btnLoginClose";
            this.btnLoginClose.Size = new System.Drawing.Size(45, 25);
            this.btnLoginClose.TabIndex = 4;
            this.btnLoginClose.UseVisualStyleBackColor = true;
            this.btnLoginClose.Click += new System.EventHandler(this.btnLoginClose_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(96, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automotive";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BaskanTicaret.Properties.Resources.mercedeslogo60px;
            this.pictureBox1.Location = new System.Drawing.Point(17, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 553);
            this.Controls.Add(this.panelLoginDesktop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.Form2_Resize);
            this.panelLoginDesktop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLoginTitle.ResumeLayout(false);
            this.panelLoginTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginDesktop;
        private System.Windows.Forms.Panel panelLoginTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnLoginMinimize;
        private FontAwesome.Sharp.IconButton btnLoginMaximize;
        private FontAwesome.Sharp.IconButton btnLoginClose;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}