
namespace Uchet_Material
{
    partial class UserControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addTaken = new System.Windows.Forms.Button();
            this.CBTaken = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.addPos = new System.Windows.Forms.Button();
            this.addEmpl = new System.Windows.Forms.Button();
            this.TBPhone = new System.Windows.Forms.TextBox();
            this.CBPos = new System.Windows.Forms.ComboBox();
            this.CBEmpl = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addSize = new System.Windows.Forms.Button();
            this.addMatelial = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.TBSize = new System.Windows.Forms.TextBox();
            this.CBSizeK = new System.Windows.Forms.ComboBox();
            this.CB1Material = new System.Windows.Forms.ComboBox();
            this.SaveIssue = new System.Windows.Forms.Button();
            this.SelectLeft = new System.Windows.Forms.Button();
            this.SelectLabel = new System.Windows.Forms.Label();
            this.l1 = new System.Windows.Forms.Label();
            this.AllLabel = new System.Windows.Forms.Label();
            this.SelectRight = new System.Windows.Forms.Button();
            this.NewIssue = new System.Windows.Forms.Button();
            this.DelIss = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.addTaken);
            this.groupBox3.Controls.Add(this.CBTaken);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(13, 281);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 128);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Получатель";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // addTaken
            // 
            this.addTaken.BackColor = System.Drawing.Color.LightGreen;
            this.addTaken.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addTaken.BackgroundImage")));
            this.addTaken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addTaken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTaken.Location = new System.Drawing.Point(571, 50);
            this.addTaken.Name = "addTaken";
            this.addTaken.Size = new System.Drawing.Size(34, 34);
            this.addTaken.TabIndex = 1;
            this.addTaken.UseVisualStyleBackColor = false;
            this.addTaken.Click += new System.EventHandler(this.addTaken_Click);
            // 
            // CBTaken
            // 
            this.CBTaken.FormattingEnabled = true;
            this.CBTaken.Location = new System.Drawing.Point(26, 51);
            this.CBTaken.Name = "CBTaken";
            this.CBTaken.Size = new System.Drawing.Size(538, 33);
            this.CBTaken.TabIndex = 0;
            this.CBTaken.Text = "ФИО";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.labPhone);
            this.groupBox2.Controls.Add(this.addPos);
            this.groupBox2.Controls.Add(this.addEmpl);
            this.groupBox2.Controls.Add(this.TBPhone);
            this.groupBox2.Controls.Add(this.CBPos);
            this.groupBox2.Controls.Add(this.CBEmpl);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(13, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 122);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сотрудник";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labPhone.ForeColor = System.Drawing.Color.Red;
            this.labPhone.Location = new System.Drawing.Point(571, 82);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(0, 15);
            this.labPhone.TabIndex = 5;
            // 
            // addPos
            // 
            this.addPos.BackColor = System.Drawing.Color.LightGreen;
            this.addPos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addPos.BackgroundImage")));
            this.addPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addPos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPos.Location = new System.Drawing.Point(757, 40);
            this.addPos.Name = "addPos";
            this.addPos.Size = new System.Drawing.Size(34, 34);
            this.addPos.TabIndex = 4;
            this.addPos.UseVisualStyleBackColor = false;
            this.addPos.Click += new System.EventHandler(this.addPos_Click);
            // 
            // addEmpl
            // 
            this.addEmpl.BackColor = System.Drawing.Color.LightGreen;
            this.addEmpl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addEmpl.BackgroundImage")));
            this.addEmpl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addEmpl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addEmpl.Location = new System.Drawing.Point(364, 40);
            this.addEmpl.Name = "addEmpl";
            this.addEmpl.Size = new System.Drawing.Size(34, 34);
            this.addEmpl.TabIndex = 3;
            this.addEmpl.UseVisualStyleBackColor = false;
            this.addEmpl.Click += new System.EventHandler(this.addEmpl_Click);
            // 
            // TBPhone
            // 
            this.TBPhone.Location = new System.Drawing.Point(416, 82);
            this.TBPhone.MaxLength = 11;
            this.TBPhone.Name = "TBPhone";
            this.TBPhone.PlaceholderText = "8(800)888-8080";
            this.TBPhone.Size = new System.Drawing.Size(148, 33);
            this.TBPhone.TabIndex = 2;
            this.TBPhone.TextChanged += new System.EventHandler(this.TBPhone_TextChanged);
            // 
            // CBPos
            // 
            this.CBPos.FormattingEnabled = true;
            this.CBPos.Location = new System.Drawing.Point(416, 41);
            this.CBPos.Name = "CBPos";
            this.CBPos.Size = new System.Drawing.Size(335, 33);
            this.CBPos.TabIndex = 1;
            this.CBPos.Text = "Должность";
            this.CBPos.SelectedIndexChanged += new System.EventHandler(this.CBPos_SelectedIndexChanged);
            // 
            // CBEmpl
            // 
            this.CBEmpl.FormattingEnabled = true;
            this.CBEmpl.Location = new System.Drawing.Point(26, 41);
            this.CBEmpl.Name = "CBEmpl";
            this.CBEmpl.Size = new System.Drawing.Size(332, 33);
            this.CBEmpl.TabIndex = 0;
            this.CBEmpl.Text = "ФИО";
            this.CBEmpl.SelectedIndexChanged += new System.EventHandler(this.CBEmpl_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.addSize);
            this.groupBox1.Controls.Add(this.addMatelial);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.TBSize);
            this.groupBox1.Controls.Add(this.CBSizeK);
            this.groupBox1.Controls.Add(this.CB1Material);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(13, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Материал";
            // 
            // addSize
            // 
            this.addSize.BackColor = System.Drawing.Color.LightGreen;
            this.addSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addSize.BackgroundImage")));
            this.addSize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSize.Location = new System.Drawing.Point(757, 41);
            this.addSize.Name = "addSize";
            this.addSize.Size = new System.Drawing.Size(34, 34);
            this.addSize.TabIndex = 5;
            this.addSize.UseVisualStyleBackColor = false;
            this.addSize.Click += new System.EventHandler(this.addSize_Click);
            // 
            // addMatelial
            // 
            this.addMatelial.BackColor = System.Drawing.Color.LightGreen;
            this.addMatelial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addMatelial.BackgroundImage")));
            this.addMatelial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addMatelial.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addMatelial.Location = new System.Drawing.Point(364, 41);
            this.addMatelial.Name = "addMatelial";
            this.addMatelial.Size = new System.Drawing.Size(34, 34);
            this.addMatelial.TabIndex = 4;
            this.addMatelial.UseVisualStyleBackColor = false;
            this.addMatelial.Click += new System.EventHandler(this.addMatelial_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 94);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(332, 33);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // TBSize
            // 
            this.TBSize.Location = new System.Drawing.Point(416, 42);
            this.TBSize.MaxLength = 9;
            this.TBSize.Name = "TBSize";
            this.TBSize.PlaceholderText = "Кол-во";
            this.TBSize.Size = new System.Drawing.Size(148, 33);
            this.TBSize.TabIndex = 2;
            this.TBSize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CBSizeK
            // 
            this.CBSizeK.FormattingEnabled = true;
            this.CBSizeK.Location = new System.Drawing.Point(571, 42);
            this.CBSizeK.Name = "CBSizeK";
            this.CBSizeK.Size = new System.Drawing.Size(180, 33);
            this.CBSizeK.TabIndex = 1;
            this.CBSizeK.Text = "-";
            this.CBSizeK.SelectedIndexChanged += new System.EventHandler(this.CBSizeK_SelectedIndexChanged);
            this.CBSizeK.TextUpdate += new System.EventHandler(this.CBSizeK_TextUpdate);
            // 
            // CB1Material
            // 
            this.CB1Material.FormattingEnabled = true;
            this.CB1Material.Location = new System.Drawing.Point(26, 42);
            this.CB1Material.Name = "CB1Material";
            this.CB1Material.Size = new System.Drawing.Size(332, 33);
            this.CB1Material.TabIndex = 0;
            this.CB1Material.Text = "Название материала";
            this.CB1Material.SelectedIndexChanged += new System.EventHandler(this.CB1Material_SelectedIndexChanged);
            // 
            // SaveIssue
            // 
            this.SaveIssue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveIssue.BackColor = System.Drawing.SystemColors.Control;
            this.SaveIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveIssue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveIssue.Location = new System.Drawing.Point(255, 478);
            this.SaveIssue.Name = "SaveIssue";
            this.SaveIssue.Size = new System.Drawing.Size(418, 48);
            this.SaveIssue.TabIndex = 7;
            this.SaveIssue.Text = "Сохранить выдачу";
            this.SaveIssue.UseVisualStyleBackColor = false;
            this.SaveIssue.Visible = false;
            this.SaveIssue.Click += new System.EventHandler(this.SaveIssue_Click);
            // 
            // SelectLeft
            // 
            this.SelectLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectLeft.BackgroundImage")));
            this.SelectLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectLeft.Location = new System.Drawing.Point(21, 436);
            this.SelectLeft.Name = "SelectLeft";
            this.SelectLeft.Size = new System.Drawing.Size(29, 29);
            this.SelectLeft.TabIndex = 8;
            this.SelectLeft.UseVisualStyleBackColor = true;
            this.SelectLeft.Click += new System.EventHandler(this.SelectLeft_Click);
            // 
            // SelectLabel
            // 
            this.SelectLabel.AutoSize = true;
            this.SelectLabel.Location = new System.Drawing.Point(56, 443);
            this.SelectLabel.Name = "SelectLabel";
            this.SelectLabel.Size = new System.Drawing.Size(13, 15);
            this.SelectLabel.TabIndex = 9;
            this.SelectLabel.Text = "0";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(75, 443);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(12, 15);
            this.l1.TabIndex = 10;
            this.l1.Text = "/";
            // 
            // AllLabel
            // 
            this.AllLabel.AutoSize = true;
            this.AllLabel.Location = new System.Drawing.Point(93, 443);
            this.AllLabel.Name = "AllLabel";
            this.AllLabel.Size = new System.Drawing.Size(13, 15);
            this.AllLabel.TabIndex = 11;
            this.AllLabel.Text = "0";
            // 
            // SelectRight
            // 
            this.SelectRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectRight.BackgroundImage")));
            this.SelectRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectRight.Location = new System.Drawing.Point(112, 436);
            this.SelectRight.Name = "SelectRight";
            this.SelectRight.Size = new System.Drawing.Size(29, 29);
            this.SelectRight.TabIndex = 12;
            this.SelectRight.UseVisualStyleBackColor = true;
            this.SelectRight.Click += new System.EventHandler(this.SelectRight_Click);
            // 
            // NewIssue
            // 
            this.NewIssue.BackColor = System.Drawing.Color.LightGreen;
            this.NewIssue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewIssue.BackgroundImage")));
            this.NewIssue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NewIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewIssue.Location = new System.Drawing.Point(147, 437);
            this.NewIssue.Name = "NewIssue";
            this.NewIssue.Size = new System.Drawing.Size(27, 27);
            this.NewIssue.TabIndex = 13;
            this.NewIssue.UseVisualStyleBackColor = false;
            this.NewIssue.Click += new System.EventHandler(this.NewIssue_Click);
            // 
            // DelIss
            // 
            this.DelIss.BackColor = System.Drawing.Color.Red;
            this.DelIss.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelIss.BackgroundImage")));
            this.DelIss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelIss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DelIss.Location = new System.Drawing.Point(860, 436);
            this.DelIss.Margin = new System.Windows.Forms.Padding(6);
            this.DelIss.Name = "DelIss";
            this.DelIss.Padding = new System.Windows.Forms.Padding(3);
            this.DelIss.Size = new System.Drawing.Size(29, 29);
            this.DelIss.TabIndex = 14;
            this.DelIss.UseVisualStyleBackColor = false;
            this.DelIss.Click += new System.EventHandler(this.DelIss_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DelIss);
            this.Controls.Add(this.NewIssue);
            this.Controls.Add(this.SelectRight);
            this.Controls.Add(this.AllLabel);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.SelectLabel);
            this.Controls.Add(this.SelectLeft);
            this.Controls.Add(this.SaveIssue);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(902, 572);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addTaken;
        private System.Windows.Forms.ComboBox CBTaken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addPos;
        private System.Windows.Forms.Button addEmpl;
        private System.Windows.Forms.TextBox TBPhone;
        private System.Windows.Forms.ComboBox CBPos;
        private System.Windows.Forms.ComboBox CBEmpl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addSize;
        private System.Windows.Forms.Button addMatelial;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox TBSize;
        private System.Windows.Forms.ComboBox CBSizeK;
        private System.Windows.Forms.ComboBox CB1Material;
        private System.Windows.Forms.Button SaveIssue;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Button SelectLeft;
        private System.Windows.Forms.Label SelectLabel;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label AllLabel;
        private System.Windows.Forms.Button SelectRight;
        private System.Windows.Forms.Button NewIssue;
        private System.Windows.Forms.Button DelIss;
    }
}
