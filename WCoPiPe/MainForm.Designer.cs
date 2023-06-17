namespace WCoPiPe
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.textBoxOutputPreview = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGetUDB = new System.Windows.Forms.Button();
            this.buttonGetCDB = new System.Windows.Forms.Button();
            this.buttonOutputSys = new System.Windows.Forms.Button();
            this.buttonCDBOutput = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelC = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.buttonUDBOutput = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlValiable = new System.Windows.Forms.TabControl();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(32, 62);
            this.numericUpDownA.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownA.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownA.TabIndex = 3;
            this.numericUpDownA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(109, 62);
            this.numericUpDownB.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownB.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownB.TabIndex = 5;
            this.numericUpDownB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(189, 62);
            this.numericUpDownC.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownC.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(57, 19);
            this.numericUpDownC.TabIndex = 7;
            this.numericUpDownC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxOutputPreview
            // 
            this.textBoxOutputPreview.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOutputPreview.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.textBoxOutputPreview.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxOutputPreview.Location = new System.Drawing.Point(12, 47);
            this.textBoxOutputPreview.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxOutputPreview.Name = "textBoxOutputPreview";
            this.textBoxOutputPreview.ReadOnly = true;
            this.textBoxOutputPreview.Size = new System.Drawing.Size(156, 34);
            this.textBoxOutputPreview.TabIndex = 12;
            this.textBoxOutputPreview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonOutputSys);
            this.groupBox1.Controls.Add(this.buttonCDBOutput);
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.labelC);
            this.groupBox1.Controls.Add(this.labelB);
            this.groupBox1.Controls.Add(this.labelA);
            this.groupBox1.Controls.Add(this.buttonUDBOutput);
            this.groupBox1.Controls.Add(this.numericUpDownB);
            this.groupBox1.Controls.Add(this.numericUpDownC);
            this.groupBox1.Controls.Add(this.numericUpDownA);
            this.groupBox1.Location = new System.Drawing.Point(11, 300);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(368, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "データベース";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "データベース　タイプA/データB/項目C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonGetUDB);
            this.groupBox2.Controls.Add(this.buttonGetCDB);
            this.groupBox2.Location = new System.Drawing.Point(17, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 63);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "文字列変数コピペ";
            // 
            // buttonGetUDB
            // 
            this.buttonGetUDB.Location = new System.Drawing.Point(11, 25);
            this.buttonGetUDB.Name = "buttonGetUDB";
            this.buttonGetUDB.Size = new System.Drawing.Size(75, 23);
            this.buttonGetUDB.TabIndex = 14;
            this.buttonGetUDB.Text = "UDB値コピ-";
            this.buttonGetUDB.UseVisualStyleBackColor = true;
            this.buttonGetUDB.Click += new System.EventHandler(this.buttonGetUDB_Click);
            // 
            // buttonGetCDB
            // 
            this.buttonGetCDB.Location = new System.Drawing.Point(92, 25);
            this.buttonGetCDB.Name = "buttonGetCDB";
            this.buttonGetCDB.Size = new System.Drawing.Size(75, 23);
            this.buttonGetCDB.TabIndex = 15;
            this.buttonGetCDB.Text = "CDB値コピ-";
            this.buttonGetCDB.UseVisualStyleBackColor = true;
            this.buttonGetCDB.Click += new System.EventHandler(this.buttonGetCDB_Click);
            // 
            // buttonOutputSys
            // 
            this.buttonOutputSys.Location = new System.Drawing.Point(243, 102);
            this.buttonOutputSys.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOutputSys.Name = "buttonOutputSys";
            this.buttonOutputSys.Size = new System.Drawing.Size(109, 40);
            this.buttonOutputSys.TabIndex = 17;
            this.buttonOutputSys.Text = "Sysコピ-";
            this.buttonOutputSys.UseVisualStyleBackColor = true;
            this.buttonOutputSys.Click += new System.EventHandler(this.buttonOutputSys_Click);
            // 
            // buttonCDBOutput
            // 
            this.buttonCDBOutput.Location = new System.Drawing.Point(130, 102);
            this.buttonCDBOutput.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCDBOutput.Name = "buttonCDBOutput";
            this.buttonCDBOutput.Size = new System.Drawing.Size(109, 40);
            this.buttonCDBOutput.TabIndex = 16;
            this.buttonCDBOutput.Text = "CDBコピ-";
            this.buttonCDBOutput.UseVisualStyleBackColor = true;
            this.buttonCDBOutput.Click += new System.EventHandler(this.buttonCDBOutput_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClear.Location = new System.Drawing.Point(277, 62);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "クリア";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(174, 64);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(13, 12);
            this.labelC.TabIndex = 6;
            this.labelC.Text = "C";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(94, 64);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(13, 12);
            this.labelB.TabIndex = 4;
            this.labelB.Text = "B";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(15, 64);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(13, 12);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "A";
            // 
            // buttonUDBOutput
            // 
            this.buttonUDBOutput.Location = new System.Drawing.Point(17, 102);
            this.buttonUDBOutput.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUDBOutput.Name = "buttonUDBOutput";
            this.buttonUDBOutput.Size = new System.Drawing.Size(109, 40);
            this.buttonUDBOutput.TabIndex = 10;
            this.buttonUDBOutput.Text = "UDBコピ-";
            this.buttonUDBOutput.UseVisualStyleBackColor = true;
            this.buttonUDBOutput.Click += new System.EventHandler(this.buttonUDBOutput_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "WCoPiPe";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(99, 26);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.CloseToolStripMenuItem.Text = "終了";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // tabControlValiable
            // 
            this.tabControlValiable.Location = new System.Drawing.Point(10, 27);
            this.tabControlValiable.Multiline = true;
            this.tabControlValiable.Name = "tabControlValiable";
            this.tabControlValiable.SelectedIndex = 0;
            this.tabControlValiable.Size = new System.Drawing.Size(538, 258);
            this.tabControlValiable.TabIndex = 13;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSettings});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(563, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip2";
            // 
            // ToolStripMenuItemSettings
            // 
            this.ToolStripMenuItemSettings.Name = "ToolStripMenuItemSettings";
            this.ToolStripMenuItemSettings.ShortcutKeyDisplayString = "";
            this.ToolStripMenuItemSettings.Size = new System.Drawing.Size(57, 20);
            this.ToolStripMenuItemSettings.Text = "設定(&S)";
            this.ToolStripMenuItemSettings.Click += new System.EventHandler(this.ToolStripMenuItemSettings_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxOutputPreview);
            this.groupBox3.Location = new System.Drawing.Point(384, 435);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 100);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "結果";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonUDBOutput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonClear;
            this.ClientSize = new System.Drawing.Size(563, 550);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.tabControlValiable);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "WCoPiPe  Ctrl+Qで前面表示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.TextBox textBoxOutputPreview;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonGetCDB;
        private System.Windows.Forms.Button buttonGetUDB;
        private System.Windows.Forms.Button buttonCDBOutput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonOutputSys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUDBOutput;
        private System.Windows.Forms.TabControl tabControlValiable;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSettings;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

