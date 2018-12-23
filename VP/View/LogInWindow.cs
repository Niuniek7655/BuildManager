using Constans;
using IView;
using IView.Presenter;
using IView.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP.View
{
    public partial class LogInWindow : Form, ILogInView
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private ILogInPresenter _presenter;
        public void SetPresenter(ILogInPresenter presenter)
        {
            _presenter = presenter;
        }

        public event Func<string, string, Task> LogIn;
        async private void LogInToApp_Click(object sender, EventArgs e)
        {
            var logIn = LogInInput.Text;
            var password = PasswordInput.Text;
            await LogIn?.Invoke(logIn, password);
        }

        public void ShowWarning(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowMainWindow()
        {
            if(InvokeRequired)
            {
                Invoke(new MethodInvoker(() => ActionForShowMainWindow()));
            }
            else
            {
                ActionForShowMainWindow();
            }
        }

        private void ActionForShowMainWindow()
        {
            var mainWindow = new MainAppWindow();
            Visible = false;
            mainWindow.Show();
        }

        private void ShowPassword_MouseDown(object sender, MouseEventArgs e)
        {
            PasswordInput.PasswordChar = '\0';
        }

        private void ShowPassword_MouseUp(object sender, MouseEventArgs e)
        {
            PasswordInput.PasswordChar = '*';
        }
    }
}
