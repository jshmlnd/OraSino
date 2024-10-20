using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORASINO_DESKTOP
{
    public partial class MyClassesForm : Form
    {
        public MyClassesForm()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            new SideBar().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new SideBar().Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
