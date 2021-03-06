﻿namespace RetroFun.Pages
{
    partial class BuyFurniBruteforcerPage
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
            this.furnITextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendPurchaseBtn = new Sulakore.Components.SKoreButton();
            this.PurchaseLoopCoolDown = new System.Windows.Forms.NumericUpDown();
            this.CataloguePageIdBruteforcerbtx = new Sulakore.Components.SKoreButton();
            this.CatalogueFurnIDBruteForcerbtx = new Sulakore.Components.SKoreButton();
            this.CatalogueBruteForceBtn = new Sulakore.Components.SKoreButton();
            this.CataloguePageIDBox = new System.Windows.Forms.NumericUpDown();
            this.CatalogueFurniIDBox = new System.Windows.Forms.NumericUpDown();
            this.CatalogueSButtonLoopToggle = new Sulakore.Components.SKoreButton();
            this.isValidPurchcheck = new System.Windows.Forms.CheckBox();
            this.FurniIDRangeNbx = new System.Windows.Forms.NumericUpDown();
            this.PageIDRangeNbx = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PageIDRangeChbx = new System.Windows.Forms.CheckBox();
            this.FurniIDRangeChbx = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PurchaseConfirmedChbx = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.GlobalSleepExtraNbx = new System.Windows.Forms.NumericUpDown();
            this.FurniNameShowChbx = new System.Windows.Forms.CheckBox();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckLockFileNameChbx = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FurniIDOptionChbx = new System.Windows.Forms.RadioButton();
            this.PageIDOptionChbx = new System.Windows.Forms.RadioButton();
            this.CaptureModeBtn = new Sulakore.Components.SKoreButton();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseLoopCoolDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataloguePageIDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogueFurniIDBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDRangeNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageIDRangeNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalSleepExtraNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // furnITextBox
            // 
            this.furnITextBox.Location = new System.Drawing.Point(776, 131);
            this.furnITextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.furnITextBox.Name = "furnITextBox";
            this.furnITextBox.Size = new System.Drawing.Size(182, 26);
            this.furnITextBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(778, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 80);
            this.label5.TabIndex = 36;
            this.label5.Text = "If The Furni supports text\r\nwrite here,\r\nelse \r\nleave blank as default\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "FurniID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "PageID";
            // 
            // SendPurchaseBtn
            // 
            this.SendPurchaseBtn.Location = new System.Drawing.Point(405, 429);
            this.SendPurchaseBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SendPurchaseBtn.Name = "SendPurchaseBtn";
            this.SendPurchaseBtn.Size = new System.Drawing.Size(336, 31);
            this.SendPurchaseBtn.TabIndex = 26;
            this.SendPurchaseBtn.Text = "Purchase Item";
            this.SendPurchaseBtn.Click += new System.EventHandler(this.SendPurchaseBtn_Click);
            // 
            // PurchaseLoopCoolDown
            // 
            this.PurchaseLoopCoolDown.Location = new System.Drawing.Point(18, 220);
            this.PurchaseLoopCoolDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PurchaseLoopCoolDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PurchaseLoopCoolDown.Name = "PurchaseLoopCoolDown";
            this.PurchaseLoopCoolDown.Size = new System.Drawing.Size(122, 26);
            this.PurchaseLoopCoolDown.TabIndex = 39;
            this.PurchaseLoopCoolDown.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // CataloguePageIdBruteforcerbtx
            // 
            this.CataloguePageIdBruteforcerbtx.Location = new System.Drawing.Point(510, 91);
            this.CataloguePageIdBruteforcerbtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CataloguePageIdBruteforcerbtx.Name = "CataloguePageIdBruteforcerbtx";
            this.CataloguePageIdBruteforcerbtx.Size = new System.Drawing.Size(254, 31);
            this.CataloguePageIdBruteforcerbtx.TabIndex = 40;
            this.CataloguePageIdBruteforcerbtx.Text = "PageID Bruteforcer : Off";
            this.CataloguePageIdBruteforcerbtx.Click += new System.EventHandler(this.CataloguePageIdBruteforcerbtx_Click);
            // 
            // CatalogueFurnIDBruteForcerbtx
            // 
            this.CatalogueFurnIDBruteForcerbtx.Location = new System.Drawing.Point(510, 146);
            this.CatalogueFurnIDBruteForcerbtx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatalogueFurnIDBruteForcerbtx.Name = "CatalogueFurnIDBruteForcerbtx";
            this.CatalogueFurnIDBruteForcerbtx.Size = new System.Drawing.Size(254, 31);
            this.CatalogueFurnIDBruteForcerbtx.TabIndex = 41;
            this.CatalogueFurnIDBruteForcerbtx.Text = "FurniID Bruteforcer : Off";
            this.CatalogueFurnIDBruteForcerbtx.Click += new System.EventHandler(this.CatalogueFurnIDBruteForcerbtx_Click);
            // 
            // CatalogueBruteForceBtn
            // 
            this.CatalogueBruteForceBtn.Location = new System.Drawing.Point(782, 412);
            this.CatalogueBruteForceBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatalogueBruteForceBtn.Name = "CatalogueBruteForceBtn";
            this.CatalogueBruteForceBtn.Size = new System.Drawing.Size(194, 31);
            this.CatalogueBruteForceBtn.TabIndex = 42;
            this.CatalogueBruteForceBtn.Text = "BruteForcer : Off";
            this.CatalogueBruteForceBtn.Click += new System.EventHandler(this.CatalogueBruteForceBtn_Click);
            // 
            // CataloguePageIDBox
            // 
            this.CataloguePageIDBox.Location = new System.Drawing.Point(15, 91);
            this.CataloguePageIDBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CataloguePageIDBox.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CataloguePageIDBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.CataloguePageIDBox.Name = "CataloguePageIDBox";
            this.CataloguePageIDBox.Size = new System.Drawing.Size(180, 26);
            this.CataloguePageIDBox.TabIndex = 43;
            // 
            // CatalogueFurniIDBox
            // 
            this.CatalogueFurniIDBox.Location = new System.Drawing.Point(15, 146);
            this.CatalogueFurniIDBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatalogueFurniIDBox.Maximum = new decimal(new int[] {
            2147483647,
            2,
            0,
            0});
            this.CatalogueFurniIDBox.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.CatalogueFurniIDBox.Name = "CatalogueFurniIDBox";
            this.CatalogueFurniIDBox.Size = new System.Drawing.Size(180, 26);
            this.CatalogueFurniIDBox.TabIndex = 44;
            // 
            // CatalogueSButtonLoopToggle
            // 
            this.CatalogueSButtonLoopToggle.Location = new System.Drawing.Point(30, 370);
            this.CatalogueSButtonLoopToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CatalogueSButtonLoopToggle.Name = "CatalogueSButtonLoopToggle";
            this.CatalogueSButtonLoopToggle.Size = new System.Drawing.Size(319, 31);
            this.CatalogueSButtonLoopToggle.TabIndex = 38;
            this.CatalogueSButtonLoopToggle.Text = "Buy On loop : Off";
            this.CatalogueSButtonLoopToggle.Click += new System.EventHandler(this.CatalogueSButtonLoopToggle_Click);
            // 
            // isValidPurchcheck
            // 
            this.isValidPurchcheck.AutoSize = true;
            this.isValidPurchcheck.Enabled = false;
            this.isValidPurchcheck.Location = new System.Drawing.Point(18, 5);
            this.isValidPurchcheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isValidPurchcheck.Name = "isValidPurchcheck";
            this.isValidPurchcheck.Size = new System.Drawing.Size(138, 24);
            this.isValidPurchcheck.TabIndex = 45;
            this.isValidPurchcheck.Text = "Packet is Valid";
            this.isValidPurchcheck.UseVisualStyleBackColor = true;
            this.isValidPurchcheck.Visible = false;
            // 
            // FurniIDRangeNbx
            // 
            this.FurniIDRangeNbx.Enabled = false;
            this.FurniIDRangeNbx.Location = new System.Drawing.Point(267, 146);
            this.FurniIDRangeNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurniIDRangeNbx.Maximum = new decimal(new int[] {
            2147483647,
            2,
            0,
            0});
            this.FurniIDRangeNbx.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.FurniIDRangeNbx.Name = "FurniIDRangeNbx";
            this.FurniIDRangeNbx.Size = new System.Drawing.Size(180, 26);
            this.FurniIDRangeNbx.TabIndex = 49;
            // 
            // PageIDRangeNbx
            // 
            this.PageIDRangeNbx.Enabled = false;
            this.PageIDRangeNbx.Location = new System.Drawing.Point(267, 91);
            this.PageIDRangeNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageIDRangeNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.PageIDRangeNbx.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.PageIDRangeNbx.Name = "PageIDRangeNbx";
            this.PageIDRangeNbx.Size = new System.Drawing.Size(180, 26);
            this.PageIDRangeNbx.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "FurniID Range Limit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "PageID Range Limit";
            // 
            // PageIDRangeChbx
            // 
            this.PageIDRangeChbx.AutoSize = true;
            this.PageIDRangeChbx.Location = new System.Drawing.Point(456, 100);
            this.PageIDRangeChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageIDRangeChbx.Name = "PageIDRangeChbx";
            this.PageIDRangeChbx.Size = new System.Drawing.Size(22, 21);
            this.PageIDRangeChbx.TabIndex = 50;
            this.PageIDRangeChbx.UseVisualStyleBackColor = true;
            this.PageIDRangeChbx.CheckedChanged += new System.EventHandler(this.PageIDRangeChbx_CheckedChanged);
            // 
            // FurniIDRangeChbx
            // 
            this.FurniIDRangeChbx.AutoSize = true;
            this.FurniIDRangeChbx.Location = new System.Drawing.Point(456, 155);
            this.FurniIDRangeChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurniIDRangeChbx.Name = "FurniIDRangeChbx";
            this.FurniIDRangeChbx.Size = new System.Drawing.Size(22, 21);
            this.FurniIDRangeChbx.TabIndex = 51;
            this.FurniIDRangeChbx.UseVisualStyleBackColor = true;
            this.FurniIDRangeChbx.CheckedChanged += new System.EventHandler(this.FurniIDRangeChbx_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 195);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Cooldown";
            // 
            // PurchaseConfirmedChbx
            // 
            this.PurchaseConfirmedChbx.AutoSize = true;
            this.PurchaseConfirmedChbx.Location = new System.Drawing.Point(260, 197);
            this.PurchaseConfirmedChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PurchaseConfirmedChbx.Name = "PurchaseConfirmedChbx";
            this.PurchaseConfirmedChbx.Size = new System.Drawing.Size(217, 24);
            this.PurchaseConfirmedChbx.TabIndex = 53;
            this.PurchaseConfirmedChbx.Text = "Show BruteForcer Output";
            this.PurchaseConfirmedChbx.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(778, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Purchase Default Sleep";
            // 
            // GlobalSleepExtraNbx
            // 
            this.GlobalSleepExtraNbx.Location = new System.Drawing.Point(783, 222);
            this.GlobalSleepExtraNbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GlobalSleepExtraNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.GlobalSleepExtraNbx.Name = "GlobalSleepExtraNbx";
            this.GlobalSleepExtraNbx.Size = new System.Drawing.Size(122, 26);
            this.GlobalSleepExtraNbx.TabIndex = 54;
            this.GlobalSleepExtraNbx.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // FurniNameShowChbx
            // 
            this.FurniNameShowChbx.AutoSize = true;
            this.FurniNameShowChbx.Location = new System.Drawing.Point(260, 232);
            this.FurniNameShowChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurniNameShowChbx.Name = "FurniNameShowChbx";
            this.FurniNameShowChbx.Size = new System.Drawing.Size(161, 24);
            this.FurniNameShowChbx.TabIndex = 56;
            this.FurniNameShowChbx.Text = "Show Furni Name";
            this.FurniNameShowChbx.UseVisualStyleBackColor = true;
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.Enabled = false;
            this.FileNameTextBox.Location = new System.Drawing.Point(30, 334);
            this.FileNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FileNameTextBox.MaxLength = 1073741823;
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.Size = new System.Drawing.Size(319, 26);
            this.FileNameTextBox.TabIndex = 57;
            this.FileNameTextBox.Text = "bobbaitalia.it";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 20);
            this.label8.TabIndex = 58;
            this.label8.Text = "Name Of the Bruteforcer OutPut File.";
            // 
            // CheckLockFileNameChbx
            // 
            this.CheckLockFileNameChbx.AutoSize = true;
            this.CheckLockFileNameChbx.Location = new System.Drawing.Point(357, 339);
            this.CheckLockFileNameChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CheckLockFileNameChbx.Name = "CheckLockFileNameChbx";
            this.CheckLockFileNameChbx.Size = new System.Drawing.Size(22, 21);
            this.CheckLockFileNameChbx.TabIndex = 59;
            this.CheckLockFileNameChbx.UseVisualStyleBackColor = true;
            this.CheckLockFileNameChbx.CheckedChanged += new System.EventHandler(this.CheckLockFileNameChbx_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FurniIDOptionChbx);
            this.groupBox1.Controls.Add(this.PageIDOptionChbx);
            this.groupBox1.Location = new System.Drawing.Point(782, 289);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(196, 114);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BruteForcer options";
            // 
            // FurniIDOptionChbx
            // 
            this.FurniIDOptionChbx.AutoSize = true;
            this.FurniIDOptionChbx.Location = new System.Drawing.Point(36, 65);
            this.FurniIDOptionChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FurniIDOptionChbx.Name = "FurniIDOptionChbx";
            this.FurniIDOptionChbx.Size = new System.Drawing.Size(91, 24);
            this.FurniIDOptionChbx.TabIndex = 1;
            this.FurniIDOptionChbx.Text = "FurniID ";
            this.FurniIDOptionChbx.UseVisualStyleBackColor = true;
            // 
            // PageIDOptionChbx
            // 
            this.PageIDOptionChbx.AutoSize = true;
            this.PageIDOptionChbx.Location = new System.Drawing.Point(36, 29);
            this.PageIDOptionChbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PageIDOptionChbx.Name = "PageIDOptionChbx";
            this.PageIDOptionChbx.Size = new System.Drawing.Size(88, 24);
            this.PageIDOptionChbx.TabIndex = 0;
            this.PageIDOptionChbx.Text = "PageID";
            this.PageIDOptionChbx.UseVisualStyleBackColor = true;
            // 
            // CaptureModeBtn
            // 
            this.CaptureModeBtn.Location = new System.Drawing.Point(30, 429);
            this.CaptureModeBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CaptureModeBtn.Name = "CaptureModeBtn";
            this.CaptureModeBtn.Size = new System.Drawing.Size(336, 31);
            this.CaptureModeBtn.TabIndex = 62;
            this.CaptureModeBtn.Text = "Capture Mode : OFF";
            this.CaptureModeBtn.Click += new System.EventHandler(this.CaptureModeBtn_Click);
            // 
            // BuyFurniBruteforcerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CaptureModeBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CheckLockFileNameChbx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.FurniNameShowChbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GlobalSleepExtraNbx);
            this.Controls.Add(this.PurchaseConfirmedChbx);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FurniIDRangeChbx);
            this.Controls.Add(this.PageIDRangeChbx);
            this.Controls.Add(this.FurniIDRangeNbx);
            this.Controls.Add(this.PageIDRangeNbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isValidPurchcheck);
            this.Controls.Add(this.CatalogueFurniIDBox);
            this.Controls.Add(this.CataloguePageIDBox);
            this.Controls.Add(this.CatalogueBruteForceBtn);
            this.Controls.Add(this.CatalogueFurnIDBruteForcerbtx);
            this.Controls.Add(this.CataloguePageIdBruteforcerbtx);
            this.Controls.Add(this.PurchaseLoopCoolDown);
            this.Controls.Add(this.CatalogueSButtonLoopToggle);
            this.Controls.Add(this.furnITextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendPurchaseBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuyFurniBruteforcerPage";
            this.Size = new System.Drawing.Size(1026, 495);
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseLoopCoolDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataloguePageIDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatalogueFurniIDBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FurniIDRangeNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageIDRangeNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GlobalSleepExtraNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox furnITextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Sulakore.Components.SKoreButton SendPurchaseBtn;
        private System.Windows.Forms.NumericUpDown PurchaseLoopCoolDown;
        private Sulakore.Components.SKoreButton CataloguePageIdBruteforcerbtx;
        private Sulakore.Components.SKoreButton CatalogueFurnIDBruteForcerbtx;
        private Sulakore.Components.SKoreButton CatalogueBruteForceBtn;
        private System.Windows.Forms.NumericUpDown CataloguePageIDBox;
        private System.Windows.Forms.NumericUpDown CatalogueFurniIDBox;
        private Sulakore.Components.SKoreButton CatalogueSButtonLoopToggle;
        private System.Windows.Forms.CheckBox isValidPurchcheck;
        private System.Windows.Forms.NumericUpDown FurniIDRangeNbx;
        private System.Windows.Forms.NumericUpDown PageIDRangeNbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox PageIDRangeChbx;
        private System.Windows.Forms.CheckBox FurniIDRangeChbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox PurchaseConfirmedChbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown GlobalSleepExtraNbx;
        private System.Windows.Forms.CheckBox FurniNameShowChbx;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox CheckLockFileNameChbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FurniIDOptionChbx;
        private System.Windows.Forms.RadioButton PageIDOptionChbx;
        private Sulakore.Components.SKoreButton CaptureModeBtn;
    }
}
