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
    public partial class LogInWindow : Form
    {
        public LogInWindow()
        {
            InitializeComponent();
        }

        private void LogInToApp_Click(object sender, EventArgs e)
        {
            if(LogInInput.Text != "admin")
            {
                MessageBox.Show("Użytkownik o podanej nazwie nie istniejeje w systemie", "Niepoprawny login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (PasswordInput.Text != "admin")
                {
                    MessageBox.Show("Wprowadzone hasło jest niepoprawne", "Niepoprawne hasło", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var mainWindow = new MainAppWindow();
                    Visible = false;
                    mainWindow.Show();
                }
            }
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
