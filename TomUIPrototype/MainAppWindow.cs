using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomUIPrototype
{
    public partial class MainAppWindow : Form
    {
        public MainAppWindow()
        {
            InitializeComponent();
        }

        private void AddClient_Click(object sender, EventArgs e)
        {
            var clientWindow = new ClientWindow();
            clientWindow.Show();
        }

        private void EditClient_Click(object sender, EventArgs e)
        {
            var clientWindow = new ClientWindow();
            clientWindow.Show();
        }
    }
}
