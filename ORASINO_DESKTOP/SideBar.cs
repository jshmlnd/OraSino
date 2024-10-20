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
    public partial class SideBar : Form
    {
        public SideBar()
        {
            InitializeComponent();
        }

        private void MyScheduleButton_Click(object sender, EventArgs e)
        {
            new MyScheduleForm().Show();
            this.Hide();
        }

        private void MyClassesButton_Click(object sender, EventArgs e)
        {
            new MyClassesForm().Show();
            this.Hide();
        }

        private void MyGradesButton_Click(object sender, EventArgs e)
        {
            new MyGradesForm().Show();
            this.Hide();
        }

        private void MyAccountButton_Click(object sender, EventArgs e)
        {
            new MyAccountForm().Show();
            this.Hide();
        }

        private void AccountLedgerButton_Click(object sender, EventArgs e)
        {
            new AccountLedgerForm().Show();
            this.Hide();
        }

        private void SideBar_Load(object sender, EventArgs e)
        {

        }
    }
}
