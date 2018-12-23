using IView;
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
    public partial class OrderWindow : Form, IOrderView
    {
        public OrderWindow()
        {
            InitializeComponent();
        }

        private void SaveOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
