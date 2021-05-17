
namespace BookQuote
{
    partial class Quote
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
            this.companyNameLabel = new System.Windows.Forms.Label();
            this.companyNameInput = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.bookCountLabel = new System.Windows.Forms.Label();
            this.bookCount = new System.Windows.Forms.TextBox();
            this.sewingGroup = new System.Windows.Forms.GroupBox();
            this.sig16Count = new System.Windows.Forms.TextBox();
            this.sig12Count = new System.Windows.Forms.TextBox();
            this.sig4Count = new System.Windows.Forms.TextBox();
            this.sig8Count = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sig16Cost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sig12Cost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sig4Cost = new System.Windows.Forms.TextBox();
            this.sig8Cost = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sig8Label = new System.Windows.Forms.Label();
            this.sewingSetupFee = new System.Windows.Forms.TextBox();
            this.setupFeeLabel = new System.Windows.Forms.Label();
            this.bookCountList = new System.Windows.Forms.ListBox();
            this.CaseInGroup = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.caseInCost = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.caseInSetupFee = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.perfectBindGroup = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.perfectBindCost = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.perfectBindSetupFee = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.endSheetGlueGroup = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.endSheetGlueCost = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.endSheetGlueSetupFee = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.caseBindingGroup = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.caseBindingCost = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.caseBindingSetupFee = new System.Windows.Forms.TextBox();
            this.quoteButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordOption = new System.Windows.Forms.ToolStripMenuItem();
            this.changePresetFees = new System.Windows.Forms.ToolStripMenuItem();
            this.quoteTable = new System.Windows.Forms.DataGridView();
            this.bookCount_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCost_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perBookCost_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            descriptionLabel = new System.Windows.Forms.Label();
            this.sewingGroup.SuspendLayout();
            this.CaseInGroup.SuspendLayout();
            this.perfectBindGroup.SuspendLayout();
            this.endSheetGlueGroup.SuspendLayout();
            this.caseBindingGroup.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quoteTable)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            descriptionLabel.Location = new System.Drawing.Point(50, 69);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(91, 19);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
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
            this.companyNameInput.Size = new System.Drawing.Size(382, 23);
            this.companyNameInput.TabIndex = 1;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(150, 70);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(382, 70);
            this.description.TabIndex = 5;
            // 
            // bookCountLabel
            // 
            this.bookCountLabel.AutoSize = true;
            this.bookCountLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookCountLabel.Location = new System.Drawing.Point(47, 147);
            this.bookCountLabel.Name = "bookCountLabel";
            this.bookCountLabel.Size = new System.Drawing.Size(94, 19);
            this.bookCountLabel.TabIndex = 6;
            this.bookCountLabel.Text = "Book Count:";
            // 
            // bookCount
            // 
            this.bookCount.Location = new System.Drawing.Point(150, 147);
            this.bookCount.Margin = new System.Windows.Forms.Padding(0);
            this.bookCount.Name = "bookCount";
            this.bookCount.Size = new System.Drawing.Size(76, 23);
            this.bookCount.TabIndex = 7;
            this.bookCount.Click += new System.EventHandler(this.bookCount_onClick);
            this.bookCount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enter_bookCount_to_list);
            // 
            // sewingGroup
            // 
            this.sewingGroup.Controls.Add(this.sig16Count);
            this.sewingGroup.Controls.Add(this.sig12Count);
            this.sewingGroup.Controls.Add(this.sig4Count);
            this.sewingGroup.Controls.Add(this.sig8Count);
            this.sewingGroup.Controls.Add(this.label10);
            this.sewingGroup.Controls.Add(this.label3);
            this.sewingGroup.Controls.Add(this.label7);
            this.sewingGroup.Controls.Add(this.label9);
            this.sewingGroup.Controls.Add(this.label29);
            this.sewingGroup.Controls.Add(this.label4);
            this.sewingGroup.Controls.Add(this.label6);
            this.sewingGroup.Controls.Add(this.label28);
            this.sewingGroup.Controls.Add(this.label2);
            this.sewingGroup.Controls.Add(this.sig16Cost);
            this.sewingGroup.Controls.Add(this.label1);
            this.sewingGroup.Controls.Add(this.sig12Cost);
            this.sewingGroup.Controls.Add(this.label8);
            this.sewingGroup.Controls.Add(this.sig4Cost);
            this.sewingGroup.Controls.Add(this.sig8Cost);
            this.sewingGroup.Controls.Add(this.label26);
            this.sewingGroup.Controls.Add(this.label5);
            this.sewingGroup.Controls.Add(this.sig8Label);
            this.sewingGroup.Controls.Add(this.sewingSetupFee);
            this.sewingGroup.Controls.Add(this.setupFeeLabel);
            this.sewingGroup.Location = new System.Drawing.Point(20, 239);
            this.sewingGroup.Name = "sewingGroup";
            this.sewingGroup.Size = new System.Drawing.Size(404, 190);
            this.sewingGroup.TabIndex = 8;
            this.sewingGroup.TabStop = false;
            this.sewingGroup.Text = "Sewing";
            // 
            // sig16Count
            // 
            this.sig16Count.Location = new System.Drawing.Point(288, 146);
            this.sig16Count.Name = "sig16Count";
            this.sig16Count.Size = new System.Drawing.Size(100, 23);
            this.sig16Count.TabIndex = 7;
            // 
            // sig12Count
            // 
            this.sig12Count.Location = new System.Drawing.Point(288, 116);
            this.sig12Count.Name = "sig12Count";
            this.sig12Count.Size = new System.Drawing.Size(100, 23);
            this.sig12Count.TabIndex = 7;
            // 
            // sig4Count
            // 
            this.sig4Count.Location = new System.Drawing.Point(288, 59);
            this.sig4Count.Name = "sig4Count";
            this.sig4Count.Size = new System.Drawing.Size(100, 23);
            this.sig4Count.TabIndex = 7;
            // 
            // sig8Count
            // 
            this.sig8Count.Location = new System.Drawing.Point(288, 86);
            this.sig8Count.Name = "sig8Count";
            this.sig8Count.Size = new System.Drawing.Size(100, 23);
            this.sig8Count.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(262, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 19);
            this.label10.TabIndex = 6;
            this.label10.Text = "X";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(262, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(130, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 6;
            this.label9.Text = "$";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(262, 59);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(20, 19);
            this.label29.TabIndex = 6;
            this.label29.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(262, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(130, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "$";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(130, 59);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(17, 19);
            this.label28.TabIndex = 6;
            this.label28.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(130, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "$";
            // 
            // sig16Cost
            // 
            this.sig16Cost.Location = new System.Drawing.Point(155, 146);
            this.sig16Cost.Name = "sig16Cost";
            this.sig16Cost.Size = new System.Drawing.Size(100, 23);
            this.sig16Cost.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(130, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "$";
            // 
            // sig12Cost
            // 
            this.sig12Cost.Location = new System.Drawing.Point(155, 116);
            this.sig12Cost.Name = "sig12Cost";
            this.sig12Cost.Size = new System.Drawing.Size(100, 23);
            this.sig12Cost.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(2, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "16-pp Signature:";
            // 
            // sig4Cost
            // 
            this.sig4Cost.Location = new System.Drawing.Point(155, 59);
            this.sig4Cost.Name = "sig4Cost";
            this.sig4Cost.Size = new System.Drawing.Size(100, 23);
            this.sig4Cost.TabIndex = 5;
            // 
            // sig8Cost
            // 
            this.sig8Cost.Location = new System.Drawing.Point(155, 86);
            this.sig8Cost.Name = "sig8Cost";
            this.sig8Cost.Size = new System.Drawing.Size(100, 23);
            this.sig8Cost.TabIndex = 5;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(10, 59);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(111, 19);
            this.label26.TabIndex = 3;
            this.label26.Text = "4-pp Signature:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(2, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "12-pp Signature:";
            // 
            // sig8Label
            // 
            this.sig8Label.AutoSize = true;
            this.sig8Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sig8Label.Location = new System.Drawing.Point(10, 86);
            this.sig8Label.Name = "sig8Label";
            this.sig8Label.Size = new System.Drawing.Size(111, 19);
            this.sig8Label.TabIndex = 3;
            this.sig8Label.Text = "8-pp Signature:";
            // 
            // sewingSetupFee
            // 
            this.sewingSetupFee.Location = new System.Drawing.Point(155, 30);
            this.sewingSetupFee.Name = "sewingSetupFee";
            this.sewingSetupFee.Size = new System.Drawing.Size(100, 23);
            this.sewingSetupFee.TabIndex = 1;
            // 
            // setupFeeLabel
            // 
            this.setupFeeLabel.AutoSize = true;
            this.setupFeeLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.setupFeeLabel.Location = new System.Drawing.Point(40, 30);
            this.setupFeeLabel.Name = "setupFeeLabel";
            this.setupFeeLabel.Size = new System.Drawing.Size(81, 19);
            this.setupFeeLabel.TabIndex = 0;
            this.setupFeeLabel.Text = "Setup Fee:";
            // 
            // bookCountList
            // 
            this.bookCountList.FormattingEnabled = true;
            this.bookCountList.ItemHeight = 15;
            this.bookCountList.Location = new System.Drawing.Point(150, 169);
            this.bookCountList.Name = "bookCountList";
            this.bookCountList.ScrollAlwaysVisible = true;
            this.bookCountList.Size = new System.Drawing.Size(120, 64);
            this.bookCountList.TabIndex = 13;
            this.bookCountList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.remove_bookCount);
            // 
            // CaseInGroup
            // 
            this.CaseInGroup.Controls.Add(this.label14);
            this.CaseInGroup.Controls.Add(this.caseInCost);
            this.CaseInGroup.Controls.Add(this.label11);
            this.CaseInGroup.Controls.Add(this.label13);
            this.CaseInGroup.Controls.Add(this.caseInSetupFee);
            this.CaseInGroup.Controls.Add(this.label12);
            this.CaseInGroup.Location = new System.Drawing.Point(310, 470);
            this.CaseInGroup.Name = "CaseInGroup";
            this.CaseInGroup.Size = new System.Drawing.Size(272, 114);
            this.CaseInGroup.TabIndex = 9;
            this.CaseInGroup.TabStop = false;
            this.CaseInGroup.Text = "Case In";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(15, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Per Book Fee:";
            // 
            // caseInCost
            // 
            this.caseInCost.Location = new System.Drawing.Point(155, 63);
            this.caseInCost.Name = "caseInCost";
            this.caseInCost.Size = new System.Drawing.Size(100, 23);
            this.caseInCost.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(40, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Setup Fee:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(130, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 19);
            this.label13.TabIndex = 6;
            this.label13.Text = "$";
            // 
            // caseInSetupFee
            // 
            this.caseInSetupFee.Location = new System.Drawing.Point(155, 30);
            this.caseInSetupFee.Name = "caseInSetupFee";
            this.caseInSetupFee.Size = new System.Drawing.Size(100, 23);
            this.caseInSetupFee.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(130, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 19);
            this.label12.TabIndex = 6;
            this.label12.Text = "$";
            // 
            // perfectBindGroup
            // 
            this.perfectBindGroup.Controls.Add(this.label15);
            this.perfectBindGroup.Controls.Add(this.perfectBindCost);
            this.perfectBindGroup.Controls.Add(this.label16);
            this.perfectBindGroup.Controls.Add(this.label17);
            this.perfectBindGroup.Controls.Add(this.perfectBindSetupFee);
            this.perfectBindGroup.Controls.Add(this.label18);
            this.perfectBindGroup.Location = new System.Drawing.Point(425, 230);
            this.perfectBindGroup.Name = "perfectBindGroup";
            this.perfectBindGroup.Size = new System.Drawing.Size(282, 114);
            this.perfectBindGroup.TabIndex = 9;
            this.perfectBindGroup.TabStop = false;
            this.perfectBindGroup.Text = "Perfect Bind";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(15, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Per Book Fee:";
            // 
            // perfectBindCost
            // 
            this.perfectBindCost.Location = new System.Drawing.Point(155, 63);
            this.perfectBindCost.Name = "perfectBindCost";
            this.perfectBindCost.Size = new System.Drawing.Size(100, 23);
            this.perfectBindCost.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(40, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Setup Fee:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(130, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 19);
            this.label17.TabIndex = 6;
            this.label17.Text = "$";
            // 
            // perfectBindSetupFee
            // 
            this.perfectBindSetupFee.Location = new System.Drawing.Point(155, 30);
            this.perfectBindSetupFee.Name = "perfectBindSetupFee";
            this.perfectBindSetupFee.Size = new System.Drawing.Size(100, 23);
            this.perfectBindSetupFee.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(130, 30);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 19);
            this.label18.TabIndex = 6;
            this.label18.Text = "$";
            // 
            // endSheetGlueGroup
            // 
            this.endSheetGlueGroup.Controls.Add(this.label19);
            this.endSheetGlueGroup.Controls.Add(this.endSheetGlueCost);
            this.endSheetGlueGroup.Controls.Add(this.label20);
            this.endSheetGlueGroup.Controls.Add(this.label21);
            this.endSheetGlueGroup.Controls.Add(this.endSheetGlueSetupFee);
            this.endSheetGlueGroup.Controls.Add(this.label22);
            this.endSheetGlueGroup.Location = new System.Drawing.Point(430, 350);
            this.endSheetGlueGroup.Name = "endSheetGlueGroup";
            this.endSheetGlueGroup.Size = new System.Drawing.Size(281, 114);
            this.endSheetGlueGroup.TabIndex = 10;
            this.endSheetGlueGroup.TabStop = false;
            this.endSheetGlueGroup.Text = "End Sheet Glue";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(15, 63);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(106, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Per Book Fee:";
            // 
            // endSheetGlueCost
            // 
            this.endSheetGlueCost.Location = new System.Drawing.Point(155, 63);
            this.endSheetGlueCost.Name = "endSheetGlueCost";
            this.endSheetGlueCost.Size = new System.Drawing.Size(100, 23);
            this.endSheetGlueCost.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(40, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(81, 19);
            this.label20.TabIndex = 0;
            this.label20.Text = "Setup Fee:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(130, 63);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(17, 19);
            this.label21.TabIndex = 6;
            this.label21.Text = "$";
            // 
            // endSheetGlueSetupFee
            // 
            this.endSheetGlueSetupFee.Location = new System.Drawing.Point(155, 30);
            this.endSheetGlueSetupFee.Name = "endSheetGlueSetupFee";
            this.endSheetGlueSetupFee.Size = new System.Drawing.Size(100, 23);
            this.endSheetGlueSetupFee.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label22.Location = new System.Drawing.Point(130, 30);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(17, 19);
            this.label22.TabIndex = 6;
            this.label22.Text = "$";
            // 
            // caseBindingGroup
            // 
            this.caseBindingGroup.Controls.Add(this.label23);
            this.caseBindingGroup.Controls.Add(this.caseBindingCost);
            this.caseBindingGroup.Controls.Add(this.label24);
            this.caseBindingGroup.Controls.Add(this.label25);
            this.caseBindingGroup.Controls.Add(this.caseBindingSetupFee);
            this.caseBindingGroup.Location = new System.Drawing.Point(22, 435);
            this.caseBindingGroup.Name = "caseBindingGroup";
            this.caseBindingGroup.Size = new System.Drawing.Size(282, 114);
            this.caseBindingGroup.TabIndex = 10;
            this.caseBindingGroup.TabStop = false;
            this.caseBindingGroup.Text = "Case Binding";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(15, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 19);
            this.label23.TabIndex = 0;
            this.label23.Text = "Per Book Fee:";
            // 
            // caseBindingCost
            // 
            this.caseBindingCost.Location = new System.Drawing.Point(155, 63);
            this.caseBindingCost.Name = "caseBindingCost";
            this.caseBindingCost.Size = new System.Drawing.Size(100, 23);
            this.caseBindingCost.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label24.Location = new System.Drawing.Point(40, 30);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(81, 19);
            this.label24.TabIndex = 0;
            this.label24.Text = "Setup Fee:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(130, 63);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(17, 19);
            this.label25.TabIndex = 6;
            this.label25.Text = "$";
            // 
            // caseBindingSetupFee
            // 
            this.caseBindingSetupFee.Location = new System.Drawing.Point(155, 30);
            this.caseBindingSetupFee.Name = "caseBindingSetupFee";
            this.caseBindingSetupFee.Size = new System.Drawing.Size(100, 23);
            this.caseBindingSetupFee.TabIndex = 1;
            // 
            // quoteButton
            // 
            this.quoteButton.Location = new System.Drawing.Point(94, 571);
            this.quoteButton.Name = "quoteButton";
            this.quoteButton.Size = new System.Drawing.Size(75, 28);
            this.quoteButton.TabIndex = 11;
            this.quoteButton.Text = "QUOTE";
            this.quoteButton.UseVisualStyleBackColor = true;
            this.quoteButton.Click += new System.EventHandler(this.quoteButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 146);
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
            this.label27.Location = new System.Drawing.Point(282, 147);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(47, 19);
            this.label27.TabIndex = 6;
            this.label27.Text = "Date:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminOptions});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminOptions
            // 
            this.adminOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordOption,
            this.changePresetFees});
            this.adminOptions.Name = "adminOptions";
            this.adminOptions.Size = new System.Drawing.Size(55, 20);
            this.adminOptions.Text = "Admin";
            // 
            // changePasswordOption
            // 
            this.changePasswordOption.Name = "changePasswordOption";
            this.changePasswordOption.Size = new System.Drawing.Size(176, 22);
            this.changePasswordOption.Text = "Change Password";
            // 
            // changePresetFees
            // 
            this.changePresetFees.Name = "changePresetFees";
            this.changePresetFees.Size = new System.Drawing.Size(176, 22);
            this.changePresetFees.Text = "Change Preset Fees";
            // 
            // quoteTable
            // 
            this.quoteTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quoteTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCount_col,
            this.totalCost_col,
            this.perBookCost_col});
            this.quoteTable.Location = new System.Drawing.Point(50, 615);
            this.quoteTable.Name = "quoteTable";
            this.quoteTable.RowTemplate.Height = 25;
            this.quoteTable.Size = new System.Drawing.Size(358, 214);
            this.quoteTable.TabIndex = 18;
            this.quoteTable.Visible = false;
            // 
            // bookCount_col
            // 
            this.bookCount_col.DataPropertyName = "bookCount";
            this.bookCount_col.HeaderText = "Book Count";
            this.bookCount_col.Name = "bookCount_col";
            // 
            // totalCost_col
            // 
            this.totalCost_col.DataPropertyName = "totalCost";
            this.totalCost_col.HeaderText = "Total Cost";
            this.totalCost_col.Name = "totalCost_col";
            // 
            // perBookCost_col
            // 
            this.perBookCost_col.DataPropertyName = "perBookCost";
            this.perBookCost_col.HeaderText = "Per Book Cost";
            this.perBookCost_col.Name = "perBookCost_col";
            this.perBookCost_col.Width = 120;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(332, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // Quote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(719, 984);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.quoteTable);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bookCountList);
            this.Controls.Add(this.quoteButton);
            this.Controls.Add(this.caseBindingGroup);
            this.Controls.Add(this.endSheetGlueGroup);
            this.Controls.Add(this.perfectBindGroup);
            this.Controls.Add(this.CaseInGroup);
            this.Controls.Add(this.sewingGroup);
            this.Controls.Add(this.bookCount);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.bookCountLabel);
            this.Controls.Add(this.description);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.companyNameInput);
            this.Controls.Add(this.companyNameLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Quote";
            this.Text = "Quote";
            this.sewingGroup.ResumeLayout(false);
            this.sewingGroup.PerformLayout();
            this.CaseInGroup.ResumeLayout(false);
            this.CaseInGroup.PerformLayout();
            this.perfectBindGroup.ResumeLayout(false);
            this.perfectBindGroup.PerformLayout();
            this.endSheetGlueGroup.ResumeLayout(false);
            this.endSheetGlueGroup.PerformLayout();
            this.caseBindingGroup.ResumeLayout(false);
            this.caseBindingGroup.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quoteTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyNameLabel;
        private System.Windows.Forms.TextBox companyNameInput;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label bookCountLabel;
        private System.Windows.Forms.TextBox bookCount;
        private System.Windows.Forms.GroupBox sewingGroup;
        private System.Windows.Forms.Label setupFeeLabel;

        private System.Windows.Forms.Label sig8Label;
        private System.Windows.Forms.TextBox sig8Cost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sig8Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox sig12Count;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox sig12Cost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sig16Count;
        private System.Windows.Forms.GroupBox CaseInGroup;
        private System.Windows.Forms.TextBox sewingSetupFee;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox caseInCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox caseInSetupFee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox perfectBindGroup;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox perfectBindCost;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox perfectBindSetupFee;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox endSheetGlueGroup;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox endSheetGlueCost;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox endSheetGlueSetupFee;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox caseBindingGroup;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox caseBindingCost;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox caseBindingSetupFee;
        private System.Windows.Forms.Button quoteButton;
        private System.Windows.Forms.ListBox bookCountList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminOptions;
        private System.Windows.Forms.ToolStripMenuItem changePasswordOption;
        private System.Windows.Forms.ToolStripMenuItem changePresetFees;
        private System.Windows.Forms.DataGridView quoteTable;
        private System.Windows.Forms.TextBox sig4Count;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox sig4Cost;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox sig16Cost;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCount_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCost_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn perBookCost_col;
    }
}

