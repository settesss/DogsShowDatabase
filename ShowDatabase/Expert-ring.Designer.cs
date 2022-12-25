
namespace Lab2_
{
    partial class FormExpert_ring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormExpert_ring));
            this.выставкаDataSet = new Lab2_.ВыставкаDataSet();
            this.эксперт_РингBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.эксперт_РингTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.Эксперт_РингTableAdapter();
            this.tableAdapterManager = new Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager();
            this.эксперт_РингBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.эксперт_РингBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.эксперт_РингDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингBindingNavigator)).BeginInit();
            this.эксперт_РингBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // выставкаDataSet
            // 
            this.выставкаDataSet.DataSetName = "ВыставкаDataSet";
            this.выставкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // эксперт_РингBindingSource
            // 
            this.эксперт_РингBindingSource.DataMember = "Эксперт_Ринг";
            this.эксперт_РингBindingSource.DataSource = this.выставкаDataSet;
            // 
            // эксперт_РингTableAdapter
            // 
            this.эксперт_РингTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыставкаTableAdapter = null;
            this.tableAdapterManager.Клуб_ВыставкаTableAdapter = null;
            this.tableAdapterManager.КлубTableAdapter = null;
            this.tableAdapterManager.ОрганизаторTableAdapter = null;
            this.tableAdapterManager.РингTableAdapter = null;
            this.tableAdapterManager.Собака_РингTableAdapter = null;
            this.tableAdapterManager.СобакаTableAdapter = null;
            this.tableAdapterManager.ХозяинTableAdapter = null;
            this.tableAdapterManager.Эксперт_РингTableAdapter = this.эксперт_РингTableAdapter;
            this.tableAdapterManager.ЭкспертTableAdapter = null;
            // 
            // эксперт_РингBindingNavigator
            // 
            this.эксперт_РингBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.эксперт_РингBindingNavigator.BindingSource = this.эксперт_РингBindingSource;
            this.эксперт_РингBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.эксперт_РингBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.эксперт_РингBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.эксперт_РингBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.эксперт_РингBindingNavigatorSaveItem});
            this.эксперт_РингBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.эксперт_РингBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.эксперт_РингBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.эксперт_РингBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.эксперт_РингBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.эксперт_РингBindingNavigator.Name = "эксперт_РингBindingNavigator";
            this.эксперт_РингBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.эксперт_РингBindingNavigator.Size = new System.Drawing.Size(459, 27);
            this.эксперт_РингBindingNavigator.TabIndex = 0;
            this.эксперт_РингBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 20);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // эксперт_РингBindingNavigatorSaveItem
            // 
            this.эксперт_РингBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.эксперт_РингBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("эксперт_РингBindingNavigatorSaveItem.Image")));
            this.эксперт_РингBindingNavigatorSaveItem.Name = "эксперт_РингBindingNavigatorSaveItem";
            this.эксперт_РингBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.эксперт_РингBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.эксперт_РингBindingNavigatorSaveItem.Click += new System.EventHandler(this.эксперт_РингBindingNavigatorSaveItem_Click);
            // 
            // эксперт_РингDataGridView
            // 
            this.эксперт_РингDataGridView.AutoGenerateColumns = false;
            this.эксперт_РингDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.эксперт_РингDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.эксперт_РингDataGridView.DataSource = this.эксперт_РингBindingSource;
            this.эксперт_РингDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.эксперт_РингDataGridView.Location = new System.Drawing.Point(0, 27);
            this.эксперт_РингDataGridView.Name = "эксперт_РингDataGridView";
            this.эксперт_РингDataGridView.RowHeadersWidth = 51;
            this.эксперт_РингDataGridView.RowTemplate.Height = 24;
            this.эксперт_РингDataGridView.Size = new System.Drawing.Size(459, 349);
            this.эксперт_РингDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Данные_паспорта";
            this.dataGridViewTextBoxColumn1.HeaderText = "Данные_паспорта";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код_ринга";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код_ринга";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // FormExpert_ring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 376);
            this.Controls.Add(this.эксперт_РингDataGridView);
            this.Controls.Add(this.эксперт_РингBindingNavigator);
            this.Name = "FormExpert_ring";
            this.Text = "Expert_ring";
            this.Load += new System.EventHandler(this.FormExpert_ring_Load);
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингBindingNavigator)).EndInit();
            this.эксперт_РингBindingNavigator.ResumeLayout(false);
            this.эксперт_РингBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.эксперт_РингDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ВыставкаDataSet выставкаDataSet;
        private System.Windows.Forms.BindingSource эксперт_РингBindingSource;
        private ВыставкаDataSetTableAdapters.Эксперт_РингTableAdapter эксперт_РингTableAdapter;
        private ВыставкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator эксперт_РингBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton эксперт_РингBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView эксперт_РингDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}