using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP.Properties;

namespace VP.View
{
    public partial class MainAppWindow : Form
    {
        public MainAppWindow()
        {
            InitializeComponent();
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            var clientWindow = new ClientWindow();
            clientWindow.Show();
        }

        private void removeClient_Click(object sender, EventArgs e)
        {
            if (clientBoard.SelectedObject != null)
            {

            }
        }

        private void editClient_Click(object sender, EventArgs e)
        {
            if(clientBoard.SelectedObject != null)
            {
                var clientWindow = new ClientWindow();
                clientWindow.Show();
            }
        }

        private ContextMenuStrip clientContextMenu = new ContextMenuStrip();
        private void clientBoard_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            clientContextMenu.Items.Clear();
            ToolStripMenuItem[] menuOptions;
            if (clientBoard.SelectedObject != null)
            {
                menuOptions = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Dodaj", Resources.add_16px, addClient_Click),
                    new ToolStripMenuItem("Edytuj", Resources.notes_16px, editClient_Click),
                    new ToolStripMenuItem("Usuń", Resources.minus_16px, removeClient_Click)
                };
            }
            else
            {
                menuOptions = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Dodaj", Resources.add_16px, addClient_Click)
                };
            }
            clientContextMenu.Items.AddRange(menuOptions);
            clientContextMenu.Show(this, PointToClient(MousePosition));
        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            var orderWindow = new OrderWindow();
            orderWindow.Show();
        }

        private void removeOrder_Click(object sender, EventArgs e)
        {
            if (orderBoard.SelectedObject != null)
            {

            }
        }

        private void editOrder_Click(object sender, EventArgs e)
        {
            if(orderBoard.SelectedObject != null)
            {
                var orderWindow = new OrderWindow();
                orderWindow.Show();
            }
        }

        private ContextMenuStrip orderContextMenu = new ContextMenuStrip();
        private void orderBoard_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            orderContextMenu.Items.Clear();
            ToolStripMenuItem[] menuOptions;
            if (clientBoard.SelectedObject != null)
            {
                menuOptions = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Dodaj", Resources.add_16px, addOrder_Click),
                    new ToolStripMenuItem("Edytuj", Resources.notes_16px, editOrder_Click),
                    new ToolStripMenuItem("Usuń", Resources.minus_16px, removeOrder_Click)
                };
            }
            else
            {
                menuOptions = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Dodaj", Resources.add_16px, addOrder_Click)
                };
            }
            orderContextMenu.Items.AddRange(menuOptions);
            orderContextMenu.Show(this, PointToClient(MousePosition));
        }

        private void addWorker_Click(object sender, EventArgs e)
        {
            var workerWindow = new WorkerWindow();
            workerWindow.Show();
        }

        private void removeWorker_Click(object sender, EventArgs e)
        {
            if(workerBoard.SelectedObject != null)
            {

            }
        }

        private void editWorker_Click(object sender, EventArgs e)
        {
            if (workerBoard.SelectedObject != null)
            {
                var workerWindow = new WorkerWindow();
                workerWindow.Show();
            }
        }

        private ContextMenuStrip workerContextMenu = new ContextMenuStrip();
        private void workerBoard_CellRightClick(object sender, BrightIdeasSoftware.CellRightClickEventArgs e)
        {
            workerContextMenu.Items.Clear();
            ToolStripMenuItem[] menuOptions;
            if (clientBoard.SelectedObject != null)
            {
                menuOptions = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Dodaj", Resources.add_16px, addWorker_Click),
                    new ToolStripMenuItem("Edytuj", Resources.notes_16px, editWorker_Click),
                    new ToolStripMenuItem("Usuń", Resources.minus_16px, removeWorker_Click)
                };
            }
            else
            {
                menuOptions = new ToolStripMenuItem[]
                {
                    new ToolStripMenuItem("Dodaj", Resources.add_16px, addWorker_Click)
                };
            }
            workerContextMenu.Items.AddRange(menuOptions);
            workerContextMenu.Show(this, PointToClient(MousePosition));
        }
    }
}
