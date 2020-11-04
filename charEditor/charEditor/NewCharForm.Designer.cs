namespace charEditor
{
    partial class NewCharForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewCharForm));
            this.classSelectionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.classCombo = new System.Windows.Forms.ComboBox();
            this.classLbl = new System.Windows.Forms.Label();
            this.nextBt = new System.Windows.Forms.Button();
            this.editingMenuPanel = new System.Windows.Forms.Panel();
            this.cancelBt = new System.Windows.Forms.Button();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.polyNumeric2 = new System.Windows.Forms.NumericUpDown();
            this.polyNumeric1 = new System.Windows.Forms.NumericUpDown();
            this.experienceIn = new System.Windows.Forms.NumericUpDown();
            this.weightLimitIn = new System.Windows.Forms.NumericUpDown();
            this.tbCharName = new System.Windows.Forms.TextBox();
            this.hpText = new System.Windows.Forms.Label();
            this.healthSlider = new System.Windows.Forms.TrackBar();
            this.weightLbl = new System.Windows.Forms.Label();
            this.polyLbl1 = new System.Windows.Forms.Label();
            this.polyLbl2 = new System.Windows.Forms.Label();
            this.xpLbl = new System.Windows.Forms.Label();
            this.lblCharName = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.classSelectionPanel.SuspendLayout();
            this.editingMenuPanel.SuspendLayout();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polyNumeric2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polyNumeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.experienceIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weightLimitIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // classSelectionPanel
            // 
            this.classSelectionPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classSelectionPanel.BackColor = System.Drawing.Color.Transparent;
            this.classSelectionPanel.ColumnCount = 2;
            this.classSelectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.01724F));
            this.classSelectionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.98276F));
            this.classSelectionPanel.Controls.Add(this.classCombo, 1, 0);
            this.classSelectionPanel.Controls.Add(this.classLbl, 0, 0);
            this.classSelectionPanel.Controls.Add(this.nextBt, 1, 1);
            this.classSelectionPanel.Location = new System.Drawing.Point(127, 1);
            this.classSelectionPanel.Name = "classSelectionPanel";
            this.classSelectionPanel.RowCount = 2;
            this.classSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.classSelectionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.classSelectionPanel.Size = new System.Drawing.Size(196, 132);
            this.classSelectionPanel.TabIndex = 0;
            // 
            // classCombo
            // 
            this.classCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.classCombo.DisplayMember = "1";
            this.classCombo.FormattingEnabled = true;
            this.classCombo.Items.AddRange(new object[] {
            "BlackWitch",
            "Brawler",
            "Cleric",
            "Orc"});
            this.classCombo.Location = new System.Drawing.Point(57, 22);
            this.classCombo.Name = "classCombo";
            this.classCombo.Size = new System.Drawing.Size(136, 21);
            this.classCombo.TabIndex = 5;
            this.classCombo.SelectedIndexChanged += new System.EventHandler(this.classCombo_SelectedIndexChanged);
            // 
            // classLbl
            // 
            this.classLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.classLbl.AutoSize = true;
            this.classLbl.Location = new System.Drawing.Point(3, 26);
            this.classLbl.Name = "classLbl";
            this.classLbl.Size = new System.Drawing.Size(48, 13);
            this.classLbl.TabIndex = 0;
            this.classLbl.Text = "Class:";
            // 
            // nextBt
            // 
            this.nextBt.Location = new System.Drawing.Point(57, 69);
            this.nextBt.Name = "nextBt";
            this.nextBt.Size = new System.Drawing.Size(75, 23);
            this.nextBt.TabIndex = 6;
            this.nextBt.Text = "Next";
            this.nextBt.UseVisualStyleBackColor = true;
            this.nextBt.Click += new System.EventHandler(this.nextBt_Click);
            // 
            // editingMenuPanel
            // 
            this.editingMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editingMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.editingMenuPanel.Controls.Add(this.cancelBt);
            this.editingMenuPanel.Controls.Add(this.layout);
            this.editingMenuPanel.Controls.Add(this.saveBtn);
            this.editingMenuPanel.Location = new System.Drawing.Point(1, 8);
            this.editingMenuPanel.Name = "editingMenuPanel";
            this.editingMenuPanel.Size = new System.Drawing.Size(465, 387);
            this.editingMenuPanel.TabIndex = 1;
            this.editingMenuPanel.Visible = false;
            this.editingMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.editingMenuPanel_Paint);
            // 
            // cancelBt
            // 
            this.cancelBt.Location = new System.Drawing.Point(277, 350);
            this.cancelBt.Name = "cancelBt";
            this.cancelBt.Size = new System.Drawing.Size(75, 23);
            this.cancelBt.TabIndex = 5;
            this.cancelBt.Text = "Cancel";
            this.cancelBt.UseVisualStyleBackColor = true;
            this.cancelBt.Click += new System.EventHandler(this.cancelBt_Click);
            // 
            // layout
            // 
            this.layout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.layout.AutoSize = true;
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.02041F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.layout.Controls.Add(this.polyNumeric2, 1, 5);
            this.layout.Controls.Add(this.polyNumeric1, 1, 4);
            this.layout.Controls.Add(this.experienceIn, 1, 2);
            this.layout.Controls.Add(this.weightLimitIn, 1, 3);
            this.layout.Controls.Add(this.tbCharName, 1, 0);
            this.layout.Controls.Add(this.hpText, 0, 1);
            this.layout.Controls.Add(this.healthSlider, 1, 1);
            this.layout.Controls.Add(this.weightLbl, 0, 3);
            this.layout.Controls.Add(this.polyLbl1, 0, 4);
            this.layout.Controls.Add(this.polyLbl2, 0, 5);
            this.layout.Controls.Add(this.xpLbl, 0, 2);
            this.layout.Controls.Add(this.lblCharName, 0, 0);
            this.layout.Location = new System.Drawing.Point(26, 15);
            this.layout.MaximumSize = new System.Drawing.Size(400, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 6;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.layout.Size = new System.Drawing.Size(400, 324);
            this.layout.TabIndex = 4;
            this.layout.Paint += new System.Windows.Forms.PaintEventHandler(this.layout_Paint);
            // 
            // polyNumeric2
            // 
            this.polyNumeric2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.polyNumeric2.Location = new System.Drawing.Point(252, 287);
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
            this.polyNumeric1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.polyNumeric1.Location = new System.Drawing.Point(252, 233);
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
            this.experienceIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.experienceIn.Location = new System.Drawing.Point(252, 119);
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
            this.weightLimitIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightLimitIn.Location = new System.Drawing.Point(252, 177);
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
            // tbCharName
            // 
            this.tbCharName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCharName.Location = new System.Drawing.Point(252, 15);
            this.tbCharName.MaximumSize = new System.Drawing.Size(100, 50);
            this.tbCharName.MaxLength = 15;
            this.tbCharName.Name = "tbCharName";
            this.tbCharName.Size = new System.Drawing.Size(100, 20);
            this.tbCharName.TabIndex = 1;
            // 
            // hpText
            // 
            this.hpText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hpText.AutoSize = true;
            this.hpText.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.hpText.Location = new System.Drawing.Point(56, 67);
            this.hpText.Name = "hpText";
            this.hpText.Size = new System.Drawing.Size(92, 19);
            this.hpText.TabIndex = 3;
            this.hpText.Text = "Health:";
            // 
            // healthSlider
            // 
            this.healthSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.healthSlider.Location = new System.Drawing.Point(207, 54);
            this.healthSlider.Maximum = 100;
            this.healthSlider.MaximumSize = new System.Drawing.Size(200, 0);
            this.healthSlider.Name = "healthSlider";
            this.healthSlider.Size = new System.Drawing.Size(190, 45);
            this.healthSlider.TabIndex = 2;
            this.healthSlider.TickFrequency = 10;
            this.healthSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.healthSlider.Value = 50;
            // 
            // weightLbl
            // 
            this.weightLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.weightLbl.AutoSize = true;
            this.weightLbl.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.weightLbl.Location = new System.Drawing.Point(24, 177);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(155, 19);
            this.weightLbl.TabIndex = 6;
            this.weightLbl.Text = "Weight Limit:";
            // 
            // polyLbl1
            // 
            this.polyLbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.polyLbl1.AutoSize = true;
            this.polyLbl1.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.polyLbl1.Location = new System.Drawing.Point(71, 234);
            this.polyLbl1.Name = "polyLbl1";
            this.polyLbl1.Size = new System.Drawing.Size(61, 19);
            this.polyLbl1.TabIndex = 7;
            this.polyLbl1.Text = "plbl1";
            // 
            // polyLbl2
            // 
            this.polyLbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.polyLbl2.AutoSize = true;
            this.polyLbl2.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.polyLbl2.Location = new System.Drawing.Point(70, 287);
            this.polyLbl2.Name = "polyLbl2";
            this.polyLbl2.Size = new System.Drawing.Size(63, 19);
            this.polyLbl2.TabIndex = 8;
            this.polyLbl2.Text = "plbl2";
            // 
            // xpLbl
            // 
            this.xpLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.xpLbl.AutoSize = true;
            this.xpLbl.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.xpLbl.Location = new System.Drawing.Point(38, 120);
            this.xpLbl.Name = "xpLbl";
            this.xpLbl.Size = new System.Drawing.Size(128, 19);
            this.xpLbl.TabIndex = 5;
            this.xpLbl.Text = "Experience:";
            // 
            // lblCharName
            // 
            this.lblCharName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCharName.AutoSize = true;
            this.lblCharName.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold);
            this.lblCharName.Location = new System.Drawing.Point(69, 16);
            this.lblCharName.Name = "lblCharName";
            this.lblCharName.Size = new System.Drawing.Size(66, 19);
            this.lblCharName.TabIndex = 0;
            this.lblCharName.Text = "Name";
            this.lblCharName.Click += new System.EventHandler(this.lblCharName_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(115, 350);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // NewCharForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(478, 407);
            this.Controls.Add(this.editingMenuPanel);
            this.Controls.Add(this.classSelectionPanel);
            this.Name = "NewCharForm";
            this.Text = "newCharForm";
            this.Load += new System.EventHandler(this.NewCharForm_Load);
            this.classSelectionPanel.ResumeLayout(false);
            this.classSelectionPanel.PerformLayout();
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

        private System.Windows.Forms.TableLayoutPanel classSelectionPanel;
        private System.Windows.Forms.ComboBox classCombo;
        private System.Windows.Forms.Label classLbl;
        private System.Windows.Forms.Panel editingMenuPanel;
        private System.Windows.Forms.TableLayoutPanel layout;
        private System.Windows.Forms.NumericUpDown polyNumeric2;
        private System.Windows.Forms.NumericUpDown polyNumeric1;
        private System.Windows.Forms.NumericUpDown experienceIn;
        private System.Windows.Forms.NumericUpDown weightLimitIn;
        private System.Windows.Forms.TextBox tbCharName;
        private System.Windows.Forms.Label hpText;
        private System.Windows.Forms.Label lblCharName;
        private System.Windows.Forms.TrackBar healthSlider;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label polyLbl1;
        private System.Windows.Forms.Label polyLbl2;
        private System.Windows.Forms.Label xpLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBt;
        private System.Windows.Forms.Button nextBt;
    }
}