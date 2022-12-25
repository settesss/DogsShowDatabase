
namespace Lab2_
{
    partial class FormShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow));
            this.выставкаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.выставкаDataSet = new Lab2_.ВыставкаDataSet();
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
            this.выставкаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.выставкаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.выставкаTableAdapter = new Lab2_.ВыставкаDataSetTableAdapters.ВыставкаTableAdapter();
            this.tableAdapterManager = new Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager();
            this.выставкаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.видDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаBindingNavigator)).BeginInit();
            this.выставкаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // выставкаBindingSource
            // 
            this.выставкаBindingSource.DataMember = "Выставка";
            this.выставкаBindingSource.DataSource = this.выставкаDataSet;
            // 
            // выставкаDataSet
            // 
            this.выставкаDataSet.DataSetName = "ВыставкаDataSet";
            this.выставкаDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
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
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(55, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // выставкаBindingNavigatorSaveItem
            // 
            this.выставкаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.выставкаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("выставкаBindingNavigatorSaveItem.Image")));
            this.выставкаBindingNavigatorSaveItem.Name = "выставкаBindingNavigatorSaveItem";
            this.выставкаBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.выставкаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.выставкаBindingNavigatorSaveItem.Click += new System.EventHandler(this.выставкаBindingNavigatorSaveItem_Click);
            // 
            // выставкаBindingNavigator
            // 
            this.выставкаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.выставкаBindingNavigator.BindingSource = this.выставкаBindingSource;
            this.выставкаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.выставкаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.выставкаBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.выставкаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.выставкаBindingNavigatorSaveItem});
            this.выставкаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.выставкаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.выставкаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.выставкаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.выставкаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.выставкаBindingNavigator.Name = "выставкаBindingNavigator";
            this.выставкаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.выставкаBindingNavigator.Size = new System.Drawing.Size(693, 27);
            this.выставкаBindingNavigator.TabIndex = 0;
            this.выставкаBindingNavigator.Text = "bindingNavigator1";
            // 
            // выставкаTableAdapter
            // 
            this.выставкаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Lab2_.ВыставкаDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ВыставкаTableAdapter = this.выставкаTableAdapter;
            this.tableAdapterManager.Клуб_ВыставкаTableAdapter = null;
            this.tableAdapterManager.КлубTableAdapter = null;
            this.tableAdapterManager.ОрганизаторTableAdapter = null;
            this.tableAdapterManager.РингTableAdapter = null;
            this.tableAdapterManager.Собака_РингTableAdapter = null;
            this.tableAdapterManager.СобакаTableAdapter = null;
            this.tableAdapterManager.ХозяинTableAdapter = null;
            this.tableAdapterManager.Эксперт_РингTableAdapter = null;
            this.tableAdapterManager.ЭкспертTableAdapter = null;
            // 
            // выставкаDataGridView
            // 
            this.выставкаDataGridView.AutoGenerateColumns = false;
            this.выставкаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.выставкаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.видDataGridViewTextBoxColumn});
            this.выставкаDataGridView.DataSource = this.выставкаBindingSource;
            this.выставкаDataGridView.Location = new System.Drawing.Point(0, 30);
            this.выставкаDataGridView.Name = "выставкаDataGridView";
            this.выставкаDataGridView.RowHeadersWidth = 51;
            this.выставкаDataGridView.RowTemplate.Height = 24;
            this.выставкаDataGridView.Size = new System.Drawing.Size(693, 591);
            this.выставкаDataGridView.TabIndex = 1;
            this.выставкаDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.выставкаDataGridView_CellFormatting);
            // 
            // dataGridViewTextBoxColumn
            // 
            this.dataGridViewTextBoxColumn.DataPropertyName = "Название_выставки";
            this.dataGridViewTextBoxColumn.HeaderText = "Название_выставки";
            this.dataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn.Name = "dataGridViewTextBoxColumn";
            this.dataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_проведения";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата_проведения";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Место_проведения";
            this.dataGridViewTextBoxColumn3.HeaderText = "Место_проведения";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // видDataGridViewTextBoxColumn
            // 
            this.видDataGridViewTextBoxColumn.DataPropertyName = "Вид";
            this.видDataGridViewTextBoxColumn.HeaderText = "Вид";
            this.видDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.видDataGridViewTextBoxColumn.Name = "видDataGridViewTextBoxColumn";
            this.видDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.видDataGridViewTextBoxColumn.Width = 125;
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 620);
            this.Controls.Add(this.выставкаDataGridView);
            this.Controls.Add(this.выставкаBindingNavigator);
            this.Name = "FormShow";
            this.Text = "Show";
            this.Load += new System.EventHandler(this.Show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.выставкаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаBindingNavigator)).EndInit();
            this.выставкаBindingNavigator.ResumeLayout(false);
            this.выставкаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.выставкаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource выставкаBindingSource;
        private ВыставкаDataSet выставкаDataSet;
        private ВыставкаDataSetTableAdapters.ВыставкаTableAdapter выставкаTableAdapter;
        private ВыставкаDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton выставкаBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator выставкаBindingNavigator;
        private System.Windows.Forms.DataGridView выставкаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn видDataGridViewTextBoxColumn;
    }
}