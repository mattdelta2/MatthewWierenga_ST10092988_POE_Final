namespace MatthewWierenga_ST10092988_POE_Final
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
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.rtbAttackLog = new System.Windows.Forms.RichTextBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.rtbSelectedEnemy = new System.Windows.Forms.RichTextBox();
            this.gbxAttack = new System.Windows.Forms.GroupBox();
            this.cbxEnemies = new System.Windows.Forms.ComboBox();
            this.gbxAttack.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Location = new System.Drawing.Point(512, 286);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(51, 20);
            this.lblMap.TabIndex = 0;
            this.lblMap.Text = "label1";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(19, 213);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(332, 44);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1436, 51);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 55);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1248, 51);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(1422, 965);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 38);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = ">";
            this.btnRight.UseVisualStyleBackColor = true;
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(1264, 965);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 38);
            this.btnLeft.TabIndex = 5;
            this.btnLeft.Text = "<";
            this.btnLeft.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(1345, 1000);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 42);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "V";
            this.btnDown.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(1345, 936);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 32);
            this.btnUp.TabIndex = 7;
            this.btnUp.Text = "^";
            this.btnUp.UseVisualStyleBackColor = true;
            // 
            // rtbAttackLog
            // 
            this.rtbAttackLog.Location = new System.Drawing.Point(6, 307);
            this.rtbAttackLog.Name = "rtbAttackLog";
            this.rtbAttackLog.Size = new System.Drawing.Size(345, 96);
            this.rtbAttackLog.TabIndex = 8;
            this.rtbAttackLog.Text = "";
            // 
            // rtbInfo
            // 
            this.rtbInfo.Location = new System.Drawing.Point(1210, 128);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(357, 151);
            this.rtbInfo.TabIndex = 9;
            this.rtbInfo.Text = "";
            // 
            // rtbSelectedEnemy
            // 
            this.rtbSelectedEnemy.Location = new System.Drawing.Point(6, 93);
            this.rtbSelectedEnemy.Name = "rtbSelectedEnemy";
            this.rtbSelectedEnemy.Size = new System.Drawing.Size(351, 96);
            this.rtbSelectedEnemy.TabIndex = 10;
            this.rtbSelectedEnemy.Text = "";
            // 
            // gbxAttack
            // 
            this.gbxAttack.Controls.Add(this.cbxEnemies);
            this.gbxAttack.Controls.Add(this.rtbSelectedEnemy);
            this.gbxAttack.Controls.Add(this.rtbAttackLog);
            this.gbxAttack.Controls.Add(this.btnAttack);
            this.gbxAttack.Location = new System.Drawing.Point(1210, 402);
            this.gbxAttack.Name = "gbxAttack";
            this.gbxAttack.Size = new System.Drawing.Size(357, 499);
            this.gbxAttack.TabIndex = 11;
            this.gbxAttack.TabStop = false;
            this.gbxAttack.Text = "Attack";
            // 
            // cbxEnemies
            // 
            this.cbxEnemies.FormattingEnabled = true;
            this.cbxEnemies.Location = new System.Drawing.Point(0, 41);
            this.cbxEnemies.Name = "cbxEnemies";
            this.cbxEnemies.Size = new System.Drawing.Size(357, 28);
            this.cbxEnemies.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1849, 1082);
            this.Controls.Add(this.gbxAttack);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxAttack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMap;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.RichTextBox rtbAttackLog;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.RichTextBox rtbSelectedEnemy;
        private System.Windows.Forms.GroupBox gbxAttack;
        private System.Windows.Forms.ComboBox cbxEnemies;
    }
}

