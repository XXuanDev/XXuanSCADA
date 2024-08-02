using CCWin;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace XXuanSCADA
{
    public partial class LoginForm : CCSkinMain
    {
        public LoginForm()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2024-" + DateTime.Now.Year.ToString() + " By XXuan";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username, password;

                username = txtUserName.Text.ToString();
                password = txtPassword.Text.ToString();
                DataTable dataTable = DB.GetData("select * from userinfo where username='" + username + "' and pwd='" + password + "'");

                int n = dataTable.Rows.Count;
                if (n > 0)
                {
                    Com.LoginUser = username;
                    Com.LoginUserLe = dataTable.Rows[0]["le"].ToString();
                    DB.DoSql("update userinfo set lastlogintime='" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' where username='" + username + "'");

                    RealData realData = new RealData();
                    realData.Show();
                    this.Hide();
                }
                else
                {
                    XtraMessageBox.Show("用户名或密码错误，请重新登录", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.txtUserName.Text = "";
                    this.txtPassword.Text = "";
                }
            }
            catch (Exception err)
            {
                XtraMessageBox.Show(err.Message.ToString(), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
