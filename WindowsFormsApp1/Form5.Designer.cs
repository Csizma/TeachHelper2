namespace WindowsFormsApp1
{
    partial class Form5
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tantargy = new System.Windows.Forms.Label();
            this.nap = new System.Windows.Forms.Label();
            this.datum = new System.Windows.Forms.Label();
            this.ora = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.osztaly = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.letsz = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diaknevDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jelenlét = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.diakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdatTablak = new WindowsFormsApp1.AdatTablak();
            this.con = new System.Data.Odbc.OdbcConnection();
            this.dsOsztaly = new System.Data.Odbc.OdbcCommand();
            this.dsOsszehasonlit = new System.Data.Odbc.OdbcCommand();
            this.osztaly_idToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.osztaly_idToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.diakTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.diakTableAdapter();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdatTablak)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.13984F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.86016F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1311, 851);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.88417F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.11583F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1305, 259);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.naploheader;
            this.tableLayoutPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 175F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1299, 175);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 11;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.00231F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.62894F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.00231F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16782F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.925327F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32102F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.618168F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.32102F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.618168F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52631F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.631578F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.tantargy, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.nap, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.datum, 5, 1);
            this.tableLayoutPanel4.Controls.Add(this.ora, 7, 1);
            this.tableLayoutPanel4.Controls.Add(this.rjButton1, 9, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 184);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.24779F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.75221F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1299, 72);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tantargy
            // 
            this.tantargy.AutoSize = true;
            this.tantargy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tantargy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tantargy.Location = new System.Drawing.Point(42, 31);
            this.tantargy.Name = "tantargy";
            this.tantargy.Size = new System.Drawing.Size(223, 41);
            this.tantargy.TabIndex = 0;
            this.tantargy.Text = "Tantárgy";
            this.tantargy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nap
            // 
            this.nap.AutoSize = true;
            this.nap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nap.Location = new System.Drawing.Point(310, 31);
            this.nap.Name = "nap";
            this.nap.Size = new System.Drawing.Size(230, 41);
            this.nap.TabIndex = 1;
            this.nap.Text = "nap";
            this.nap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datum.Location = new System.Drawing.Point(584, 31);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(219, 41);
            this.datum.TabIndex = 2;
            this.datum.Text = "dátum";
            this.datum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ora
            // 
            this.ora.AutoSize = true;
            this.ora.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ora.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ora.Location = new System.Drawing.Point(856, 31);
            this.ora.Name = "ora";
            this.ora.Size = new System.Drawing.Size(219, 41);
            this.ora.TabIndex = 3;
            this.ora.Text = "óra";
            this.ora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 268);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.81633F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.18367F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1305, 580);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.switchorange;
            this.tableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1299, 114);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 6;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.89189F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21622F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.21622F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.osztaly, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.label2, 3, 1);
            this.tableLayoutPanel7.Controls.Add(this.letsz, 4, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1293, 108);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(221, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Osztály neve:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // osztaly
            // 
            this.osztaly.AutoSize = true;
            this.osztaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osztaly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.osztaly.Location = new System.Drawing.Point(439, 36);
            this.osztaly.Name = "osztaly";
            this.osztaly.Size = new System.Drawing.Size(103, 32);
            this.osztaly.TabIndex = 1;
            this.osztaly.Text = "osztaly";
            this.osztaly.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(657, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Létszám:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // letsz
            // 
            this.letsz.AutoSize = true;
            this.letsz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.letsz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.letsz.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.letsz.Location = new System.Drawing.Point(875, 36);
            this.letsz.Name = "letsz";
            this.letsz.Size = new System.Drawing.Size(203, 36);
            this.letsz.TabIndex = 4;
            this.letsz.Text = "szám";
            this.letsz.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diaknevDataGridViewTextBoxColumn,
            this.Jelenlét});
            this.dataGridView1.DataSource = this.diakBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1299, 454);
            this.dataGridView1.TabIndex = 1;
            // 
            // diaknevDataGridViewTextBoxColumn
            // 
            this.diaknevDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diaknevDataGridViewTextBoxColumn.DataPropertyName = "diak_nev";
            this.diaknevDataGridViewTextBoxColumn.HeaderText = "diak_nev";
            this.diaknevDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaknevDataGridViewTextBoxColumn.Name = "diaknevDataGridViewTextBoxColumn";
            // 
            // Jelenlét
            // 
            this.Jelenlét.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Jelenlét.FalseValue = "0";
            this.Jelenlét.HeaderText = "Jelentlét";
            this.Jelenlét.MinimumWidth = 6;
            this.Jelenlét.Name = "Jelenlét";
            this.Jelenlét.TrueValue = "1";
            // 
            // diakBindingSource
            // 
            this.diakBindingSource.DataMember = "diak";
            this.diakBindingSource.DataSource = this.AdatTablak;
            // 
            // AdatTablak
            // 
            this.AdatTablak.DataSetName = "AdatTablak";
            this.AdatTablak.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // con
            // 
            this.con.ConnectionString = "Dsn=localhost;uid=root;database=teachhelper;port=3306";
            // 
            // dsOsztaly
            // 
            this.dsOsztaly.CommandText = "SELECT osztaly_id\r\nFROM     osztaly\r\nWHERE  (osztaly_nev = ?)";
            this.dsOsztaly.Connection = this.con;
            this.dsOsztaly.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("osztaly", System.Data.Odbc.OdbcType.NVarChar, 30, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // dsOsszehasonlit
            // 
            this.dsOsszehasonlit.CommandText = "SELECT COUNT(diak.diak_nev) AS diak_id\r\nFROM     osztaly, diak\r\nWHERE  (osztaly.o" +
    "sztaly_id = ?) AND (diak.osztaly_id = ?)";
            this.dsOsszehasonlit.Connection = this.con;
            this.dsOsszehasonlit.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("oszdiakid", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("diakdiakid", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // osztaly_idToolStripLabel
            // 
            this.osztaly_idToolStripLabel.Name = "osztaly_idToolStripLabel";
            this.osztaly_idToolStripLabel.Size = new System.Drawing.Size(23, 23);
            // 
            // osztaly_idToolStripTextBox
            // 
            this.osztaly_idToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.osztaly_idToolStripTextBox.Name = "osztaly_idToolStripTextBox";
            this.osztaly_idToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // diakTableAdapter
            // 
            this.diakTableAdapter.ClearBeforeFill = true;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.DimGray;
            this.rjButton1.BackgroundColor = System.Drawing.Color.DimGray;
            this.rjButton1.BorderColor = System.Drawing.Color.White;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(1128, 34);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(131, 35);
            this.rjButton1.TabIndex = 4;
            this.rjButton1.Text = "Vissza ";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 851);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdatTablak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label tantargy;
        private System.Windows.Forms.Label nap;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label ora;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label osztaly;
        private AdatTablak AdatTablak;
        private System.Data.Odbc.OdbcConnection con;
        private System.Data.Odbc.OdbcCommand dsOsztaly;
        private System.Data.Odbc.OdbcCommand dsOsszehasonlit;
        private System.Windows.Forms.DataGridViewTextBoxColumn diakidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn osztalyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn kepDataGridViewImageColumn;
        private System.Windows.Forms.ToolStripLabel osztaly_idToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox osztaly_idToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label letsz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource diakBindingSource;
        private AdatTablakTableAdapters.diakTableAdapter diakTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaknevDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Jelenlét;
    }
}