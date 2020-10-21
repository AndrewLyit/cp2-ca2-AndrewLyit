namespace charEditor
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
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.editingMenuPanel = new System.Windows.Forms.Panel();
            this.tbCharName = new System.Windows.Forms.TextBox();
            this.lblCharName = new System.Windows.Forms.Label();
            this.editingMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(877, 413);
            this.mainMenuPanel.TabIndex = 0;
            this.mainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // editingMenuPanel
            // 
            this.editingMenuPanel.Controls.Add(this.tbCharName);
            this.editingMenuPanel.Controls.Add(this.lblCharName);
            this.editingMenuPanel.Location = new System.Drawing.Point(892, 125);
            this.editingMenuPanel.Name = "editingMenuPanel";
            this.editingMenuPanel.Size = new System.Drawing.Size(294, 126);
            this.editingMenuPanel.TabIndex = 0;
            // 
            // tbCharName
            // 
            this.tbCharName.Location = new System.Drawing.Point(44, 15);
            this.tbCharName.Name = "tbCharName";
            this.tbCharName.Size = new System.Drawing.Size(100, 20);
            this.tbCharName.TabIndex = 1;
            // 
            // lblCharName
            // 
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(3, 18);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(41, 13);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Name: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1593, 451);
            this.Controls.Add(this.editingMenuPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.editingMenuPanel.ResumeLayout(false);
            this.editingMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel editingMenuPanel;
        private System.Windows.Forms.TextBox tbCharName;
        private System.Windows.Forms.Label lblCharName;
    }
}

