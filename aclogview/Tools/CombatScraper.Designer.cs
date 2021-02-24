
namespace aclogview.Tools
{
    partial class CombatScraper
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCreatureName1 = new System.Windows.Forms.TextBox();
            this.btnStartScrape = new System.Windows.Forms.Button();
            this.btnStopScrape = new System.Windows.Forms.Button();
            this.tbSearchPathRoot = new System.Windows.Forms.TextBox();
            this.tbOutputFolder = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnChangeSearchPathRoot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChangeOutputFolder = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rdbMeleeDamage = new System.Windows.Forms.RadioButton();
            this.rdbMagicDamage = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbCreatureName2 = new System.Windows.Forms.TextBox();
            this.tbCreatureName3 = new System.Windows.Forms.TextBox();
            this.tbCreatureName4 = new System.Windows.Forms.TextBox();
            this.tbCreatureName5 = new System.Windows.Forms.TextBox();
            this.chkExcludeNonRetailPcaps = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Up to 5 Creatures. (leave others blank if using less than 5)";
            // 
            // tbCreatureName1
            // 
            this.tbCreatureName1.Location = new System.Drawing.Point(30, 52);
            this.tbCreatureName1.Name = "tbCreatureName1";
            this.tbCreatureName1.Size = new System.Drawing.Size(247, 20);
            this.tbCreatureName1.TabIndex = 0;
            // 
            // btnStartScrape
            // 
            this.btnStartScrape.Location = new System.Drawing.Point(373, 378);
            this.btnStartScrape.Name = "btnStartScrape";
            this.btnStartScrape.Size = new System.Drawing.Size(103, 23);
            this.btnStartScrape.TabIndex = 2;
            this.btnStartScrape.Text = "Start Scrape";
            this.btnStartScrape.UseVisualStyleBackColor = true;
            this.btnStartScrape.Click += new System.EventHandler(this.btnStartScrape_Click);
            // 
            // btnStopScrape
            // 
            this.btnStopScrape.Location = new System.Drawing.Point(482, 378);
            this.btnStopScrape.Name = "btnStopScrape";
            this.btnStopScrape.Size = new System.Drawing.Size(102, 23);
            this.btnStopScrape.TabIndex = 3;
            this.btnStopScrape.Text = "Stop Scrape";
            this.btnStopScrape.UseVisualStyleBackColor = true;
            this.btnStopScrape.Click += new System.EventHandler(this.btnStopScrape_Click);
            // 
            // tbSearchPathRoot
            // 
            this.tbSearchPathRoot.Location = new System.Drawing.Point(15, 25);
            this.tbSearchPathRoot.Name = "tbSearchPathRoot";
            this.tbSearchPathRoot.Size = new System.Drawing.Size(517, 20);
            this.tbSearchPathRoot.TabIndex = 4;
            // 
            // tbOutputFolder
            // 
            this.tbOutputFolder.Location = new System.Drawing.Point(15, 74);
            this.tbOutputFolder.Name = "tbOutputFolder";
            this.tbOutputFolder.Size = new System.Drawing.Size(517, 20);
            this.tbOutputFolder.TabIndex = 5;
            // 
            // btnChangeSearchPathRoot
            // 
            this.btnChangeSearchPathRoot.Location = new System.Drawing.Point(538, 25);
            this.btnChangeSearchPathRoot.Name = "btnChangeSearchPathRoot";
            this.btnChangeSearchPathRoot.Size = new System.Drawing.Size(46, 23);
            this.btnChangeSearchPathRoot.TabIndex = 6;
            this.btnChangeSearchPathRoot.Text = "Folder";
            this.btnChangeSearchPathRoot.UseVisualStyleBackColor = true;
            this.btnChangeSearchPathRoot.Click += new System.EventHandler(this.btnChangeSearchPathRoot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scraper Root Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Output Folder:";
            // 
            // btnChangeOutputFolder
            // 
            this.btnChangeOutputFolder.Location = new System.Drawing.Point(539, 70);
            this.btnChangeOutputFolder.Name = "btnChangeOutputFolder";
            this.btnChangeOutputFolder.Size = new System.Drawing.Size(45, 23);
            this.btnChangeOutputFolder.TabIndex = 7;
            this.btnChangeOutputFolder.Text = "Folder";
            this.btnChangeOutputFolder.UseVisualStyleBackColor = true;
            this.btnChangeOutputFolder.Click += new System.EventHandler(this.btnChangeOutputFolder_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(596, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel4.Text = "Status:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(89, 17);
            this.toolStripStatusLabel1.Text = "Files Processed:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel2.Text = "Total Hits:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Margin = new System.Windows.Forms.Padding(20, 3, 0, 2);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(116, 17);
            this.toolStripStatusLabel3.Text = "Message Exceptions:";
            // 
            // rdbMeleeDamage
            // 
            this.rdbMeleeDamage.AutoSize = true;
            this.rdbMeleeDamage.Checked = true;
            this.rdbMeleeDamage.Location = new System.Drawing.Point(326, 152);
            this.rdbMeleeDamage.Name = "rdbMeleeDamage";
            this.rdbMeleeDamage.Size = new System.Drawing.Size(133, 17);
            this.rdbMeleeDamage.TabIndex = 11;
            this.rdbMeleeDamage.TabStop = true;
            this.rdbMeleeDamage.Text = "Melee/Missile Damage";
            this.rdbMeleeDamage.UseVisualStyleBackColor = true;
            // 
            // rdbMagicDamage
            // 
            this.rdbMagicDamage.AutoSize = true;
            this.rdbMagicDamage.Enabled = false;
            this.rdbMagicDamage.Location = new System.Drawing.Point(465, 151);
            this.rdbMagicDamage.Name = "rdbMagicDamage";
            this.rdbMagicDamage.Size = new System.Drawing.Size(97, 17);
            this.rdbMagicDamage.TabIndex = 12;
            this.rdbMagicDamage.Text = "Magic Damage";
            this.rdbMagicDamage.UseVisualStyleBackColor = true;
            this.rdbMagicDamage.CheckedChanged += new System.EventHandler(this.rdbMagicDamage_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCreatureName5);
            this.groupBox1.Controls.Add(this.tbCreatureName4);
            this.groupBox1.Controls.Add(this.tbCreatureName3);
            this.groupBox1.Controls.Add(this.tbCreatureName2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbCreatureName1);
            this.groupBox1.Location = new System.Drawing.Point(15, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 188);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creature Name";
            // 
            // tbCreatureName2
            // 
            this.tbCreatureName2.Location = new System.Drawing.Point(30, 78);
            this.tbCreatureName2.Name = "tbCreatureName2";
            this.tbCreatureName2.Size = new System.Drawing.Size(247, 20);
            this.tbCreatureName2.TabIndex = 1;
            // 
            // tbCreatureName3
            // 
            this.tbCreatureName3.Location = new System.Drawing.Point(30, 104);
            this.tbCreatureName3.Name = "tbCreatureName3";
            this.tbCreatureName3.Size = new System.Drawing.Size(247, 20);
            this.tbCreatureName3.TabIndex = 2;
            // 
            // tbCreatureName4
            // 
            this.tbCreatureName4.Location = new System.Drawing.Point(30, 130);
            this.tbCreatureName4.Name = "tbCreatureName4";
            this.tbCreatureName4.Size = new System.Drawing.Size(247, 20);
            this.tbCreatureName4.TabIndex = 3;
            // 
            // tbCreatureName5
            // 
            this.tbCreatureName5.Location = new System.Drawing.Point(30, 156);
            this.tbCreatureName5.Name = "tbCreatureName5";
            this.tbCreatureName5.Size = new System.Drawing.Size(247, 20);
            this.tbCreatureName5.TabIndex = 4;
            // 
            // chkExcludeNonRetailPcaps
            // 
            this.chkExcludeNonRetailPcaps.AutoSize = true;
            this.chkExcludeNonRetailPcaps.Checked = true;
            this.chkExcludeNonRetailPcaps.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExcludeNonRetailPcaps.Location = new System.Drawing.Point(382, 100);
            this.chkExcludeNonRetailPcaps.Name = "chkExcludeNonRetailPcaps";
            this.chkExcludeNonRetailPcaps.Size = new System.Drawing.Size(150, 17);
            this.chkExcludeNonRetailPcaps.TabIndex = 24;
            this.chkExcludeNonRetailPcaps.Text = "Exclude Non-Retail Pcaps";
            this.chkExcludeNonRetailPcaps.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "1.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "4.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "5.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "3.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "2.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(388, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 16);
            this.label9.TabIndex = 25;
            this.label9.Text = "DamageType:";
            // 
            // CombatScraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.chkExcludeNonRetailPcaps);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rdbMagicDamage);
            this.Controls.Add(this.rdbMeleeDamage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnChangeOutputFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChangeSearchPathRoot);
            this.Controls.Add(this.tbOutputFolder);
            this.Controls.Add(this.tbSearchPathRoot);
            this.Controls.Add(this.btnStopScrape);
            this.Controls.Add(this.btnStartScrape);
            this.Name = "CombatScraper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CombatScraper";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCreatureName1;
        private System.Windows.Forms.Button btnStartScrape;
        private System.Windows.Forms.Button btnStopScrape;
        private System.Windows.Forms.TextBox tbSearchPathRoot;
        private System.Windows.Forms.TextBox tbOutputFolder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnChangeSearchPathRoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChangeOutputFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.RadioButton rdbMeleeDamage;
        private System.Windows.Forms.RadioButton rdbMagicDamage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCreatureName5;
        private System.Windows.Forms.TextBox tbCreatureName4;
        private System.Windows.Forms.TextBox tbCreatureName3;
        private System.Windows.Forms.TextBox tbCreatureName2;
        private System.Windows.Forms.CheckBox chkExcludeNonRetailPcaps;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
    }
}