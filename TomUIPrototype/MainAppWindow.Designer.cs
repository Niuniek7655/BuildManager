namespace TomUIPrototype
{
    partial class MainAppWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllAplicationTab = new System.Windows.Forms.TabControl();
            this.ClientTab = new System.Windows.Forms.TabPage();
            this.ClientTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ClientList = new BrightIdeasSoftware.FastObjectListView();
            this.CompanyClientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ClientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Surname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.PhoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Description = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ClientButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddClient = new System.Windows.Forms.Button();
            this.RemoveClient = new System.Windows.Forms.Button();
            this.EditClient = new System.Windows.Forms.Button();
            this.OrderTab = new System.Windows.Forms.TabPage();
            this.OrderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OrderList = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn_OrderNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.OrderButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddOrder = new System.Windows.Forms.Button();
            this.RemoveOrder = new System.Windows.Forms.Button();
            this.EditOrder = new System.Windows.Forms.Button();
            this.WorkerTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.WorkerList = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn_WorkerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.HelloUser = new System.Windows.Forms.Label();
            this.MainWindowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.olvColumn_OrderName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.olvColumn_WorkerSurname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_WorkerPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_PriceForHour = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.AllAplicationTab.SuspendLayout();
            this.ClientTab.SuspendLayout();
            this.ClientTabLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).BeginInit();
            this.ClientButtonsLayout.SuspendLayout();
            this.OrderTab.SuspendLayout();
            this.OrderLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).BeginInit();
            this.OrderButtonsLayout.SuspendLayout();
            this.WorkerTab.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerList)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            this.MainWindowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // AllAplicationTab
            // 
            this.AllAplicationTab.Controls.Add(this.ClientTab);
            this.AllAplicationTab.Controls.Add(this.OrderTab);
            this.AllAplicationTab.Controls.Add(this.WorkerTab);
            this.AllAplicationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllAplicationTab.Location = new System.Drawing.Point(4, 104);
            this.AllAplicationTab.Margin = new System.Windows.Forms.Padding(4);
            this.AllAplicationTab.Name = "AllAplicationTab";
            this.AllAplicationTab.SelectedIndex = 0;
            this.AllAplicationTab.Size = new System.Drawing.Size(1344, 624);
            this.AllAplicationTab.TabIndex = 0;
            // 
            // ClientTab
            // 
            this.ClientTab.Controls.Add(this.ClientTabLayout);
            this.ClientTab.Location = new System.Drawing.Point(4, 25);
            this.ClientTab.Margin = new System.Windows.Forms.Padding(4);
            this.ClientTab.Name = "ClientTab";
            this.ClientTab.Padding = new System.Windows.Forms.Padding(4);
            this.ClientTab.Size = new System.Drawing.Size(1336, 595);
            this.ClientTab.TabIndex = 0;
            this.ClientTab.Text = "Klienci";
            this.ClientTab.UseVisualStyleBackColor = true;
            // 
            // ClientTabLayout
            // 
            this.ClientTabLayout.ColumnCount = 1;
            this.ClientTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClientTabLayout.Controls.Add(this.ClientList, 0, 0);
            this.ClientTabLayout.Controls.Add(this.ClientButtonsLayout, 0, 1);
            this.ClientTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientTabLayout.Location = new System.Drawing.Point(4, 4);
            this.ClientTabLayout.Name = "ClientTabLayout";
            this.ClientTabLayout.RowCount = 2;
            this.ClientTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClientTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.ClientTabLayout.Size = new System.Drawing.Size(1328, 587);
            this.ClientTabLayout.TabIndex = 1;
            // 
            // ClientList
            // 
            this.ClientList.AllColumns.Add(this.CompanyClientName);
            this.ClientList.AllColumns.Add(this.ClientName);
            this.ClientList.AllColumns.Add(this.Surname);
            this.ClientList.AllColumns.Add(this.Email);
            this.ClientList.AllColumns.Add(this.PhoneNumber);
            this.ClientList.AllColumns.Add(this.Description);
            this.ClientList.CellEditUseWholeCell = false;
            this.ClientList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CompanyClientName,
            this.ClientName,
            this.Surname,
            this.Email,
            this.PhoneNumber,
            this.Description});
            this.ClientList.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientList.Location = new System.Drawing.Point(3, 3);
            this.ClientList.Name = "ClientList";
            this.ClientList.ShowGroups = false;
            this.ClientList.Size = new System.Drawing.Size(1322, 541);
            this.ClientList.TabIndex = 0;
            this.ClientList.UseCompatibleStateImageBehavior = false;
            this.ClientList.View = System.Windows.Forms.View.Details;
            this.ClientList.VirtualMode = true;
            // 
            // CompanyClientName
            // 
            this.CompanyClientName.Text = "Nazwa klienta";
            this.CompanyClientName.Width = 120;
            // 
            // ClientName
            // 
            this.ClientName.Text = "Imie";
            this.ClientName.Width = 120;
            // 
            // Surname
            // 
            this.Surname.Text = "Nazwisko";
            this.Surname.Width = 120;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 120;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Numer telefonu";
            this.PhoneNumber.Width = 120;
            // 
            // Description
            // 
            this.Description.Text = "Informacje dodatkowe";
            this.Description.Width = 240;
            // 
            // ClientButtonsLayout
            // 
            this.ClientButtonsLayout.ColumnCount = 3;
            this.ClientButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ClientButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ClientButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ClientButtonsLayout.Controls.Add(this.AddClient, 0, 0);
            this.ClientButtonsLayout.Controls.Add(this.RemoveClient, 1, 0);
            this.ClientButtonsLayout.Controls.Add(this.EditClient, 2, 0);
            this.ClientButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientButtonsLayout.Location = new System.Drawing.Point(3, 550);
            this.ClientButtonsLayout.Name = "ClientButtonsLayout";
            this.ClientButtonsLayout.RowCount = 1;
            this.ClientButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ClientButtonsLayout.Size = new System.Drawing.Size(1322, 34);
            this.ClientButtonsLayout.TabIndex = 1;
            // 
            // AddClient
            // 
            this.AddClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddClient.Location = new System.Drawing.Point(3, 3);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(434, 28);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Dodaj";
            this.AddClient.UseVisualStyleBackColor = true;
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // RemoveClient
            // 
            this.RemoveClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveClient.Location = new System.Drawing.Point(443, 3);
            this.RemoveClient.Name = "RemoveClient";
            this.RemoveClient.Size = new System.Drawing.Size(434, 28);
            this.RemoveClient.TabIndex = 1;
            this.RemoveClient.Text = "Usuń";
            this.RemoveClient.UseVisualStyleBackColor = true;
            // 
            // EditClient
            // 
            this.EditClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditClient.Location = new System.Drawing.Point(883, 3);
            this.EditClient.Name = "EditClient";
            this.EditClient.Size = new System.Drawing.Size(436, 28);
            this.EditClient.TabIndex = 2;
            this.EditClient.Text = "Edytuj";
            this.EditClient.UseVisualStyleBackColor = true;
            this.EditClient.Click += new System.EventHandler(this.EditClient_Click);
            // 
            // OrderTab
            // 
            this.OrderTab.Controls.Add(this.OrderLayout);
            this.OrderTab.Location = new System.Drawing.Point(4, 25);
            this.OrderTab.Margin = new System.Windows.Forms.Padding(4);
            this.OrderTab.Name = "OrderTab";
            this.OrderTab.Padding = new System.Windows.Forms.Padding(4);
            this.OrderTab.Size = new System.Drawing.Size(1336, 595);
            this.OrderTab.TabIndex = 1;
            this.OrderTab.Text = "Zlecenia";
            this.OrderTab.UseVisualStyleBackColor = true;
            // 
            // OrderLayout
            // 
            this.OrderLayout.ColumnCount = 1;
            this.OrderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OrderLayout.Controls.Add(this.OrderList, 0, 0);
            this.OrderLayout.Controls.Add(this.OrderButtonsLayout, 0, 1);
            this.OrderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderLayout.Location = new System.Drawing.Point(4, 4);
            this.OrderLayout.Name = "OrderLayout";
            this.OrderLayout.RowCount = 2;
            this.OrderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.OrderLayout.Size = new System.Drawing.Size(1328, 587);
            this.OrderLayout.TabIndex = 0;
            // 
            // OrderList
            // 
            this.OrderList.AllColumns.Add(this.olvColumn_OrderNumber);
            this.OrderList.AllColumns.Add(this.olvColumn_OrderName);
            this.OrderList.CellEditUseWholeCell = false;
            this.OrderList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_OrderNumber,
            this.olvColumn_OrderName});
            this.OrderList.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderList.Location = new System.Drawing.Point(3, 3);
            this.OrderList.Name = "OrderList";
            this.OrderList.ShowGroups = false;
            this.OrderList.Size = new System.Drawing.Size(1322, 541);
            this.OrderList.TabIndex = 0;
            this.OrderList.UseCompatibleStateImageBehavior = false;
            this.OrderList.View = System.Windows.Forms.View.Details;
            this.OrderList.VirtualMode = true;
            // 
            // olvColumn_OrderNumber
            // 
            this.olvColumn_OrderNumber.Text = "Numer zlecenia";
            this.olvColumn_OrderNumber.Width = 150;
            // 
            // OrderButtonsLayout
            // 
            this.OrderButtonsLayout.ColumnCount = 3;
            this.OrderButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OrderButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OrderButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OrderButtonsLayout.Controls.Add(this.AddOrder, 0, 0);
            this.OrderButtonsLayout.Controls.Add(this.RemoveOrder, 1, 0);
            this.OrderButtonsLayout.Controls.Add(this.EditOrder, 2, 0);
            this.OrderButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderButtonsLayout.Location = new System.Drawing.Point(3, 550);
            this.OrderButtonsLayout.Name = "OrderButtonsLayout";
            this.OrderButtonsLayout.RowCount = 1;
            this.OrderButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OrderButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.OrderButtonsLayout.Size = new System.Drawing.Size(1322, 34);
            this.OrderButtonsLayout.TabIndex = 1;
            // 
            // AddOrder
            // 
            this.AddOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddOrder.Location = new System.Drawing.Point(3, 3);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(434, 28);
            this.AddOrder.TabIndex = 0;
            this.AddOrder.Text = "Dodaj";
            this.AddOrder.UseVisualStyleBackColor = true;
            // 
            // RemoveOrder
            // 
            this.RemoveOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveOrder.Location = new System.Drawing.Point(443, 3);
            this.RemoveOrder.Name = "RemoveOrder";
            this.RemoveOrder.Size = new System.Drawing.Size(434, 28);
            this.RemoveOrder.TabIndex = 1;
            this.RemoveOrder.Text = "Usuń";
            this.RemoveOrder.UseVisualStyleBackColor = true;
            // 
            // EditOrder
            // 
            this.EditOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditOrder.Location = new System.Drawing.Point(883, 3);
            this.EditOrder.Name = "EditOrder";
            this.EditOrder.Size = new System.Drawing.Size(436, 28);
            this.EditOrder.TabIndex = 2;
            this.EditOrder.Text = "Edytuj";
            this.EditOrder.UseVisualStyleBackColor = true;
            // 
            // WorkerTab
            // 
            this.WorkerTab.Controls.Add(this.tableLayoutPanel3);
            this.WorkerTab.Location = new System.Drawing.Point(4, 25);
            this.WorkerTab.Margin = new System.Windows.Forms.Padding(4);
            this.WorkerTab.Name = "WorkerTab";
            this.WorkerTab.Padding = new System.Windows.Forms.Padding(4);
            this.WorkerTab.Size = new System.Drawing.Size(1336, 595);
            this.WorkerTab.TabIndex = 3;
            this.WorkerTab.Text = "Pracownicy";
            this.WorkerTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.WorkerList, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1328, 587);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // WorkerList
            // 
            this.WorkerList.AllColumns.Add(this.olvColumn_WorkerName);
            this.WorkerList.AllColumns.Add(this.olvColumn_WorkerSurname);
            this.WorkerList.AllColumns.Add(this.olvColumn_WorkerPhone);
            this.WorkerList.AllColumns.Add(this.olvColumn_PriceForHour);
            this.WorkerList.CellEditUseWholeCell = false;
            this.WorkerList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_WorkerName,
            this.olvColumn_WorkerSurname,
            this.olvColumn_WorkerPhone,
            this.olvColumn_PriceForHour});
            this.WorkerList.Cursor = System.Windows.Forms.Cursors.Default;
            this.WorkerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkerList.Location = new System.Drawing.Point(3, 3);
            this.WorkerList.Name = "WorkerList";
            this.WorkerList.ShowGroups = false;
            this.WorkerList.Size = new System.Drawing.Size(1322, 541);
            this.WorkerList.TabIndex = 0;
            this.WorkerList.UseCompatibleStateImageBehavior = false;
            this.WorkerList.View = System.Windows.Forms.View.Details;
            this.WorkerList.VirtualMode = true;
            // 
            // olvColumn_WorkerName
            // 
            this.olvColumn_WorkerName.Text = "Imie";
            this.olvColumn_WorkerName.Width = 150;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button6, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 550);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1322, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(434, 28);
            this.button4.TabIndex = 0;
            this.button4.Text = "Dodaj";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(443, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(434, 28);
            this.button5.TabIndex = 1;
            this.button5.Text = "Usuń";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(883, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(436, 28);
            this.button6.TabIndex = 2;
            this.button6.Text = "Edytuj";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.White;
            this.LogoPanel.Controls.Add(this.HelloUser);
            this.LogoPanel.Controls.Add(this.Logo);
            this.LogoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPanel.Location = new System.Drawing.Point(4, 4);
            this.LogoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(1344, 92);
            this.LogoPanel.TabIndex = 1;
            // 
            // HelloUser
            // 
            this.HelloUser.AutoSize = true;
            this.HelloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HelloUser.Location = new System.Drawing.Point(269, 19);
            this.HelloUser.Name = "HelloUser";
            this.HelloUser.Size = new System.Drawing.Size(313, 55);
            this.HelloUser.TabIndex = 1;
            this.HelloUser.Text = "Witaj Tomasz";
            // 
            // MainWindowLayout
            // 
            this.MainWindowLayout.ColumnCount = 1;
            this.MainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowLayout.Controls.Add(this.LogoPanel, 0, 0);
            this.MainWindowLayout.Controls.Add(this.AllAplicationTab, 0, 1);
            this.MainWindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowLayout.Location = new System.Drawing.Point(0, 0);
            this.MainWindowLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowLayout.Name = "MainWindowLayout";
            this.MainWindowLayout.RowCount = 2;
            this.MainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.MainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowLayout.Size = new System.Drawing.Size(1352, 732);
            this.MainWindowLayout.TabIndex = 2;
            // 
            // olvColumn_OrderName
            // 
            this.olvColumn_OrderName.Text = "Nazwa zlecenia";
            this.olvColumn_OrderName.Width = 150;
            // 
            // Logo
            // 
            this.Logo.Image = global::TomUIPrototype.Properties.Resources.Tomix;
            this.Logo.Location = new System.Drawing.Point(8, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(255, 86);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // olvColumn_WorkerSurname
            // 
            this.olvColumn_WorkerSurname.Text = "Nazwisko";
            this.olvColumn_WorkerSurname.Width = 150;
            // 
            // olvColumn_WorkerPhone
            // 
            this.olvColumn_WorkerPhone.Text = "Telefon";
            this.olvColumn_WorkerPhone.Width = 150;
            // 
            // olvColumn_PriceForHour
            // 
            this.olvColumn_PriceForHour.Text = "Stawak za godzinę";
            this.olvColumn_PriceForHour.Width = 150;
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 732);
            this.Controls.Add(this.MainWindowLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainAppWindow";
            this.Text = "Witaj Tomasz";
            this.AllAplicationTab.ResumeLayout(false);
            this.ClientTab.ResumeLayout(false);
            this.ClientTabLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientList)).EndInit();
            this.ClientButtonsLayout.ResumeLayout(false);
            this.OrderTab.ResumeLayout(false);
            this.OrderLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderList)).EndInit();
            this.OrderButtonsLayout.ResumeLayout(false);
            this.WorkerTab.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkerList)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            this.LogoPanel.PerformLayout();
            this.MainWindowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AllAplicationTab;
        private System.Windows.Forms.TabPage ClientTab;
        private System.Windows.Forms.TabPage OrderTab;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.TableLayoutPanel MainWindowLayout;
        private BrightIdeasSoftware.FastObjectListView ClientList;
        private BrightIdeasSoftware.OLVColumn CompanyClientName;
        private BrightIdeasSoftware.OLVColumn ClientName;
        private BrightIdeasSoftware.OLVColumn Surname;
        private BrightIdeasSoftware.OLVColumn Email;
        private BrightIdeasSoftware.OLVColumn PhoneNumber;
        private BrightIdeasSoftware.OLVColumn Description;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label HelloUser;
        private System.Windows.Forms.TableLayoutPanel ClientTabLayout;
        private System.Windows.Forms.TableLayoutPanel ClientButtonsLayout;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.Button RemoveClient;
        private System.Windows.Forms.Button EditClient;
        private System.Windows.Forms.TableLayoutPanel OrderLayout;
        private BrightIdeasSoftware.FastObjectListView OrderList;
        private BrightIdeasSoftware.OLVColumn olvColumn_OrderNumber;
        private System.Windows.Forms.TableLayoutPanel OrderButtonsLayout;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button RemoveOrder;
        private System.Windows.Forms.Button EditOrder;
        private System.Windows.Forms.TabPage WorkerTab;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private BrightIdeasSoftware.FastObjectListView WorkerList;
        private BrightIdeasSoftware.OLVColumn olvColumn_WorkerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private BrightIdeasSoftware.OLVColumn olvColumn_OrderName;
        private BrightIdeasSoftware.OLVColumn olvColumn_WorkerSurname;
        private BrightIdeasSoftware.OLVColumn olvColumn_WorkerPhone;
        private BrightIdeasSoftware.OLVColumn olvColumn_PriceForHour;
    }
}