using System.Reflection.Metadata;
using System.Data.OleDb;

namespace ORASINO_DESKTOP
{
    public partial class LoginForm : Form
    {
        //OleDbConnection trmnl = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=H:\ORASINO_DESKTOP\ORASINO_DESKTOP\Orasino_Accounts.accdb");
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataReader reader;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new ForgotPassword().Show();
        }

        private void StudentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)7)
                PasswordBox.Focus();
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)7)
                LoginButton.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(StudentIDBox.Text))
            {
                MessageBox.Show("Please enter Student ID", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                StudentIDBox.Focus();
                return;
            }
            try
            {
                DataSet1TableAdapters.AccountsTableAdapter accounts = new DataSet1TableAdapters.AccountsTableAdapter();
                DataSet1.AccountsDataTable dt = accounts.GetDataByStudentIDPassword(StudentIDBox.Text, PasswordBox.Text);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("You have successfully logged in.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new MyScheduleForm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your Student ID or Password is incorrect.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
