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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tol = new CustomControls.RJControls.RJTextBox();
            this.ig = new CustomControls.RJControls.RJTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tantargyak_combo = new System.Windows.Forms.ComboBox();
            this.osztaly = new System.Windows.Forms.ComboBox();
            this.osztalyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsNevek = new System.Data.Odbc.OdbcCommand();
            this.dsTantargy = new System.Data.Odbc.OdbcCommand();
            this.jelenletTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.jelenletTableAdapter();
            this.dsTantargyParameter = new System.Data.Odbc.OdbcCommand();
            this.dsOsztaly_id = new System.Data.Odbc.OdbcCommand();
            this.dsOsztaly_nev = new System.Data.Odbc.OdbcCommand();
            this.osztalyTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.osztalyTableAdapter();
            this.osztalyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tantargyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tantargyTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.tantargyTableAdapter();
            this.dsOSztalyNevId = new System.Data.Odbc.OdbcCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelenletBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatTablak)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tantargyBindingSource)).BeginInit();
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(3, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // jelenletidDataGridViewTextBoxColumn
            // 
            this.jelenletidDataGridViewTextBoxColumn.DataPropertyName = "jelenlet_id";
            this.jelenletidDataGridViewTextBoxColumn.HeaderText = "Jelenlét sorszáma";
            this.jelenletidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenletidDataGridViewTextBoxColumn.Name = "jelenletidDataGridViewTextBoxColumn";
            // 
            // diakidDataGridViewTextBoxColumn
            // 
            this.diakidDataGridViewTextBoxColumn.DataPropertyName = "diak_id";
            this.diakidDataGridViewTextBoxColumn.HeaderText = "Diák azonosítója";
            this.diakidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diakidDataGridViewTextBoxColumn.Name = "diakidDataGridViewTextBoxColumn";
            this.diakidDataGridViewTextBoxColumn.Visible = false;
            // 
            // diak_neve
            // 
            this.diak_neve.HeaderText = "Diák neve";
            this.diak_neve.MinimumWidth = 6;
            this.diak_neve.Name = "diak_neve";
            this.diak_neve.ReadOnly = true;
            // 
            // tantargyidDataGridViewTextBoxColumn
            // 
            this.tantargyidDataGridViewTextBoxColumn.DataPropertyName = "tantargy_id";
            this.tantargyidDataGridViewTextBoxColumn.HeaderText = "tantargy_id";
            this.tantargyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tantargyidDataGridViewTextBoxColumn.Name = "tantargyidDataGridViewTextBoxColumn";
            this.tantargyidDataGridViewTextBoxColumn.Visible = false;
            // 
            // tantargy_nevek
            // 
            this.tantargy_nevek.HeaderText = "Tantárgy neve";
            this.tantargy_nevek.MinimumWidth = 6;
            this.tantargy_nevek.Name = "tantargy_nevek";
            this.tantargy_nevek.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Dátum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            // 
            // jelenletDataGridViewTextBoxColumn
            // 
            this.jelenletDataGridViewTextBoxColumn.DataPropertyName = "jelenlet";
            this.jelenletDataGridViewTextBoxColumn.HeaderText = "jelenlet";
            this.jelenletDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenletDataGridViewTextBoxColumn.Name = "jelenletDataGridViewTextBoxColumn";
            this.jelenletDataGridViewTextBoxColumn.Visible = false;
            // 
            // jelenletek
            // 
            this.jelenletek.HeaderText = "Jelenlét";
            this.jelenletek.MinimumWidth = 6;
            this.jelenletek.Name = "jelenletek";
            this.jelenletek.ReadOnly = true;
            // 
            // osztaly_id
            // 
            this.osztaly_id.HeaderText = "Osztály azonosító";
            this.osztaly_id.MinimumWidth = 6;
            this.osztaly_id.Name = "osztaly_id";
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1308, 583);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tol, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ig, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tantargyak_combo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.osztaly, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1302, 285);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tol
            // 
            this.tol.BackColor = System.Drawing.SystemColors.Window;
            this.tol.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.tol.BorderFocusColor = System.Drawing.Color.HotPink;
            this.tol.BorderSize = 2;
            this.tol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.tol.ForeColor = System.Drawing.Color.DimGray;
            this.tol.Location = new System.Drawing.Point(4, 4);
            this.tol.Margin = new System.Windows.Forms.Padding(4);
            this.tol.Multiline = false;
            this.tol.Name = "tol";
            this.tol.Padding = new System.Windows.Forms.Padding(7);
            this.tol.PasswordChar = false;
            this.tol.Size = new System.Drawing.Size(250, 35);
            this.tol.TabIndex = 1;
            this.tol.Texts = "";
            this.tol.UnderlinedStyle = false;
            // 
            // ig
            // 
            this.ig.BackColor = System.Drawing.SystemColors.Window;
            this.ig.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.ig.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ig.BorderSize = 2;
            this.ig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ig.ForeColor = System.Drawing.Color.DimGray;
            this.ig.Location = new System.Drawing.Point(329, 4);
            this.ig.Margin = new System.Windows.Forms.Padding(4);
            this.ig.Multiline = false;
            this.ig.Name = "ig";
            this.ig.Padding = new System.Windows.Forms.Padding(7);
            this.ig.PasswordChar = false;
            this.ig.Size = new System.Drawing.Size(250, 35);
            this.ig.TabIndex = 0;
            this.ig.Texts = "";
            this.ig.UnderlinedStyle = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tantargyak_combo.FormattingEnabled = true;
            this.tantargyak_combo.Location = new System.Drawing.Point(653, 3);
            this.tantargyak_combo.Name = "tantargyak_combo";
            this.tantargyak_combo.Size = new System.Drawing.Size(319, 24);
            this.tantargyak_combo.TabIndex = 5;
            // 
            // osztaly
            // 
            this.osztaly.DataSource = this.osztalyBindingSource;
            this.osztaly.DisplayMember = "osztaly_nev";
            this.osztaly.FormattingEnabled = true;
            this.osztaly.Location = new System.Drawing.Point(978, 3);
            this.osztaly.Name = "osztaly";
            this.osztaly.Size = new System.Drawing.Size(321, 24);
            this.osztaly.TabIndex = 6;
            // 
            // osztalyBindingSource
            // 
            this.osztalyBindingSource.DataMember = "osztaly";
            this.osztalyBindingSource.DataSource = this.adatTablak;
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
            // tantargyBindingSource
            // 
            this.tantargyBindingSource.DataMember = "tantargy";
            this.tantargyBindingSource.DataSource = this.adatTablak;
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
            this.ClientSize = new System.Drawing.Size(1308, 583);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelenletBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatTablak)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tantargyBindingSource)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.RJControls.RJTextBox tol;
        private CustomControls.RJControls.RJTextBox ig;
        private System.Windows.Forms.Button button1;
        private System.Data.Odbc.OdbcCommand dsNevek;
        private System.Data.Odbc.OdbcCommand dsTantargy;
        private System.Windows.Forms.ComboBox tantargyak_combo;
        private System.Data.Odbc.OdbcCommand dsTantargyParameter;
        private System.Data.Odbc.OdbcCommand dsOsztaly_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diakidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diak_neve;
        private System.Windows.Forms.DataGridViewTextBoxColumn tantargyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tantargy_nevek;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletek;
        private System.Windows.Forms.DataGridViewTextBoxColumn osztaly_id;
        private System.Data.Odbc.OdbcCommand dsOsztaly_nev;
        private System.Windows.Forms.ComboBox osztaly;
        private System.Windows.Forms.BindingSource osztalyBindingSource;
        private AdatTablakTableAdapters.osztalyTableAdapter osztalyTableAdapter;
        private System.Windows.Forms.BindingSource osztalyBindingSource1;
        private System.Windows.Forms.BindingSource tantargyBindingSource;
        private AdatTablakTableAdapters.tantargyTableAdapter tantargyTableAdapter;
        private System.Data.Odbc.OdbcCommand dsOSztalyNevId;
    }
}