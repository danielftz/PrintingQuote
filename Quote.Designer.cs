
namespace BookQuote
{
    partial class quoteForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label label2;
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameInput = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.bookCountLabel = new System.Windows.Forms.Label();
            this.bookCount = new System.Windows.Forms.TextBox();
            this.userInputGroup = new System.Windows.Forms.GroupBox();
            this.sig16Count = new System.Windows.Forms.TextBox();
            this.sig12Count = new System.Windows.Forms.TextBox();
            this.sig4Count = new System.Windows.Forms.TextBox();
            this.sig8Count = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.quoteButton = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sig8Label = new System.Windows.Forms.Label();
            this.bookCountList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.quoteTable = new System.Windows.Forms.DataGridView();
            this.bookCount_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perBookCost_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.existingCompanyLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.jobName = new System.Windows.Forms.TextBox();
            this.memo = new System.Windows.Forms.TextBox();
            this.home = new System.Windows.Forms.ToolStripMenuItem();
            this.adminOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePresetFeesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            descriptionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.userInputGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quoteTable)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            descriptionLabel.Location = new System.Drawing.Point(50, 139);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(91, 19);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(83, 212);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 19);
            label2.TabIndex = 4;
            label2.Text = "Memo:";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.companyNameLabel.Location = new System.Drawing.Point(20, 41);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(121, 19);
            this.companyNameLabel.TabIndex = 0;
            this.companyNameLabel.Text = "Company Name:";
            // 
            // companyNameInput
            // 
            this.companyNameInput.Location = new System.Drawing.Point(150, 41);
            this.companyNameInput.Name = "companyNameInput";
            this.companyNameInput.Size = new System.Drawing.Size(456, 23);
            this.companyNameInput.TabIndex = 1;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(150, 139);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(456, 58);
            this.description.TabIndex = 5;
            // 
            // bookCountLabel
            // 
            this.bookCountLabel.AutoSize = true;
            this.bookCountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookCountLabel.Location = new System.Drawing.Point(47, 285);
            this.bookCountLabel.Name = "bookCountLabel";
            this.bookCountLabel.Size = new System.Drawing.Size(94, 19);
            this.bookCountLabel.TabIndex = 6;
            this.bookCountLabel.Text = "Book Count:";
            // 
            // bookCount
            // 
            this.bookCount.Location = new System.Drawing.Point(150, 285);
            this.bookCount.Margin = new System.Windows.Forms.Padding(0);
            this.bookCount.Name = "bookCount";
            this.bookCount.Size = new System.Drawing.Size(76, 23);
            this.bookCount.TabIndex = 7;
            this.bookCount.Click += new System.EventHandler(this.bookCount_onClick);
            this.bookCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_bookCount_to_list);
            // 
            // userInputGroup
            // 
            this.userInputGroup.Controls.Add(this.sig16Count);
            this.userInputGroup.Controls.Add(this.sig12Count);
            this.userInputGroup.Controls.Add(this.sig4Count);
            this.userInputGroup.Controls.Add(this.sig8Count);
            this.userInputGroup.Controls.Add(this.label3);
            this.userInputGroup.Controls.Add(this.label8);
            this.userInputGroup.Controls.Add(this.quoteButton);
            this.userInputGroup.Controls.Add(this.label26);
            this.userInputGroup.Controls.Add(this.label5);
            this.userInputGroup.Controls.Add(this.sig8Label);
            this.userInputGroup.Location = new System.Drawing.Point(19, 377);
            this.userInputGroup.Name = "userInputGroup";
            this.userInputGroup.Size = new System.Drawing.Size(251, 190);
            this.userInputGroup.TabIndex = 8;
            this.userInputGroup.TabStop = false;
            // 
            // sig16Count
            // 
            this.sig16Count.Location = new System.Drawing.Point(136, 117);
            this.sig16Count.Name = "sig16Count";
            this.sig16Count.Size = new System.Drawing.Size(100, 23);
            this.sig16Count.TabIndex = 7;
            // 
            // sig12Count
            // 
            this.sig12Count.Location = new System.Drawing.Point(136, 87);
            this.sig12Count.Name = "sig12Count";
            this.sig12Count.Size = new System.Drawing.Size(100, 23);
            this.sig12Count.TabIndex = 7;
            // 
            // sig4Count
            // 
            this.sig4Count.Location = new System.Drawing.Point(136, 30);
            this.sig4Count.Name = "sig4Count";
            this.sig4Count.Size = new System.Drawing.Size(100, 23);
            this.sig4Count.TabIndex = 7;
            // 
            // sig8Count
            // 
            this.sig8Count.Location = new System.Drawing.Point(136, 57);
            this.sig8Count.Name = "sig8Count";
            this.sig8Count.Size = new System.Drawing.Size(100, 23);
            this.sig8Count.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(68, -22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(8, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "16-pp Signature:";
            // 
            // quoteButton
            // 
            this.quoteButton.Location = new System.Drawing.Point(91, 146);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(75, 28);
            this.quoteButton.TabIndex = 11;
            this.quoteButton.Text = "QUOTE";
            this.quoteButton.UseVisualStyleBackColor = true;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(16, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 19);
            this.label26.TabIndex = 3;
            this.label26.Text = "4-pp Signature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "12-pp Signature:";
            // 
            // sig8Label
            // 
            this.sig8Label.AutoSize = true;
            this.sig8Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sig8Label.Location = new System.Drawing.Point(16, 57);
            this.sig8Label.Name = "sig8Label";
            this.sig8Label.Size = new System.Drawing.Size(111, 19);
            this.sig8Label.TabIndex = 3;
            this.sig8Label.Text = "8-pp Signature:";
            // 
            // bookCountList
            // 
            this.bookCountList.FormattingEnabled = true;
            this.bookCountList.ItemHeight = 15;
            this.bookCountList.Location = new System.Drawing.Point(150, 307);
            this.bookCountList.Name = "bookCountList";
            this.bookCountList.ScrollAlwaysVisible = true;
            this.bookCountList.Size = new System.Drawing.Size(120, 64);
            this.bookCountList.TabIndex = 13;
            this.bookCountList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remove_bookCount);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_bookCount_to_list);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(356, 284);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 19);
            this.label27.TabIndex = 6;
            this.label27.Text = "Date:";
            // 
            // quoteTable
            // 
            this.quoteTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCount_col,
            this.totalCost_col,
            this.perBookCost_col});
            this.quoteTable.Location = new System.Drawing.Point(291, 386);
            this.quoteTable.Name = "quoteTable";
            this.quoteTable.RowTemplate.Height = 25;
            this.quoteTable.Size = new System.Drawing.Size(315, 214);
            this.quoteTable.TabIndex = 18;
            this.quoteTable.Visible = false;
            // 
            // bookCount_col
            // 
            this.bookCount_col.DataPropertyName = "bookCount";
            this.bookCount_col.HeaderText = "Quantity";
            this.bookCount_col.Name = "bookCount_col";
            // 
            // totalCost_col
            // 
            this.totalCost_col.DataPropertyName = "totalCost";
            this.totalCost_col.HeaderText = "Total $";
            this.totalCost_col.Name = "totalCost_col";
            // 
            // perBookCost_col
            // 
            this.perBookCost_col.DataPropertyName = "perBookCost";
            this.perBookCost_col.HeaderText = "$/Ea";
            this.perBookCost_col.Name = "perBookCost_col";
            this.perBookCost_col.Width = 120;
            // 
            // jobDatePicker
            // 
            this.jobDatePicker.Location = new System.Drawing.Point(406, 284);
            this.jobDatePicker.Name = "jobDatePicker";
            this.jobDatePicker.Size = new System.Drawing.Size(200, 23);
            this.jobDatePicker.TabIndex = 19;
            // 
            // existingCompanyLink
            // 
            this.existingCompanyLink.AutoSize = true;
            this.existingCompanyLink.Location = new System.Drawing.Point(150, 67);
            this.existingCompanyLink.Name = "existingCompanyLink";
            this.existingCompanyLink.Size = new System.Drawing.Size(163, 15);
            this.existingCompanyLink.TabIndex = 20;
            this.existingCompanyLink.TabStop = true;
            this.existingCompanyLink.Text = "This Company Already Exsits?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job Name :";
            // 
            // jobName
            // 
            this.jobName.Location = new System.Drawing.Point(150, 103);
            this.jobName.Name = "jobName";
            this.jobName.Size = new System.Drawing.Size(456, 23);
            this.jobName.TabIndex = 21;
            // 
            // memo
            // 
            this.memo.Location = new System.Drawing.Point(150, 212);
            this.memo.Multiline = true;
            this.memo.Name = "memo";
            this.memo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.memo.Size = new System.Drawing.Size(456, 58);
            this.memo.TabIndex = 5;
            // 
            // home
            // 
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(52, 20);
            this.home.Text = "Home";
            this.home.Visible = false;
            // 
            // adminOptions
            // 
            this.adminOptions.CheckOnClick = true;
            this.adminOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordMenuItem,
            this.changePresetFeesMenuItem});
            this.adminOptions.Name = "adminOptions";
            this.adminOptions.Size = new System.Drawing.Size(55, 20);
            this.adminOptions.Text = "Admin";
            // 
            // changePasswordMenuItem
            // 
            this.changePasswordMenuItem.Name = "changePasswordMenuItem";
            this.changePasswordMenuItem.Size = new System.Drawing.Size(176, 22);
            this.changePasswordMenuItem.Text = "Change Password";
            // 
            // changePresetFeesMenuItem
            // 
            this.changePresetFeesMenuItem.Name = "changePresetFeesMenuItem";
            this.changePresetFeesMenuItem.Size = new System.Drawing.Size(176, 22);
            this.changePresetFeesMenuItem.Text = "Change Preset Fees";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.home,
            this.adminOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(676, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(676, 674);
            this.Controls.Add(this.jobName);
            this.Controls.Add(this.existingCompanyLink);
            this.Controls.Add(this.jobDatePicker);
            this.Controls.Add(this.quoteTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookCountList);
            this.Controls.Add(this.userInputGroup);
            this.Controls.Add(this.bookCount);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.bookCountLabel);
            this.Controls.Add(this.memo);
            this.Controls.Add(label2);
            this.Controls.Add(this.description);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.companyNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "quoteForm";
            this.Text = "Quote";
            this.userInputGroup.ResumeLayout(false);
            this.userInputGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quoteTable)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameInput;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label bookCountLabel;
        private System.Windows.Forms.TextBox bookCount;
        private System.Windows.Forms.GroupBox userInputGroup;

        private System.Windows.Forms.Label sig8Label;
        private System.Windows.Forms.TextBox sig8Count;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox sig12Count;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sig16Count;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.ListBox bookCountList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView quoteTable;
        private System.Windows.Forms.TextBox sig4Count;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DateTimePicker jobDatePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCount_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn perBookCost_col;
        private System.Windows.Forms.LinkLabel existingCompanyLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jobName;
        private System.Windows.Forms.TextBox memo;
        private System.Windows.Forms.ToolStripMenuItem home;
        private System.Windows.Forms.ToolStripMenuItem adminOptions;
        private System.Windows.Forms.ToolStripMenuItem changePasswordMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePresetFeesMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

