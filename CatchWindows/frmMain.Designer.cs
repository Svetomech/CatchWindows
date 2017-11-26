namespace CatchWindows
{
    partial class frmMain
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
            this.lstProcessWindows = new System.Windows.Forms.ListBox();
            this.txtProcess = new CatchWindows.CueTextBox();
            this.btnFindProcessWindows = new System.Windows.Forms.Button();
            this.progressFind = new CatchWindows.VerticalProgressBar();
            this.SuspendLayout();
            // 
            // lstProcessWindows
            // 
            this.lstProcessWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lstProcessWindows.FormattingEnabled = true;
            this.lstProcessWindows.Location = new System.Drawing.Point(12, 38);
            this.lstProcessWindows.Name = "lstProcessWindows";
            this.lstProcessWindows.Size = new System.Drawing.Size(114, 95);
            this.lstProcessWindows.TabIndex = 2;
            this.lstProcessWindows.DoubleClick += new System.EventHandler(this.lstProcessWindows_DoubleClick);
            this.lstProcessWindows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstProcessWindows_KeyPress);
            // 
            // txtProcess
            // 
            this.txtProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProcess.Cue = "process name";
            this.txtProcess.Location = new System.Drawing.Point(12, 12);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(114, 20);
            this.txtProcess.TabIndex = 0;
            this.txtProcess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProcess_KeyPress);
            // 
            // btnFindProcessWindows
            // 
            this.btnFindProcessWindows.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFindProcessWindows.Location = new System.Drawing.Point(132, 12);
            this.btnFindProcessWindows.Name = "btnFindProcessWindows";
            this.btnFindProcessWindows.Size = new System.Drawing.Size(20, 20);
            this.btnFindProcessWindows.TabIndex = 1;
            this.btnFindProcessWindows.Text = ">";
            this.btnFindProcessWindows.UseVisualStyleBackColor = true;
            this.btnFindProcessWindows.Click += new System.EventHandler(this.btnFindProcessWindows_Click);
            // 
            // progressFind
            // 
            this.progressFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.progressFind.Location = new System.Drawing.Point(132, 38);
            this.progressFind.Name = "progressFind";
            this.progressFind.Size = new System.Drawing.Size(20, 95);
            this.progressFind.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 141);
            this.Controls.Add(this.progressFind);
            this.Controls.Add(this.btnFindProcessWindows);
            this.Controls.Add(this.txtProcess);
            this.Controls.Add(this.lstProcessWindows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximumSize = new System.Drawing.Size(1920, 180);
            this.MinimumSize = new System.Drawing.Size(180, 180);
            this.Name = "frmMain";
            this.Text = "CatchWindows";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProcessWindows;
        private CueTextBox txtProcess;
        private System.Windows.Forms.Button btnFindProcessWindows;
        private VerticalProgressBar progressFind;
    }
}

