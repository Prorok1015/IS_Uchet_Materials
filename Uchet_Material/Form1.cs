using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uchet_Material
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            butHome.BackColor = Color.Aqua;
            butsearch.BackColor = Color.White;
            butOtchet.BackColor = Color.White;
            UC2Search.CustomControlClickMe += new ClickMe(EdI);
        }
        private void EdI()
        {
            UC1Insert.BringToFront();
            UC1Insert.EditIss(UC2Search.idIssue);
            butHome.BackColor = Color.Aqua;
            butsearch.BackColor = Color.White;
            butOtchet.BackColor = Color.White;
        }
        private void butHome_Click(object sender, EventArgs e)
        {
            EdI();
        }

        private void butsearch_Click(object sender, EventArgs e)
        {
            UC2Search.BringToFront();
            butsearch.BackColor = Color.Aqua;
            butHome.BackColor = Color.White;
            butOtchet.BackColor = Color.White;
        }

        private void UC1Insert_Load(object sender, EventArgs e)
        {

        }

        private void ButOtchet_Click(object sender, EventArgs e)
        {
            UCOtchet.BringToFront();
            butOtchet.BackColor = Color.Aqua;
            butHome.BackColor = Color.White;
            butsearch.BackColor = Color.White;
        }
    }
}
