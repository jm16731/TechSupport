
namespace TechSupport.UserControls
{
    partial class AddIncident
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
            this.tblLayoutPnlAddIncident = new System.Windows.Forms.TableLayoutPanel();
            this.lblIncidentCustomerName = new System.Windows.Forms.Label();
            this.lblIDError = new System.Windows.Forms.Label();
            this.txtIncidentDescription = new System.Windows.Forms.TextBox();
            this.lblIncidentDescription = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtIncidentTitle = new System.Windows.Forms.TextBox();
            this.comboIncidentCustomer = new System.Windows.Forms.ComboBox();
            this.comboIncidentProduct = new System.Windows.Forms.ComboBox();
            this.tblLayoutPnlAddIncident.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPnlAddIncident
            // 
            this.tblLayoutPnlAddIncident.ColumnCount = 2;
            this.tblLayoutPnlAddIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPnlAddIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIncidentCustomerName, 0, 0);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIDError, 1, 4);
            this.tblLayoutPnlAddIncident.Controls.Add(this.txtIncidentDescription, 1, 3);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIncidentDescription, 0, 3);
            this.tblLayoutPnlAddIncident.Controls.Add(this.btnClear, 1, 5);
            this.tblLayoutPnlAddIncident.Controls.Add(this.btnAdd, 0, 5);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblProduct, 0, 1);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblTitle, 0, 2);
            this.tblLayoutPnlAddIncident.Controls.Add(this.txtIncidentTitle, 1, 2);
            this.tblLayoutPnlAddIncident.Controls.Add(this.comboIncidentCustomer, 1, 0);
            this.tblLayoutPnlAddIncident.Controls.Add(this.comboIncidentProduct, 1, 1);
            this.tblLayoutPnlAddIncident.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPnlAddIncident.Name = "tblLayoutPnlAddIncident";
            this.tblLayoutPnlAddIncident.RowCount = 6;
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tblLayoutPnlAddIncident.Size = new System.Drawing.Size(1413, 664);
            this.tblLayoutPnlAddIncident.TabIndex = 0;
            // 
            // lblIncidentCustomerName
            // 
            this.lblIncidentCustomerName.AutoSize = true;
            this.lblIncidentCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentCustomerName.Location = new System.Drawing.Point(3, 0);
            this.lblIncidentCustomerName.Name = "lblIncidentCustomerName";
            this.lblIncidentCustomerName.Size = new System.Drawing.Size(193, 46);
            this.lblIncidentCustomerName.TabIndex = 3;
            this.lblIncidentCustomerName.Text = "Customer";
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.Location = new System.Drawing.Point(709, 424);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(0, 46);
            this.lblIDError.TabIndex = 11;
            // 
            // txtIncidentDescription
            // 
            this.txtIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentDescription.Location = new System.Drawing.Point(709, 267);
            this.txtIncidentDescription.Multiline = true;
            this.txtIncidentDescription.Name = "txtIncidentDescription";
            this.txtIncidentDescription.Size = new System.Drawing.Size(556, 152);
            this.txtIncidentDescription.TabIndex = 7;
            this.txtIncidentDescription.TextChanged += new System.EventHandler(this.LblDescription_TextChanged);
            // 
            // lblIncidentDescription
            // 
            this.lblIncidentDescription.AutoSize = true;
            this.lblIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentDescription.Location = new System.Drawing.Point(3, 264);
            this.lblIncidentDescription.Name = "lblIncidentDescription";
            this.lblIncidentDescription.Size = new System.Drawing.Size(221, 46);
            this.lblIncidentDescription.TabIndex = 5;
            this.lblIncidentDescription.Text = "Description";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(709, 519);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(344, 105);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 519);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(344, 105);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Create Incident";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(3, 93);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(159, 46);
            this.lblProduct.TabIndex = 12;
            this.lblProduct.Text = "Product";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(3, 184);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 46);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            // 
            // txtIncidentTitle
            // 
            this.txtIncidentTitle.Location = new System.Drawing.Point(709, 187);
            this.txtIncidentTitle.Name = "txtIncidentTitle";
            this.txtIncidentTitle.Size = new System.Drawing.Size(516, 38);
            this.txtIncidentTitle.TabIndex = 15;
            // 
            // comboIncidentCustomer
            // 
            this.comboIncidentCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIncidentCustomer.FormattingEnabled = true;
            this.comboIncidentCustomer.Location = new System.Drawing.Point(709, 3);
            this.comboIncidentCustomer.Name = "comboIncidentCustomer";
            this.comboIncidentCustomer.Size = new System.Drawing.Size(516, 39);
            this.comboIncidentCustomer.TabIndex = 16;
            // 
            // comboIncidentProduct
            // 
            this.comboIncidentProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIncidentProduct.FormattingEnabled = true;
            this.comboIncidentProduct.Location = new System.Drawing.Point(709, 96);
            this.comboIncidentProduct.Name = "comboIncidentProduct";
            this.comboIncidentProduct.Size = new System.Drawing.Size(516, 39);
            this.comboIncidentProduct.TabIndex = 17;
            // 
            // AddIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblLayoutPnlAddIncident);
            this.Name = "AddIncident";
            this.Size = new System.Drawing.Size(1416, 667);
            this.tblLayoutPnlAddIncident.ResumeLayout(false);
            this.tblLayoutPnlAddIncident.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPnlAddIncident;
        private System.Windows.Forms.Label lblIncidentCustomerName;
        private System.Windows.Forms.Label lblIncidentDescription;
        private System.Windows.Forms.TextBox txtIncidentDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtIncidentTitle;
        private System.Windows.Forms.ComboBox comboIncidentCustomer;
        private System.Windows.Forms.ComboBox comboIncidentProduct;
    }
}
