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
            this.charLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.lblCharName = new System.Windows.Forms.Label();
            this.tbCharName = new System.Windows.Forms.TextBox();
            this.healthSlider = new System.Windows.Forms.TrackBar();
            this.hpText = new System.Windows.Forms.Label();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.mainMenuPanel.SuspendLayout();
            this.editingMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.healthSlider)).BeginInit();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.Controls.Add(this.charLayoutPanel);
            this.mainMenuPanel.Location = new System.Drawing.Point(12, 12);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(877, 413);
            this.mainMenuPanel.TabIndex = 0;
            this.mainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // editingMenuPanel
            // 
            this.editingMenuPanel.Controls.Add(this.layout);
            this.editingMenuPanel.Controls.Add(this.saveBtn);
            this.editingMenuPanel.Location = new System.Drawing.Point(934, 12);
            this.editingMenuPanel.Name = "editingMenuPanel";
            this.editingMenuPanel.Size = new System.Drawing.Size(436, 413);
            this.editingMenuPanel.TabIndex = 0;
            this.editingMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editingMenuPanel_Paint);
            // 
            // charLayoutPanel
            // 
            this.charLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.charLayoutPanel.Name = "charLayoutPanel";
            this.charLayoutPanel.Size = new System.Drawing.Size(871, 407);
            this.charLayoutPanel.TabIndex = 0;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(78, 367);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // lblCharName
            // 
            this.lblCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharName.AutoSize = true;
            this.lblCharName.Location = new System.Drawing.Point(3, 22);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(42, 13);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Name: ";
            this.lblCharName.Click += new System.EventHandler(this.lblCharName_Click);
            // 
            // tbCharName
            // 
            this.tbCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCharName.Location = new System.Drawing.Point(51, 19);
            this.tbCharName.MaximumSize = new System.Drawing.Size(100, 50);
            this.tbCharName.MaxLength = 15;
            this.tbCharName.Name = "tbCharName";
            this.tbCharName.Size = new System.Drawing.Size(100, 20);
            this.tbCharName.TabIndex = 1;
            // 
            // healthSlider
            // 
            this.healthSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthSlider.Location = new System.Drawing.Point(51, 69);
            this.healthSlider.Maximum = 100;
            this.healthSlider.Name = "healthSlider";
            this.healthSlider.Size = new System.Drawing.Size(259, 45);
            this.healthSlider.TabIndex = 2;
            this.healthSlider.TickFrequency = 10;
            this.healthSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.healthSlider.Value = 50;
            this.healthSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // hpText
            // 
            this.hpText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hpText.AutoSize = true;
            this.hpText.Location = new System.Drawing.Point(3, 81);
            this.hpText.Name = "hpText";
            this.hpText.Size = new System.Drawing.Size(42, 13);
            this.hpText.TabIndex = 3;
            this.hpText.Text = "Health:";
            this.hpText.Click += new System.EventHandler(this.label1_Click);
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.33546F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.66454F));
            this.layout.Controls.Add(this.tbCharName, 1, 0);
            this.layout.Controls.Add(this.hpText, 0, 1);
            this.layout.Controls.Add(this.lblCharName, 0, 0);
            this.layout.Controls.Add(this.healthSlider, 1, 1);
            this.layout.Location = new System.Drawing.Point(3, 16);
            this.layout.Name = "layout";
            this.layout.RowCount = 2;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Size = new System.Drawing.Size(313, 117);
            this.layout.TabIndex = 4;
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
            this.mainMenuPanel.ResumeLayout(false);
            this.editingMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.healthSlider)).EndInit();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel editingMenuPanel;
        private System.Windows.Forms.FlowLayoutPanel charLayoutPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TextBox tbCharName;
        private System.Windows.Forms.TrackBar healthSlider;
        private System.Windows.Forms.Label hpText;
        private System.Windows.Forms.TableLayoutPanel layout;
    }
}

