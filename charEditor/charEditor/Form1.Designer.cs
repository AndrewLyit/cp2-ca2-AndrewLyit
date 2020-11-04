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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.charLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.editingMenuPanel = new System.Windows.Forms.Panel();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.polyNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.polyNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.experienceIn = new System.Windows.Forms.NumericUpDown();
            this.weightLimitIn = new System.Windows.Forms.NumericUpDown();
            this.xpLbl = new System.Windows.Forms.Label();
            this.tbCharName = new System.Windows.Forms.TextBox();
            this.hpText = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.healthSlider = new System.Windows.Forms.TrackBar();
            this.weightLbl = new System.Windows.Forms.Label();
            this.polyLbl1 = new System.Windows.Forms.Label();
            this.polyLbl2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.newCharBtn = new System.Windows.Forms.Button();
            this.mainMenuPanel.SuspendLayout();
            this.editingMenuPanel.SuspendLayout();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polyNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightLimitIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainMenuPanel.BackgroundImage")));
            this.mainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainMenuPanel.Controls.Add(this.newCharBtn);
            this.mainMenuPanel.Controls.Add(this.label1);
            this.mainMenuPanel.Controls.Add(this.charLayoutPanel);
            this.mainMenuPanel.Location = new System.Drawing.Point(12, 9);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(835, 430);
            this.mainMenuPanel.TabIndex = 0;
            this.mainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // charLayoutPanel
            // 
            this.charLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.charLayoutPanel.Location = new System.Drawing.Point(69, 67);
            this.charLayoutPanel.Name = "charLayoutPanel";
            this.charLayoutPanel.Size = new System.Drawing.Size(899, 317);
            this.charLayoutPanel.TabIndex = 0;
            // 
            // editingMenuPanel
            // 
            this.editingMenuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.editingMenuPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editingMenuPanel.BackgroundImage")));
            this.editingMenuPanel.Controls.Add(this.deleteBtn);
            this.editingMenuPanel.Controls.Add(this.layout);
            this.editingMenuPanel.Controls.Add(this.saveBtn);
            this.editingMenuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.editingMenuPanel.Location = new System.Drawing.Point(853, 12);
            this.editingMenuPanel.Name = "editingMenuPanel";
            this.editingMenuPanel.Size = new System.Drawing.Size(489, 413);
            this.editingMenuPanel.TabIndex = 0;
            this.editingMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editingMenuPanel_Paint);
            // 
            // layout
            // 
            this.layout.AutoSize = true;
            this.layout.BackColor = System.Drawing.Color.Transparent;
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.33546F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.66454F));
            this.layout.Controls.Add(this.polyNumeric2, 1, 5);
            this.layout.Controls.Add(this.polyNumeric1, 1, 4);
            this.layout.Controls.Add(this.experienceIn, 1, 2);
            this.layout.Controls.Add(this.weightLimitIn, 1, 3);
            this.layout.Controls.Add(this.xpLbl, 0, 2);
            this.layout.Controls.Add(this.tbCharName, 1, 0);
            this.layout.Controls.Add(this.hpText, 0, 1);
            this.layout.Controls.Add(this.lblCharName, 0, 0);
            this.layout.Controls.Add(this.healthSlider, 1, 1);
            this.layout.Controls.Add(this.weightLbl, 0, 3);
            this.layout.Controls.Add(this.polyLbl1, 0, 4);
            this.layout.Controls.Add(this.polyLbl2, 0, 5);
            this.layout.Location = new System.Drawing.Point(3, 16);
            this.layout.Name = "layout";
            this.layout.RowCount = 6;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.layout.Size = new System.Drawing.Size(1050, 365);
            this.layout.TabIndex = 4;
            // 
            // polyNumeric2
            // 
            this.polyNumeric2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.polyNumeric2.Location = new System.Drawing.Point(164, 327);
            this.polyNumeric2.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.polyNumeric2.MaximumSize = new System.Drawing.Size(100, 0);
            this.polyNumeric2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.polyNumeric2.Name = "polyNumeric2";
            this.polyNumeric2.Size = new System.Drawing.Size(100, 20);
            this.polyNumeric2.TabIndex = 16;
            this.polyNumeric2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // polyNumeric1
            // 
            this.polyNumeric1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.polyNumeric1.Location = new System.Drawing.Point(164, 273);
            this.polyNumeric1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.polyNumeric1.MaximumSize = new System.Drawing.Size(100, 0);
            this.polyNumeric1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.polyNumeric1.Name = "polyNumeric1";
            this.polyNumeric1.Size = new System.Drawing.Size(100, 20);
            this.polyNumeric1.TabIndex = 15;
            this.polyNumeric1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // experienceIn
            // 
            this.experienceIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.experienceIn.Location = new System.Drawing.Point(164, 159);
            this.experienceIn.MaximumSize = new System.Drawing.Size(100, 0);
            this.experienceIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.experienceIn.Name = "experienceIn";
            this.experienceIn.Size = new System.Drawing.Size(100, 20);
            this.experienceIn.TabIndex = 14;
            this.experienceIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // weightLimitIn
            // 
            this.weightLimitIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLimitIn.Location = new System.Drawing.Point(164, 217);
            this.weightLimitIn.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.weightLimitIn.MaximumSize = new System.Drawing.Size(100, 0);
            this.weightLimitIn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.weightLimitIn.Name = "weightLimitIn";
            this.weightLimitIn.Size = new System.Drawing.Size(100, 20);
            this.weightLimitIn.TabIndex = 13;
            this.weightLimitIn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xpLbl
            // 
            this.xpLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.xpLbl.AutoSize = true;
            this.xpLbl.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.xpLbl.Location = new System.Drawing.Point(3, 160);
            this.xpLbl.Name = "xpLbl";
            this.xpLbl.Size = new System.Drawing.Size(155, 19);
            this.xpLbl.TabIndex = 5;
            this.xpLbl.Text = "Experience:";
            this.xpLbl.Click += new System.EventHandler(this.xpLbl_Click);
            // 
            // tbCharName
            // 
            this.tbCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCharName.BackColor = System.Drawing.SystemColors.Info;
            this.tbCharName.Location = new System.Drawing.Point(164, 25);
            this.tbCharName.MaximumSize = new System.Drawing.Size(100, 50);
            this.tbCharName.MaxLength = 15;
            this.tbCharName.Name = "tbCharName";
            this.tbCharName.Size = new System.Drawing.Size(100, 20);
            this.tbCharName.TabIndex = 1;
            // 
            // hpText
            // 
            this.hpText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hpText.AutoSize = true;
            this.hpText.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.hpText.Location = new System.Drawing.Point(3, 97);
            this.hpText.Name = "hpText";
            this.hpText.Size = new System.Drawing.Size(155, 19);
            this.hpText.TabIndex = 3;
            this.hpText.Text = "Health:";
            this.hpText.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCharName
            // 
            this.lblCharName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCharName.AutoSize = true;
            this.lblCharName.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharName.Location = new System.Drawing.Point(3, 26);
            this.lblCharName.MinimumSize = new System.Drawing.Size(110, 0);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(155, 19);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Name: ";
            this.lblCharName.Click += new System.EventHandler(this.lblCharName_Click);
            // 
            // healthSlider
            // 
            this.healthSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthSlider.BackColor = System.Drawing.SystemColors.Control;
            this.healthSlider.Location = new System.Drawing.Point(164, 94);
            this.healthSlider.Maximum = 100;
            this.healthSlider.MaximumSize = new System.Drawing.Size(200, 0);
            this.healthSlider.Name = "healthSlider";
            this.healthSlider.Size = new System.Drawing.Size(200, 45);
            this.healthSlider.TabIndex = 2;
            this.healthSlider.TickFrequency = 10;
            this.healthSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.healthSlider.Value = 50;
            this.healthSlider.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // weightLbl
            // 
            this.weightLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.weightLbl.AutoSize = true;
            this.weightLbl.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.weightLbl.Location = new System.Drawing.Point(3, 217);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(155, 19);
            this.weightLbl.TabIndex = 6;
            this.weightLbl.Text = "Weight Limit:";
            // 
            // polyLbl1
            // 
            this.polyLbl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.polyLbl1.AutoSize = true;
            this.polyLbl1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.polyLbl1.Location = new System.Drawing.Point(3, 274);
            this.polyLbl1.Name = "polyLbl1";
            this.polyLbl1.Size = new System.Drawing.Size(155, 19);
            this.polyLbl1.TabIndex = 7;
            this.polyLbl1.Text = "plbl1";
            // 
            // polyLbl2
            // 
            this.polyLbl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.polyLbl2.AutoSize = true;
            this.polyLbl2.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.polyLbl2.Location = new System.Drawing.Point(3, 328);
            this.polyLbl2.Name = "polyLbl2";
            this.polyLbl2.Size = new System.Drawing.Size(155, 19);
            this.polyLbl2.TabIndex = 8;
            this.polyLbl2.Text = "plbl2";
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveBtn.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.saveBtn.Location = new System.Drawing.Point(37, 387);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Castellar", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Characters:";
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.deleteBtn.Location = new System.Drawing.Point(205, 387);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(93, 23);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // newCharBtn
            // 
            this.newCharBtn.BackColor = System.Drawing.Color.Transparent;
            this.newCharBtn.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.newCharBtn.Location = new System.Drawing.Point(553, 31);
            this.newCharBtn.Name = "newCharBtn";
            this.newCharBtn.Size = new System.Drawing.Size(95, 30);
            this.newCharBtn.TabIndex = 6;
            this.newCharBtn.Text = "Create";
            this.newCharBtn.UseVisualStyleBackColor = false;
            this.newCharBtn.Click += new System.EventHandler(this.newCharBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1213, 451);
            this.Controls.Add(this.editingMenuPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainMenuPanel.ResumeLayout(false);
            this.mainMenuPanel.PerformLayout();
            this.editingMenuPanel.ResumeLayout(false);
            this.editingMenuPanel.PerformLayout();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polyNumeric2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyNumeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightLimitIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthSlider)).EndInit();
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
        private System.Windows.Forms.Label xpLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label polyLbl1;
        private System.Windows.Forms.Label polyLbl2;
        private System.Windows.Forms.NumericUpDown experienceIn;
        private System.Windows.Forms.NumericUpDown weightLimitIn;
        private System.Windows.Forms.NumericUpDown polyNumeric2;
        private System.Windows.Forms.NumericUpDown polyNumeric1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button newCharBtn;
    }
}

