namespace andrew_foster_lab_2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cityIDLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label populationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cityDBDataSet = new andrew_foster_lab_2.CityDBDataSet();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityTableAdapter = new andrew_foster_lab_2.CityDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new andrew_foster_lab_2.CityDBDataSetTableAdapters.TableAdapterManager();
            this.cityBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cityBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cityDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ascPopSort = new System.Windows.Forms.Button();
            this.descPopSort = new System.Windows.Forms.Button();
            this.totalPop = new System.Windows.Forms.Button();
            this.nameSort = new System.Windows.Forms.Button();
            this.sortByNameFrame = new System.Windows.Forms.GroupBox();
            this.cityIDTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.avgPop = new System.Windows.Forms.Button();
            this.popGroupBox = new System.Windows.Forms.GroupBox();
            this.lowPop = new System.Windows.Forms.Button();
            this.highPop = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            cityIDLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).BeginInit();
            this.cityBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).BeginInit();
            this.sortByNameFrame.SuspendLayout();
            this.popGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // cityIDLabel
            // 
            cityIDLabel.AutoSize = true;
            cityIDLabel.Location = new System.Drawing.Point(28, 236);
            cityIDLabel.Name = "cityIDLabel";
            cityIDLabel.Size = new System.Drawing.Size(48, 16);
            cityIDLabel.TabIndex = 6;
            cityIDLabel.Text = "City ID:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(28, 264);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(32, 16);
            cityLabel.TabIndex = 8;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(28, 292);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(41, 16);
            stateLabel.TabIndex = 10;
            stateLabel.Text = "State:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(28, 320);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(74, 16);
            populationLabel.TabIndex = 12;
            populationLabel.Text = "Population:";
            // 
            // cityDBDataSet
            // 
            this.cityDBDataSet.DataSetName = "CityDBDataSet";
            this.cityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.cityDBDataSet;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = andrew_foster_lab_2.CityDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cityBindingNavigator
            // 
            this.cityBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cityBindingNavigator.BindingSource = this.cityBindingSource;
            this.cityBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cityBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cityBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cityBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cityBindingNavigatorSaveItem});
            this.cityBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cityBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cityBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cityBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cityBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cityBindingNavigator.Name = "cityBindingNavigator";
            this.cityBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cityBindingNavigator.Size = new System.Drawing.Size(620, 27);
            this.cityBindingNavigator.TabIndex = 0;
            this.cityBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // cityBindingNavigatorSaveItem
            // 
            this.cityBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cityBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cityBindingNavigatorSaveItem.Image")));
            this.cityBindingNavigatorSaveItem.Name = "cityBindingNavigatorSaveItem";
            this.cityBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.cityBindingNavigatorSaveItem.Text = "Save Data";
            this.cityBindingNavigatorSaveItem.Click += new System.EventHandler(this.cityBindingNavigatorSaveItem_Click);
            // 
            // cityDataGridView
            // 
            this.cityDataGridView.AutoGenerateColumns = false;
            this.cityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.cityDataGridView.DataSource = this.cityBindingSource;
            this.cityDataGridView.Location = new System.Drawing.Point(0, 32);
            this.cityDataGridView.Name = "cityDataGridView";
            this.cityDataGridView.RowHeadersWidth = 51;
            this.cityDataGridView.RowTemplate.Height = 24;
            this.cityDataGridView.Size = new System.Drawing.Size(601, 173);
            this.cityDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CityID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CityID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn2.HeaderText = "City";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn3.HeaderText = "State";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Population";
            this.dataGridViewTextBoxColumn4.HeaderText = "Population";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // ascPopSort
            // 
            this.ascPopSort.AccessibleName = "ascPopSort";
            this.ascPopSort.Location = new System.Drawing.Point(6, 31);
            this.ascPopSort.Name = "ascPopSort";
            this.ascPopSort.Size = new System.Drawing.Size(82, 29);
            this.ascPopSort.TabIndex = 1;
            this.ascPopSort.Text = "Low - High";
            this.ascPopSort.UseVisualStyleBackColor = true;
            this.ascPopSort.Click += new System.EventHandler(this.ascPopSort_Click);
            // 
            // descPopSort
            // 
            this.descPopSort.AccessibleName = "names_desc_button";
            this.descPopSort.Location = new System.Drawing.Point(94, 31);
            this.descPopSort.Name = "descPopSort";
            this.descPopSort.Size = new System.Drawing.Size(77, 29);
            this.descPopSort.TabIndex = 2;
            this.descPopSort.Text = "Hi - Low";
            this.descPopSort.UseVisualStyleBackColor = true;
            this.descPopSort.Click += new System.EventHandler(this.descPopSort_Click);
            // 
            // totalPop
            // 
            this.totalPop.Location = new System.Drawing.Point(6, 59);
            this.totalPop.Name = "totalPop";
            this.totalPop.Size = new System.Drawing.Size(82, 30);
            this.totalPop.TabIndex = 4;
            this.totalPop.Text = "Total";
            this.totalPop.UseVisualStyleBackColor = true;
            this.totalPop.Click += new System.EventHandler(this.totalPop_Click);
            // 
            // nameSort
            // 
            this.nameSort.Location = new System.Drawing.Point(220, 306);
            this.nameSort.Name = "nameSort";
            this.nameSort.Size = new System.Drawing.Size(165, 33);
            this.nameSort.TabIndex = 5;
            this.nameSort.Text = "Sort by City Name";
            this.nameSort.UseVisualStyleBackColor = true;
            this.nameSort.Click += new System.EventHandler(this.nameSort_Click);
            // 
            // sortByNameFrame
            // 
            this.sortByNameFrame.Controls.Add(this.descPopSort);
            this.sortByNameFrame.Controls.Add(this.ascPopSort);
            this.sortByNameFrame.Location = new System.Drawing.Point(214, 233);
            this.sortByNameFrame.Name = "sortByNameFrame";
            this.sortByNameFrame.Size = new System.Drawing.Size(177, 66);
            this.sortByNameFrame.TabIndex = 6;
            this.sortByNameFrame.TabStop = false;
            this.sortByNameFrame.Text = "Sort Cities by Population";
            // 
            // cityIDTextBox
            // 
            this.cityIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "CityID", true));
            this.cityIDTextBox.Location = new System.Drawing.Point(108, 233);
            this.cityIDTextBox.Name = "cityIDTextBox";
            this.cityIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityIDTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(108, 261);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(100, 22);
            this.cityTextBox.TabIndex = 9;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(108, 289);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 22);
            this.stateTextBox.TabIndex = 11;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(108, 317);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(100, 22);
            this.populationTextBox.TabIndex = 13;
            // 
            // avgPop
            // 
            this.avgPop.Location = new System.Drawing.Point(6, 21);
            this.avgPop.Name = "avgPop";
            this.avgPop.Size = new System.Drawing.Size(82, 30);
            this.avgPop.TabIndex = 14;
            this.avgPop.Text = "Average";
            this.avgPop.UseVisualStyleBackColor = true;
            this.avgPop.Click += new System.EventHandler(this.avgPop_Click);
            // 
            // popGroupBox
            // 
            this.popGroupBox.Controls.Add(this.lowPop);
            this.popGroupBox.Controls.Add(this.highPop);
            this.popGroupBox.Controls.Add(this.avgPop);
            this.popGroupBox.Controls.Add(this.totalPop);
            this.popGroupBox.Location = new System.Drawing.Point(397, 233);
            this.popGroupBox.Name = "popGroupBox";
            this.popGroupBox.Size = new System.Drawing.Size(198, 106);
            this.popGroupBox.TabIndex = 15;
            this.popGroupBox.TabStop = false;
            this.popGroupBox.Text = "Population Statistics";
            // 
            // lowPop
            // 
            this.lowPop.Location = new System.Drawing.Point(104, 59);
            this.lowPop.Name = "lowPop";
            this.lowPop.Size = new System.Drawing.Size(82, 30);
            this.lowPop.TabIndex = 17;
            this.lowPop.Text = "Lowest";
            this.lowPop.UseVisualStyleBackColor = true;
            this.lowPop.Click += new System.EventHandler(this.lowPop_Click);
            // 
            // highPop
            // 
            this.highPop.Location = new System.Drawing.Point(104, 21);
            this.highPop.Name = "highPop";
            this.highPop.Size = new System.Drawing.Size(82, 30);
            this.highPop.TabIndex = 16;
            this.highPop.Text = "Highest";
            this.highPop.UseVisualStyleBackColor = true;
            this.highPop.Click += new System.EventHandler(this.highPop_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(262, 356);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(82, 30);
            this.close.TabIndex = 18;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.popGroupBox);
            this.Controls.Add(cityIDLabel);
            this.Controls.Add(this.cityIDTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(this.sortByNameFrame);
            this.Controls.Add(this.nameSort);
            this.Controls.Add(this.cityDataGridView);
            this.Controls.Add(this.cityBindingNavigator);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andrew Foster Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingNavigator)).EndInit();
            this.cityBindingNavigator.ResumeLayout(false);
            this.cityBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cityDataGridView)).EndInit();
            this.sortByNameFrame.ResumeLayout(false);
            this.popGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDBDataSet cityDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private CityDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private CityDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cityBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cityBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cityDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button ascPopSort;
        private System.Windows.Forms.Button descPopSort;
        private System.Windows.Forms.Button totalPop;
        private System.Windows.Forms.Button nameSort;
        private System.Windows.Forms.GroupBox sortByNameFrame;
        private System.Windows.Forms.TextBox cityIDTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.Button avgPop;
        private System.Windows.Forms.GroupBox popGroupBox;
        private System.Windows.Forms.Button lowPop;
        private System.Windows.Forms.Button highPop;
        private System.Windows.Forms.Button close;
    }
}

