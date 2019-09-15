namespace Teckslick.Batch4.WinApp
{
    partial class frmCountries
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
            this.gvCountries = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.teckslick_Batch4DataSet = new Teckslick.Batch4.WinApp.Teckslick_Batch4DataSet();
            this.countryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countryTableAdapter = new Teckslick.Batch4.WinApp.Teckslick_Batch4DataSetTableAdapters.CountryTableAdapter();
            this.countryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teckslick_Batch4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gvCountries
            // 
            this.gvCountries.AutoGenerateColumns = false;
            this.gvCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCountries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.countryIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.gvCountries.DataSource = this.countryBindingSource;
            this.gvCountries.Location = new System.Drawing.Point(12, 12);
            this.gvCountries.Name = "gvCountries";
            this.gvCountries.Size = new System.Drawing.Size(325, 150);
            this.gvCountries.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(100, 168);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(181, 168);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(262, 168);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // teckslick_Batch4DataSet
            // 
            this.teckslick_Batch4DataSet.DataSetName = "Teckslick_Batch4DataSet";
            this.teckslick_Batch4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // countryBindingSource
            // 
            this.countryBindingSource.DataMember = "Country";
            this.countryBindingSource.DataSource = this.teckslick_Batch4DataSet;
            // 
            // countryTableAdapter
            // 
            this.countryTableAdapter.ClearBeforeFill = true;
            // 
            // countryIDDataGridViewTextBoxColumn
            // 
            this.countryIDDataGridViewTextBoxColumn.DataPropertyName = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.HeaderText = "CountryID";
            this.countryIDDataGridViewTextBoxColumn.Name = "countryIDDataGridViewTextBoxColumn";
            this.countryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // frmCountries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 213);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gvCountries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCountries";
            this.Text = "Countries";
            this.Load += new System.EventHandler(this.frmCountries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teckslick_Batch4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvCountries;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private Teckslick_Batch4DataSet teckslick_Batch4DataSet;
        private System.Windows.Forms.BindingSource countryBindingSource;
        private Teckslick_Batch4DataSetTableAdapters.CountryTableAdapter countryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
    }
}