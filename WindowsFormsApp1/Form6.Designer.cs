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
            this.cmd = new System.Data.Odbc.OdbcConnection();
            this.odbcCommand1 = new System.Data.Odbc.OdbcCommand();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adatTablak = new WindowsFormsApp1.AdatTablak();
            this.jelenletBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jelenletTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.jelenletTableAdapter();
            this.jelenletidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diakidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tantargyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jelenletDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            this.rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.odbcCommand2 = new System.Data.Odbc.OdbcCommand();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adatTablak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelenletBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd
            // 
            this.cmd.ConnectionString = "Dsn=localhost;uid=root;database=teachhelper;port=3306";
            // 
            // odbcCommand1
            // 
            this.odbcCommand1.CommandText = "SELECT datum, tantargy_id, osztaly_nev\r\nFROM     jelenlet\r\nWHERE  (datum BETWEEN " +
    "? AND ?) AND (tantargy_id = ?) AND (osztaly_nev = ?)";
            this.odbcCommand1.Connection = this.cmd;
            this.odbcCommand1.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("datum-tol", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("datum-ig", System.Data.Odbc.OdbcType.NVarChar, 0, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(20)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("tantargy", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null),
            new System.Data.Odbc.OdbcParameter("osztaly", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, null)});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jelenletidDataGridViewTextBoxColumn,
            this.diakidDataGridViewTextBoxColumn,
            this.tantargyidDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.jelenletDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jelenletBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1302, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // adatTablak
            // 
            this.adatTablak.DataSetName = "AdatTablak";
            this.adatTablak.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jelenletBindingSource
            // 
            this.jelenletBindingSource.DataMember = "jelenlet";
            this.jelenletBindingSource.DataSource = this.adatTablak;
            // 
            // jelenletTableAdapter
            // 
            this.jelenletTableAdapter.ClearBeforeFill = true;
            // 
            // jelenletidDataGridViewTextBoxColumn
            // 
            this.jelenletidDataGridViewTextBoxColumn.DataPropertyName = "jelenlet_id";
            this.jelenletidDataGridViewTextBoxColumn.HeaderText = "jelenlet_id";
            this.jelenletidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenletidDataGridViewTextBoxColumn.Name = "jelenletidDataGridViewTextBoxColumn";
            this.jelenletidDataGridViewTextBoxColumn.Width = 125;
            // 
            // diakidDataGridViewTextBoxColumn
            // 
            this.diakidDataGridViewTextBoxColumn.DataPropertyName = "diak_id";
            this.diakidDataGridViewTextBoxColumn.HeaderText = "diak_id";
            this.diakidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diakidDataGridViewTextBoxColumn.Name = "diakidDataGridViewTextBoxColumn";
            this.diakidDataGridViewTextBoxColumn.Width = 125;
            // 
            // tantargyidDataGridViewTextBoxColumn
            // 
            this.tantargyidDataGridViewTextBoxColumn.DataPropertyName = "tantargy_id";
            this.tantargyidDataGridViewTextBoxColumn.HeaderText = "tantargy_id";
            this.tantargyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tantargyidDataGridViewTextBoxColumn.Name = "tantargyidDataGridViewTextBoxColumn";
            this.tantargyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "datum";
            this.datumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.Width = 125;
            // 
            // jelenletDataGridViewTextBoxColumn
            // 
            this.jelenletDataGridViewTextBoxColumn.DataPropertyName = "jelenlet";
            this.jelenletDataGridViewTextBoxColumn.HeaderText = "jelenlet";
            this.jelenletDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jelenletDataGridViewTextBoxColumn.Name = "jelenletDataGridViewTextBoxColumn";
            this.jelenletDataGridViewTextBoxColumn.Width = 125;
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
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox4, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.rjTextBox1, 1, 0);
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
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox1.Location = new System.Drawing.Point(329, 4);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.Size = new System.Drawing.Size(250, 35);
            this.rjTextBox1.TabIndex = 0;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox2.Location = new System.Drawing.Point(4, 4);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.Size = new System.Drawing.Size(250, 35);
            this.rjTextBox2.TabIndex = 1;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox3.Location = new System.Drawing.Point(654, 4);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.Size = new System.Drawing.Size(250, 35);
            this.rjTextBox3.TabIndex = 2;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            this.rjTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.rjTextBox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjTextBox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox4.BorderSize = 2;
            this.rjTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.rjTextBox4.ForeColor = System.Drawing.Color.DimGray;
            this.rjTextBox4.Location = new System.Drawing.Point(979, 4);
            this.rjTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox4.Multiline = false;
            this.rjTextBox4.Name = "rjTextBox4";
            this.rjTextBox4.Padding = new System.Windows.Forms.Padding(7);
            this.rjTextBox4.PasswordChar = false;
            this.rjTextBox4.Size = new System.Drawing.Size(250, 35);
            this.rjTextBox4.TabIndex = 3;
            this.rjTextBox4.Texts = "";
            this.rjTextBox4.UnderlinedStyle = false;
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
            // odbcCommand2
            // 
            this.odbcCommand2.Connection = this.cmd;
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
            ((System.ComponentModel.ISupportInitialize)(this.adatTablak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jelenletBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.Odbc.OdbcConnection cmd;
        private System.Data.Odbc.OdbcCommand odbcCommand1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AdatTablak adatTablak;
        private System.Windows.Forms.BindingSource jelenletBindingSource;
        private AdatTablakTableAdapters.jelenletTableAdapter jelenletTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diakidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tantargyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jelenletDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Data.Odbc.OdbcCommand odbcCommand2;
    }
}