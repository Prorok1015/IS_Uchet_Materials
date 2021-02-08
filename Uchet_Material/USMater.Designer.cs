
namespace Uchet_Material
{
    partial class USMater
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Tak1 = new System.Windows.Forms.Label();
            this.Emp1 = new System.Windows.Forms.Label();
            this.Date1 = new System.Windows.Forms.Label();
            this.Kol1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Tak1);
            this.groupBox1.Controls.Add(this.Emp1);
            this.groupBox1.Controls.Add(this.Date1);
            this.groupBox1.Controls.Add(this.Kol1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Название материала";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Tak1
            // 
            this.Tak1.AutoSize = true;
            this.Tak1.Location = new System.Drawing.Point(461, 20);
            this.Tak1.Name = "Tak1";
            this.Tak1.Size = new System.Drawing.Size(79, 25);
            this.Tak1.TabIndex = 3;
            this.Tak1.Text = "Принял";
            // 
            // Emp1
            // 
            this.Emp1.AutoSize = true;
            this.Emp1.Location = new System.Drawing.Point(275, 20);
            this.Emp1.Name = "Emp1";
            this.Emp1.Size = new System.Drawing.Size(104, 25);
            this.Emp1.TabIndex = 2;
            this.Emp1.Text = "Сотрудник";
            // 
            // Date1
            // 
            this.Date1.AutoSize = true;
            this.Date1.Location = new System.Drawing.Point(177, 20);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(53, 25);
            this.Date1.TabIndex = 1;
            this.Date1.Text = "Дата";
            // 
            // Kol1
            // 
            this.Kol1.AutoSize = true;
            this.Kol1.Location = new System.Drawing.Point(20, 20);
            this.Kol1.Name = "Kol1";
            this.Kol1.Size = new System.Drawing.Size(114, 25);
            this.Kol1.TabIndex = 0;
            this.Kol1.Text = "Количество";
            // 
            // USMater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "USMater";
            this.Size = new System.Drawing.Size(600, 147);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Date1;
        private System.Windows.Forms.Label Kol1;
        private System.Windows.Forms.Label Tak1;
        private System.Windows.Forms.Label Emp1;
    }
}
