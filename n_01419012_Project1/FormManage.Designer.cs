
namespace n_01419012_Project1
{
    partial class FormManage
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor3 = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.timePickerDate = new System.Windows.Forms.DateTimePicker();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.rdbAvailable = new System.Windows.Forms.RadioButton();
            this.rdbNotAvailable = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReserve = new System.Windows.Forms.Button();
            this.txtTextArea = new System.Windows.Forms.ListBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tableTableAdapter1 = new n_01419012_Project1.LibraryDatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableTableAdapter2 = new n_01419012_Project1.LibraryDatabaseDataSetTableAdapters.TableTableAdapter();
            this.btnAll = new System.Windows.Forms.Button();
            this.btbClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(640, 44);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 40);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(79, 59);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(64, 25);
            this.lblISBN.TabIndex = 24;
            this.lblISBN.Text = "ISBN";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(79, 113);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 25);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(79, 168);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(81, 25);
            this.lblAuthor.TabIndex = 26;
            this.lblAuthor.Text = "Author";
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPublisher.Location = new System.Drawing.Point(79, 221);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(111, 25);
            this.lblPublisher.TabIndex = 27;
            this.lblPublisher.Text = "Publisher";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(79, 275);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(203, 25);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "Date of publishing";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(79, 328);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(107, 25);
            this.lblCategory.TabIndex = 29;
            this.lblCategory.Text = "Category";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(79, 382);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(79, 25);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(314, 58);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(243, 26);
            this.txtISBN.TabIndex = 31;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(314, 112);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(243, 26);
            this.txtTitle.TabIndex = 32;
            // 
            // txtAuthor3
            // 
            this.txtAuthor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor3.Location = new System.Drawing.Point(314, 169);
            this.txtAuthor3.Name = "txtAuthor3";
            this.txtAuthor3.Size = new System.Drawing.Size(243, 26);
            this.txtAuthor3.TabIndex = 33;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(314, 222);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(354, 26);
            this.txtPublisher.TabIndex = 34;
            // 
            // timePickerDate
            // 
            this.timePickerDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerDate.Location = new System.Drawing.Point(314, 275);
            this.timePickerDate.Name = "timePickerDate";
            this.timePickerDate.Size = new System.Drawing.Size(243, 26);
            this.timePickerDate.TabIndex = 35;
            this.timePickerDate.Value = new System.DateTime(2021, 3, 24, 0, 0, 0, 0);
            this.timePickerDate.ValueChanged += new System.EventHandler(this.timePickerDate_ValueChanged);
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategory.Location = new System.Drawing.Point(314, 329);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(243, 26);
            this.txtCategory.TabIndex = 36;
            // 
            // rdbAvailable
            // 
            this.rdbAvailable.AutoSize = true;
            this.rdbAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAvailable.Location = new System.Drawing.Point(314, 382);
            this.rdbAvailable.Name = "rdbAvailable";
            this.rdbAvailable.Size = new System.Drawing.Size(104, 28);
            this.rdbAvailable.TabIndex = 37;
            this.rdbAvailable.TabStop = true;
            this.rdbAvailable.Text = "Available";
            this.rdbAvailable.UseVisualStyleBackColor = true;
            // 
            // rdbNotAvailable
            // 
            this.rdbNotAvailable.AutoSize = true;
            this.rdbNotAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNotAvailable.Location = new System.Drawing.Point(470, 379);
            this.rdbNotAvailable.Name = "rdbNotAvailable";
            this.rdbNotAvailable.Size = new System.Drawing.Size(138, 28);
            this.rdbNotAvailable.TabIndex = 38;
            this.rdbNotAvailable.TabStop = true;
            this.rdbNotAvailable.Text = "Not Available";
            this.rdbNotAvailable.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(41, 438);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 40);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(180, 438);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(102, 40);
            this.btnFind.TabIndex = 40;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReserve
            // 
            this.btnReserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Location = new System.Drawing.Point(481, 438);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(102, 40);
            this.btnReserve.TabIndex = 41;
            this.btnReserve.Text = "Reserve";
            this.btnReserve.UseVisualStyleBackColor = true;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtTextArea
            // 
            this.txtTextArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextArea.ForeColor = System.Drawing.Color.DarkBlue;
            this.txtTextArea.FormattingEnabled = true;
            this.txtTextArea.HorizontalScrollbar = true;
            this.txtTextArea.ItemHeight = 24;
            this.txtTextArea.Location = new System.Drawing.Point(34, 484);
            this.txtTextArea.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.txtTextArea.Name = "txtTextArea";
            this.txtTextArea.ScrollAlwaysVisible = true;
            this.txtTextArea.Size = new System.Drawing.Size(720, 292);
            this.txtTextArea.TabIndex = 44;
            this.txtTextArea.SelectedIndexChanged += new System.EventHandler(this.txtTextArea_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(332, 438);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 40);
            this.btnRemove.TabIndex = 45;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableTableAdapter2
            // 
            this.tableTableAdapter2.ClearBeforeFill = true;
            // 
            // btnAll
            // 
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.Location = new System.Drawing.Point(623, 438);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(102, 40);
            this.btnAll.TabIndex = 43;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btbClear
            // 
            this.btbClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbClear.Location = new System.Drawing.Point(652, 126);
            this.btbClear.Name = "btbClear";
            this.btbClear.Size = new System.Drawing.Size(102, 40);
            this.btbClear.TabIndex = 46;
            this.btbClear.Text = "Clear";
            this.btbClear.UseVisualStyleBackColor = true;
            this.btbClear.Click += new System.EventHandler(this.btbClear_Click);
            // 
            // FormManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 816);
            this.Controls.Add(this.btbClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.txtTextArea);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.rdbNotAvailable);
            this.Controls.Add(this.rdbAvailable);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.timePickerDate);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtAuthor3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.btnExit);
            this.Name = "FormManage";
            this.Text = "Library Management System : Main";
            this.Load += new System.EventHandler(this.FormManage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor3;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.DateTimePicker timePickerDate;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.RadioButton rdbAvailable;
        private System.Windows.Forms.RadioButton rdbNotAvailable;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.ListBox txtTextArea;
        private System.Windows.Forms.Button btnRemove;
        private LibraryDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter1;
        private LibraryDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter2;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btbClear;
    }
}