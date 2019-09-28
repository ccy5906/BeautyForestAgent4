namespace BeautyForestAgent
{
    partial class FormMemo
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
            this.Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabMode = new System.Windows.Forms.TabControl();
            this.tpRead = new System.Windows.Forms.TabPage();
            this.tpWrite = new System.Windows.Forms.TabPage();
            this.loadFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.txtLoadFile = new System.Windows.Forms.TextBox();
            this.btnLoadFileSelect = new System.Windows.Forms.Button();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtLoadText = new System.Windows.Forms.TextBox();
            this.txtSaveText = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnSaveFileSelect = new System.Windows.Forms.Button();
            this.txtSaveFile = new System.Windows.Forms.TextBox();
            this.Status.SuspendLayout();
            this.tabMode.SuspendLayout();
            this.tpRead.SuspendLayout();
            this.tpWrite.SuspendLayout();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.Status.Location = new System.Drawing.Point(0, 387);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(548, 26);
            this.Status.TabIndex = 0;
            this.Status.Text = "status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(207, 20);
            this.toolStripStatusLabel1.Text = "3517 최지연 - 파일 읽고 쓰기";
            // 
            // tabMode
            // 
            this.tabMode.Controls.Add(this.tpRead);
            this.tabMode.Controls.Add(this.tpWrite);
            this.tabMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMode.Location = new System.Drawing.Point(0, 0);
            this.tabMode.Name = "tabMode";
            this.tabMode.SelectedIndex = 0;
            this.tabMode.Size = new System.Drawing.Size(548, 387);
            this.tabMode.TabIndex = 1;
            // 
            // tpRead
            // 
            this.tpRead.Controls.Add(this.txtLoadText);
            this.tpRead.Controls.Add(this.btnLoadFile);
            this.tpRead.Controls.Add(this.btnLoadFileSelect);
            this.tpRead.Controls.Add(this.txtLoadFile);
            this.tpRead.Location = new System.Drawing.Point(4, 25);
            this.tpRead.Name = "tpRead";
            this.tpRead.Padding = new System.Windows.Forms.Padding(3);
            this.tpRead.Size = new System.Drawing.Size(540, 358);
            this.tpRead.TabIndex = 0;
            this.tpRead.Text = "파일 읽기";
            this.tpRead.UseVisualStyleBackColor = true;
            // 
            // tpWrite
            // 
            this.tpWrite.Controls.Add(this.txtSaveText);
            this.tpWrite.Controls.Add(this.btnSaveFile);
            this.tpWrite.Controls.Add(this.btnSaveFileSelect);
            this.tpWrite.Controls.Add(this.txtSaveFile);
            this.tpWrite.Location = new System.Drawing.Point(4, 25);
            this.tpWrite.Name = "tpWrite";
            this.tpWrite.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrite.Size = new System.Drawing.Size(540, 358);
            this.tpWrite.TabIndex = 1;
            this.tpWrite.Text = "파일 쓰기";
            this.tpWrite.UseVisualStyleBackColor = true;
            // 
            // loadFileDlg
            // 
            this.loadFileDlg.FileName = "openFileDialog1";
            this.loadFileDlg.Filter = "텍스트 파일(*.txt)|*.txt|모든파일 (*.*)|*.*";
            // 
            // saveFileDlg
            // 
            this.saveFileDlg.Filter = "텍스트 파일(*.txt)|*.txt";
            // 
            // txtLoadFile
            // 
            this.txtLoadFile.Location = new System.Drawing.Point(9, 7);
            this.txtLoadFile.Name = "txtLoadFile";
            this.txtLoadFile.ReadOnly = true;
            this.txtLoadFile.Size = new System.Drawing.Size(251, 25);
            this.txtLoadFile.TabIndex = 0;
            // 
            // btnLoadFileSelect
            // 
            this.btnLoadFileSelect.Location = new System.Drawing.Point(267, 8);
            this.btnLoadFileSelect.Name = "btnLoadFileSelect";
            this.btnLoadFileSelect.Size = new System.Drawing.Size(123, 23);
            this.btnLoadFileSelect.TabIndex = 1;
            this.btnLoadFileSelect.Text = "파일 선택";
            this.btnLoadFileSelect.UseVisualStyleBackColor = true;
            this.btnLoadFileSelect.Click += new System.EventHandler(this.btnLoadFileSelect_Click);
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(396, 9);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(123, 23);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "불러오기";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // txtLoadText
            // 
            this.txtLoadText.Location = new System.Drawing.Point(9, 39);
            this.txtLoadText.Multiline = true;
            this.txtLoadText.Name = "txtLoadText";
            this.txtLoadText.ReadOnly = true;
            this.txtLoadText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLoadText.Size = new System.Drawing.Size(510, 298);
            this.txtLoadText.TabIndex = 3;
            // 
            // txtSaveText
            // 
            this.txtSaveText.Location = new System.Drawing.Point(15, 46);
            this.txtSaveText.Multiline = true;
            this.txtSaveText.Name = "txtSaveText";
            this.txtSaveText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSaveText.Size = new System.Drawing.Size(510, 298);
            this.txtSaveText.TabIndex = 7;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(402, 16);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(123, 23);
            this.btnSaveFile.TabIndex = 6;
            this.btnSaveFile.Text = "저장하기";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnSaveFileSelect
            // 
            this.btnSaveFileSelect.Location = new System.Drawing.Point(273, 15);
            this.btnSaveFileSelect.Name = "btnSaveFileSelect";
            this.btnSaveFileSelect.Size = new System.Drawing.Size(123, 23);
            this.btnSaveFileSelect.TabIndex = 5;
            this.btnSaveFileSelect.Text = "파일 선택";
            this.btnSaveFileSelect.UseVisualStyleBackColor = true;
            this.btnSaveFileSelect.Click += new System.EventHandler(this.btnSaveFileSelect_Click);
            // 
            // txtSaveFile
            // 
            this.txtSaveFile.Location = new System.Drawing.Point(15, 14);
            this.txtSaveFile.Name = "txtSaveFile";
            this.txtSaveFile.ReadOnly = true;
            this.txtSaveFile.Size = new System.Drawing.Size(251, 25);
            this.txtSaveFile.TabIndex = 4;
            // 
            // FormMemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 413);
            this.Controls.Add(this.tabMode);
            this.Controls.Add(this.Status);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMemo";
            this.Text = "FormMemo";
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.tabMode.ResumeLayout(false);
            this.tpRead.ResumeLayout(false);
            this.tpRead.PerformLayout();
            this.tpWrite.ResumeLayout(false);
            this.tpWrite.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabMode;
        private System.Windows.Forms.TabPage tpRead;
        private System.Windows.Forms.TabPage tpWrite;
        private System.Windows.Forms.OpenFileDialog loadFileDlg;
        private System.Windows.Forms.SaveFileDialog saveFileDlg;
        private System.Windows.Forms.TextBox txtLoadText;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.Button btnLoadFileSelect;
        private System.Windows.Forms.TextBox txtLoadFile;
        private System.Windows.Forms.TextBox txtSaveText;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnSaveFileSelect;
        private System.Windows.Forms.TextBox txtSaveFile;
    }
}