using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Uchet_Material
{
    public partial class USMater : UserControl
    {
        public enum status
        {
            Material,
            Data,
            Emploeer
        };

        void MatLoad(List<ISSUE> ilist)
        {
            Emp1.Text = "Сотрудник";
            Date1.Text = "Дата";
            Kol1.Text = "Кол-во";
            Tak1.Text = "Принял";
            Point p = new Point(23, 43);
            foreach (ISSUE Issue1 in ilist)
            {
                groupBox1.Text = Issue1.material.name;
                Label quin = new Label();
                Label Date = new Label();
                Label Empl = new Label();
                Empl.AutoSize = true;
                Label Take = new Label();
                Take.AutoSize = true;

                quin.Text = Issue1.quin + " " + Issue1.Size.name;
                quin.Location = new Point(Kol1.Location.X, p.Y);
                quin.AutoSize = true;

                Date.Text = Issue1.date.Date.ToString("dd.MM.yyyy");
                Date.Location = new Point(Date1.Location.X, p.Y);
                Date.AutoSize = true;

                Empl.Text = Issue1.employeer.FIO;
                Empl.Location = new Point(Emp1.Location.X, p.Y);

                Take.Text = Issue1.taken.FIO;
                Take.Location = new Point(Tak1.Location.X, p.Y);


                p.Y += 20;
                groupBox1.Controls.Add(quin);
                groupBox1.Controls.Add(Date);
                groupBox1.Controls.Add(Empl);
                groupBox1.Controls.Add(Take);

                groupBox1.Size = new Size(Take.Location.X + Take.Size.Width, Take.Location.Y + Take.Size.Height + 20);
            }
            this.Width = 560;
        }
        void DataLoad(List<ISSUE> ilist)
        {
            Emp1.Text = "Сотрудник";
            Date1.Text = "Материал";
            Kol1.Text = "Кол-во";
            Tak1.Text = "Принял";
            Point p = new Point(23, 43);
            Point gr; int height = 0;
            Size beforeSize = groupBox1.Size;
            string before = "";
            GroupBox group =  groupBox1;
            foreach (ISSUE Issue1 in ilist)
            {
                gr = group.Location;
                height = group.Size.Height;
                if (before != Issue1.date.Date.ToString("dd.MM.yyyy") && before != "")
                {
                    beforeSize = group.Size;
                    group = new GroupBox();
                    p.X = 23;
                    p.Y = 23;                  
                    group.Location = new Point(gr.X, gr.Y + height + 20);
                    group.Size = new Size(beforeSize.Width, beforeSize.Height);
                    Controls.Add(group);
                }

                Label quin = new Label();
                Label Material = new Label();
                Label Empl = new Label();
                Empl.AutoSize = true;
                Label Take = new Label();
                Take.AutoSize = true;

                group.Text = Issue1.date.Date.ToString("dd.MM.yyyy");

                quin.Text = Issue1.quin + " " + Issue1.Size.name;
                quin.Location = new Point(Kol1.Location.X, p.Y);
                quin.AutoSize = true;

                Material.Text = Issue1.material.name;
                Material.Location = new Point(Date1.Location.X, p.Y);
                Material.AutoSize = true;

                Empl.Text = Issue1.employeer.FIO;
                Empl.Location = new Point(Emp1.Location.X, p.Y);

                Take.Text = Issue1.taken.FIO;
                Take.Location = new Point(Tak1.Location.X, p.Y);

                
                p.Y += 20;
                group.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                group.Width = Take.Location.X + Take.Width + 10;
                group.Height = Take.Location.Y + Take.Height + 20;
                group.Controls.Add(quin);
                group.Controls.Add(Material);
                group.Controls.Add(Empl);
                group.Controls.Add(Take);
                
                
                this.Height = group.Location.Y + group.Size.Height + 20;
                before = Issue1.date.Date.ToString("dd.MM.yyyy");
                
            }
        }
        void EmplLoad(List<ISSUE> ilist)
        {
            Emp1.Text = "Материал";
            Date1.Text = "Дата";
            Kol1.Text = "Кол-во";
            Tak1.Text = "Принял";
            Point p = new Point(23, 43);
            foreach (ISSUE Issue1 in ilist)
            {
                groupBox1.Text = Issue1.employeer.FIO;
                Label quin = new Label();
                Label Date = new Label();
                Label Material = new Label();
                Material.AutoSize = true;
                Label Take = new Label();
                Take.AutoSize = true;

                quin.Text = Issue1.quin + " " + Issue1.Size.name;
                quin.Location = new Point(Kol1.Location.X, p.Y);
                quin.AutoSize = true;

                Date.Text = Issue1.date.Date.ToString("dd.MM.yyyy");
                Date.Location = new Point(Date1.Location.X, p.Y);
                Date.AutoSize = true;

                Material.Text = Issue1.material.name;
                Material.Location = new Point(Emp1.Location.X, p.Y);

                Take.Text = Issue1.taken.FIO;
                Take.Location = new Point(Tak1.Location.X, p.Y);


                p.Y += 20;
                groupBox1.Controls.Add(quin);
                groupBox1.Controls.Add(Date);
                groupBox1.Controls.Add(Material);
                groupBox1.Controls.Add(Take);

                groupBox1.Size = new Size(Take.Location.X + Take.Size.Width, Take.Location.Y + Take.Size.Height + 20);
            }
            this.Width = 560;
        }
        public USMater(List<ISSUE> ilist, status st)
        {           
            InitializeComponent();
            
            Date1.Location = new Point(Kol1.Location.X + Kol1.Size.Width - 40, Date1.Location.Y);
            Emp1.Location = new Point(Date1.Location.X + Date1.Size.Width + 20, Date1.Location.Y);
            Tak1.Location = new Point(Emp1.Location.X + Emp1.Size.Width + 90, Date1.Location.Y);

            switch (st)
            {
                case status.Material: MatLoad(ilist);
                    break;
                case status.Data: DataLoad(ilist);
                    break;
                case status.Emploeer: EmplLoad(ilist);
                    break;
                default:
                    break;
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
