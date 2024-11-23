namespace BaskanTicaret.Forms
{
    partial class Preview
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMenu = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.urunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baskanTicaretDataSet1 = new BaskanTicaret.BaskanTicaretDataSet1();
            this.urunTableAdapter = new BaskanTicaret.BaskanTicaretDataSet1TableAdapters.urunTableAdapter();
            this.urunkodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunturDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aracseriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunaltmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunustmodelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urundurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunsutunDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunsatirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baskanTicaretDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 375);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 75);
            this.panel2.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnMenu.IconColor = System.Drawing.Color.White;
            this.btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMenu.IconSize = 30;
            this.btnMenu.Location = new System.Drawing.Point(733, 7);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 60);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.urunkodDataGridViewTextBoxColumn,
            this.urunturDataGridViewTextBoxColumn,
            this.aracseriDataGridViewTextBoxColumn,
            this.urunaltmodelDataGridViewTextBoxColumn,
            this.urunustmodelDataGridViewTextBoxColumn,
            this.urundurumDataGridViewTextBoxColumn,
            this.urunfiyatDataGridViewTextBoxColumn,
            this.urunsutunDataGridViewTextBoxColumn,
            this.urunsatirDataGridViewTextBoxColumn,
            this.urunadetDataGridViewTextBoxColumn,
            this.edit,
            this.delete});
            this.dataGridView1.DataSource = this.urunBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 306);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // urunBindingSource
            // 
            this.urunBindingSource.DataMember = "urun";
            this.urunBindingSource.DataSource = this.baskanTicaretDataSet1;
            // 
            // baskanTicaretDataSet1
            // 
            this.baskanTicaretDataSet1.DataSetName = "BaskanTicaretDataSet1";
            this.baskanTicaretDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // urunTableAdapter
            // 
            this.urunTableAdapter.ClearBeforeFill = true;
            // 
            // urunkodDataGridViewTextBoxColumn
            // 
            this.urunkodDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urunkodDataGridViewTextBoxColumn.DataPropertyName = "urunkod";
            this.urunkodDataGridViewTextBoxColumn.HeaderText = "Ürün Kodu";
            this.urunkodDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.urunkodDataGridViewTextBoxColumn.Name = "urunkodDataGridViewTextBoxColumn";
            // 
            // urunturDataGridViewTextBoxColumn
            // 
            this.urunturDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.urunturDataGridViewTextBoxColumn.DataPropertyName = "uruntur";
            this.urunturDataGridViewTextBoxColumn.HeaderText = "Ürün Türü";
            this.urunturDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.urunturDataGridViewTextBoxColumn.Name = "urunturDataGridViewTextBoxColumn";
            // 
            // aracseriDataGridViewTextBoxColumn
            // 
            this.aracseriDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.aracseriDataGridViewTextBoxColumn.DataPropertyName = "aracseri";
            this.aracseriDataGridViewTextBoxColumn.HeaderText = "Araç Serisi";
            this.aracseriDataGridViewTextBoxColumn.MinimumWidth = 125;
            this.aracseriDataGridViewTextBoxColumn.Name = "aracseriDataGridViewTextBoxColumn";
            // 
            // urunaltmodelDataGridViewTextBoxColumn
            // 
            this.urunaltmodelDataGridViewTextBoxColumn.DataPropertyName = "urunaltmodel";
            this.urunaltmodelDataGridViewTextBoxColumn.HeaderText = "Ürün Alt Modeli";
            this.urunaltmodelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunaltmodelDataGridViewTextBoxColumn.Name = "urunaltmodelDataGridViewTextBoxColumn";
            this.urunaltmodelDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunustmodelDataGridViewTextBoxColumn
            // 
            this.urunustmodelDataGridViewTextBoxColumn.DataPropertyName = "urunustmodel";
            this.urunustmodelDataGridViewTextBoxColumn.HeaderText = "Ürün Üst Modeli";
            this.urunustmodelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunustmodelDataGridViewTextBoxColumn.Name = "urunustmodelDataGridViewTextBoxColumn";
            this.urunustmodelDataGridViewTextBoxColumn.Width = 125;
            // 
            // urundurumDataGridViewTextBoxColumn
            // 
            this.urundurumDataGridViewTextBoxColumn.DataPropertyName = "urundurum";
            this.urundurumDataGridViewTextBoxColumn.HeaderText = "Ürün Durumu";
            this.urundurumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urundurumDataGridViewTextBoxColumn.Name = "urundurumDataGridViewTextBoxColumn";
            this.urundurumDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunfiyatDataGridViewTextBoxColumn
            // 
            this.urunfiyatDataGridViewTextBoxColumn.DataPropertyName = "urunfiyat";
            this.urunfiyatDataGridViewTextBoxColumn.HeaderText = "Ürünün Fiyatı";
            this.urunfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunfiyatDataGridViewTextBoxColumn.Name = "urunfiyatDataGridViewTextBoxColumn";
            this.urunfiyatDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunsutunDataGridViewTextBoxColumn
            // 
            this.urunsutunDataGridViewTextBoxColumn.DataPropertyName = "urunsutun";
            this.urunsutunDataGridViewTextBoxColumn.HeaderText = "Ürünün Sütunu";
            this.urunsutunDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunsutunDataGridViewTextBoxColumn.Name = "urunsutunDataGridViewTextBoxColumn";
            this.urunsutunDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunsatirDataGridViewTextBoxColumn
            // 
            this.urunsatirDataGridViewTextBoxColumn.DataPropertyName = "urunsatir";
            this.urunsatirDataGridViewTextBoxColumn.HeaderText = "Ürünün Satırı";
            this.urunsatirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunsatirDataGridViewTextBoxColumn.Name = "urunsatirDataGridViewTextBoxColumn";
            this.urunsatirDataGridViewTextBoxColumn.Width = 125;
            // 
            // urunadetDataGridViewTextBoxColumn
            // 
            this.urunadetDataGridViewTextBoxColumn.DataPropertyName = "urunadet";
            this.urunadetDataGridViewTextBoxColumn.HeaderText = "Ürün Adeti";
            this.urunadetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadetDataGridViewTextBoxColumn.Name = "urunadetDataGridViewTextBoxColumn";
            this.urunadetDataGridViewTextBoxColumn.Width = 125;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.edit.HeaderText = "";
            this.edit.Image = global::BaskanTicaret.Properties.Resources.edit32px;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.Width = 6;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.delete.HeaderText = "";
            this.delete.Image = global::BaskanTicaret.Properties.Resources.delete32px;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Width = 6;
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Preview";
            this.Tag = "Ürün Ekleme";
            this.Text = "Ürün Ekleme";
            this.Load += new System.EventHandler(this.Preview_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baskanTicaretDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BaskanTicaretDataSet1 baskanTicaretDataSet1;
        private System.Windows.Forms.BindingSource urunBindingSource;
        private BaskanTicaretDataSet1TableAdapters.urunTableAdapter urunTableAdapter;
        private FontAwesome.Sharp.IconButton btnMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunkodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunturDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aracseriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunaltmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunustmodelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urundurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunsutunDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunsatirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}