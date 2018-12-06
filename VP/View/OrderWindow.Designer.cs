namespace VP.View
{
    partial class OrderWindow
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
            this.orderNumber = new System.Windows.Forms.Label();
            this.orderNumberOutput = new System.Windows.Forms.TextBox();
            this.orderName = new System.Windows.Forms.Label();
            this.orderNameInput = new System.Windows.Forms.TextBox();
            this.saveOrder = new System.Windows.Forms.Button();
            this.allWorksBoard = new BrightIdeasSoftware.FastObjectListView();
            this.workNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.priceForWorkUnitColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.workQuantityColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.finalWorkCostColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.orderWithMaterial = new System.Windows.Forms.CheckBox();
            this.workNameInput = new System.Windows.Forms.TextBox();
            this.orderInformation = new System.Windows.Forms.GroupBox();
            this.workInformation = new System.Windows.Forms.GroupBox();
            this.removeWork = new System.Windows.Forms.Button();
            this.editWork = new System.Windows.Forms.Button();
            this.addWork = new System.Windows.Forms.Button();
            this.workQuantity = new System.Windows.Forms.Label();
            this.workQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.priceForWorkUnitInput = new System.Windows.Forms.NumericUpDown();
            this.priceForWorkUnit = new System.Windows.Forms.Label();
            this.workName = new System.Windows.Forms.Label();
            this.costInformation = new System.Windows.Forms.GroupBox();
            this.removeCost = new System.Windows.Forms.Button();
            this.allCostSumOutput = new System.Windows.Forms.NumericUpDown();
            this.editCost = new System.Windows.Forms.Button();
            this.allCostSum = new System.Windows.Forms.Label();
            this.addCost = new System.Windows.Forms.Button();
            this.expanseForCost = new System.Windows.Forms.Label();
            this.expanseForCostInput = new System.Windows.Forms.NumericUpDown();
            this.costNameInput = new System.Windows.Forms.TextBox();
            this.costName = new System.Windows.Forms.Label();
            this.allWorks = new System.Windows.Forms.GroupBox();
            this.allCosts = new System.Windows.Forms.GroupBox();
            this.allCostsBoard = new BrightIdeasSoftware.FastObjectListView();
            this.costNameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.expanseForCostColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.allWorksBoard)).BeginInit();
            this.orderInformation.SuspendLayout();
            this.workInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workQuantityInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceForWorkUnitInput)).BeginInit();
            this.costInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCostSumOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expanseForCostInput)).BeginInit();
            this.allWorks.SuspendLayout();
            this.allCosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCostsBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSize = true;
            this.orderNumber.Location = new System.Drawing.Point(6, 26);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(106, 17);
            this.orderNumber.TabIndex = 0;
            this.orderNumber.Text = "Numer zlecenia";
            // 
            // orderNumberOutput
            // 
            this.orderNumberOutput.Location = new System.Drawing.Point(143, 21);
            this.orderNumberOutput.Name = "orderNumberOutput";
            this.orderNumberOutput.ReadOnly = true;
            this.orderNumberOutput.Size = new System.Drawing.Size(193, 22);
            this.orderNumberOutput.TabIndex = 1;
            // 
            // orderName
            // 
            this.orderName.AutoSize = true;
            this.orderName.Location = new System.Drawing.Point(6, 52);
            this.orderName.Name = "orderName";
            this.orderName.Size = new System.Drawing.Size(106, 17);
            this.orderName.TabIndex = 2;
            this.orderName.Text = "Nazwa zlecenia";
            // 
            // orderNameInput
            // 
            this.orderNameInput.Location = new System.Drawing.Point(143, 49);
            this.orderNameInput.Name = "orderNameInput";
            this.orderNameInput.Size = new System.Drawing.Size(193, 22);
            this.orderNameInput.TabIndex = 3;
            // 
            // saveOrder
            // 
            this.saveOrder.Image = global::VP.Properties.Resources.save_16px;
            this.saveOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveOrder.Location = new System.Drawing.Point(143, 105);
            this.saveOrder.Name = "saveOrder";
            this.saveOrder.Size = new System.Drawing.Size(193, 27);
            this.saveOrder.TabIndex = 4;
            this.saveOrder.Text = "Zapisz zmiany";
            this.saveOrder.UseVisualStyleBackColor = true;
            this.saveOrder.Click += new System.EventHandler(this.SaveOrder_Click);
            // 
            // allWorksBoard
            // 
            this.allWorksBoard.AllColumns.Add(this.workNameColumn);
            this.allWorksBoard.AllColumns.Add(this.priceForWorkUnitColumn);
            this.allWorksBoard.AllColumns.Add(this.workQuantityColumn);
            this.allWorksBoard.AllColumns.Add(this.finalWorkCostColumn);
            this.allWorksBoard.CellEditUseWholeCell = false;
            this.allWorksBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.workNameColumn,
            this.priceForWorkUnitColumn,
            this.workQuantityColumn,
            this.finalWorkCostColumn});
            this.allWorksBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.allWorksBoard.Location = new System.Drawing.Point(6, 21);
            this.allWorksBoard.Name = "allWorksBoard";
            this.allWorksBoard.ShowGroups = false;
            this.allWorksBoard.Size = new System.Drawing.Size(787, 251);
            this.allWorksBoard.TabIndex = 5;
            this.allWorksBoard.UseCompatibleStateImageBehavior = false;
            this.allWorksBoard.View = System.Windows.Forms.View.Details;
            this.allWorksBoard.VirtualMode = true;
            // 
            // workNameColumn
            // 
            this.workNameColumn.Text = "Nazwa pracy";
            this.workNameColumn.Width = 120;
            // 
            // priceForWorkUnitColumn
            // 
            this.priceForWorkUnitColumn.Text = "Stawka za metr k/b";
            this.priceForWorkUnitColumn.Width = 140;
            // 
            // workQuantityColumn
            // 
            this.workQuantityColumn.Text = "Liczba metrów k/b";
            this.workQuantityColumn.Width = 134;
            // 
            // finalWorkCostColumn
            // 
            this.finalWorkCostColumn.Text = "Finalny koszt pracy";
            this.finalWorkCostColumn.Width = 150;
            // 
            // orderWithMaterial
            // 
            this.orderWithMaterial.AutoSize = true;
            this.orderWithMaterial.Location = new System.Drawing.Point(143, 77);
            this.orderWithMaterial.Name = "orderWithMaterial";
            this.orderWithMaterial.Size = new System.Drawing.Size(168, 21);
            this.orderWithMaterial.TabIndex = 6;
            this.orderWithMaterial.Text = "Zlecenie z materiałem";
            this.orderWithMaterial.UseVisualStyleBackColor = true;
            // 
            // workNameInput
            // 
            this.workNameInput.Location = new System.Drawing.Point(139, 21);
            this.workNameInput.Name = "workNameInput";
            this.workNameInput.Size = new System.Drawing.Size(193, 22);
            this.workNameInput.TabIndex = 7;
            // 
            // orderInformation
            // 
            this.orderInformation.Controls.Add(this.orderNumber);
            this.orderInformation.Controls.Add(this.orderNumberOutput);
            this.orderInformation.Controls.Add(this.orderWithMaterial);
            this.orderInformation.Controls.Add(this.orderName);
            this.orderInformation.Controls.Add(this.orderNameInput);
            this.orderInformation.Controls.Add(this.saveOrder);
            this.orderInformation.Location = new System.Drawing.Point(12, 12);
            this.orderInformation.Name = "orderInformation";
            this.orderInformation.Size = new System.Drawing.Size(342, 140);
            this.orderInformation.TabIndex = 8;
            this.orderInformation.TabStop = false;
            this.orderInformation.Text = "Dane zlecenia";
            // 
            // workInformation
            // 
            this.workInformation.Controls.Add(this.removeWork);
            this.workInformation.Controls.Add(this.editWork);
            this.workInformation.Controls.Add(this.addWork);
            this.workInformation.Controls.Add(this.workQuantity);
            this.workInformation.Controls.Add(this.workQuantityInput);
            this.workInformation.Controls.Add(this.priceForWorkUnitInput);
            this.workInformation.Controls.Add(this.priceForWorkUnit);
            this.workInformation.Controls.Add(this.workName);
            this.workInformation.Controls.Add(this.workNameInput);
            this.workInformation.Location = new System.Drawing.Point(12, 158);
            this.workInformation.Name = "workInformation";
            this.workInformation.Size = new System.Drawing.Size(342, 206);
            this.workInformation.TabIndex = 9;
            this.workInformation.TabStop = false;
            this.workInformation.Text = "Prace";
            // 
            // removeWork
            // 
            this.removeWork.Image = global::VP.Properties.Resources.minus_16px;
            this.removeWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeWork.Location = new System.Drawing.Point(139, 170);
            this.removeWork.Name = "removeWork";
            this.removeWork.Size = new System.Drawing.Size(193, 27);
            this.removeWork.TabIndex = 14;
            this.removeWork.Text = "Usuń prace";
            this.removeWork.UseVisualStyleBackColor = true;
            // 
            // editWork
            // 
            this.editWork.Image = global::VP.Properties.Resources.save_16px;
            this.editWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editWork.Location = new System.Drawing.Point(139, 138);
            this.editWork.Name = "editWork";
            this.editWork.Size = new System.Drawing.Size(193, 27);
            this.editWork.TabIndex = 13;
            this.editWork.Text = "Zapisz zmiany";
            this.editWork.UseVisualStyleBackColor = true;
            // 
            // addWork
            // 
            this.addWork.Image = global::VP.Properties.Resources.add_16px;
            this.addWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addWork.Location = new System.Drawing.Point(139, 106);
            this.addWork.Name = "addWork";
            this.addWork.Size = new System.Drawing.Size(193, 27);
            this.addWork.TabIndex = 12;
            this.addWork.Text = "Dodaj prace";
            this.addWork.UseVisualStyleBackColor = true;
            // 
            // workQuantity
            // 
            this.workQuantity.AutoSize = true;
            this.workQuantity.Location = new System.Drawing.Point(6, 79);
            this.workQuantity.Name = "workQuantity";
            this.workQuantity.Size = new System.Drawing.Size(121, 17);
            this.workQuantity.TabIndex = 11;
            this.workQuantity.Text = "Liczba metrów k/b";
            // 
            // workQuantityInput
            // 
            this.workQuantityInput.Location = new System.Drawing.Point(139, 77);
            this.workQuantityInput.Name = "workQuantityInput";
            this.workQuantityInput.Size = new System.Drawing.Size(193, 22);
            this.workQuantityInput.TabIndex = 10;
            // 
            // priceForWorkUnitInput
            // 
            this.priceForWorkUnitInput.Location = new System.Drawing.Point(139, 49);
            this.priceForWorkUnitInput.Name = "priceForWorkUnitInput";
            this.priceForWorkUnitInput.Size = new System.Drawing.Size(193, 22);
            this.priceForWorkUnitInput.TabIndex = 9;
            // 
            // priceForWorkUnit
            // 
            this.priceForWorkUnit.AutoSize = true;
            this.priceForWorkUnit.Location = new System.Drawing.Point(6, 51);
            this.priceForWorkUnit.Name = "priceForWorkUnit";
            this.priceForWorkUnit.Size = new System.Drawing.Size(127, 17);
            this.priceForWorkUnit.TabIndex = 8;
            this.priceForWorkUnit.Text = "Stawka za metr k/b";
            // 
            // workName
            // 
            this.workName.AutoSize = true;
            this.workName.Location = new System.Drawing.Point(6, 24);
            this.workName.Name = "workName";
            this.workName.Size = new System.Drawing.Size(89, 17);
            this.workName.TabIndex = 0;
            this.workName.Text = "Nazwa pracy";
            // 
            // costInformation
            // 
            this.costInformation.Controls.Add(this.removeCost);
            this.costInformation.Controls.Add(this.allCostSumOutput);
            this.costInformation.Controls.Add(this.editCost);
            this.costInformation.Controls.Add(this.allCostSum);
            this.costInformation.Controls.Add(this.addCost);
            this.costInformation.Controls.Add(this.expanseForCost);
            this.costInformation.Controls.Add(this.expanseForCostInput);
            this.costInformation.Controls.Add(this.costNameInput);
            this.costInformation.Controls.Add(this.costName);
            this.costInformation.Location = new System.Drawing.Point(12, 370);
            this.costInformation.Name = "costInformation";
            this.costInformation.Size = new System.Drawing.Size(342, 203);
            this.costInformation.TabIndex = 10;
            this.costInformation.TabStop = false;
            this.costInformation.Text = "Materiały";
            // 
            // removeCost
            // 
            this.removeCost.Image = global::VP.Properties.Resources.minus_16px;
            this.removeCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeCost.Location = new System.Drawing.Point(139, 169);
            this.removeCost.Name = "removeCost";
            this.removeCost.Size = new System.Drawing.Size(193, 27);
            this.removeCost.TabIndex = 17;
            this.removeCost.Text = "Usuń wydatek";
            this.removeCost.UseVisualStyleBackColor = true;
            // 
            // allCostSumOutput
            // 
            this.allCostSumOutput.Location = new System.Drawing.Point(139, 77);
            this.allCostSumOutput.Name = "allCostSumOutput";
            this.allCostSumOutput.ReadOnly = true;
            this.allCostSumOutput.Size = new System.Drawing.Size(193, 22);
            this.allCostSumOutput.TabIndex = 14;
            // 
            // editCost
            // 
            this.editCost.Image = global::VP.Properties.Resources.save_16px;
            this.editCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.editCost.Location = new System.Drawing.Point(139, 137);
            this.editCost.Name = "editCost";
            this.editCost.Size = new System.Drawing.Size(193, 27);
            this.editCost.TabIndex = 16;
            this.editCost.Text = "Zapisz zmiany";
            this.editCost.UseVisualStyleBackColor = true;
            // 
            // allCostSum
            // 
            this.allCostSum.AutoSize = true;
            this.allCostSum.Location = new System.Drawing.Point(6, 79);
            this.allCostSum.Name = "allCostSum";
            this.allCostSum.Size = new System.Drawing.Size(98, 17);
            this.allCostSum.TabIndex = 13;
            this.allCostSum.Text = "Suma kosztów";
            // 
            // addCost
            // 
            this.addCost.Image = global::VP.Properties.Resources.add_16px;
            this.addCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addCost.Location = new System.Drawing.Point(139, 105);
            this.addCost.Name = "addCost";
            this.addCost.Size = new System.Drawing.Size(193, 27);
            this.addCost.TabIndex = 15;
            this.addCost.Text = "Dodaj wydatek";
            this.addCost.UseVisualStyleBackColor = true;
            // 
            // expanseForCost
            // 
            this.expanseForCost.AutoSize = true;
            this.expanseForCost.Location = new System.Drawing.Point(6, 51);
            this.expanseForCost.Name = "expanseForCost";
            this.expanseForCost.Size = new System.Drawing.Size(99, 17);
            this.expanseForCost.TabIndex = 12;
            this.expanseForCost.Text = "Suma wydatku";
            // 
            // expanseForCostInput
            // 
            this.expanseForCostInput.Location = new System.Drawing.Point(139, 49);
            this.expanseForCostInput.Name = "expanseForCostInput";
            this.expanseForCostInput.Size = new System.Drawing.Size(193, 22);
            this.expanseForCostInput.TabIndex = 2;
            // 
            // costNameInput
            // 
            this.costNameInput.Location = new System.Drawing.Point(139, 21);
            this.costNameInput.Name = "costNameInput";
            this.costNameInput.Size = new System.Drawing.Size(193, 22);
            this.costNameInput.TabIndex = 1;
            // 
            // costName
            // 
            this.costName.AutoSize = true;
            this.costName.Location = new System.Drawing.Point(6, 24);
            this.costName.Name = "costName";
            this.costName.Size = new System.Drawing.Size(105, 17);
            this.costName.TabIndex = 0;
            this.costName.Text = "Nazwa wydatku";
            // 
            // allWorks
            // 
            this.allWorks.Controls.Add(this.allWorksBoard);
            this.allWorks.Location = new System.Drawing.Point(360, 12);
            this.allWorks.Name = "allWorks";
            this.allWorks.Size = new System.Drawing.Size(799, 278);
            this.allWorks.TabIndex = 11;
            this.allWorks.TabStop = false;
            this.allWorks.Text = "Informacje o pracach";
            // 
            // allCosts
            // 
            this.allCosts.Controls.Add(this.allCostsBoard);
            this.allCosts.Location = new System.Drawing.Point(360, 296);
            this.allCosts.Name = "allCosts";
            this.allCosts.Size = new System.Drawing.Size(799, 277);
            this.allCosts.TabIndex = 12;
            this.allCosts.TabStop = false;
            this.allCosts.Text = "Informacje o wydatkach";
            // 
            // allCostsBoard
            // 
            this.allCostsBoard.AllColumns.Add(this.costNameColumn);
            this.allCostsBoard.AllColumns.Add(this.expanseForCostColumn);
            this.allCostsBoard.CellEditUseWholeCell = false;
            this.allCostsBoard.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.costNameColumn,
            this.expanseForCostColumn});
            this.allCostsBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.allCostsBoard.Location = new System.Drawing.Point(6, 21);
            this.allCostsBoard.Name = "allCostsBoard";
            this.allCostsBoard.ShowGroups = false;
            this.allCostsBoard.Size = new System.Drawing.Size(793, 250);
            this.allCostsBoard.TabIndex = 0;
            this.allCostsBoard.UseCompatibleStateImageBehavior = false;
            this.allCostsBoard.View = System.Windows.Forms.View.Details;
            this.allCostsBoard.VirtualMode = true;
            // 
            // costNameColumn
            // 
            this.costNameColumn.Text = "Nazwa wydatku";
            this.costNameColumn.Width = 120;
            // 
            // expanseForCostColumn
            // 
            this.expanseForCostColumn.Text = "Suma wydatku";
            this.expanseForCostColumn.Width = 120;
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 580);
            this.Controls.Add(this.allCosts);
            this.Controls.Add(this.allWorks);
            this.Controls.Add(this.costInformation);
            this.Controls.Add(this.workInformation);
            this.Controls.Add(this.orderInformation);
            this.Name = "OrderWindow";
            this.Text = "Okno zlecenia";
            ((System.ComponentModel.ISupportInitialize)(this.allWorksBoard)).EndInit();
            this.orderInformation.ResumeLayout(false);
            this.orderInformation.PerformLayout();
            this.workInformation.ResumeLayout(false);
            this.workInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workQuantityInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceForWorkUnitInput)).EndInit();
            this.costInformation.ResumeLayout(false);
            this.costInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allCostSumOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expanseForCostInput)).EndInit();
            this.allWorks.ResumeLayout(false);
            this.allCosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allCostsBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label orderNumber;
        private System.Windows.Forms.TextBox orderNumberOutput;
        private System.Windows.Forms.Label orderName;
        private System.Windows.Forms.TextBox orderNameInput;
        private System.Windows.Forms.Button saveOrder;
        private BrightIdeasSoftware.FastObjectListView allWorksBoard;
        private System.Windows.Forms.CheckBox orderWithMaterial;
        private System.Windows.Forms.TextBox workNameInput;
        private System.Windows.Forms.GroupBox orderInformation;
        private System.Windows.Forms.GroupBox workInformation;
        private System.Windows.Forms.Label workName;
        private System.Windows.Forms.Label workQuantity;
        private System.Windows.Forms.NumericUpDown workQuantityInput;
        private System.Windows.Forms.NumericUpDown priceForWorkUnitInput;
        private System.Windows.Forms.Label priceForWorkUnit;
        private System.Windows.Forms.Button removeWork;
        private System.Windows.Forms.Button editWork;
        private System.Windows.Forms.Button addWork;
        private System.Windows.Forms.GroupBox costInformation;
        private System.Windows.Forms.Label expanseForCost;
        private System.Windows.Forms.NumericUpDown expanseForCostInput;
        private System.Windows.Forms.TextBox costNameInput;
        private System.Windows.Forms.Label costName;
        private System.Windows.Forms.GroupBox allWorks;
        private System.Windows.Forms.NumericUpDown allCostSumOutput;
        private System.Windows.Forms.Label allCostSum;
        private System.Windows.Forms.Button removeCost;
        private System.Windows.Forms.Button editCost;
        private System.Windows.Forms.Button addCost;
        private System.Windows.Forms.GroupBox allCosts;
        private BrightIdeasSoftware.FastObjectListView allCostsBoard;
        private BrightIdeasSoftware.OLVColumn workNameColumn;
        private BrightIdeasSoftware.OLVColumn priceForWorkUnitColumn;
        private BrightIdeasSoftware.OLVColumn workQuantityColumn;
        private BrightIdeasSoftware.OLVColumn costNameColumn;
        private BrightIdeasSoftware.OLVColumn expanseForCostColumn;
        private BrightIdeasSoftware.OLVColumn finalWorkCostColumn;
    }
}