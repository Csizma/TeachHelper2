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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.datum = new System.Windows.Forms.Label();
            this.ido = new System.Windows.Forms.Label();
            this.nap = new System.Windows.Forms.Label();
            this.tabelLayoutPanel1 = new WindowsFormsApp1.TabelLayoutPanel();
            this.tabelLayoutPanel2 = new WindowsFormsApp1.TabelLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tantargy = new System.Windows.Forms.ComboBox();
            this.tantargyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.AdatTablak = new WindowsFormsApp1.AdatTablak();
            this.osztaly = new System.Windows.Forms.ComboBox();
            this.osztalyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.odbcConnection1 = new System.Data.Odbc.OdbcConnection();
            this.tantargyTableAdapter1 = new WindowsFormsApp1.AdatTablakTableAdapters.tantargyTableAdapter();
            this.osztalyTableAdapter = new WindowsFormsApp1.AdatTablakTableAdapters.osztalyTableAdapter();
            this.dsMent = new System.Data.Odbc.OdbcCommand();
            this.dsTantargyid = new System.Data.Odbc.OdbcCommand();
            this.huzhatosag1 = new WindowsFormsApp1.huzhatosag();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabelLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tantargyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdatTablak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabelLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.04318F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.95683F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 579);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.switchheader;
            this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.datum, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.ido, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.nap, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(757, 139);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // datum
            // 
            this.datum.AutoSize = true;
            this.datum.BackColor = System.Drawing.Color.Transparent;
            this.datum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.datum.Location = new System.Drawing.Point(255, 69);
            this.datum.Name = "datum";
            this.datum.Size = new System.Drawing.Size(246, 70);
            this.datum.TabIndex = 0;
            this.datum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ido
            // 
            this.ido.AutoSize = true;
            this.ido.BackColor = System.Drawing.Color.Transparent;
            this.ido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ido.Location = new System.Drawing.Point(507, 69);
            this.ido.Name = "ido";
            this.ido.Size = new System.Drawing.Size(247, 70);
            this.ido.TabIndex = 1;
            this.ido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nap
            // 
            this.nap.AutoSize = true;
            this.nap.BackColor = System.Drawing.Color.Transparent;
            this.nap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nap.Location = new System.Drawing.Point(3, 69);
            this.nap.Name = "nap";
            this.nap.Size = new System.Drawing.Size(246, 70);
            this.nap.TabIndex = 2;
            this.nap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabelLayoutPanel1
            // 
            this.tabelLayoutPanel1.ColumnCount = 1;
            this.tabelLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabelLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabelLayoutPanel1.Controls.Add(this.tabelLayoutPanel2, 0, 0);
            this.tabelLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tabelLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelLayoutPanel1.Location = new System.Drawing.Point(3, 148);
            this.tabelLayoutPanel1.Name = "tabelLayoutPanel1";
            this.tabelLayoutPanel1.RowCount = 2;
            this.tabelLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.56075F));
            this.tabelLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.43925F));
            this.tabelLayoutPanel1.Size = new System.Drawing.Size(757, 428);
            this.tabelLayoutPanel1.TabIndex = 1;
            // 
            // tabelLayoutPanel2
            // 
            this.tabelLayoutPanel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.switchtantargy;
            this.tabelLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabelLayoutPanel2.ColumnCount = 1;
            this.tabelLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabelLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tabelLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabelLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tabelLayoutPanel2.Name = "tabelLayoutPanel2";
            this.tabelLayoutPanel2.RowCount = 1;
            this.tabelLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabelLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tabelLayoutPanel2.Size = new System.Drawing.Size(751, 82);
            this.tabelLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Controls.Add(this.tantargy, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.osztaly, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.rjButton1, 1, 5);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.22654F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.13592F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.7438F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.98347F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.8595F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(751, 334);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tantargy
            // 
            this.tantargy.DataSource = this.tantargyBindingSource2;
            this.tantargy.DisplayMember = "tantargy_nev";
            this.tantargy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tantargy.FormattingEnabled = true;
            this.tantargy.Location = new System.Drawing.Point(265, 52);
            this.tantargy.Name = "tantargy";
            this.tantargy.Size = new System.Drawing.Size(219, 24);
            this.tantargy.TabIndex = 0;
            // 
            // tantargyBindingSource2
            // 
            this.tantargyBindingSource2.DataMember = "tantargy";
            this.tantargyBindingSource2.DataSource = this.AdatTablak;
            // 
            // AdatTablak
            // 
            this.AdatTablak.DataSetName = "AdatTablak";
            this.AdatTablak.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // osztaly
            // 
            this.osztaly.DataSource = this.osztalyBindingSource;
            this.osztaly.DisplayMember = "osztaly_nev";
            this.osztaly.Dock = System.Windows.Forms.DockStyle.Fill;
            this.osztaly.FormattingEnabled = true;
            this.osztaly.Location = new System.Drawing.Point(265, 107);
            this.osztaly.Name = "osztaly";
            this.osztaly.Size = new System.Drawing.Size(219, 24);
            this.osztaly.TabIndex = 1;
            // 
            // osztalyBindingSource
            // 
            this.osztalyBindingSource.DataMember = "osztaly";
            this.osztalyBindingSource.DataSource = this.AdatTablak;
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rjButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rjButton1.BorderRadius = 10;
            this.rjButton1.BorderSize = 0;
            this.rjButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.ForeColor = System.Drawing.Color.White;
            this.rjButton1.Location = new System.Drawing.Point(265, 201);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(219, 38);
            this.rjButton1.TabIndex = 2;
            this.rjButton1.Text = "rjButton1";
            this.rjButton1.TextColor = System.Drawing.Color.White;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // odbcConnection1
            // 
            this.odbcConnection1.ConnectionString = "Dsn=localhost;uid=root;database=teachhelper;port=3306";
            // 
            // tantargyTableAdapter1
            // 
            this.tantargyTableAdapter1.ClearBeforeFill = true;
            // 
            // osztalyTableAdapter
            // 
            this.osztalyTableAdapter.ClearBeforeFill = true;
            // 
            // dsMent
            // 
            this.dsMent.CommandText = "SELECT DISTINCT tanar.tanar_id AS tanarid, osztaly.osztaly_id AS osztalyid\r\nFROM " +
    "    tantargy, tanar, osztaly\r\nWHERE  (osztaly.osztaly_nev = ?) AND (tanar.tanar_" +
    "felhasznalonev = ?)";
            this.dsMent.Connection = this.odbcConnection1;
            this.dsMent.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("osztaly_id", System.Data.Odbc.OdbcType.NVarChar, 20, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "11.A I"),
            new System.Data.Odbc.OdbcParameter("tanar_nev", System.Data.Odbc.OdbcType.NVarChar, 30, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "csizmadia.adam")});
            // 
            // dsTantargyid
            // 
            this.dsTantargyid.CommandText = "SELECT tantargy_id\r\nFROM     tantargy\r\nWHERE  (tanar_id = ?)";
            this.dsTantargyid.Connection = this.odbcConnection1;
            this.dsTantargyid.Parameters.AddRange(new System.Data.Odbc.OdbcParameter[] {
            new System.Data.Odbc.OdbcParameter("tantargyid", System.Data.Odbc.OdbcType.NVarChar, 2, System.Data.ParameterDirection.InputOutput, false, ((byte)(0)), ((byte)(0)), "", System.Data.DataRowVersion.Current, "2")});
            // 
            // huzhatosag1
            // 
            this.huzhatosag1.SelectControl = this.tabelLayoutPanel2;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(763, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabelLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tantargyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdatTablak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.osztalyBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datum;
        private System.Windows.Forms.Label ido;
        private System.Windows.Forms.Label nap;
        private TabelLayoutPanel tabelLayoutPanel1;
        private TabelLayoutPanel tabelLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox tantargy;
        private System.Windows.Forms.ComboBox osztaly;
        private System.Data.Odbc.OdbcConnection odbcConnection1;
        private AdatTablak AdatTablak;
        private System.Windows.Forms.BindingSource tantargyBindingSource2;
        private AdatTablakTableAdapters.tantargyTableAdapter tantargyTableAdapter1;
        private System.Windows.Forms.BindingSource osztalyBindingSource;
        private AdatTablakTableAdapters.osztalyTableAdapter osztalyTableAdapter;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Data.Odbc.OdbcCommand dsMent;
        private System.Data.Odbc.OdbcCommand dsTantargyid;
        private huzhatosag huzhatosag1;
    }
}