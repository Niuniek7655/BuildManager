namespace VP.View
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
            this.allAplicationTab = new System.Windows.Forms.TabControl();
            this.clientTab = new System.Windows.Forms.TabPage();
            this.clientTabLayout = new System.Windows.Forms.TableLayoutPanel();
            this.clientBoard = new BrightIdeasSoftware.FastObjectListView();
            this.companyClientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clientName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.surname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.phoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clientDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.clientButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.editClient = new System.Windows.Forms.Button();
            this.orderTab = new System.Windows.Forms.TabPage();
            this.orderLayout = new System.Windows.Forms.TableLayoutPanel();
            this.orderBoard = new BrightIdeasSoftware.FastObjectListView();
            this.orderNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.orderName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.orderButtonsLayout = new System.Windows.Forms.TableLayoutPanel();
            this.addOrder = new System.Windows.Forms.Button();
            this.removeOrder = new System.Windows.Forms.Button();
            this.editOrder = new System.Windows.Forms.Button();
            this.workerTab = new System.Windows.Forms.TabPage();
            this.workerButtonLayout = new System.Windows.Forms.TableLayoutPanel();
            this.workerBoard = new BrightIdeasSoftware.FastObjectListView();
            this.workerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.workerSurname = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.workerPhone = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.priceForHour = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.workerDescription = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.addWorker = new System.Windows.Forms.Button();
            this.removeWorker = new System.Windows.Forms.Button();
            this.editWorker = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.helloUser = new System.Windows.Forms.Label();
            this.mainWindowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.addClient = new System.Windows.Forms.Button();
            this.removeClient = new System.Windows.Forms.Button();
            this.allAplicationTab.SuspendLayout();
            this.clientTab.SuspendLayout();
            this.clientTabLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBoard)).BeginInit();
            this.clientButtonsLayout.SuspendLayout();
            this.orderTab.SuspendLayout();
            this.orderLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBoard)).BeginInit();
            this.orderButtonsLayout.SuspendLayout();
            this.workerTab.SuspendLayout();
            this.workerButtonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBoard)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.mainWindowLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // allAplicationTab
            // 
            this.allAplicationTab.Controls.Add(this.clientTab);
            this.allAplicationTab.Controls.Add(this.orderTab);
            this.allAplicationTab.Controls.Add(this.workerTab);
            this.allAplicationTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allAplicationTab.Location = new System.Drawing.Point(4, 104);
            this.allAplicationTab.Margin = new System.Windows.Forms.Padding(4);
            this.allAplicationTab.Name = "allAplicationTab";
            this.allAplicationTab.SelectedIndex = 0;
            this.allAplicationTab.Size = new System.Drawing.Size(1344, 624);
            this.allAplicationTab.TabIndex = 0;
            // 
            // clientTab
            // 
            this.clientTab.Controls.Add(this.clientTabLayout);
            this.clientTab.Location = new System.Drawing.Point(4, 25);
            this.clientTab.Margin = new System.Windows.Forms.Padding(4);
            this.clientTab.Name = "clientTab";
            this.clientTab.Padding = new System.Windows.Forms.Padding(4);
            this.clientTab.Size = new System.Drawing.Size(1336, 595);
            this.clientTab.TabIndex = 0;
            this.clientTab.Text = "Klienci";
            this.clientTab.UseVisualStyleBackColor = true;
            // 
            // clientTabLayout
            // 
            this.clientTabLayout.ColumnCount = 1;
            this.clientTabLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientTabLayout.Controls.Add(this.clientBoard, 0, 0);
            this.clientTabLayout.Controls.Add(this.clientButtonsLayout, 0, 1);
            this.clientTabLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientTabLayout.Location = new System.Drawing.Point(4, 4);
            this.clientTabLayout.Name = "clientTabLayout";
            this.clientTabLayout.RowCount = 2;
            this.clientTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientTabLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.clientTabLayout.Size = new System.Drawing.Size(1328, 587);
            this.clientTabLayout.TabIndex = 1;
            // 
            // clientBoard
            // 
            this.clientBoard.AllColumns.Add(this.companyClientName);
            this.clientBoard.AllColumns.Add(this.clientName);
            this.clientBoard.AllColumns.Add(this.surname);
            this.clientBoard.AllColumns.Add(this.email);
            this.clientBoard.AllColumns.Add(this.phoneNumber);
            this.clientBoard.AllColumns.Add(this.clientDescription);
            this.clientBoard.CellEditUseWholeCell = false;
            this.clientBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.companyClientName,
            this.clientName,
            this.surname,
            this.email,
            this.phoneNumber,
            this.clientDescription});
            this.clientBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.clientBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientBoard.Location = new System.Drawing.Point(3, 3);
            this.clientBoard.Name = "clientBoard";
            this.clientBoard.ShowGroups = false;
            this.clientBoard.Size = new System.Drawing.Size(1322, 541);
            this.clientBoard.TabIndex = 0;
            this.clientBoard.UseCompatibleStateImageBehavior = false;
            this.clientBoard.View = System.Windows.Forms.View.Details;
            this.clientBoard.VirtualMode = true;
            this.clientBoard.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.clientBoard_CellRightClick);
            // 
            // companyClientName
            // 
            this.companyClientName.Text = "Nazwa klienta";
            this.companyClientName.Width = 120;
            // 
            // clientName
            // 
            this.clientName.Text = "Imie";
            this.clientName.Width = 120;
            // 
            // surname
            // 
            this.surname.Text = "Nazwisko";
            this.surname.Width = 120;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 120;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Numer telefonu";
            this.phoneNumber.Width = 120;
            // 
            // clientDescription
            // 
            this.clientDescription.Text = "Informacje dodatkowe";
            this.clientDescription.Width = 240;
            // 
            // clientButtonsLayout
            // 
            this.clientButtonsLayout.ColumnCount = 3;
            this.clientButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.clientButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.clientButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.clientButtonsLayout.Controls.Add(this.addClient, 0, 0);
            this.clientButtonsLayout.Controls.Add(this.removeClient, 1, 0);
            this.clientButtonsLayout.Controls.Add(this.editClient, 2, 0);
            this.clientButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientButtonsLayout.Location = new System.Drawing.Point(3, 550);
            this.clientButtonsLayout.Name = "clientButtonsLayout";
            this.clientButtonsLayout.RowCount = 1;
            this.clientButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.clientButtonsLayout.Size = new System.Drawing.Size(1322, 34);
            this.clientButtonsLayout.TabIndex = 1;
            // 
            // editClient
            // 
            this.editClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editClient.Image = global::VP.Properties.Resources.notes_16px;
            this.editClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editClient.Location = new System.Drawing.Point(883, 3);
            this.editClient.Name = "editClient";
            this.editClient.Size = new System.Drawing.Size(436, 28);
            this.editClient.TabIndex = 2;
            this.editClient.Text = "Edytuj";
            this.editClient.UseVisualStyleBackColor = true;
            this.editClient.Click += new System.EventHandler(this.editClient_Click);
            // 
            // orderTab
            // 
            this.orderTab.Controls.Add(this.orderLayout);
            this.orderTab.Location = new System.Drawing.Point(4, 25);
            this.orderTab.Margin = new System.Windows.Forms.Padding(4);
            this.orderTab.Name = "orderTab";
            this.orderTab.Padding = new System.Windows.Forms.Padding(4);
            this.orderTab.Size = new System.Drawing.Size(1336, 595);
            this.orderTab.TabIndex = 1;
            this.orderTab.Text = "Zlecenia";
            this.orderTab.UseVisualStyleBackColor = true;
            // 
            // orderLayout
            // 
            this.orderLayout.ColumnCount = 1;
            this.orderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.orderLayout.Controls.Add(this.orderBoard, 0, 0);
            this.orderLayout.Controls.Add(this.orderButtonsLayout, 0, 1);
            this.orderLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderLayout.Location = new System.Drawing.Point(4, 4);
            this.orderLayout.Name = "orderLayout";
            this.orderLayout.RowCount = 2;
            this.orderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.orderLayout.Size = new System.Drawing.Size(1328, 587);
            this.orderLayout.TabIndex = 0;
            // 
            // orderBoard
            // 
            this.orderBoard.AllColumns.Add(this.orderNumber);
            this.orderBoard.AllColumns.Add(this.orderName);
            this.orderBoard.CellEditUseWholeCell = false;
            this.orderBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNumber,
            this.orderName});
            this.orderBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.orderBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderBoard.Location = new System.Drawing.Point(3, 3);
            this.orderBoard.Name = "orderBoard";
            this.orderBoard.ShowGroups = false;
            this.orderBoard.Size = new System.Drawing.Size(1322, 541);
            this.orderBoard.TabIndex = 0;
            this.orderBoard.UseCompatibleStateImageBehavior = false;
            this.orderBoard.View = System.Windows.Forms.View.Details;
            this.orderBoard.VirtualMode = true;
            this.orderBoard.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.orderBoard_CellRightClick);
            // 
            // orderNumber
            // 
            this.orderNumber.Text = "Numer zlecenia";
            this.orderNumber.Width = 150;
            // 
            // orderName
            // 
            this.orderName.Text = "Nazwa zlecenia";
            this.orderName.Width = 150;
            // 
            // orderButtonsLayout
            // 
            this.orderButtonsLayout.ColumnCount = 3;
            this.orderButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderButtonsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.orderButtonsLayout.Controls.Add(this.addOrder, 0, 0);
            this.orderButtonsLayout.Controls.Add(this.removeOrder, 1, 0);
            this.orderButtonsLayout.Controls.Add(this.editOrder, 2, 0);
            this.orderButtonsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderButtonsLayout.Location = new System.Drawing.Point(3, 550);
            this.orderButtonsLayout.Name = "orderButtonsLayout";
            this.orderButtonsLayout.RowCount = 1;
            this.orderButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderButtonsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.orderButtonsLayout.Size = new System.Drawing.Size(1322, 34);
            this.orderButtonsLayout.TabIndex = 1;
            // 
            // addOrder
            // 
            this.addOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOrder.Image = global::VP.Properties.Resources.add_16px;
            this.addOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addOrder.Location = new System.Drawing.Point(3, 3);
            this.addOrder.Name = "addOrder";
            this.addOrder.Size = new System.Drawing.Size(434, 28);
            this.addOrder.TabIndex = 0;
            this.addOrder.Text = "Dodaj";
            this.addOrder.UseVisualStyleBackColor = true;
            this.addOrder.Click += new System.EventHandler(this.addOrder_Click);
            // 
            // removeOrder
            // 
            this.removeOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeOrder.Image = global::VP.Properties.Resources.minus_16px;
            this.removeOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeOrder.Location = new System.Drawing.Point(443, 3);
            this.removeOrder.Name = "removeOrder";
            this.removeOrder.Size = new System.Drawing.Size(434, 28);
            this.removeOrder.TabIndex = 1;
            this.removeOrder.Text = "Usuń";
            this.removeOrder.UseVisualStyleBackColor = true;
            this.removeOrder.Click += new System.EventHandler(this.removeOrder_Click);
            // 
            // editOrder
            // 
            this.editOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editOrder.Image = global::VP.Properties.Resources.notes_16px;
            this.editOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editOrder.Location = new System.Drawing.Point(883, 3);
            this.editOrder.Name = "editOrder";
            this.editOrder.Size = new System.Drawing.Size(436, 28);
            this.editOrder.TabIndex = 2;
            this.editOrder.Text = "Edytuj";
            this.editOrder.UseVisualStyleBackColor = true;
            this.editOrder.Click += new System.EventHandler(this.editOrder_Click);
            // 
            // workerTab
            // 
            this.workerTab.Controls.Add(this.workerButtonLayout);
            this.workerTab.Location = new System.Drawing.Point(4, 25);
            this.workerTab.Margin = new System.Windows.Forms.Padding(4);
            this.workerTab.Name = "workerTab";
            this.workerTab.Padding = new System.Windows.Forms.Padding(4);
            this.workerTab.Size = new System.Drawing.Size(1336, 595);
            this.workerTab.TabIndex = 3;
            this.workerTab.Text = "Pracownicy";
            this.workerTab.UseVisualStyleBackColor = true;
            // 
            // workerButtonLayout
            // 
            this.workerButtonLayout.ColumnCount = 1;
            this.workerButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workerButtonLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.workerButtonLayout.Controls.Add(this.workerBoard, 0, 0);
            this.workerButtonLayout.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.workerButtonLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerButtonLayout.Location = new System.Drawing.Point(4, 4);
            this.workerButtonLayout.Name = "workerButtonLayout";
            this.workerButtonLayout.RowCount = 2;
            this.workerButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.workerButtonLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.workerButtonLayout.Size = new System.Drawing.Size(1328, 587);
            this.workerButtonLayout.TabIndex = 0;
            // 
            // workerBoard
            // 
            this.workerBoard.AllColumns.Add(this.workerName);
            this.workerBoard.AllColumns.Add(this.workerSurname);
            this.workerBoard.AllColumns.Add(this.workerPhone);
            this.workerBoard.AllColumns.Add(this.priceForHour);
            this.workerBoard.AllColumns.Add(this.workerDescription);
            this.workerBoard.CellEditUseWholeCell = false;
            this.workerBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workerName,
            this.workerSurname,
            this.workerPhone,
            this.priceForHour,
            this.workerDescription});
            this.workerBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.workerBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workerBoard.Location = new System.Drawing.Point(3, 3);
            this.workerBoard.Name = "workerBoard";
            this.workerBoard.ShowGroups = false;
            this.workerBoard.Size = new System.Drawing.Size(1322, 541);
            this.workerBoard.TabIndex = 0;
            this.workerBoard.UseCompatibleStateImageBehavior = false;
            this.workerBoard.View = System.Windows.Forms.View.Details;
            this.workerBoard.VirtualMode = true;
            this.workerBoard.CellRightClick += new System.EventHandler<BrightIdeasSoftware.CellRightClickEventArgs>(this.workerBoard_CellRightClick);
            // 
            // workerName
            // 
            this.workerName.Text = "Imie";
            this.workerName.Width = 150;
            // 
            // workerSurname
            // 
            this.workerSurname.Text = "Nazwisko";
            this.workerSurname.Width = 150;
            // 
            // workerPhone
            // 
            this.workerPhone.Text = "Telefon";
            this.workerPhone.Width = 150;
            // 
            // priceForHour
            // 
            this.priceForHour.Text = "Stawak za godzinę";
            this.priceForHour.Width = 150;
            // 
            // workerDescription
            // 
            this.workerDescription.Text = "Informacje dodatkowe";
            this.workerDescription.Width = 150;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.addWorker, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.removeWorker, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.editWorker, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 550);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1322, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // addWorker
            // 
            this.addWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addWorker.Image = global::VP.Properties.Resources.add_16px;
            this.addWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWorker.Location = new System.Drawing.Point(3, 3);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(434, 28);
            this.addWorker.TabIndex = 0;
            this.addWorker.Text = "Dodaj";
            this.addWorker.UseVisualStyleBackColor = true;
            this.addWorker.Click += new System.EventHandler(this.addWorker_Click);
            // 
            // removeWorker
            // 
            this.removeWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeWorker.Image = global::VP.Properties.Resources.minus_16px;
            this.removeWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeWorker.Location = new System.Drawing.Point(443, 3);
            this.removeWorker.Name = "removeWorker";
            this.removeWorker.Size = new System.Drawing.Size(434, 28);
            this.removeWorker.TabIndex = 1;
            this.removeWorker.Text = "Usuń";
            this.removeWorker.UseVisualStyleBackColor = true;
            this.removeWorker.Click += new System.EventHandler(this.removeWorker_Click);
            // 
            // editWorker
            // 
            this.editWorker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editWorker.Image = global::VP.Properties.Resources.notes_16px;
            this.editWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editWorker.Location = new System.Drawing.Point(883, 3);
            this.editWorker.Name = "editWorker";
            this.editWorker.Size = new System.Drawing.Size(436, 28);
            this.editWorker.TabIndex = 2;
            this.editWorker.Text = "Edytuj";
            this.editWorker.UseVisualStyleBackColor = true;
            this.editWorker.Click += new System.EventHandler(this.editWorker_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.White;
            this.logoPanel.Controls.Add(this.helloUser);
            this.logoPanel.Controls.Add(this.logo);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPanel.Location = new System.Drawing.Point(4, 4);
            this.logoPanel.Margin = new System.Windows.Forms.Padding(4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(1344, 92);
            this.logoPanel.TabIndex = 1;
            // 
            // helloUser
            // 
            this.helloUser.AutoSize = true;
            this.helloUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.helloUser.Location = new System.Drawing.Point(269, 19);
            this.helloUser.Name = "helloUser";
            this.helloUser.Size = new System.Drawing.Size(313, 55);
            this.helloUser.TabIndex = 1;
            this.helloUser.Text = "Witaj Tomasz";
            // 
            // mainWindowLayout
            // 
            this.mainWindowLayout.ColumnCount = 1;
            this.mainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainWindowLayout.Controls.Add(this.logoPanel, 0, 0);
            this.mainWindowLayout.Controls.Add(this.allAplicationTab, 0, 1);
            this.mainWindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowLayout.Location = new System.Drawing.Point(0, 0);
            this.mainWindowLayout.Margin = new System.Windows.Forms.Padding(4);
            this.mainWindowLayout.Name = "mainWindowLayout";
            this.mainWindowLayout.RowCount = 2;
            this.mainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainWindowLayout.Size = new System.Drawing.Size(1352, 732);
            this.mainWindowLayout.TabIndex = 2;
            // 
            // logo
            // 
            this.logo.Image = global::VP.Properties.Resources.Tomix;
            this.logo.Location = new System.Drawing.Point(8, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(255, 86);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // addClient
            // 
            this.addClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addClient.Image = global::VP.Properties.Resources.add_16px;
            this.addClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClient.Location = new System.Drawing.Point(3, 3);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(434, 28);
            this.addClient.TabIndex = 0;
            this.addClient.Text = "Dodaj";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // removeClient
            // 
            this.removeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeClient.Image = global::VP.Properties.Resources.minus_16px;
            this.removeClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeClient.Location = new System.Drawing.Point(443, 3);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(434, 28);
            this.removeClient.TabIndex = 1;
            this.removeClient.Text = "Usuń";
            this.removeClient.UseVisualStyleBackColor = true;
            this.removeClient.Click += new System.EventHandler(this.removeClient_Click);
            // 
            // MainAppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 732);
            this.Controls.Add(this.mainWindowLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainAppWindow";
            this.Text = "Witaj Tomasz";
            this.allAplicationTab.ResumeLayout(false);
            this.clientTab.ResumeLayout(false);
            this.clientTabLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clientBoard)).EndInit();
            this.clientButtonsLayout.ResumeLayout(false);
            this.orderTab.ResumeLayout(false);
            this.orderLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderBoard)).EndInit();
            this.orderButtonsLayout.ResumeLayout(false);
            this.workerTab.ResumeLayout(false);
            this.workerButtonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.workerBoard)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.mainWindowLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl allAplicationTab;
        private System.Windows.Forms.TabPage clientTab;
        private System.Windows.Forms.TabPage orderTab;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.TableLayoutPanel mainWindowLayout;
        private BrightIdeasSoftware.FastObjectListView clientBoard;
        private BrightIdeasSoftware.OLVColumn companyClientName;
        private BrightIdeasSoftware.OLVColumn clientName;
        private BrightIdeasSoftware.OLVColumn surname;
        private BrightIdeasSoftware.OLVColumn email;
        private BrightIdeasSoftware.OLVColumn phoneNumber;
        private BrightIdeasSoftware.OLVColumn clientDescription;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label helloUser;
        private System.Windows.Forms.TableLayoutPanel clientTabLayout;
        private System.Windows.Forms.TableLayoutPanel clientButtonsLayout;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button removeClient;
        private System.Windows.Forms.Button editClient;
        private System.Windows.Forms.TableLayoutPanel orderLayout;
        private BrightIdeasSoftware.FastObjectListView orderBoard;
        private BrightIdeasSoftware.OLVColumn orderNumber;
        private System.Windows.Forms.TableLayoutPanel orderButtonsLayout;
        private System.Windows.Forms.Button addOrder;
        private System.Windows.Forms.Button removeOrder;
        private System.Windows.Forms.Button editOrder;
        private System.Windows.Forms.TabPage workerTab;
        private System.Windows.Forms.TableLayoutPanel workerButtonLayout;
        private BrightIdeasSoftware.FastObjectListView workerBoard;
        private BrightIdeasSoftware.OLVColumn workerName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button addWorker;
        private System.Windows.Forms.Button removeWorker;
        private System.Windows.Forms.Button editWorker;
        private BrightIdeasSoftware.OLVColumn orderName;
        private BrightIdeasSoftware.OLVColumn workerSurname;
        private BrightIdeasSoftware.OLVColumn workerPhone;
        private BrightIdeasSoftware.OLVColumn priceForHour;
        private BrightIdeasSoftware.OLVColumn workerDescription;
    }
}