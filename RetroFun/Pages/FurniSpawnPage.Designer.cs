﻿namespace RetroFun.Pages
{
    partial class FurniSpawnPage
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.CoordXNbx = new System.Windows.Forms.NumericUpDown();
            this.CoordZNBx = new System.Windows.Forms.NumericUpDown();
            this.CoordYNbx = new System.Windows.Forms.NumericUpDown();
            this.SpawnFloorFurniBtn = new Sulakore.Components.SKoreButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RotationNbx = new System.Windows.Forms.NumericUpDown();
            this.RotationRight = new System.Windows.Forms.RadioButton();
            this.rotationLeft = new System.Windows.Forms.RadioButton();
            this.RotationDown = new System.Windows.Forms.RadioButton();
            this.RotationUp = new System.Windows.Forms.RadioButton();
            this.SetOwnUsernameBtn = new Sulakore.Components.SKoreButton();
            this.FurniOwnerTxbx = new System.Windows.Forms.TextBox();
            this.SpawnFloorFurniOnClickBtn = new Sulakore.Components.SKoreButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.IRadioBtn = new System.Windows.Forms.RadioButton();
            this.SRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FloorFurniSpawnerNbx = new System.Windows.Forms.NumericUpDown();
            this.SpawnFurniInvBtn = new Sulakore.Components.SKoreButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.FurniInventoryIDNbx = new System.Windows.Forms.NumericUpDown();
            this.AmountNbx = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.PosterIDTxbx = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.CoordXNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordZNBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordYNbx)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationNbx)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniSpawnerNbx)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FurniInventoryIDNbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNbx)).BeginInit();
            this.Username.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoordXNbx
            // 
            this.CoordXNbx.Location = new System.Drawing.Point(10, 124);
            this.CoordXNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CoordXNbx.Name = "CoordXNbx";
            this.CoordXNbx.Size = new System.Drawing.Size(80, 26);
            this.CoordXNbx.TabIndex = 1;
            // 
            // CoordZNBx
            // 
            this.CoordZNBx.Location = new System.Drawing.Point(10, 246);
            this.CoordZNBx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CoordZNBx.Name = "CoordZNBx";
            this.CoordZNBx.Size = new System.Drawing.Size(80, 26);
            this.CoordZNBx.TabIndex = 3;
            // 
            // CoordYNbx
            // 
            this.CoordYNbx.Location = new System.Drawing.Point(10, 183);
            this.CoordYNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.CoordYNbx.Name = "CoordYNbx";
            this.CoordYNbx.Size = new System.Drawing.Size(80, 26);
            this.CoordYNbx.TabIndex = 2;
            // 
            // SpawnFloorFurniBtn
            // 
            this.SpawnFloorFurniBtn.Location = new System.Drawing.Point(19, 294);
            this.SpawnFloorFurniBtn.Name = "SpawnFloorFurniBtn";
            this.SpawnFloorFurniBtn.Size = new System.Drawing.Size(195, 35);
            this.SpawnFloorFurniBtn.TabIndex = 4;
            this.SpawnFloorFurniBtn.Text = "Spawn Floor Furni";
            this.SpawnFloorFurniBtn.Click += new System.EventHandler(this.SpawnFloorFurniBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RotationNbx);
            this.groupBox1.Controls.Add(this.RotationRight);
            this.groupBox1.Controls.Add(this.rotationLeft);
            this.groupBox1.Controls.Add(this.RotationDown);
            this.groupBox1.Controls.Add(this.RotationUp);
            this.groupBox1.Location = new System.Drawing.Point(123, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(164, 145);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotation";
            // 
            // RotationNbx
            // 
            this.RotationNbx.Enabled = false;
            this.RotationNbx.Location = new System.Drawing.Point(54, 65);
            this.RotationNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.RotationNbx.Name = "RotationNbx";
            this.RotationNbx.Size = new System.Drawing.Size(56, 26);
            this.RotationNbx.TabIndex = 13;
            // 
            // RotationRight
            // 
            this.RotationRight.AutoSize = true;
            this.RotationRight.Checked = true;
            this.RotationRight.Location = new System.Drawing.Point(117, 71);
            this.RotationRight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotationRight.Name = "RotationRight";
            this.RotationRight.Size = new System.Drawing.Size(21, 20);
            this.RotationRight.TabIndex = 4;
            this.RotationRight.TabStop = true;
            this.RotationRight.UseVisualStyleBackColor = true;
            this.RotationRight.CheckedChanged += new System.EventHandler(this.RotationRight_CheckedChanged);
            // 
            // rotationLeft
            // 
            this.rotationLeft.AutoSize = true;
            this.rotationLeft.Location = new System.Drawing.Point(26, 71);
            this.rotationLeft.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rotationLeft.Name = "rotationLeft";
            this.rotationLeft.Size = new System.Drawing.Size(21, 20);
            this.rotationLeft.TabIndex = 3;
            this.rotationLeft.UseVisualStyleBackColor = true;
            this.rotationLeft.CheckedChanged += new System.EventHandler(this.rotationLeft_CheckedChanged);
            // 
            // RotationDown
            // 
            this.RotationDown.AutoSize = true;
            this.RotationDown.Location = new System.Drawing.Point(68, 112);
            this.RotationDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotationDown.Name = "RotationDown";
            this.RotationDown.Size = new System.Drawing.Size(21, 20);
            this.RotationDown.TabIndex = 2;
            this.RotationDown.UseVisualStyleBackColor = true;
            this.RotationDown.CheckedChanged += new System.EventHandler(this.RotationDown_CheckedChanged);
            // 
            // RotationUp
            // 
            this.RotationUp.AutoSize = true;
            this.RotationUp.Location = new System.Drawing.Point(68, 29);
            this.RotationUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RotationUp.Name = "RotationUp";
            this.RotationUp.Size = new System.Drawing.Size(21, 20);
            this.RotationUp.TabIndex = 1;
            this.RotationUp.UseVisualStyleBackColor = true;
            this.RotationUp.CheckedChanged += new System.EventHandler(this.RotationUp_CheckedChanged);
            // 
            // SetOwnUsernameBtn
            // 
            this.SetOwnUsernameBtn.Location = new System.Drawing.Point(42, 65);
            this.SetOwnUsernameBtn.Name = "SetOwnUsernameBtn";
            this.SetOwnUsernameBtn.Size = new System.Drawing.Size(195, 45);
            this.SetOwnUsernameBtn.TabIndex = 10;
            this.SetOwnUsernameBtn.Text = "Set own username";
            this.SetOwnUsernameBtn.Click += new System.EventHandler(this.SetOwnUsernameBtn_Click);
            // 
            // FurniOwnerTxbx
            // 
            this.FurniOwnerTxbx.Location = new System.Drawing.Point(16, 33);
            this.FurniOwnerTxbx.Name = "FurniOwnerTxbx";
            this.FurniOwnerTxbx.Size = new System.Drawing.Size(251, 26);
            this.FurniOwnerTxbx.TabIndex = 11;
            // 
            // SpawnFloorFurniOnClickBtn
            // 
            this.SpawnFloorFurniOnClickBtn.Location = new System.Drawing.Point(19, 346);
            this.SpawnFloorFurniOnClickBtn.Name = "SpawnFloorFurniOnClickBtn";
            this.SpawnFloorFurniOnClickBtn.Size = new System.Drawing.Size(251, 35);
            this.SpawnFloorFurniOnClickBtn.TabIndex = 12;
            this.SpawnFloorFurniOnClickBtn.Text = "Spawn Floor Furni on click : OFF";
            this.SpawnFloorFurniOnClickBtn.Click += new System.EventHandler(this.SpawnFloorFurniOnClickBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IRadioBtn);
            this.groupBox2.Controls.Add(this.SRadioBtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 98);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FurniType";
            // 
            // IRadioBtn
            // 
            this.IRadioBtn.AutoSize = true;
            this.IRadioBtn.Location = new System.Drawing.Point(17, 68);
            this.IRadioBtn.Name = "IRadioBtn";
            this.IRadioBtn.Size = new System.Drawing.Size(64, 24);
            this.IRadioBtn.TabIndex = 0;
            this.IRadioBtn.Text = "Wall";
            this.IRadioBtn.UseVisualStyleBackColor = true;
            this.IRadioBtn.CheckedChanged += new System.EventHandler(this.IRadioBtn_CheckedChanged);
            // 
            // SRadioBtn
            // 
            this.SRadioBtn.AutoSize = true;
            this.SRadioBtn.Checked = true;
            this.SRadioBtn.Location = new System.Drawing.Point(17, 35);
            this.SRadioBtn.Name = "SRadioBtn";
            this.SRadioBtn.Size = new System.Drawing.Size(70, 24);
            this.SRadioBtn.TabIndex = 1;
            this.SRadioBtn.TabStop = true;
            this.SRadioBtn.Text = "Floor";
            this.SRadioBtn.UseVisualStyleBackColor = true;
            this.SRadioBtn.CheckedChanged += new System.EventHandler(this.SRadioBtn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.FloorFurniSpawnerNbx);
            this.groupBox3.Controls.Add(this.SpawnFloorFurniOnClickBtn);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.SpawnFloorFurniBtn);
            this.groupBox3.Controls.Add(this.CoordZNBx);
            this.groupBox3.Controls.Add(this.CoordYNbx);
            this.groupBox3.Controls.Add(this.CoordXNbx);
            this.groupBox3.Location = new System.Drawing.Point(15, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 405);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Floor Furni Spawner ( CS )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "FurniID";
            // 
            // FloorFurniSpawnerNbx
            // 
            this.FloorFurniSpawnerNbx.Location = new System.Drawing.Point(10, 58);
            this.FloorFurniSpawnerNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.FloorFurniSpawnerNbx.Name = "FloorFurniSpawnerNbx";
            this.FloorFurniSpawnerNbx.Size = new System.Drawing.Size(277, 26);
            this.FloorFurniSpawnerNbx.TabIndex = 13;
            // 
            // SpawnFurniInvBtn
            // 
            this.SpawnFurniInvBtn.Location = new System.Drawing.Point(5, 232);
            this.SpawnFurniInvBtn.Name = "SpawnFurniInvBtn";
            this.SpawnFurniInvBtn.Size = new System.Drawing.Size(202, 35);
            this.SpawnFurniInvBtn.TabIndex = 18;
            this.SpawnFurniInvBtn.Text = "Spawn Furni On inventory";
            this.SpawnFurniInvBtn.Click += new System.EventHandler(this.SpawnFurniInvBtn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.FurniInventoryIDNbx);
            this.groupBox5.Controls.Add(this.AmountNbx);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.PosterIDTxbx);
            this.groupBox5.Controls.Add(this.SpawnFurniInvBtn);
            this.groupBox5.Controls.Add(this.groupBox2);
            this.groupBox5.Location = new System.Drawing.Point(355, 22);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(356, 306);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Inventory Spawner ( CS )";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "FurniID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Amount";
            // 
            // FurniInventoryIDNbx
            // 
            this.FurniInventoryIDNbx.Location = new System.Drawing.Point(5, 58);
            this.FurniInventoryIDNbx.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.FurniInventoryIDNbx.Name = "FurniInventoryIDNbx";
            this.FurniInventoryIDNbx.Size = new System.Drawing.Size(277, 26);
            this.FurniInventoryIDNbx.TabIndex = 20;
            // 
            // AmountNbx
            // 
            this.AmountNbx.Enabled = false;
            this.AmountNbx.Location = new System.Drawing.Point(120, 130);
            this.AmountNbx.Name = "AmountNbx";
            this.AmountNbx.Size = new System.Drawing.Size(170, 26);
            this.AmountNbx.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "PosterID";
            // 
            // PosterIDTxbx
            // 
            this.PosterIDTxbx.Location = new System.Drawing.Point(120, 196);
            this.PosterIDTxbx.Name = "PosterIDTxbx";
            this.PosterIDTxbx.Size = new System.Drawing.Size(170, 26);
            this.PosterIDTxbx.TabIndex = 19;
            this.PosterIDTxbx.Text = "2005";
            // 
            // Username
            // 
            this.Username.Controls.Add(this.FurniOwnerTxbx);
            this.Username.Controls.Add(this.SetOwnUsernameBtn);
            this.Username.Location = new System.Drawing.Point(376, 332);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(334, 140);
            this.Username.TabIndex = 21;
            this.Username.TabStop = false;
            this.Username.Text = "Furni Owner";
            // 
            // FurniSpawnPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Username);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "FurniSpawnPage";
            this.Size = new System.Drawing.Size(1160, 491);
            ((System.ComponentModel.ISupportInitialize)(this.CoordXNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordZNBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CoordYNbx)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationNbx)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FloorFurniSpawnerNbx)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FurniInventoryIDNbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AmountNbx)).EndInit();
            this.Username.ResumeLayout(false);
            this.Username.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown CoordXNbx;
        private System.Windows.Forms.NumericUpDown CoordZNBx;
        private System.Windows.Forms.NumericUpDown CoordYNbx;
        private Sulakore.Components.SKoreButton SpawnFloorFurniBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RotationRight;
        private System.Windows.Forms.RadioButton rotationLeft;
        private System.Windows.Forms.RadioButton RotationDown;
        private System.Windows.Forms.RadioButton RotationUp;
        private Sulakore.Components.SKoreButton SetOwnUsernameBtn;
        private System.Windows.Forms.TextBox FurniOwnerTxbx;
        private System.Windows.Forms.NumericUpDown RotationNbx;
        private Sulakore.Components.SKoreButton SpawnFloorFurniOnClickBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton SRadioBtn;
        private System.Windows.Forms.RadioButton IRadioBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private Sulakore.Components.SKoreButton SpawnFurniInvBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox PosterIDTxbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown AmountNbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown FloorFurniSpawnerNbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown FurniInventoryIDNbx;
        private System.Windows.Forms.GroupBox Username;
    }
}
