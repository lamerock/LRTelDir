namespace LRTelDir
{
    partial class mainFrm
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblNumRecords = new System.Windows.Forms.Label();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtMiddlename = new System.Windows.Forms.TextBox();
            this.txtPhoneID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCloseCancel = new System.Windows.Forms.Button();
            this.dgvTelDir = new System.Windows.Forms.DataGridView();
            this.grpSearch.SuspendLayout();
            this.grpInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelDir)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblNumRecords);
            this.grpSearch.Controls.Add(this.txtSearchKey);
            this.grpSearch.Controls.Add(this.cbxSearchBy);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.label2);
            this.grpSearch.ForeColor = System.Drawing.Color.Black;
            this.grpSearch.Location = new System.Drawing.Point(12, 12);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(200, 123);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Engine";
            // 
            // lblNumRecords
            // 
            this.lblNumRecords.AutoSize = true;
            this.lblNumRecords.Location = new System.Drawing.Point(6, 81);
            this.lblNumRecords.Name = "lblNumRecords";
            this.lblNumRecords.Size = new System.Drawing.Size(82, 13);
            this.lblNumRecords.TabIndex = 2;
            this.lblNumRecords.Text = "No. of Records:";
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Location = new System.Drawing.Point(77, 46);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(117, 20);
            this.txtSearchKey.TabIndex = 6;
            this.txtSearchKey.TextChanged += new System.EventHandler(this.txtSearchKey_TextChanged);
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Location = new System.Drawing.Point(77, 19);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(117, 21);
            this.cbxSearchBy.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search Key:";
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.txtNotes);
            this.grpInformation.Controls.Add(this.txtPhoneNumber);
            this.grpInformation.Controls.Add(this.txtAddress);
            this.grpInformation.Controls.Add(this.txtFirstname);
            this.grpInformation.Controls.Add(this.txtLastname);
            this.grpInformation.Controls.Add(this.txtMiddlename);
            this.grpInformation.Controls.Add(this.txtPhoneID);
            this.grpInformation.Controls.Add(this.label10);
            this.grpInformation.Controls.Add(this.label9);
            this.grpInformation.Controls.Add(this.label8);
            this.grpInformation.Controls.Add(this.label4);
            this.grpInformation.Controls.Add(this.label5);
            this.grpInformation.Controls.Add(this.label6);
            this.grpInformation.Controls.Add(this.label7);
            this.grpInformation.ForeColor = System.Drawing.Color.Black;
            this.grpInformation.Location = new System.Drawing.Point(218, 12);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(399, 123);
            this.grpInformation.TabIndex = 1;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Information";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(248, 71);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(143, 42);
            this.txtNotes.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(291, 45);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(291, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 13;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(98, 71);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(100, 20);
            this.txtFirstname.TabIndex = 12;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(98, 45);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(100, 20);
            this.txtLastname.TabIndex = 11;
            // 
            // txtMiddlename
            // 
            this.txtMiddlename.Location = new System.Drawing.Point(98, 97);
            this.txtMiddlename.Name = "txtMiddlename";
            this.txtMiddlename.Size = new System.Drawing.Size(100, 20);
            this.txtMiddlename.TabIndex = 10;
            // 
            // txtPhoneID
            // 
            this.txtPhoneID.Location = new System.Drawing.Point(98, 19);
            this.txtPhoneID.Name = "txtPhoneID";
            this.txtPhoneID.ReadOnly = true;
            this.txtPhoneID.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneID.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Notes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(204, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(237, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Phone ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "First Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Middle Name:";
            // 
            // btnNewSave
            // 
            this.btnNewSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSave.ForeColor = System.Drawing.Color.Black;
            this.btnNewSave.Location = new System.Drawing.Point(623, 25);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(114, 23);
            this.btnNewSave.TabIndex = 2;
            this.btnNewSave.Text = "&New";
            this.btnNewSave.UseVisualStyleBackColor = true;
            this.btnNewSave.Click += new System.EventHandler(this.btnNewSave_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnEditUpdate.Location = new System.Drawing.Point(623, 54);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(114, 23);
            this.btnEditUpdate.TabIndex = 3;
            this.btnEditUpdate.Text = "&Edit";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(623, 83);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCloseCancel
            // 
            this.btnCloseCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCloseCancel.Location = new System.Drawing.Point(623, 112);
            this.btnCloseCancel.Name = "btnCloseCancel";
            this.btnCloseCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCloseCancel.TabIndex = 5;
            this.btnCloseCancel.Text = "&Close";
            this.btnCloseCancel.UseVisualStyleBackColor = true;
            this.btnCloseCancel.Click += new System.EventHandler(this.btnCloseCancel_Click);
            // 
            // dgvTelDir
            // 
            this.dgvTelDir.AllowUserToAddRows = false;
            this.dgvTelDir.AllowUserToDeleteRows = false;
            this.dgvTelDir.AllowUserToOrderColumns = true;
            this.dgvTelDir.AllowUserToResizeColumns = false;
            this.dgvTelDir.AllowUserToResizeRows = false;
            this.dgvTelDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTelDir.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvTelDir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelDir.GridColor = System.Drawing.Color.Black;
            this.dgvTelDir.Location = new System.Drawing.Point(12, 141);
            this.dgvTelDir.Name = "dgvTelDir";
            this.dgvTelDir.ReadOnly = true;
            this.dgvTelDir.RowHeadersVisible = false;
            this.dgvTelDir.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTelDir.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTelDir.Size = new System.Drawing.Size(725, 256);
            this.dgvTelDir.TabIndex = 6;
            this.dgvTelDir.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelDir_CellClick);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(749, 409);
            this.Controls.Add(this.dgvTelDir);
            this.Controls.Add(this.btnCloseCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.grpInformation);
            this.Controls.Add(this.grpSearch);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(765, 447);
            this.MinimumSize = new System.Drawing.Size(765, 447);
            this.Name = "mainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telephone Directory";
            this.Load += new System.EventHandler(this.mainFrm_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelDir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNumRecords;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtMiddlename;
        private System.Windows.Forms.TextBox txtPhoneID;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCloseCancel;
        private System.Windows.Forms.DataGridView dgvTelDir;
    }
}

