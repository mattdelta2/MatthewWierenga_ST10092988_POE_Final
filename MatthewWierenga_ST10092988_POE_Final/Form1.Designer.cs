﻿namespace MatthewWierenga_ST10092988_POE_Final
{
    partial class Form1
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
            this.lblMap = new System.Windows.Forms.Label();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.gbxAttack = new System.Windows.Forms.GroupBox();
            this.rtbAttackLog = new System.Windows.Forms.RichTextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.rtbSelectedEnemy = new System.Windows.Forms.RichTextBox();
            this.cbxEnemies = new System.Windows.Forms.ComboBox();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.rtbShop = new System.Windows.Forms.RichTextBox();
            this.cbxShop = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.gbxAttack.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(291, 82);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(35, 13);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "label1";
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(796, 76);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(215, 96);
            this.rtbInfo.TabIndex = 1;
            this.rtbInfo.Text = "";
            // 
            // gbxAttack
            // 
            this.gbxAttack.Controls.Add(this.rtbAttackLog);
            this.gbxAttack.Controls.Add(this.btnAttack);
            this.gbxAttack.Controls.Add(this.rtbSelectedEnemy);
            this.gbxAttack.Controls.Add(this.cbxEnemies);
            this.gbxAttack.Location = new System.Drawing.Point(796, 209);
            this.gbxAttack.Name = "gbxAttack";
            this.gbxAttack.Size = new System.Drawing.Size(215, 269);
            this.gbxAttack.TabIndex = 2;
            this.gbxAttack.TabStop = false;
            this.gbxAttack.Text = "Attacking";
            // 
            // rtbAttackLog
            // 
            this.rtbAttackLog.Location = new System.Drawing.Point(7, 192);
            this.rtbAttackLog.Name = "rtbAttackLog";
            this.rtbAttackLog.Size = new System.Drawing.Size(208, 77);
            this.rtbAttackLog.TabIndex = 3;
            this.rtbAttackLog.Text = "";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(7, 162);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(208, 23);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // rtbSelectedEnemy
            // 
            this.rtbSelectedEnemy.Location = new System.Drawing.Point(7, 48);
            this.rtbSelectedEnemy.Name = "rtbSelectedEnemy";
            this.rtbSelectedEnemy.Size = new System.Drawing.Size(208, 96);
            this.rtbSelectedEnemy.TabIndex = 1;
            this.rtbSelectedEnemy.Text = "";
            // 
            // cbxEnemies
            // 
            this.cbxEnemies.FormattingEnabled = true;
            this.cbxEnemies.Location = new System.Drawing.Point(7, 20);
            this.cbxEnemies.Name = "cbxEnemies";
            this.cbxEnemies.Size = new System.Drawing.Size(208, 21);
            this.cbxEnemies.TabIndex = 0;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(897, 495);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(31, 23);
            this.btnUp.TabIndex = 3;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(897, 537);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(31, 23);
            this.btnDown.TabIndex = 4;
            this.btnDown.Text = "v";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(860, 515);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(31, 23);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(934, 515);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(31, 23);
            this.btnRight.TabIndex = 6;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuy);
            this.groupBox1.Controls.Add(this.cbxShop);
            this.groupBox1.Controls.Add(this.rtbShop);
            this.groupBox1.Location = new System.Drawing.Point(1111, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 269);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shop";
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Location = new System.Drawing.Point(897, 148);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(8, 8);
            this.propertyGrid1.TabIndex = 8;
            // 
            // rtbShop
            // 
            this.rtbShop.Location = new System.Drawing.Point(6, 29);
            this.rtbShop.Name = "rtbShop";
            this.rtbShop.Size = new System.Drawing.Size(193, 73);
            this.rtbShop.TabIndex = 0;
            this.rtbShop.Text = "";
            // 
            // cbxShop
            // 
            this.cbxShop.FormattingEnabled = true;
            this.cbxShop.Location = new System.Drawing.Point(0, 109);
            this.cbxShop.Name = "cbxShop";
            this.cbxShop.Size = new System.Drawing.Size(199, 21);
            this.cbxShop.TabIndex = 1;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(35, 162);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(123, 48);
            this.btnBuy.TabIndex = 2;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 618);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.gbxAttack);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.lblMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxAttack.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.GroupBox gbxAttack;
        private System.Windows.Forms.RichTextBox rtbAttackLog;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.RichTextBox rtbSelectedEnemy;
        private System.Windows.Forms.ComboBox cbxEnemies;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.ComboBox cbxShop;
        private System.Windows.Forms.RichTextBox rtbShop;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
    }
}

