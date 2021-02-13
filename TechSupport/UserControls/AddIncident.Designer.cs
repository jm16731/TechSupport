
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
            this.lblIncidentDescription = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboIncidentCustomer = new System.Windows.Forms.ComboBox();
            this.lblCustomerNameError = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.comboIncidentProduct = new System.Windows.Forms.ComboBox();
            this.lblProductNameError = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIncidentTitle = new System.Windows.Forms.TextBox();
            this.lblTitleError = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtIncidentDescription = new System.Windows.Forms.TextBox();
            this.lblDescriptionError = new System.Windows.Forms.Label();
            this.tblLayoutPnlAddIncident.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblLayoutPnlAddIncident
            // 
            this.tblLayoutPnlAddIncident.ColumnCount = 2;
            this.tblLayoutPnlAddIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPnlAddIncident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIncidentCustomerName, 0, 0);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblIncidentDescription, 0, 3);
            this.tblLayoutPnlAddIncident.Controls.Add(this.btnClear, 1, 4);
            this.tblLayoutPnlAddIncident.Controls.Add(this.btnAdd, 0, 4);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblProduct, 0, 1);
            this.tblLayoutPnlAddIncident.Controls.Add(this.lblTitle, 0, 2);
            this.tblLayoutPnlAddIncident.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tblLayoutPnlAddIncident.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tblLayoutPnlAddIncident.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tblLayoutPnlAddIncident.Controls.Add(this.tableLayoutPanel4, 1, 3);
            this.tblLayoutPnlAddIncident.Location = new System.Drawing.Point(3, 3);
            this.tblLayoutPnlAddIncident.Name = "tblLayoutPnlAddIncident";
            this.tblLayoutPnlAddIncident.RowCount = 5;
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 238F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tblLayoutPnlAddIncident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(887, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(344, 105);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.Clear_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(181, 505);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.comboIncidentCustomer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCustomerNameError, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(709, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(701, 87);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // comboIncidentCustomer
            // 
            this.comboIncidentCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIncidentCustomer.FormattingEnabled = true;
            this.comboIncidentCustomer.Location = new System.Drawing.Point(3, 3);
            this.comboIncidentCustomer.Name = "comboIncidentCustomer";
            this.comboIncidentCustomer.Size = new System.Drawing.Size(516, 39);
            this.comboIncidentCustomer.TabIndex = 16;
            this.comboIncidentCustomer.SelectedIndexChanged += new System.EventHandler(this.ComboCustomer_IndexChanged);
            // 
            // lblCustomerNameError
            // 
            this.lblCustomerNameError.AutoSize = true;
            this.lblCustomerNameError.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerNameError.Location = new System.Drawing.Point(3, 43);
            this.lblCustomerNameError.Name = "lblCustomerNameError";
            this.lblCustomerNameError.Size = new System.Drawing.Size(0, 32);
            this.lblCustomerNameError.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.comboIncidentProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblProductNameError, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(709, 96);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(701, 85);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // comboIncidentProduct
            // 
            this.comboIncidentProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIncidentProduct.FormattingEnabled = true;
            this.comboIncidentProduct.Location = new System.Drawing.Point(3, 3);
            this.comboIncidentProduct.Name = "comboIncidentProduct";
            this.comboIncidentProduct.Size = new System.Drawing.Size(516, 39);
            this.comboIncidentProduct.TabIndex = 17;
            this.comboIncidentProduct.SelectedIndexChanged += new System.EventHandler(this.ComboProduct_IndexChanged);
            // 
            // lblProductNameError
            // 
            this.lblProductNameError.AutoSize = true;
            this.lblProductNameError.ForeColor = System.Drawing.Color.Red;
            this.lblProductNameError.Location = new System.Drawing.Point(3, 42);
            this.lblProductNameError.Name = "lblProductNameError";
            this.lblProductNameError.Size = new System.Drawing.Size(0, 32);
            this.lblProductNameError.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtIncidentTitle, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblTitleError, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(709, 187);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(701, 74);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // txtIncidentTitle
            // 
            this.txtIncidentTitle.Location = new System.Drawing.Point(3, 3);
            this.txtIncidentTitle.Name = "txtIncidentTitle";
            this.txtIncidentTitle.Size = new System.Drawing.Size(516, 38);
            this.txtIncidentTitle.TabIndex = 15;
            this.txtIncidentTitle.TextChanged += new System.EventHandler(this.TextTitle_TextChanged);
            // 
            // lblTitleError
            // 
            this.lblTitleError.AutoSize = true;
            this.lblTitleError.ForeColor = System.Drawing.Color.Red;
            this.lblTitleError.Location = new System.Drawing.Point(3, 37);
            this.lblTitleError.Name = "lblTitleError";
            this.lblTitleError.Size = new System.Drawing.Size(0, 32);
            this.lblTitleError.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtIncidentDescription, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblDescriptionError, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(709, 267);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.18965F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.81034F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(701, 232);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // txtIncidentDescription
            // 
            this.txtIncidentDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIncidentDescription.Location = new System.Drawing.Point(3, 3);
            this.txtIncidentDescription.Multiline = true;
            this.txtIncidentDescription.Name = "txtIncidentDescription";
            this.txtIncidentDescription.Size = new System.Drawing.Size(516, 186);
            this.txtIncidentDescription.TabIndex = 7;
            this.txtIncidentDescription.TextChanged += new System.EventHandler(this.LblDescription_TextChanged);
            // 
            // lblDescriptionError
            // 
            this.lblDescriptionError.AutoSize = true;
            this.lblDescriptionError.ForeColor = System.Drawing.Color.Red;
            this.lblDescriptionError.Location = new System.Drawing.Point(3, 193);
            this.lblDescriptionError.Name = "lblDescriptionError";
            this.lblDescriptionError.Size = new System.Drawing.Size(0, 32);
            this.lblDescriptionError.TabIndex = 8;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblLayoutPnlAddIncident;
        private System.Windows.Forms.Label lblIncidentCustomerName;
        private System.Windows.Forms.Label lblIncidentDescription;
        private System.Windows.Forms.TextBox txtIncidentDescription;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtIncidentTitle;
        private System.Windows.Forms.ComboBox comboIncidentCustomer;
        private System.Windows.Forms.ComboBox comboIncidentProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCustomerNameError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblProductNameError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblTitleError;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblDescriptionError;
    }
}
