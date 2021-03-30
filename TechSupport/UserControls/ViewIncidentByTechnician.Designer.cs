
namespace TechSupport.UserControls
{
    partial class ViewIncidentByTechnician
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.viewIncidents = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTechnicians = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.comboTechnicians = new System.Windows.Forms.ComboBox();
            this.techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.techSupportDataSet = new TechSupport.TechSupportDataSet();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.techniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.TechniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter();
            this.openIncidentsByTechnicianBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openIncidentsByTechnicianTableAdapter = new TechSupport.TechSupportDataSetTableAdapters.OpenIncidentsByTechnicianTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.viewIncidents)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechnicianBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // viewIncidents
            // 
            this.viewIncidents.AllowUserToAddRows = false;
            this.viewIncidents.AllowUserToDeleteRows = false;
            this.viewIncidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewIncidents.Location = new System.Drawing.Point(3, 241);
            this.viewIncidents.Name = "viewIncidents";
            this.viewIncidents.ReadOnly = true;
            this.viewIncidents.RowHeadersWidth = 102;
            this.viewIncidents.RowTemplate.Height = 40;
            this.viewIncidents.Size = new System.Drawing.Size(1410, 360);
            this.viewIncidents.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.29299F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.70701F));
            this.tableLayoutPanel1.Controls.Add(this.lblTechnicians, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboTechnicians, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1413, 244);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblTechnicians
            // 
            this.lblTechnicians.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTechnicians.AutoSize = true;
            this.lblTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTechnicians.Location = new System.Drawing.Point(83, 17);
            this.lblTechnicians.Name = "lblTechnicians";
            this.lblTechnicians.Size = new System.Drawing.Size(148, 46);
            this.lblTechnicians.TabIndex = 0;
            this.lblTechnicians.Text = "Name: ";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(86, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(142, 46);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email: ";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(83, 179);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(147, 46);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone:";
            // 
            // comboTechnicians
            // 
            this.comboTechnicians.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboTechnicians.DataSource = this.techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource;
            this.comboTechnicians.DisplayMember = "Name";
            this.comboTechnicians.FormattingEnabled = true;
            this.comboTechnicians.Location = new System.Drawing.Point(317, 20);
            this.comboTechnicians.Name = "comboTechnicians";
            this.comboTechnicians.Size = new System.Drawing.Size(872, 39);
            this.comboTechnicians.TabIndex = 1;
            this.comboTechnicians.ValueMember = "TechID";
            this.comboTechnicians.SelectionChangeCommitted += new System.EventHandler(this.PopulateData);
            // 
            // techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource
            // 
            this.techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource.DataMember = "TechniciansWhoHaveHandledOrAreHandlingIncidents";
            this.techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource.DataSource = this.techSupportDataSet;
            // 
            // techSupportDataSet
            // 
            this.techSupportDataSet.DataSetName = "TechSupportDataSet";
            this.techSupportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(317, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(872, 45);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(317, 179);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(872, 45);
            this.txtPhone.TabIndex = 3;
            // 
            // techniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter
            // 
            this.techniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter.ClearBeforeFill = true;
            // 
            // openIncidentsByTechnicianBindingSource
            // 
            this.openIncidentsByTechnicianBindingSource.DataMember = "OpenIncidentsByTechnician";
            this.openIncidentsByTechnicianBindingSource.DataSource = this.techSupportDataSet;
            // 
            // openIncidentsByTechnicianTableAdapter
            // 
            this.openIncidentsByTechnicianTableAdapter.ClearBeforeFill = true;
            // 
            // ViewIncidentByTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewIncidents);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewIncidentByTechnician";
            this.Size = new System.Drawing.Size(1416, 667);
            ((System.ComponentModel.ISupportInitialize)(this.viewIncidents)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.techSupportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsByTechnicianBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewIncidents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTechnicians;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.ComboBox comboTechnicians;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.BindingSource techniciansWhoHaveHandledOrAreHandlingIncidentsBindingSource;
        private TechSupportDataSet techSupportDataSet;
        private TechSupportDataSetTableAdapters.TechniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter techniciansWhoHaveHandledOrAreHandlingIncidentsTableAdapter;
        private System.Windows.Forms.BindingSource openIncidentsByTechnicianBindingSource;
        private TechSupportDataSetTableAdapters.OpenIncidentsByTechnicianTableAdapter openIncidentsByTechnicianTableAdapter;
    }
}
