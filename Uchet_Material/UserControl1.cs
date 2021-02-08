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
    public partial class UserControl1 : UserControl
    {
        private MySqlConnection conn;
        private MySqlCommand command;
        public List<ISSUE> AllIss = new List<ISSUE>();
        public int SelectIDISSUE = 0;
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
        private void SelectSize()
        {
            conn.Open();
            CBSizeK.Items.Clear();
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM jurnaldb.measure;";
            using MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                SizeK sze = new SizeK(rdr.GetInt32(0), rdr.GetString(1));
                CBSizeK.Items.Add(sze);
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
        private void SelectTaken()
        {
            conn.Open();
            CBTaken.Items.Clear();
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM jurnaldb.recipients;";
            using MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                Taken take = new Taken(rdr.GetInt32(0), rdr.GetString(1));
                CBTaken.Items.Add(take);
            }

            conn.Close();
        }
        private void SelectPosition()
        {
            conn.Open();
            CBPos.Items.Clear();
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM jurnaldb.position;";
            using MySqlDataReader rdr = command.ExecuteReader();

            while (rdr.Read())
            {
                Position pos = new Position(rdr.GetInt32(0), rdr.GetString(1));
                CBPos.Items.Add(pos);
            }

            conn.Close();
        }

        private int InsertMaterial(string name)
        {
            
            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO `jurnaldb`.`material` (`Name_material`) VALUES ('" + name + "');";
            conn.Open();
            int res = command.ExecuteNonQuery();
            conn.Close();

            SelectMaterial();

            return res;
        }
        private int InsertEmpl(string name)
        {

            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO `jurnaldb`.`employees` (`FIO`, `Phone`, `Position_Id_position`) VALUES ('"+ name +"', '80000000000', '1');";
            conn.Open();
            int res = command.ExecuteNonQuery();
            conn.Close();

            SelectEmpl();

            return res;
        }

        void UpdatePosition(Position p, Employeer e)
        {
            command = conn.CreateCommand();
            command.CommandText = "UPDATE `jurnaldb`.`employees` SET `Position_Id_position` = '" + p.id + "' WHERE (`Id_employees` = '" + e.id + "');";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            e.Position = p.id;
            CBEmpl.SelectedItem = e;
        }

        void UpdatePhone(string phone)
        {
            labPhone.Text = "";
            Employeer emp = (Employeer)CBEmpl.SelectedItem;
            command = conn.CreateCommand();
            command.CommandText = "UPDATE `jurnaldb`.`employees` SET `Phone` = '"+ phone +"' WHERE (`Id_employees` = '"+ emp.id +"');";
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
            emp.Phone = phone;
            CBEmpl.SelectedItem = emp;
        }

        private int InsertSize(string name)
        {

            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO `jurnaldb`.`measure` (`name`) VALUES ('" + name + "');";
            conn.Open();
            int res = command.ExecuteNonQuery();
            conn.Close();

            SelectSize();

            return res;
        }

        private int InsertPos(string name)
        {

            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO `jurnaldb`.`position` (`Position_name`) VALUES ('"+ name +"');";
            conn.Open();
            int res = command.ExecuteNonQuery();
            conn.Close();

            SelectPosition();

            return res;
        }
        private int InsertTaken(string name)
        {

            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO `jurnaldb`.`recipients` (`FIO`) VALUES ('"+ name +"');";
            conn.Open();
            int res = command.ExecuteNonQuery();
            conn.Close();

            SelectTaken();

            return res;
        }

        public UserControl1()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
            SaveIssue.BackColor = Color.Aqua;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!SaveIssue.Visible)
            {
                if (isDec(TBSize.Text))
                {
                    uint quin = AllIss[SelectIDISSUE].quin;
                    uint newquin = uint.Parse(TBSize.Text);
                    if (newquin != quin)
                    {
                        string q = "UPDATE `jurnaldb`.`issue` SET `Issue_quantity` = '"+ newquin +"' WHERE (`Id_issue` = '" + AllIss[SelectIDISSUE].id +"');";

                        command = conn.CreateCommand();
                        command.CommandText = q;
                        conn.Open();
                        command.ExecuteNonQuery();
                        conn.Close();
                        AllIss[SelectIDISSUE].quin = newquin;
                    }
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void addMatelial_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox.CreateInputBox("Добавить материал", "Название материала:", ref value) == DialogResult.OK)
            {                
                InsertMaterial(value);
            }
        }

        private void addSize_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox.CreateInputBox("Добавить измерения", "Название измерения(например \"кг.\"):", ref value) == DialogResult.OK)
            {
                InsertSize(value);
            }
        }

        private void addEmpl_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox.CreateInputBox("Добавить ФИО сотрудника", "ФИО сотрудника:", ref value) == DialogResult.OK)
            {
                InsertEmpl(value);
            }
        }

        private void addPos_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox.CreateInputBox("Добавить должность", "Название должности:", ref value) == DialogResult.OK)
            {
                InsertPos(value);
            }
        }

        private void addTaken_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputBox.CreateInputBox("Добавить получателя", "ФИО получателя:", ref value) == DialogResult.OK)
            {
                InsertTaken(value);
            }
        }

        public void EditIss(uint id)
        {
            for (int i = 0; i < AllIss.Count; ++i)
            {
                if (id == AllIss[i].id)
                    SelectIDISSUE = i;
            }
            SelectedIssue();
            
        }

        private void SelectedIssue()
        {
            DelIss.Visible = true;
            SaveIssue.Visible = false;
            if (SelectIDISSUE > -1 && SelectIDISSUE < AllIss.Count)
            {
                ISSUE val = AllIss[SelectIDISSUE];
                foreach (Material m in CB1Material.Items)
                {
                    if (m.id == val.material.id)
                    {
                        CB1Material.SelectedItem = m;
                        break;
                    }
                }
                TBSize.Text = val.quin.ToString();
                dateTimePicker1.Value = val.date;
                foreach (SizeK size in CBSizeK.Items)
                {
                    if (size.id == val.Size.id)
                    {
                        CBSizeK.SelectedItem = size;
                        break;
                    }
                }

                foreach (Employeer e in CBEmpl.Items)
                {
                    if (e.id == val.employeer.id)
                    {
                        CBEmpl.SelectedItem = e;
                        break;
                    }
                }

                foreach (Taken t in CBTaken.Items)
                {
                    if (t.id == val.taken.id)
                    {
                        CBTaken.SelectedItem = t;
                        break;
                    }
                }
            }
            else if (SelectIDISSUE >= AllIss.Count)
            {
                SelectIDISSUE = AllIss.Count - 1;
                SelectedIssue();
            }
            else if (SelectIDISSUE < 0)
            {
                SelectIDISSUE = 0;
                SelectedIssue();
            }
            LowIndex();
        }


        private void FillIssueLabel()
        {

            AllIss.Clear();

            string query = "SELECT Id_issue, Issue_quantity, measure_idmeasure, Employees_Id_employees, material_idmaterial, Recipients_Id_recipients, Issue_date FROM jurnaldb.issue, jurnaldb.measure_has_issue where measure_has_issue.ISSUE_Id_issue = issue.Id_issue order by Id_issue;";
            command = conn.CreateCommand();
            command.CommandText = query;
            conn.Open();
            using MySqlDataReader rdr = command.ExecuteReader();
            while (rdr.Read())
            {
                ISSUE value = new ISSUE();
                value.id = rdr.GetUInt32(0);
                value.quin = rdr.GetUInt32(1);
                value.Size = new SizeK(rdr.GetInt32(2), "");
                value.employeer = new Employeer(rdr.GetInt32(3), "", "", 0);
                value.material = new Material(rdr.GetInt32(4), "");
                value.taken = new Taken(rdr.GetInt32(5), "");
                value.date = DateTime.Parse(rdr.GetString(6));
                AllIss.Add(value);
            }
            conn.Close();

            LowIndex();
            SelectedIssue();
        }
        private void LowIndex()
        {

            AllLabel.Text = AllIss.Count.ToString();        
            SelectLabel.Text = (SelectIDISSUE + 1).ToString();
            l1.Location = new Point(SelectLabel.Location.X + SelectLabel.Width, l1.Location.Y);
            AllLabel.Location = new Point(l1.Location.X + l1.Width, AllLabel.Location.Y);
            SelectRight.Location = new Point(AllLabel.Location.X + AllLabel.Width + 1, SelectRight.Location.Y);
            NewIssue.Location = new Point(SelectRight.Location.X + SelectRight.Width + 5, NewIssue.Location.Y);
        }
        private void UserControl1_Load(object sender, EventArgs e)
        {
            SelectMaterial();
            SelectSize();
            SelectEmpl();
            SelectTaken();
            SelectPosition();
            FillIssueLabel();
            LowIndex();
            SelectedIssue();
        }

        private void CBEmpl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBEmpl.SelectedIndex != -1)
            {
                Employeer emp = (Employeer)CBEmpl.SelectedItem;
                TBPhone.Text = emp.Phone;
                for (int i = 0; i < CBPos.Items.Count; ++i)
                {
                    Position p = (Position)CBPos.Items[i];
                    if (p.id == emp.Position)
                        CBPos.SelectedItem = p;
                }

            }
            else
            {
                CBPos.SelectedIndex = -1;
                CBPos.Text = "Должность";
                TBPhone.Text = "";
            }
            
        }

        private void CBPos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Position pos = (Position)CBPos.SelectedItem;
            Employeer emp = (Employeer)CBEmpl.SelectedItem;
            if (pos != null && emp != null)
                UpdatePosition(pos, emp);
        }

        private void TBPhone_TextChanged(object sender, EventArgs e)
        {
            string phone = TBPhone.Text;
            if (phone.Length < 11 && isDec(phone))
                labPhone.Text = "Номер телефона\nдолжен содержать 11 цифр";
            else if (isDec(phone))
                UpdatePhone(phone);
        }

        bool isDec(string s)
        {
            for (int i = 0; i < s.Length; ++i)
                if (!char.IsDigit(s[i]))
                    return false;
            return true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SaveIssue_Click(object sender, EventArgs e)
        {
            Material m = (Material)CB1Material.SelectedItem;
            string quantity = TBSize.Text;
            string date = dateTimePicker1.Value.Date.ToString("yyyy.MM.dd");
            Employeer emp = (Employeer)CBEmpl.SelectedItem;
            Taken t = (Taken)CBTaken.SelectedItem;
            SizeK size = (SizeK)CBSizeK.SelectedItem;
            if (m != null && quantity.Length > 0 && quantity != " " && date != " " && emp != null && t != null && size != null)
                InsertISSUE(quantity, date, emp, m, t, size);

        }

        private void InsertISSUE(string quantity, string date, Employeer emp, Material m, Taken t, SizeK s)
        {
            command = conn.CreateCommand();
            command.CommandText = "INSERT INTO `jurnaldb`.`issue` (`Issue_quantity`, `Issue_date`, `Employees_Id_employees`, `material_idmaterial`, `Recipients_Id_recipients`) VALUES ('"+ quantity +"', '"+ date +"', '"+ emp.id +"', '"+ m.id +"', '"+ t.id + "');";
            conn.Open();
            command.ExecuteNonQuery();
            command.CommandText = "Select @@Identity";
            uint id = Convert.ToUInt32(command.ExecuteScalar());

            command.CommandText = "INSERT INTO `jurnaldb`.`measure_has_issue` (`measure_idmeasure`, `ISSUE_Id_issue`) VALUES('"+ s.id +"', '"+ id +"');";
            command.ExecuteNonQuery();
            conn.Close();
            SaveIssue.BackColor = Color.GreenYellow;
            ISSUE value = new ISSUE();
            value.id = id;
            value.quin = uint.Parse(quantity);
            value.Size = s;
            value.employeer = emp;
            value.material = m;
            value.taken = t;
            value.date = DateTime.Parse(date);
            AllIss.Add(value);
            SelectIDISSUE = AllIss.Count-1;
            SelectedIssue();
            LowIndex();
        }

        private void NewIssue_Click(object sender, EventArgs e)
        {

            SelectIDISSUE = AllIss.Count;
            LowIndex();
            SaveIssue.BackColor = Color.Aqua;
            SaveIssue.Visible = true;
            DelIss.Visible = false;
            dateTimePicker1.Value = DateTime.Now;
            CB1Material.SelectedIndex = -1;
            CB1Material.Text = "Название материала";
            TBSize.Text = "";
            CBSizeK.SelectedIndex = -1;
            CBSizeK.Text = "-";
            CBEmpl.SelectedIndex = -1;
            CBEmpl.Text = "ФИО";
            CBTaken.SelectedIndex = -1;
            CBTaken.Text = "ФИО";
        }

        private void SelectRight_Click(object sender, EventArgs e)
        {
            SelectIDISSUE++;
            SelectedIssue();
        }

        private void SelectLeft_Click(object sender, EventArgs e)
        {
            SelectIDISSUE--;
            SelectedIssue();
        }

        private void DelIss_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены?", "Удалить выдачу",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                command = conn.CreateCommand();
                command.CommandText = "DELETE FROM `jurnaldb`.`issue` WHERE (`Id_issue` = '" + AllIss[SelectIDISSUE].id + "');";
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();

                AllIss.Remove(AllIss[SelectIDISSUE]);
                SelectIDISSUE--;
                SelectedIssue();
            }

        }

        private void CBSizeK_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SaveIssue.Visible)
            {
                var v = (SizeK)CBSizeK.SelectedItem;
                int idS = AllIss[SelectIDISSUE].Size.id;

                if (v.id != idS)
                {
                    string q = "UPDATE `jurnaldb`.`measure_has_issue` SET `measure_idmeasure` = '"+ v.id +"' WHERE (`measure_idmeasure` = '"+ idS +"') and (`ISSUE_Id_issue` = '"+ AllIss[SelectIDISSUE].id +"');";

                    command = conn.CreateCommand();
                    command.CommandText = q;
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    AllIss[SelectIDISSUE].Size = v;
                }
            }

        }

        private void CB1Material_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!SaveIssue.Visible)
            {
                var v = (Material)CB1Material.SelectedItem;
                int idS = AllIss[SelectIDISSUE].material.id;

                if (v.id != idS)
                {
                    string q = "UPDATE `jurnaldb`.`issue` SET `material_idmaterial` = '"+ v.id +"' WHERE (`Id_issue` = '"+ AllIss[SelectIDISSUE].id +"');";

                    command = conn.CreateCommand();
                    command.CommandText = q;
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    AllIss[SelectIDISSUE].material = v;
                }
            }
        }

        //string textSizeBefore = "";
        private void CBSizeK_TextUpdate(object sender, EventArgs e)
        {
            /*if (!SaveIssue.Visible)
            {
                var v = (SizeK)CBSizeK.SelectedItem;
                var idS = AllIss[SelectIDISSUE].Size;

                if (v.id == idS.id)
                {
                    if (v.name != textSizeBefore)
                    {
                        this.BackColor = Color.Red;
                        textSizeBefore = v.name;
                        CBSizeK.SelectedItem = v;
                    }

                    string q = "UPDATE `jurnaldb`.`issue` SET `material_idmaterial` = '" + v.id + "' WHERE (`Id_issue` = '" + AllIss[SelectIDISSUE].id + "');";

                    command = conn.CreateCommand();
                    command.CommandText = q;
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    AllIss[SelectIDISSUE].material = v;
                }
            }*/
        }
    }
}
