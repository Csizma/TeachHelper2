namespace WindowsFormsApp1
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.óraSzámDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hétfőDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.szerdaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.csütörtökDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.péntekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orarendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachhelperDataSet5 = new WindowsFormsApp1.teachhelperDataSet5();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.datum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
            this.odbcCommand1 = new System.Data.Odbc.OdbcCommand();
            this.odbcDataAdapter1 = new System.Data.Odbc.OdbcDataAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.odbcCommand2 = new System.Data.Odbc.OdbcCommand();
            this.orarendTableAdapter = new WindowsFormsApp1.teachhelperDataSet5TableAdapters.orarendTableAdapter();
            this.odbcCommand3 = new System.Data.Odbc.OdbcCommand();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orarendBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachhelperDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.orarend_bal;
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(1768, 1015);
            this.splitContainer1.SplitterDistance = 589;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.12808F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.87192F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1175, 1015);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeight = 50;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.óraSzámDataGridViewTextBoxColumn,
            this.hétfőDataGridViewTextBoxColumn,
            this.keddDataGridViewTextBoxColumn,
            this.szerdaDataGridViewTextBoxColumn,
            this.csütörtökDataGridViewTextBoxColumn,
            this.péntekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.orarendBindingSource;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 390);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1169, 622);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // óraSzámDataGridViewTextBoxColumn
            // 
            this.óraSzámDataGridViewTextBoxColumn.DataPropertyName = "Óra szám";
            this.óraSzámDataGridViewTextBoxColumn.HeaderText = "Óra szám";
            this.óraSzámDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.óraSzámDataGridViewTextBoxColumn.Name = "óraSzámDataGridViewTextBoxColumn";
            this.óraSzámDataGridViewTextBoxColumn.Width = 125;
            // 
            // hétfőDataGridViewTextBoxColumn
            // 
            this.hétfőDataGridViewTextBoxColumn.DataPropertyName = "Hétfő";
            this.hétfőDataGridViewTextBoxColumn.HeaderText = "Hétfő";
            this.hétfőDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hétfőDataGridViewTextBoxColumn.Name = "hétfőDataGridViewTextBoxColumn";
            this.hétfőDataGridViewTextBoxColumn.Width = 125;
            // 
            // keddDataGridViewTextBoxColumn
            // 
            this.keddDataGridViewTextBoxColumn.DataPropertyName = "Kedd";
            this.keddDataGridViewTextBoxColumn.HeaderText = "Kedd";
            this.keddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.keddDataGridViewTextBoxColumn.Name = "keddDataGridViewTextBoxColumn";
            this.keddDataGridViewTextBoxColumn.Width = 125;
            // 
            // szerdaDataGridViewTextBoxColumn
            // 
            this.szerdaDataGridViewTextBoxColumn.DataPropertyName = "Szerda";
            this.szerdaDataGridViewTextBoxColumn.HeaderText = "Szerda";
            this.szerdaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.szerdaDataGridViewTextBoxColumn.Name = "szerdaDataGridViewTextBoxColumn";
            this.szerdaDataGridViewTextBoxColumn.Width = 125;
            // 
            // csütörtökDataGridViewTextBoxColumn
            // 
            this.csütörtökDataGridViewTextBoxColumn.DataPropertyName = "Csütörtök";
            this.csütörtökDataGridViewTextBoxColumn.HeaderText = "Csütörtök";
            this.csütörtökDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.csütörtökDataGridViewTextBoxColumn.Name = "csütörtökDataGridViewTextBoxColumn";
            this.csütörtökDataGridViewTextBoxColumn.Width = 125;
            // 
            // péntekDataGridViewTextBoxColumn
            // 
            this.péntekDataGridViewTextBoxColumn.DataPropertyName = "Péntek";
            this.péntekDataGridViewTextBoxColumn.HeaderText = "Péntek";
            this.péntekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.péntekDataGridViewTextBoxColumn.Name = "péntekDataGridViewTextBoxColumn";
            this.péntekDataGridViewTextBoxColumn.Width = 125;
            // 
            // orarendBindingSource
            // 
            this.orarendBindingSource.DataMember = "orarend";
            this.orarendBindingSource.DataSource = this.teachhelperDataSet5;
            // 
            // teachhelperDataSet5
            // 
            this.teachhelperDataSet5.DataSetName = "teachhelperDataSet5";
            this.teachhelperDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.kep_jobb_orarend;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 181);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(188, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 375);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.Dock = System.Windows.Forms.DockStyle.Top;
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datum.Location = new System.Drawing.Point(3, 90);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(223, 32);
            this.datum.TabIndex = 3;
            this.datum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mai dátum:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ido
            // 
            this.ido.AutoSize = true;
            this.ido.Dock = System.Windows.Forms.DockStyle.Top;
            this.ido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ido.Location = new System.Drawing.Point(3, 90);
            this.ido.Name = "ido";
            this.ido.Size = new System.Drawing.Size(223, 32);
            this.ido.TabIndex = 3;
            this.ido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(3, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jelenlegi idő:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // odbcConnection1
            // 
            this.odbcConnection1.ConnectionString = "Dsn=localhost;uid=root;database=teachhelper;port=3306";
            // 
            // odbcCommand1
            // 
            this.odbcCommand1.CommandText = "SELECT `Óra szám`, Hétfő, Kedd, Szerda, Csütörtök, Péntek\r\nFROM     orarend\r\nWHER" +
    "E  (tanar = ?)";
            this.odbcCommand1.Connection = this.odbcConnection1;
            this.odbcCommand1.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("nev", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // odbcDataAdapter1
            // 
            this.odbcDataAdapter1.SelectCommand = this.odbcCommand1;
            this.odbcDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Table", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("Hétfő", "Hétfő"),
                        new System.Data.Common.DataColumnMapping("Kedd", "Kedd"),
                        new System.Data.Common.DataColumnMapping("Szerda", "Szerda"),
                        new System.Data.Common.DataColumnMapping("Csütörtök", "Csütörtök"),
                        new System.Data.Common.DataColumnMapping("Péntek", "Péntek"),
                        new System.Data.Common.DataColumnMapping("Óra szám", "Óra szám")})});
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // odbcCommand2
            // 
            this.odbcCommand2.CommandText = "INSERT INTO n_orak\r\n                  (osztaly, ora)\r\nVALUES (?, ?)";
            this.odbcCommand2.Connection = this.odbcConnection1;
            this.odbcCommand2.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("osztaly", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("ora", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // orarendTableAdapter
            // 
            this.orarendTableAdapter.ClearBeforeFill = true;
            // 
            // odbcCommand3
            // 
            this.odbcCommand3.CommandText = "SELECT COUNT(osztaly) AS naplo\r\nFROM     n_orak\r\nWHERE  (ora = ?) AND (nap = ?) A" +
    "ND (osztaly = ?) AND (idő = ?);";
            this.odbcCommand3.Connection = this.odbcConnection1;
            this.odbcCommand3.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("ora", System.Data.Odbc.OdbcType.NVarChar, 30, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("nap", System.Data.Odbc.OdbcType.NVarChar, 30, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("osztaly", System.Data.Odbc.OdbcType.NVarChar, 30, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("idő", System.Data.Odbc.OdbcType.NVarChar, 30, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1768, 1015);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Órarend";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orarendBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachhelperDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
        private System.Data.Odbc.OdbcCommand odbcCommand1;
        private System.Data.Odbc.OdbcDataAdapter odbcDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TabelLayoutPanel tabelLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private TabelLayoutPanel tabelLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private TabelLayoutPanel tabelLayoutPanel3;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private TabelLayoutPanel tabelLayoutPanel4;
        private System.Windows.Forms.Label ido;
        private System.Windows.Forms.Label label3;
        private System.Data.Odbc.OdbcCommand odbcCommand2;
        private teachhelperDataSet5 teachhelperDataSet5;
        private System.Windows.Forms.DataGridViewTextBoxColumn óraSzámDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hétfőDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn szerdaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn csütörtökDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn péntekDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orarendBindingSource;
        private teachhelperDataSet5TableAdapters.orarendTableAdapter orarendTableAdapter;
        private System.Data.Odbc.OdbcCommand odbcCommand3;
    }
}