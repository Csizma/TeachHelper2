namespace WindowsFormsApp1
{
    partial class Form6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.con = new System.Data.Odbc.OdbcConnection();
            this.odbcCommand1 = new System.Data.Odbc.OdbcCommand();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.jelenletidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diakidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diak_neve = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tantargyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tantargy_nevek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelenletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelenletek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.osztaly_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelenletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adatTablak = new WindowsFormsApp1.AdatTablak();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tol = new CustomControls.RJControls.RJTextBox();
            this.tabelLayoutPanel1 = new WindowsFormsApp1.TabelLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lable3 = new System.Windows.Forms.Label();
            this.tantargyak_combo = new System.Windows.Forms.ComboBox();
            this.tantargyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.ig = new CustomControls.RJControls.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.osztaly = new System.Windows.Forms.ComboBox();
            this.osztalyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new CustomControls.RJControls.RJButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dsNevek = new System.Data.Odbc.OdbcCommand();
            this.dsTantargy = new System.Data.Odbc.OdbcCommand();
            this.jelenletTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.jelenletTableAdapter();
            this.dsTantargyParameter = new System.Data.Odbc.OdbcCommand();
            this.dsOsztaly_id = new System.Data.Odbc.OdbcCommand();
            this.dsOsztaly_nev = new System.Data.Odbc.OdbcCommand();
            this.osztalyTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.osztalyTableAdapter();
            this.osztalyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tantargyTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.tantargyTableAdapter();
            this.dsOSztalyNevId = new System.Data.Odbc.OdbcCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelenletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatTablak)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabelLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tantargyBindingSource)).BeginInit();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // con
            // 
            this.con.ConnectionString = "Dsn=localhost;uid=root;database=teachhelper;port=3306";
            // 
            // odbcCommand1
            // 
            this.odbcCommand1.CommandText = "SELECT datum, tantargy_id, osztaly_nev\r\nFROM     jelenlet\r\nWHERE  (datum BETWEEN " +
    "? AND ?) AND (tantargy_id = ?) AND (osztaly_nev = ?)";
            this.odbcCommand1.Connection = this.con;
            this.odbcCommand1.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("datum-tol", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("datum-ig", System.Data.Odbc.OdbcType.NVarChar, 0, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(20)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("tantargy", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("osztaly", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jelenletidDataGridViewTextBoxColumn,
            this.diakidDataGridViewTextBoxColumn,
            this.diak_neve,
            this.tantargyidDataGridViewTextBoxColumn,
            this.tantargy_nevek,
            this.datumDataGridViewTextBoxColumn,
            this.jelenletDataGridViewTextBoxColumn,
            this.jelenletek,
            this.osztaly_id});
            this.dataGridView1.DataSource = this.jelenletBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 510);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1762, 502);
            this.dataGridView1.TabIndex = 0;
            // 
            // jelenletidDataGridViewTextBoxColumn
            // 
            this.jelenletidDataGridViewTextBoxColumn.DataPropertyName = "jelenlet_id";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.jelenletidDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.jelenletidDataGridViewTextBoxColumn.HeaderText = "Jelenlét sorszáma";
            this.jelenletidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenletidDataGridViewTextBoxColumn.Name = "jelenletidDataGridViewTextBoxColumn";
            this.jelenletidDataGridViewTextBoxColumn.ReadOnly = true;
            this.jelenletidDataGridViewTextBoxColumn.Visible = false;
            // 
            // diakidDataGridViewTextBoxColumn
            // 
            this.diakidDataGridViewTextBoxColumn.DataPropertyName = "diak_id";
            this.diakidDataGridViewTextBoxColumn.HeaderText = "Diák azonosítója";
            this.diakidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diakidDataGridViewTextBoxColumn.Name = "diakidDataGridViewTextBoxColumn";
            this.diakidDataGridViewTextBoxColumn.ReadOnly = true;
            this.diakidDataGridViewTextBoxColumn.Visible = false;
            // 
            // diak_neve
            // 
            this.diak_neve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diak_neve.HeaderText = "Diák neve";
            this.diak_neve.MinimumWidth = 6;
            this.diak_neve.Name = "diak_neve";
            this.diak_neve.ReadOnly = true;
            this.diak_neve.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tantargyidDataGridViewTextBoxColumn
            // 
            this.tantargyidDataGridViewTextBoxColumn.DataPropertyName = "tantargy_id";
            this.tantargyidDataGridViewTextBoxColumn.HeaderText = "tantargy_id";
            this.tantargyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tantargyidDataGridViewTextBoxColumn.Name = "tantargyidDataGridViewTextBoxColumn";
            this.tantargyidDataGridViewTextBoxColumn.ReadOnly = true;
            this.tantargyidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tantargy_nevek
            // 
            this.tantargy_nevek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tantargy_nevek.HeaderText = "Tantárgy neve";
            this.tantargy_nevek.MinimumWidth = 6;
            this.tantargy_nevek.Name = "tantargy_nevek";
            this.tantargy_nevek.ReadOnly = true;
            this.tantargy_nevek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Dátum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            this.datumDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.datumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // jelenletDataGridViewTextBoxColumn
            // 
            this.jelenletDataGridViewTextBoxColumn.DataPropertyName = "jelenlet";
            this.jelenletDataGridViewTextBoxColumn.HeaderText = "jelenlet";
            this.jelenletDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenletDataGridViewTextBoxColumn.Name = "jelenletDataGridViewTextBoxColumn";
            this.jelenletDataGridViewTextBoxColumn.ReadOnly = true;
            this.jelenletDataGridViewTextBoxColumn.Visible = false;
            // 
            // jelenletek
            // 
            this.jelenletek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jelenletek.HeaderText = "Jelenlét";
            this.jelenletek.MinimumWidth = 6;
            this.jelenletek.Name = "jelenletek";
            this.jelenletek.ReadOnly = true;
            this.jelenletek.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // osztaly_id
            // 
            this.osztaly_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.osztaly_id.HeaderText = "Osztály azonosító";
            this.osztaly_id.MinimumWidth = 6;
            this.osztaly_id.Name = "osztaly_id";
            this.osztaly_id.ReadOnly = true;
            // 
            // jelenletBindingSource
            // 
            this.jelenletBindingSource.DataMember = "jelenlet";
            this.jelenletBindingSource.DataSource = this.adatTablak;
            // 
            // adatTablak
            // 
            this.adatTablak.DataSetName = "AdatTablak";
            this.adatTablak.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1768, 1015);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1762, 501);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.98861F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.498861F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.17084F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.17768F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.33485F));
            this.tableLayoutPanel3.Controls.Add(this.tol, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tabelLayoutPanel1, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.Lable3, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tantargyak_combo, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.osztaly, 4, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 170);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1756, 161);
            this.tableLayoutPanel3.TabIndex = 8;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tol
            // 
            this.tol.BackColor = System.Drawing.SystemColors.Window;
            this.tol.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tol.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tol.BorderSize = 2;
            this.tol.Cursor = System.Windows.Forms.Cursors.No;
            this.tol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tol.ForeColor = System.Drawing.Color.DimGray;
            this.tol.Location = new System.Drawing.Point(4, 122);
            this.tol.Margin = new System.Windows.Forms.Padding(4);
            this.tol.Multiline = false;
            this.tol.Name = "tol";
            this.tol.Padding = new System.Windows.Forms.Padding(7);
            this.tol.PasswordChar = false;
            this.tol.Size = new System.Drawing.Size(342, 35);
            this.tol.TabIndex = 1;
            this.tol.Texts = "";
            this.tol.UnderlinedStyle = false;
            this.tol._TextChanged += new System.EventHandler(this.tol__TextChanged);
            // 
            // tabelLayoutPanel1
            // 
            this.tabelLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tabelLayoutPanel1.ColumnCount = 2;
            this.tabelLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.7032F));
            this.tabelLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.2968F));
            this.tabelLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tabelLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelLayoutPanel1.Location = new System.Drawing.Point(431, 3);
            this.tabelLayoutPanel1.Name = "tabelLayoutPanel1";
            this.tabelLayoutPanel1.RowCount = 1;
            this.tabelLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabelLayoutPanel1.Size = new System.Drawing.Size(435, 106);
            this.tabelLayoutPanel1.TabIndex = 0;
            this.tabelLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tabelLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 51);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dátum";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dátum";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(1428, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "Osztály";
            // 
            // Lable3
            // 
            this.Lable3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Lable3.AutoSize = true;
            this.Lable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold);
            this.Lable3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Lable3.Location = new System.Drawing.Point(972, 61);
            this.Lable3.Name = "Lable3";
            this.Lable3.Size = new System.Drawing.Size(200, 51);
            this.Lable3.TabIndex = 9;
            this.Lable3.Text = "Tantárgy";
            // 
            // tantargyak_combo
            // 
            this.tantargyak_combo.AutoCompleteCustomSource.AddRange(new string[] {
            "Adatbázis-kezelés I.",
            "Asztali alkalmazások fejlesztése",
            "Fizika",
            "Hálózatok I. gyakorlat",
            "Idegen nyelv (angol)",
            "IKT projektmunka II.",
            "IT kompetencia fejlesztés",
            "Matematika",
            "Programozás",
            "Programozás (tehetséggondozás)",
            "Programozás gyakorlat",
            "Sportkör, tömegsport foglalkozás",
            "Szakmai angol"});
            this.tantargyak_combo.DataSource = this.tantargyBindingSource;
            this.tantargyak_combo.DisplayMember = "tantargy_nev";
            this.tantargyak_combo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tantargyak_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tantargyak_combo.FormattingEnabled = true;
            this.tantargyak_combo.Location = new System.Drawing.Point(872, 115);
            this.tantargyak_combo.Name = "tantargyak_combo";
            this.tantargyak_combo.Size = new System.Drawing.Size(400, 37);
            this.tantargyak_combo.TabIndex = 5;
            // 
            // tantargyBindingSource
            // 
            this.tantargyBindingSource.DataMember = "tantargy";
            this.tantargyBindingSource.DataSource = this.adatTablak;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel7.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.ig, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(431, 115);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(435, 43);
            this.tableLayoutPanel7.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(372, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 43);
            this.label5.TabIndex = 3;
            this.label5.Text = "-ig";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ig
            // 
            this.ig.BackColor = System.Drawing.SystemColors.Window;
            this.ig.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ig.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ig.BorderSize = 2;
            this.ig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ig.ForeColor = System.Drawing.Color.DimGray;
            this.ig.Location = new System.Drawing.Point(4, 4);
            this.ig.Margin = new System.Windows.Forms.Padding(4);
            this.ig.Multiline = false;
            this.ig.Name = "ig";
            this.ig.Padding = new System.Windows.Forms.Padding(7);
            this.ig.PasswordChar = false;
            this.ig.Size = new System.Drawing.Size(361, 35);
            this.ig.TabIndex = 1;
            this.ig.Texts = "";
            this.ig.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(353, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 49);
            this.label6.TabIndex = 14;
            this.label6.Text = "-tól";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // osztaly
            // 
            this.osztaly.DataSource = this.osztalyBindingSource;
            this.osztaly.DisplayMember = "osztaly_nev";
            this.osztaly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osztaly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.osztaly.FormattingEnabled = true;
            this.osztaly.Location = new System.Drawing.Point(1278, 115);
            this.osztaly.Name = "osztaly";
            this.osztaly.Size = new System.Drawing.Size(475, 37);
            this.osztaly.TabIndex = 6;
            // 
            // osztalyBindingSource
            // 
            this.osztalyBindingSource.DataMember = "osztaly";
            this.osztalyBindingSource.DataSource = this.adatTablak;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.tableLayoutPanel4.Controls.Add(this.button1, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1756, 161);
            this.tableLayoutPanel4.TabIndex = 9;
            this.tableLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.BackgroundColor = System.Drawing.Color.DarkOrange;
            this.button1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button1.BorderRadius = 0;
            this.button1.BorderSize = 0;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(664, 62);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(427, 93);
            this.button1.TabIndex = 7;
            this.button1.Text = "Lekérdezés";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.switch_top;
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1756, 161);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // dsNevek
            // 
            this.dsNevek.CommandText = "SELECT diak_nev\r\nFROM     diak\r\nWHERE  (diak_id = ?)";
            this.dsNevek.Connection = this.con;
            // 
            // dsTantargy
            // 
            this.dsTantargy.CommandText = "SELECT tantargy_nev\r\nFROM     tantargy\r\nWHERE  (tantargy_id = ?)";
            this.dsTantargy.Connection = this.con;
            // 
            // jelenletTableAdapter
            // 
            this.jelenletTableAdapter.ClearBeforeFill = true;
            // 
            // dsTantargyParameter
            // 
            this.dsTantargyParameter.CommandText = "SELECT tantargy_id\r\nFROM     tantargy\r\nWHERE  (tantargy_nev = ?)";
            this.dsTantargyParameter.Connection = this.con;
            this.dsTantargyParameter.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("nev", System.Data.Odbc.OdbcType.NVarChar, 90, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "")});
            // 
            // dsOsztaly_id
            // 
            this.dsOsztaly_id.CommandText = "SELECT osztaly_id\r\nFROM     diak\r\nWHERE  (diak_id = ?)";
            this.dsOsztaly_id.Connection = this.con;
            // 
            // dsOsztaly_nev
            // 
            this.dsOsztaly_nev.CommandText = "SELECT osztaly_nev\r\nFROM     osztaly\r\nWHERE  (osztaly_id = ?)";
            this.dsOsztaly_nev.Connection = this.con;
            // 
            // osztalyTableAdapter
            // 
            this.osztalyTableAdapter.ClearBeforeFill = true;
            // 
            // osztalyBindingSource1
            // 
            this.osztalyBindingSource1.DataMember = "osztaly";
            this.osztalyBindingSource1.DataSource = this.adatTablak;
            // 
            // tantargyTableAdapter
            // 
            this.tantargyTableAdapter.ClearBeforeFill = true;
            // 
            // dsOSztalyNevId
            // 
            this.dsOSztalyNevId.CommandText = "SELECT osztaly_id\r\nFROM     osztaly\r\nWHERE  (osztaly_nev = ?)";
            this.dsOSztalyNevId.Connection = this.con;
            this.dsOSztalyNevId.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("osztalynev", System.Data.Odbc.OdbcType.NVarChar, 30)});
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 1015);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form6_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelenletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatTablak)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabelLayoutPanel1.ResumeLayout(false);
            this.tabelLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tantargyBindingSource)).EndInit();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.Odbc.OdbcConnection con;
        private System.Data.Odbc.OdbcCommand odbcCommand1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdatTablak adatTablak;
        private System.Windows.Forms.BindingSource jelenletBindingSource;
        private AdatTablakTableAdapters.jelenletTableAdapter jelenletTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Data.Odbc.OdbcCommand dsNevek;
        private System.Data.Odbc.OdbcCommand dsTantargy;
        private System.Data.Odbc.OdbcCommand dsTantargyParameter;
        private System.Data.Odbc.OdbcCommand dsOsztaly_id;
        private System.Data.Odbc.OdbcCommand dsOsztaly_nev;
        private System.Windows.Forms.BindingSource osztalyBindingSource;
        private AdatTablakTableAdapters.osztalyTableAdapter osztalyTableAdapter;
        private System.Windows.Forms.BindingSource osztalyBindingSource1;
        private System.Windows.Forms.BindingSource tantargyBindingSource;
        private AdatTablakTableAdapters.tantargyTableAdapter tantargyTableAdapter;
        private System.Data.Odbc.OdbcCommand dsOSztalyNevId;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diakidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diak_neve;
        private System.Windows.Forms.DataGridViewTextBoxColumn tantargyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tantargy_nevek;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletek;
        private System.Windows.Forms.DataGridViewTextBoxColumn osztaly_id;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox tantargyak_combo;
        private System.Windows.Forms.ComboBox osztaly;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private CustomControls.RJControls.RJButton button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Lable3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private CustomControls.RJControls.RJTextBox ig;
        private System.Windows.Forms.Label label5;
        private TabelLayoutPanel tabelLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private CustomControls.RJControls.RJTextBox tol;
    }
}