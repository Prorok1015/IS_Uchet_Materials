namespace Uchet_Material
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.butOtchet = new System.Windows.Forms.Button();
            this.butsearch = new System.Windows.Forms.Button();
            this.butHome = new System.Windows.Forms.Button();
            this.UC1Insert = new Uchet_Material.UserControl1();
            this.UC2Search = new Uchet_Material.UserControl2();
            this.UCOtchet = new Uchet_Material.UserControl3();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.butOtchet);
            this.panel1.Controls.Add(this.butsearch);
            this.panel1.Controls.Add(this.butHome);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 630);
            this.panel1.TabIndex = 4;
            // 
            // butOtchet
            // 
            this.butOtchet.BackColor = System.Drawing.SystemColors.Control;
            this.butOtchet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butOtchet.BackgroundImage")));
            this.butOtchet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butOtchet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butOtchet.Location = new System.Drawing.Point(12, 281);
            this.butOtchet.Name = "butOtchet";
            this.butOtchet.Size = new System.Drawing.Size(100, 89);
            this.butOtchet.TabIndex = 2;
            this.butOtchet.UseVisualStyleBackColor = false;
            this.butOtchet.Click += new System.EventHandler(this.ButOtchet_Click);
            // 
            // butsearch
            // 
            this.butsearch.BackColor = System.Drawing.SystemColors.Control;
            this.butsearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butsearch.BackgroundImage")));
            this.butsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butsearch.Location = new System.Drawing.Point(12, 171);
            this.butsearch.Name = "butsearch";
            this.butsearch.Size = new System.Drawing.Size(100, 89);
            this.butsearch.TabIndex = 1;
            this.butsearch.UseVisualStyleBackColor = false;
            this.butsearch.Click += new System.EventHandler(this.butsearch_Click);
            // 
            // butHome
            // 
            this.butHome.BackColor = System.Drawing.SystemColors.Control;
            this.butHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butHome.BackgroundImage")));
            this.butHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.butHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butHome.Location = new System.Drawing.Point(12, 62);
            this.butHome.Name = "butHome";
            this.butHome.Size = new System.Drawing.Size(100, 89);
            this.butHome.TabIndex = 0;
            this.butHome.UseVisualStyleBackColor = false;
            this.butHome.Click += new System.EventHandler(this.butHome_Click);
            // 
            // UC1Insert
            // 
            this.UC1Insert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC1Insert.Location = new System.Drawing.Point(119, 1);
            this.UC1Insert.Name = "UC1Insert";
            this.UC1Insert.Size = new System.Drawing.Size(929, 630);
            this.UC1Insert.TabIndex = 5;
            this.UC1Insert.Load += new System.EventHandler(this.UC1Insert_Load);
            // 
            // UC2Search
            // 
            this.UC2Search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UC2Search.idIssue = ((uint)(0u));
            this.UC2Search.Location = new System.Drawing.Point(119, 1);
            this.UC2Search.Name = "UC2Search";
            this.UC2Search.Size = new System.Drawing.Size(929, 630);
            this.UC2Search.TabIndex = 6;
            // 
            // UCOtchet
            // 
            this.UCOtchet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UCOtchet.AutoScroll = true;
            this.UCOtchet.Location = new System.Drawing.Point(119, 1);
            this.UCOtchet.Name = "UCOtchet";
            this.UCOtchet.Size = new System.Drawing.Size(929, 630);
            this.UCOtchet.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UC1Insert);
            this.Controls.Add(this.UC2Search);
            this.Controls.Add(this.UCOtchet);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учет выдачи материалов";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butsearch;
        private System.Windows.Forms.Button butHome;
        private UserControl1 UC1Insert;
        private UserControl2 UC2Search;
        private System.Windows.Forms.Button butOtchet;
        private UserControl3 UCOtchet;
    }
}

