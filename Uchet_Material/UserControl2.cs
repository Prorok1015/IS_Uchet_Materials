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
    public delegate void ClickMe();
    public partial class UserControl2 : UserControl
    {
        private MySqlConnection conn;
        private MySqlCommand command;
        public event ClickMe CustomControlClickMe;
        public uint idIssue { get; set; }
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
        public UserControl2()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            this.EditRow.Click += new System.EventHandler(this.EditRow_Click);
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string material = "";
            if (CB1Material.SelectedIndex > -1)
            {
                Material mat = (Material)CB1Material.SelectedItem;
                material = "and idmaterial = '"+ mat.id + "'";
            }
            string StrEmpl = "";
            if (CBEmpl.SelectedIndex > -1)
            {
                Employeer emp = (Employeer)CBEmpl.SelectedItem;
                StrEmpl = "and Id_employees = '" + emp.id + "'";
            }
            DateTime from = dateTimePicker1.Value.Date;
            DateTime to = dateTimePicker2.Value.Date;
            string query;
            if (from == DateTime.Now.Date && to == DateTime.Now.Date)
                query = "and Issue_date BETWEEN '" + from.Date.ToString("yyyy-MM-dd") + "' ";
            query = "and Issue_date BETWEEN '"+from.Date.ToString("yyyy-MM-dd")+"' AND '"+ to.Date.ToString("yyyy-MM-dd") +"' ";
            dataGridView1.Rows.Clear();
            command = conn.CreateCommand();
            command.CommandText = "SELECT Id_issue, Issue_quantity, measure.name, Issue_date, employees.Id_employees, employees.FIO, employees.Phone, employees.Position_Id_position, material.idmaterial, material.Name_material, recipients.Id_recipients, recipients.FIO FROM jurnaldb.issue, jurnaldb.employees, jurnaldb.material, jurnaldb.recipients, jurnaldb.measure, jurnaldb.measure_has_issue where Employees_Id_employees = employees.Id_employees and material_idmaterial = material.idmaterial and Recipients_Id_recipients = recipients.Id_recipients and measure_has_issue.measure_idmeasure = measure.idmeasure and measure_has_issue.ISSUE_Id_issue = issue.Id_issue "+ query + material + StrEmpl + " order by jurnaldb.issue.Issue_date DESC;";

            conn.Open();
            using MySqlDataReader rdr = command.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {                
                ISSUE value = new ISSUE();
                value.id = rdr.GetUInt32(0);
                value.quin = rdr.GetUInt32(1);
                value.date = DateTime.Parse(rdr.GetString(3));
                value.employeer = new Employeer(rdr.GetInt32(4), rdr.GetString(5), rdr.GetString(6), rdr.GetInt32(7));
                value.material = new Material(rdr.GetInt32(8), rdr.GetString(9));
                value.taken = new Taken(rdr.GetInt32(10), rdr.GetString(11));

                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = value;
                dataGridView1.Rows[i].Cells[1].Value = value.quin + " " + rdr.GetString(2);
                dataGridView1.Rows[i].Cells[2].Value = value.date.Date.ToString("dd.MM.yyyy");
                dataGridView1.Rows[i].Cells[3].Value = value.employeer;
                dataGridView1.Rows[i].Cells[4].Value = value.taken;
                ++i;
            }
            conn.Close();


        }

        private void ButDrop_Click(object sender, EventArgs e)
        {
            CB1Material.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CBEmpl.SelectedIndex = -1;
        }

        private void UserControl2_Enter(object sender, EventArgs e)
        {
            SelectMaterial();
            SelectEmpl();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dataGridView1.HitTest(e.X, e.Y);

                if (hti.RowIndex != -1)
                {
                    dataGridView1.ClearSelection();                    
                    dataGridView1.Rows[hti.RowIndex].Selected = true;
                    contextMenuStrip1.Show(dataGridView1, e.Location);
                }
            }
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            Int32 rowToDelete = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            ISSUE iss = (ISSUE)dataGridView1.Rows[rowToDelete].Cells[0].Value;
            idIssue = iss.id;
            if (CustomControlClickMe != null)
                CustomControlClickMe();

        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы уверены?", "Удалить выдачу", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Int32 rowToDelete = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                ISSUE iss = (ISSUE)dataGridView1.Rows[rowToDelete].Cells[0].Value;               
                command = conn.CreateCommand();
                command.CommandText = "DELETE FROM `jurnaldb`.`issue` WHERE (`Id_issue` = '" + iss.id + "');";
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                dataGridView1.Rows.RemoveAt(rowToDelete);
                dataGridView1.ClearSelection();
            }
        }
    }
}
