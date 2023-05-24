namespace HashComparer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceFoldertextBox = new System.Windows.Forms.TextBox();
            this.DestinationtextBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCrashDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5SHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA256ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopCurrentHahsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopAllProgressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DestinationTreeView = new System.Windows.Forms.TreeView();
            this.sourceFolderTreeView = new System.Windows.Forms.TreeView();
            this.calculateHashesButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source Parent Folder";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination Parent Folder";
            // 
            // SourceFoldertextBox
            // 
            this.SourceFoldertextBox.Location = new System.Drawing.Point(12, 53);
            this.SourceFoldertextBox.Name = "SourceFoldertextBox";
            this.SourceFoldertextBox.ReadOnly = true;
            this.SourceFoldertextBox.Size = new System.Drawing.Size(302, 20);
            this.SourceFoldertextBox.TabIndex = 4;
            // 
            // DestinationtextBox
            // 
            this.DestinationtextBox.Location = new System.Drawing.Point(349, 53);
            this.DestinationtextBox.Name = "DestinationtextBox";
            this.DestinationtextBox.ReadOnly = true;
            this.DestinationtextBox.Size = new System.Drawing.Size(302, 20);
            this.DestinationtextBox.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(959, 503);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(110, 20);
            this.progressBar1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportReportToolStripMenuItem,
            this.importCrashDataToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exportReportToolStripMenuItem
            // 
            this.exportReportToolStripMenuItem.Name = "exportReportToolStripMenuItem";
            this.exportReportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exportReportToolStripMenuItem.Text = "Export Report";
            // 
            // importCrashDataToolStripMenuItem
            // 
            this.importCrashDataToolStripMenuItem.Name = "importCrashDataToolStripMenuItem";
            this.importCrashDataToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.importCrashDataToolStripMenuItem.Text = "Import Crash Data";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hashToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // hashToolStripMenuItem
            // 
            this.hashToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mD5SHA1ToolStripMenuItem,
            this.sHA256ToolStripMenuItem});
            this.hashToolStripMenuItem.Name = "hashToolStripMenuItem";
            this.hashToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.hashToolStripMenuItem.Text = "Hash";
            // 
            // mD5SHA1ToolStripMenuItem
            // 
            this.mD5SHA1ToolStripMenuItem.Name = "mD5SHA1ToolStripMenuItem";
            this.mD5SHA1ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.mD5SHA1ToolStripMenuItem.Text = "MD5/SHA-1";
            // 
            // sHA256ToolStripMenuItem
            // 
            this.sHA256ToolStripMenuItem.Name = "sHA256ToolStripMenuItem";
            this.sHA256ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.sHA256ToolStripMenuItem.Text = "SHA256";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stopCurrentHahsToolStripMenuItem,
            this.stopAllProgressesToolStripMenuItem});
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // stopCurrentHahsToolStripMenuItem
            // 
            this.stopCurrentHahsToolStripMenuItem.Name = "stopCurrentHahsToolStripMenuItem";
            this.stopCurrentHahsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.stopCurrentHahsToolStripMenuItem.Text = "Stop Current Hash";
            // 
            // stopAllProgressesToolStripMenuItem
            // 
            this.stopAllProgressesToolStripMenuItem.Name = "stopAllProgressesToolStripMenuItem";
            this.stopAllProgressesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.stopAllProgressesToolStripMenuItem.Text = "Stop All Progresses";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 79);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 20);
            this.button2.TabIndex = 9;
            this.button2.Text = "Add Folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(349, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(673, 53);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 412);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(670, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matched Hashes";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 503);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(863, 20);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 503);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Current Status";
            // 
            // DestinationTreeView
            // 
            this.DestinationTreeView.Location = new System.Drawing.Point(349, 105);
            this.DestinationTreeView.Name = "DestinationTreeView";
            this.DestinationTreeView.Size = new System.Drawing.Size(302, 360);
            this.DestinationTreeView.TabIndex = 15;
            // 
            // sourceFolderTreeView
            // 
            this.sourceFolderTreeView.Location = new System.Drawing.Point(12, 105);
            this.sourceFolderTreeView.Name = "sourceFolderTreeView";
            this.sourceFolderTreeView.Size = new System.Drawing.Size(302, 360);
            this.sourceFolderTreeView.TabIndex = 16;
            // 
            // calculateHashesButton
            // 
            this.calculateHashesButton.Location = new System.Drawing.Point(918, 472);
            this.calculateHashesButton.Name = "calculateHashesButton";
            this.calculateHashesButton.Size = new System.Drawing.Size(150, 23);
            this.calculateHashesButton.TabIndex = 17;
            this.calculateHashesButton.Text = "Calculate Hashes";
            this.calculateHashesButton.UseVisualStyleBackColor = true;
            this.calculateHashesButton.Click += new System.EventHandler(this.calculateHashesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 535);
            this.Controls.Add(this.calculateHashesButton);
            this.Controls.Add(this.sourceFolderTreeView);
            this.Controls.Add(this.DestinationTreeView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.DestinationtextBox);
            this.Controls.Add(this.SourceFoldertextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceFoldertextBox;
        private System.Windows.Forms.TextBox DestinationtextBox;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCrashDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5SHA1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sHA256ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopCurrentHahsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopAllProgressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TreeView DestinationTreeView;
        private System.Windows.Forms.TreeView sourceFolderTreeView;
        private System.Windows.Forms.Button calculateHashesButton;
    }
}

