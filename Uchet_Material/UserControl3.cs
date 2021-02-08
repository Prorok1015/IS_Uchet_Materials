using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Uchet_Material
{

    public partial class UserControl3 : UserControl
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
        private const int TCM_SETMINTABWIDTH = 0x1300 + 49;

        private MySqlConnection conn;
        private MySqlCommand command;
        private void SelectMaterial()
        {
            conn.Open();
            CB1Material.Items.Clear();
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM jurnaldb.material;";
            using MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                Material mat = new Material(rdr.GetInt32(0), rdr.GetString(1));
                CB1Material.Items.Add(mat);
            }

            conn.Close();
        }
        private void SelectEmpl()
        {
            conn.Open();
            CBEmpl.Items.Clear();
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM jurnaldb.employees;";
            using MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                Employeer empl = new Employeer(rdr.GetInt32(0), rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3));
                CBEmpl.Items.Add(empl);
            }

            conn.Close();
        }
        public UserControl3()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
            this.tabControl1.Padding = new Point(12, 4);
            this.tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.tabControl1.HandleCreated += tabControl1_HandleCreated;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            USMater.status stat = USMater.status.Data;
            string material = "";
            if (CB1Material.SelectedIndex > -1)
            {
                Material mat = (Material)CB1Material.SelectedItem;
                material = "and idmaterial = '" + mat.id + "'";
                stat = USMater.status.Material;
            }
            string StrEmpl = "";
            if (CBEmpl.SelectedIndex > -1)
            {
                Employeer emp = (Employeer)CBEmpl.SelectedItem;
                StrEmpl = "and Id_employees = '" + emp.id + "'";
                stat = USMater.status.Emploeer;
            }
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;
            string query = "";
            if (from == DateTime.Now.Date && to == DateTime.Now.Date)
                query = "and Issue_date BETWEEN '" + from.Date.ToString("yyyy-MM-dd") + "' ";
            query = "and Issue_date BETWEEN '" + from.Date.ToString("yyyy-MM-dd") + "' AND '" + to.Date.ToString("yyyy-MM-dd") + "' ";
            
            command = conn.CreateCommand();
            command.CommandText = "SELECT Id_issue, Issue_quantity, measure.name, Issue_date, employees.Id_employees, employees.FIO, employees.Phone, employees.Position_Id_position, material.idmaterial, material.Name_material, recipients.Id_recipients, recipients.FIO FROM jurnaldb.issue, jurnaldb.employees, jurnaldb.material, jurnaldb.recipients, jurnaldb.measure, jurnaldb.measure_has_issue where Employees_Id_employees = employees.Id_employees and material_idmaterial = material.idmaterial and Recipients_Id_recipients = recipients.Id_recipients and measure_has_issue.measure_idmeasure = measure.idmeasure and measure_has_issue.ISSUE_Id_issue = issue.Id_issue " + query + material + StrEmpl + " order by jurnaldb.issue.Issue_date  DESC;";

            conn.Open();
            using MySqlDataReader rdr = command.ExecuteReader();

            USMater usm;
            
            List<ISSUE> ilist = new List<ISSUE>();
            while (rdr.Read())
            {
                ISSUE value = new ISSUE();
                value.id = rdr.GetUInt32(0);
                value.quin = rdr.GetUInt32(1);
                value.Size = new SizeK(0, rdr.GetString(2));
                value.date = DateTime.Parse(rdr.GetString(3));
                value.employeer = new Employeer(rdr.GetInt32(4), rdr.GetString(5), rdr.GetString(6), rdr.GetInt32(7));
                value.material = new Material(rdr.GetInt32(8), rdr.GetString(9));
                value.taken = new Taken(rdr.GetInt32(10), rdr.GetString(11));
                ilist.Add(value);
            }
            conn.Close();
            usm = new USMater(ilist, stat);
            tabControl1.SelectedTab.Controls.Clear();
            
            usm.Width = tabControl1.SelectedTab.Width-240;
            tabControl1.SelectedTab.Controls.Add(usm);

            //tabControl1.SelectedTab.Width = 560;
            
        }

        private void ButDrop_Click(object sender, EventArgs e)
        {
            CB1Material.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CBEmpl.SelectedIndex = -1;
        }

        private void UserControl3_Enter(object sender, EventArgs e)
        {
            SelectMaterial();
            SelectEmpl();
        }


        private void tabControl1_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(this.tabControl1.Handle, TCM_SETMINTABWIDTH, IntPtr.Zero, (IntPtr)16);

        }
        private void tabControl1_MouseDown(object sender, MouseEventArgs e)
        {
            var lastIndex = this.tabControl1.TabCount - 1;
            if (this.tabControl1.GetTabRect(lastIndex).Contains(e.Location))
            {
                this.tabControl1.TabPages.Insert(lastIndex, "New Tab " + (this.tabControl1.TabCount - 1));
                this.tabControl1.SelectedIndex = lastIndex;
                this.tabControl1.SelectedTab.BackColor = Color.White;
                this.tabControl1.SelectedTab.AutoScroll = true;
            }
            else
            {
                for (var i = 0; i < this.tabControl1.TabPages.Count; i++)
                {
                    var tabRect = this.tabControl1.GetTabRect(i);
                    tabRect.Inflate(-2, -2);
                    var closeImage = Properties.Resources.DeleteButton_Image;
                    var imageRect = new Rectangle(
                        (tabRect.Right - closeImage.Width),
                        tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                        closeImage.Width,
                        closeImage.Height);
                    if (imageRect.Contains(e.Location) && tabControl1.TabCount > 2)
                    {
                        this.tabControl1.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            var tabPage = this.tabControl1.TabPages[e.Index];
            var tabRect = this.tabControl1.GetTabRect(e.Index);
            tabRect.Inflate(-2, -2);
            if (e.Index == this.tabControl1.TabCount - 1)
            {
                var addImage = Properties.Resources.AddButton_Image;
                e.Graphics.DrawImage(addImage,
                    tabRect.Left + (tabRect.Width - addImage.Width) / 2,
                    tabRect.Top + (tabRect.Height - addImage.Height) / 2);
            }
            else
            {
                var closeImage = Properties.Resources.DeleteButton_Image;
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                    tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == this.tabControl1.TabCount - 1)
                e.Cancel = true;
        }
    }
}
