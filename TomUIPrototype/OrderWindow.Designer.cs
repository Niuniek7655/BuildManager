namespace TomUIPrototype
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
            this.OrderNumber = new System.Windows.Forms.Label();
            this.OrderNumberOutput = new System.Windows.Forms.TextBox();
            this.OrderName = new System.Windows.Forms.Label();
            this.OrderNameInput = new System.Windows.Forms.TextBox();
            this.SaveOrder = new System.Windows.Forms.Button();
            this.AllWorksList = new BrightIdeasSoftware.FastObjectListView();
            this.OrderWithMaterial = new System.Windows.Forms.CheckBox();
            this.WorkNameInput = new System.Windows.Forms.TextBox();
            this.OrderInformation = new System.Windows.Forms.GroupBox();
            this.WorkInformation = new System.Windows.Forms.GroupBox();
            this.WorkName = new System.Windows.Forms.Label();
            this.PriceForWorkUnit = new System.Windows.Forms.Label();
            this.PriceForWorkUnitInput = new System.Windows.Forms.NumericUpDown();
            this.WorkQuantityInput = new System.Windows.Forms.NumericUpDown();
            this.WorkQuantity = new System.Windows.Forms.Label();
            this.CostInformation = new System.Windows.Forms.GroupBox();
            this.AllWorks = new System.Windows.Forms.GroupBox();
            this.AddWork = new System.Windows.Forms.Button();
            this.EditWrok = new System.Windows.Forms.Button();
            this.RemoveWork = new System.Windows.Forms.Button();
            this.CostName = new System.Windows.Forms.Label();
            this.CostNameInput = new System.Windows.Forms.TextBox();
            this.ExpanseForCostInput = new System.Windows.Forms.NumericUpDown();
            this.ExpanseForCost = new System.Windows.Forms.Label();
            this.AllCostSum = new System.Windows.Forms.Label();
            this.AllCostSumOutput = new System.Windows.Forms.NumericUpDown();
            this.RemoveCost = new System.Windows.Forms.Button();
            this.EditCost = new System.Windows.Forms.Button();
            this.AddCost = new System.Windows.Forms.Button();
            this.AllCosts = new System.Windows.Forms.GroupBox();
            this.AllCostsList = new BrightIdeasSoftware.FastObjectListView();
            this.olvColumn_WorkName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_PriceForWorkUnit = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_WorkQuantity = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_CostName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn_ExpanseForCost = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.AllWorksList)).BeginInit();
            this.OrderInformation.SuspendLayout();
            this.WorkInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceForWorkUnitInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkQuantityInput)).BeginInit();
            this.CostInformation.SuspendLayout();
            this.AllWorks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpanseForCostInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCostSumOutput)).BeginInit();
            this.AllCosts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllCostsList)).BeginInit();
            this.SuspendLayout();
            // 
            // OrderNumber
            // 
            this.OrderNumber.AutoSize = true;
            this.OrderNumber.Location = new System.Drawing.Point(6, 26);
            this.OrderNumber.Name = "OrderNumber";
            this.OrderNumber.Size = new System.Drawing.Size(106, 17);
            this.OrderNumber.TabIndex = 0;
            this.OrderNumber.Text = "Numer zlecenia";
            // 
            // OrderNumberOutput
            // 
            this.OrderNumberOutput.Location = new System.Drawing.Point(143, 21);
            this.OrderNumberOutput.Name = "OrderNumberOutput";
            this.OrderNumberOutput.ReadOnly = true;
            this.OrderNumberOutput.Size = new System.Drawing.Size(193, 22);
            this.OrderNumberOutput.TabIndex = 1;
            // 
            // OrderName
            // 
            this.OrderName.AutoSize = true;
            this.OrderName.Location = new System.Drawing.Point(6, 52);
            this.OrderName.Name = "OrderName";
            this.OrderName.Size = new System.Drawing.Size(106, 17);
            this.OrderName.TabIndex = 2;
            this.OrderName.Text = "Nazwa zlecenia";
            // 
            // OrderNameInput
            // 
            this.OrderNameInput.Location = new System.Drawing.Point(143, 49);
            this.OrderNameInput.Name = "OrderNameInput";
            this.OrderNameInput.Size = new System.Drawing.Size(193, 22);
            this.OrderNameInput.TabIndex = 3;
            // 
            // SaveOrder
            // 
            this.SaveOrder.Location = new System.Drawing.Point(143, 105);
            this.SaveOrder.Name = "SaveOrder";
            this.SaveOrder.Size = new System.Drawing.Size(193, 26);
            this.SaveOrder.TabIndex = 4;
            this.SaveOrder.Text = "Zapisz zmiany";
            this.SaveOrder.UseVisualStyleBackColor = true;
            this.SaveOrder.Click += new System.EventHandler(this.SaveOrder_Click);
            // 
            // AllWorksList
            // 
            this.AllWorksList.AllColumns.Add(this.olvColumn_WorkName);
            this.AllWorksList.AllColumns.Add(this.olvColumn_PriceForWorkUnit);
            this.AllWorksList.AllColumns.Add(this.olvColumn_WorkQuantity);
            this.AllWorksList.CellEditUseWholeCell = false;
            this.AllWorksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_WorkName,
            this.olvColumn_PriceForWorkUnit,
            this.olvColumn_WorkQuantity});
            this.AllWorksList.Cursor = System.Windows.Forms.Cursors.Default;
            this.AllWorksList.Location = new System.Drawing.Point(6, 21);
            this.AllWorksList.Name = "AllWorksList";
            this.AllWorksList.ShowGroups = false;
            this.AllWorksList.Size = new System.Drawing.Size(787, 251);
            this.AllWorksList.TabIndex = 5;
            this.AllWorksList.UseCompatibleStateImageBehavior = false;
            this.AllWorksList.View = System.Windows.Forms.View.Details;
            this.AllWorksList.VirtualMode = true;
            // 
            // OrderWithMaterial
            // 
            this.OrderWithMaterial.AutoSize = true;
            this.OrderWithMaterial.Location = new System.Drawing.Point(143, 77);
            this.OrderWithMaterial.Name = "OrderWithMaterial";
            this.OrderWithMaterial.Size = new System.Drawing.Size(168, 21);
            this.OrderWithMaterial.TabIndex = 6;
            this.OrderWithMaterial.Text = "Zlecenie z materiałem";
            this.OrderWithMaterial.UseVisualStyleBackColor = true;
            // 
            // WorkNameInput
            // 
            this.WorkNameInput.Location = new System.Drawing.Point(139, 21);
            this.WorkNameInput.Name = "WorkNameInput";
            this.WorkNameInput.Size = new System.Drawing.Size(193, 22);
            this.WorkNameInput.TabIndex = 7;
            // 
            // OrderInformation
            // 
            this.OrderInformation.Controls.Add(this.OrderNumber);
            this.OrderInformation.Controls.Add(this.OrderNumberOutput);
            this.OrderInformation.Controls.Add(this.OrderWithMaterial);
            this.OrderInformation.Controls.Add(this.OrderName);
            this.OrderInformation.Controls.Add(this.OrderNameInput);
            this.OrderInformation.Controls.Add(this.SaveOrder);
            this.OrderInformation.Location = new System.Drawing.Point(12, 12);
            this.OrderInformation.Name = "OrderInformation";
            this.OrderInformation.Size = new System.Drawing.Size(342, 140);
            this.OrderInformation.TabIndex = 8;
            this.OrderInformation.TabStop = false;
            this.OrderInformation.Text = "Dane zlecenia";
            // 
            // WorkInformation
            // 
            this.WorkInformation.Controls.Add(this.RemoveWork);
            this.WorkInformation.Controls.Add(this.EditWrok);
            this.WorkInformation.Controls.Add(this.AddWork);
            this.WorkInformation.Controls.Add(this.WorkQuantity);
            this.WorkInformation.Controls.Add(this.WorkQuantityInput);
            this.WorkInformation.Controls.Add(this.PriceForWorkUnitInput);
            this.WorkInformation.Controls.Add(this.PriceForWorkUnit);
            this.WorkInformation.Controls.Add(this.WorkName);
            this.WorkInformation.Controls.Add(this.WorkNameInput);
            this.WorkInformation.Location = new System.Drawing.Point(12, 158);
            this.WorkInformation.Name = "WorkInformation";
            this.WorkInformation.Size = new System.Drawing.Size(342, 206);
            this.WorkInformation.TabIndex = 9;
            this.WorkInformation.TabStop = false;
            this.WorkInformation.Text = "Prace";
            // 
            // WorkName
            // 
            this.WorkName.AutoSize = true;
            this.WorkName.Location = new System.Drawing.Point(6, 24);
            this.WorkName.Name = "WorkName";
            this.WorkName.Size = new System.Drawing.Size(89, 17);
            this.WorkName.TabIndex = 0;
            this.WorkName.Text = "Nazwa pracy";
            // 
            // PriceForWorkUnit
            // 
            this.PriceForWorkUnit.AutoSize = true;
            this.PriceForWorkUnit.Location = new System.Drawing.Point(6, 51);
            this.PriceForWorkUnit.Name = "PriceForWorkUnit";
            this.PriceForWorkUnit.Size = new System.Drawing.Size(127, 17);
            this.PriceForWorkUnit.TabIndex = 8;
            this.PriceForWorkUnit.Text = "Stawka za metr k/b";
            // 
            // PriceForWorkUnitInput
            // 
            this.PriceForWorkUnitInput.Location = new System.Drawing.Point(139, 49);
            this.PriceForWorkUnitInput.Name = "PriceForWorkUnitInput";
            this.PriceForWorkUnitInput.Size = new System.Drawing.Size(193, 22);
            this.PriceForWorkUnitInput.TabIndex = 9;
            // 
            // WorkQuantityInput
            // 
            this.WorkQuantityInput.Location = new System.Drawing.Point(139, 77);
            this.WorkQuantityInput.Name = "WorkQuantityInput";
            this.WorkQuantityInput.Size = new System.Drawing.Size(193, 22);
            this.WorkQuantityInput.TabIndex = 10;
            // 
            // WorkQuantity
            // 
            this.WorkQuantity.AutoSize = true;
            this.WorkQuantity.Location = new System.Drawing.Point(6, 79);
            this.WorkQuantity.Name = "WorkQuantity";
            this.WorkQuantity.Size = new System.Drawing.Size(121, 17);
            this.WorkQuantity.TabIndex = 11;
            this.WorkQuantity.Text = "Liczba metrów k/b";
            // 
            // CostInformation
            // 
            this.CostInformation.Controls.Add(this.RemoveCost);
            this.CostInformation.Controls.Add(this.AllCostSumOutput);
            this.CostInformation.Controls.Add(this.EditCost);
            this.CostInformation.Controls.Add(this.AllCostSum);
            this.CostInformation.Controls.Add(this.AddCost);
            this.CostInformation.Controls.Add(this.ExpanseForCost);
            this.CostInformation.Controls.Add(this.ExpanseForCostInput);
            this.CostInformation.Controls.Add(this.CostNameInput);
            this.CostInformation.Controls.Add(this.CostName);
            this.CostInformation.Location = new System.Drawing.Point(12, 370);
            this.CostInformation.Name = "CostInformation";
            this.CostInformation.Size = new System.Drawing.Size(342, 203);
            this.CostInformation.TabIndex = 10;
            this.CostInformation.TabStop = false;
            this.CostInformation.Text = "Materiały";
            // 
            // AllWorks
            // 
            this.AllWorks.Controls.Add(this.AllWorksList);
            this.AllWorks.Location = new System.Drawing.Point(360, 12);
            this.AllWorks.Name = "AllWorks";
            this.AllWorks.Size = new System.Drawing.Size(799, 278);
            this.AllWorks.TabIndex = 11;
            this.AllWorks.TabStop = false;
            this.AllWorks.Text = "Informacje o pracach";
            // 
            // AddWork
            // 
            this.AddWork.Location = new System.Drawing.Point(139, 106);
            this.AddWork.Name = "AddWork";
            this.AddWork.Size = new System.Drawing.Size(193, 26);
            this.AddWork.TabIndex = 12;
            this.AddWork.Text = "Dodaj prace";
            this.AddWork.UseVisualStyleBackColor = true;
            // 
            // EditWrok
            // 
            this.EditWrok.Location = new System.Drawing.Point(139, 138);
            this.EditWrok.Name = "EditWrok";
            this.EditWrok.Size = new System.Drawing.Size(193, 26);
            this.EditWrok.TabIndex = 13;
            this.EditWrok.Text = "Zapisz zmiany";
            this.EditWrok.UseVisualStyleBackColor = true;
            // 
            // RemoveWork
            // 
            this.RemoveWork.Location = new System.Drawing.Point(139, 170);
            this.RemoveWork.Name = "RemoveWork";
            this.RemoveWork.Size = new System.Drawing.Size(193, 26);
            this.RemoveWork.TabIndex = 14;
            this.RemoveWork.Text = "Usuń prace";
            this.RemoveWork.UseVisualStyleBackColor = true;
            // 
            // CostName
            // 
            this.CostName.AutoSize = true;
            this.CostName.Location = new System.Drawing.Point(6, 24);
            this.CostName.Name = "CostName";
            this.CostName.Size = new System.Drawing.Size(105, 17);
            this.CostName.TabIndex = 0;
            this.CostName.Text = "Nazwa wydatku";
            // 
            // CostNameInput
            // 
            this.CostNameInput.Location = new System.Drawing.Point(139, 21);
            this.CostNameInput.Name = "CostNameInput";
            this.CostNameInput.Size = new System.Drawing.Size(193, 22);
            this.CostNameInput.TabIndex = 1;
            // 
            // ExpanseForCostInput
            // 
            this.ExpanseForCostInput.Location = new System.Drawing.Point(139, 49);
            this.ExpanseForCostInput.Name = "ExpanseForCostInput";
            this.ExpanseForCostInput.Size = new System.Drawing.Size(193, 22);
            this.ExpanseForCostInput.TabIndex = 2;
            // 
            // ExpanseForCost
            // 
            this.ExpanseForCost.AutoSize = true;
            this.ExpanseForCost.Location = new System.Drawing.Point(6, 51);
            this.ExpanseForCost.Name = "ExpanseForCost";
            this.ExpanseForCost.Size = new System.Drawing.Size(99, 17);
            this.ExpanseForCost.TabIndex = 12;
            this.ExpanseForCost.Text = "Suma wydatku";
            // 
            // AllCostSum
            // 
            this.AllCostSum.AutoSize = true;
            this.AllCostSum.Location = new System.Drawing.Point(6, 79);
            this.AllCostSum.Name = "AllCostSum";
            this.AllCostSum.Size = new System.Drawing.Size(98, 17);
            this.AllCostSum.TabIndex = 13;
            this.AllCostSum.Text = "Suma kosztów";
            // 
            // AllCostSumOutput
            // 
            this.AllCostSumOutput.Location = new System.Drawing.Point(139, 77);
            this.AllCostSumOutput.Name = "AllCostSumOutput";
            this.AllCostSumOutput.ReadOnly = true;
            this.AllCostSumOutput.Size = new System.Drawing.Size(193, 22);
            this.AllCostSumOutput.TabIndex = 14;
            // 
            // RemoveCost
            // 
            this.RemoveCost.Location = new System.Drawing.Point(139, 169);
            this.RemoveCost.Name = "RemoveCost";
            this.RemoveCost.Size = new System.Drawing.Size(193, 26);
            this.RemoveCost.TabIndex = 17;
            this.RemoveCost.Text = "Usuń wydatek";
            this.RemoveCost.UseVisualStyleBackColor = true;
            // 
            // EditCost
            // 
            this.EditCost.Location = new System.Drawing.Point(139, 137);
            this.EditCost.Name = "EditCost";
            this.EditCost.Size = new System.Drawing.Size(193, 26);
            this.EditCost.TabIndex = 16;
            this.EditCost.Text = "Zapisz zmiany";
            this.EditCost.UseVisualStyleBackColor = true;
            // 
            // AddCost
            // 
            this.AddCost.Location = new System.Drawing.Point(139, 105);
            this.AddCost.Name = "AddCost";
            this.AddCost.Size = new System.Drawing.Size(193, 26);
            this.AddCost.TabIndex = 15;
            this.AddCost.Text = "Dodaj wydatek";
            this.AddCost.UseVisualStyleBackColor = true;
            // 
            // AllCosts
            // 
            this.AllCosts.Controls.Add(this.AllCostsList);
            this.AllCosts.Location = new System.Drawing.Point(360, 296);
            this.AllCosts.Name = "AllCosts";
            this.AllCosts.Size = new System.Drawing.Size(799, 277);
            this.AllCosts.TabIndex = 12;
            this.AllCosts.TabStop = false;
            this.AllCosts.Text = "Informacje o wydatkach";
            // 
            // AllCostsList
            // 
            this.AllCostsList.AllColumns.Add(this.olvColumn_CostName);
            this.AllCostsList.AllColumns.Add(this.olvColumn_ExpanseForCost);
            this.AllCostsList.CellEditUseWholeCell = false;
            this.AllCostsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn_CostName,
            this.olvColumn_ExpanseForCost});
            this.AllCostsList.Location = new System.Drawing.Point(6, 21);
            this.AllCostsList.Name = "AllCostsList";
            this.AllCostsList.ShowGroups = false;
            this.AllCostsList.Size = new System.Drawing.Size(793, 250);
            this.AllCostsList.TabIndex = 0;
            this.AllCostsList.UseCompatibleStateImageBehavior = false;
            this.AllCostsList.View = System.Windows.Forms.View.Details;
            this.AllCostsList.VirtualMode = true;
            // 
            // olvColumn_WorkName
            // 
            this.olvColumn_WorkName.Text = "Nazwa pracy";
            this.olvColumn_WorkName.Width = 120;
            // 
            // olvColumn_PriceForWorkUnit
            // 
            this.olvColumn_PriceForWorkUnit.Text = "Stawka za metr k/b";
            this.olvColumn_PriceForWorkUnit.Width = 140;
            // 
            // olvColumn_WorkQuantity
            // 
            this.olvColumn_WorkQuantity.Text = "Liczba metrów k/b";
            this.olvColumn_WorkQuantity.Width = 134;
            // 
            // olvColumn_CostName
            // 
            this.olvColumn_CostName.Text = "Nazwa wydatku";
            this.olvColumn_CostName.Width = 120;
            // 
            // olvColumn_ExpanseForCost
            // 
            this.olvColumn_ExpanseForCost.Text = "Suma wydatku";
            this.olvColumn_ExpanseForCost.Width = 120;
            // 
            // OrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 580);
            this.Controls.Add(this.AllCosts);
            this.Controls.Add(this.AllWorks);
            this.Controls.Add(this.CostInformation);
            this.Controls.Add(this.WorkInformation);
            this.Controls.Add(this.OrderInformation);
            this.Name = "OrderWindow";
            this.Text = "Okno zlecenia";
            ((System.ComponentModel.ISupportInitialize)(this.AllWorksList)).EndInit();
            this.OrderInformation.ResumeLayout(false);
            this.OrderInformation.PerformLayout();
            this.WorkInformation.ResumeLayout(false);
            this.WorkInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PriceForWorkUnitInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkQuantityInput)).EndInit();
            this.CostInformation.ResumeLayout(false);
            this.CostInformation.PerformLayout();
            this.AllWorks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpanseForCostInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCostSumOutput)).EndInit();
            this.AllCosts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllCostsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label OrderNumber;
        private System.Windows.Forms.TextBox OrderNumberOutput;
        private System.Windows.Forms.Label OrderName;
        private System.Windows.Forms.TextBox OrderNameInput;
        private System.Windows.Forms.Button SaveOrder;
        private BrightIdeasSoftware.FastObjectListView AllWorksList;
        private System.Windows.Forms.CheckBox OrderWithMaterial;
        private System.Windows.Forms.TextBox WorkNameInput;
        private System.Windows.Forms.GroupBox OrderInformation;
        private System.Windows.Forms.GroupBox WorkInformation;
        private System.Windows.Forms.Label WorkName;
        private System.Windows.Forms.Label WorkQuantity;
        private System.Windows.Forms.NumericUpDown WorkQuantityInput;
        private System.Windows.Forms.NumericUpDown PriceForWorkUnitInput;
        private System.Windows.Forms.Label PriceForWorkUnit;
        private System.Windows.Forms.Button RemoveWork;
        private System.Windows.Forms.Button EditWrok;
        private System.Windows.Forms.Button AddWork;
        private System.Windows.Forms.GroupBox CostInformation;
        private System.Windows.Forms.Label ExpanseForCost;
        private System.Windows.Forms.NumericUpDown ExpanseForCostInput;
        private System.Windows.Forms.TextBox CostNameInput;
        private System.Windows.Forms.Label CostName;
        private System.Windows.Forms.GroupBox AllWorks;
        private System.Windows.Forms.NumericUpDown AllCostSumOutput;
        private System.Windows.Forms.Label AllCostSum;
        private System.Windows.Forms.Button RemoveCost;
        private System.Windows.Forms.Button EditCost;
        private System.Windows.Forms.Button AddCost;
        private System.Windows.Forms.GroupBox AllCosts;
        private BrightIdeasSoftware.FastObjectListView AllCostsList;
        private BrightIdeasSoftware.OLVColumn olvColumn_WorkName;
        private BrightIdeasSoftware.OLVColumn olvColumn_PriceForWorkUnit;
        private BrightIdeasSoftware.OLVColumn olvColumn_WorkQuantity;
        private BrightIdeasSoftware.OLVColumn olvColumn_CostName;
        private BrightIdeasSoftware.OLVColumn olvColumn_ExpanseForCost;
    }
}